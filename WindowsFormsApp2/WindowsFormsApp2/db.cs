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
        String connStr = "Server=localhost;Database=db_cloudstorage;Uid=root;Pwd=apmsetup;";
        MySqlConnection conn;

        public Db()
        {
            conn = new MySqlConnection(connStr);
            /**     * DB와의 연결을 검사한다.     */

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
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, from);
                if (ds.Tables.Count > 0)
                {
                    return ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return null;
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
                                VALUES('" + name + "\',\'" + id + "\',\'" + pw + "\',\'" + email + "\',\'" + phone + "\', \'1000000000\',\'"+System.DateTime.Now.ToString("yyyy/MM/dd")+"\')";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            } catch(Exception e)
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
                string sql = @"update tb_user set userPw = '"+password+"' where userEmail = '"+ email +"';";
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
