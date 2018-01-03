using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

                //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이타 가져오기
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
                string sql = @"INSERT INTO tb_user(userId, userPw, userName, userEmail, userPhone)
                         VALUES(\'" + id + "\',\'" + pw + "\',\'" + name + "\',\'" + email + "\',\'" + phone + "\')";
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
    }
}
