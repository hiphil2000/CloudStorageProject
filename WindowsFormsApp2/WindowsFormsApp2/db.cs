using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    class Db
    {
        String connStr = "Server=175.114.81.71;Port=3306;Database=db_cloudstorage;Uid=root;Pwd=root;CharSet=utf8";
        MySqlConnection conn;

        public Db()
        {
            conn = new MySqlConnection(connStr);
        }

        public bool connectChk()
        {
            try
            {
                conn.Open();
                if (conn.Ping() == true)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }

        }


        public DataSet select(string[] select, string from, string where)
        {
            MySqlDataAdapter adpt;
            try
            {
                DataSet ds = new DataSet();

                //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이터 가져오기
                string sql = "SELECT ";
                for (int i = 0; i < select.Length; i++)
                {
                    sql += select[i];
                    if (i < select.Length - 1)
                        sql += ", ";
                    else
                        sql += " ";
                }
                sql += "FROM " + from + " WHERE " + where;
                Console.WriteLine(sql);
                adpt = new MySqlDataAdapter(sql, conn);
                if (from.Contains(','))
                    adpt.Fill(ds, from.Substring(0, from.IndexOf(',')));
                else
                    adpt.Fill(ds, from);
                if (ds.Tables.Count > 0)
                {
                    
                    return ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            return null;
        }

        public void uploadFile(string[] filePath, int userSeq)
        {
            BinaryReader br;
            FileStream fs;
            FileInfo fi;

            foreach(string file in filePath)
            {
                try
                {
                    fi = new FileInfo(file);
                    string fileTemp = file.Replace('\\', '/');
                    fs = new FileStream(fileTemp, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    string filename = fi.Name;
                    long filesize = fi.Length;
                    int height, width;
                    string sql = "INSERT INTO TB_Data (userSeq, fileName, fileSize, createDate, leastDate, favorateFlag, data, width, height) " +
                        "VALUES(@userSeq, @fileName, @fileSize, NOW(), NOW(), 0, @data, 1, 1)";
                    byte[] data = br.ReadBytes((int)fs.Length);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    br.Close();
                    fs.Close();

                    cmd.Parameters.Add("@userSeq", MySqlDbType.Int16, 11);
                    cmd.Parameters.Add("@fileName", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@fileSize", MySqlDbType.Int16, 11);
                    cmd.Parameters.Add("@data", MySqlDbType.Blob);

                    cmd.Parameters["@userSeq"].Value = userSeq;
                    cmd.Parameters["@fileName"].Value = filename;
                    cmd.Parameters["@fileSize"].Value = filesize;
                    cmd.Parameters["@data"].Value = data;
                    conn.Open();
                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected > 0)
                    {
                        Console.WriteLine("Image saved sucessfully!");
                    }
                    conn.Close();
                    log("upload", userSeq);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            

        }
        
        public void downloadFile(string filename, string fileSeq, int userSeq)
        {
            string sql = "SELECT data FROM tb_data WHERE dataSeq = " + fileSeq;
            
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    FileStream outfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    using (System.IO.BinaryWriter writer = new System.IO.BinaryWriter(outfile))
                    {
                        long bufferSize = reader.GetBytes(0, 0, null, 0, 0);
                        byte[] buffer = new byte[bufferSize];
                        reader.GetBytes(0, 0, buffer, 0, (int)bufferSize);
                        writer.Write(buffer, 0, (int)bufferSize);
                        writer.Flush();
                        conn.Close();
                        writer.Close();
                        outfile.Close();
                        log("download", userSeq);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                if (conn != null)
                    conn.Close();
            }
            


        }

        public void log(string logType, int userSeq)
        {
            try
            {
                conn.Open();
                string sql = @"INSERT INTO tb_log(userSeq, logDate, logType) VALUES(" + userSeq + ", NOW(), '" + logType + "')";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                if(conn != null)
                    conn.Close();
            }
            
        }

        public Bitmap loadImage(int imgID)
        {

            MySqlDataReader myData;
            MySqlCommand cmd = new MySqlCommand();

            string SQL;
            byte[] rawData;
            MemoryStream ms;
            UInt32 FileSize;
            Bitmap outImage;

            SQL = "SELECT fileName, fileSize, data FROM tb_data WHERE dataSeq =";
            SQL += imgID.ToString();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = SQL;
                myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                    throw new Exception("There are no blobs to save");

                myData.Read();

                FileSize = myData.GetUInt32(myData.GetOrdinal("fileSize"));
                rawData = new byte[FileSize];

                myData.GetBytes(myData.GetOrdinal("data"), 0, rawData, 0, (Int32)FileSize);


                ms = new MemoryStream(rawData);
                ms.Seek(0, SeekOrigin.Begin);
                outImage = new Bitmap(ms);
                ms.Close();
                ms.Dispose();

                myData.Close();
                myData.Dispose();

                cmd.Dispose();

                return outImage;


            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }

        }

        public Bitmap selectFile(int fileSeq)
        {
            MySqlDataReader data;
            MySqlCommand cmd;

            byte[] rawData;
            MemoryStream ms;
            UInt32 fileSize;
            Bitmap outImage;

            string sql = "SELECT fileName, fileSize, data FROM tb_data WHERE dataSeq = " + fileSeq.ToString();

            try
            {
                conn.Open();
                cmd = new MySqlCommand(sql, conn);

                data = cmd.ExecuteReader();

                if (!data.HasRows)
                    throw new Exception("there is no blobs to save");
                data.Read();

                fileSize = data.GetUInt32(data.GetOrdinal("fileSize"));
                rawData = new byte[fileSize];

                data.GetBytes(data.GetOrdinal("data"), 0, rawData, 0, (Int32)fileSize);

                ms = new MemoryStream(rawData);
                outImage = new Bitmap(ms);
                ms.Close();
                ms.Dispose();

                data.Close();
                data.Dispose();

                cmd.Dispose();

                return outImage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool accCheck(string id, string pw)
        {
            DataSet ds = this.select(new[] { "userId", "userPw" }, "tb_user", "userId = \'" + id + "\' AND userPw = \'" + pw + "\'");
            if (ds == null)
                return false;
            if (ds.Tables[0].Rows.Count < 1)
                return false;
            else
                return true;
        }

        public void register(string id, string pw, string name, string email, string phone)
        {
            try
            {
                conn.Open();
                string sql = @"INSERT INTO TB_User (userName, userId, userPw, userEmail, userPhone, maxCapacity, registDate)
                                VALUES('" + name + "\',\'" + id + "\',\'" + pw + "\',\'" + email + "\',\'" + phone + "\', \'1000000000\',\'" + System.DateTime.Now.ToString("yyyy/MM/dd") + "\')";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updatePassword(string email, string password)
        {
            try
            {
                conn.Open();
                string sql = @"update tb_user set userPw = '" + password + "' where userEmail = '" + email + "';";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
