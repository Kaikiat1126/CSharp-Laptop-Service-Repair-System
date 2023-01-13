using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Login_UI
{
    public class Sql
    {
        //connection string
        public static string connStr = ConfigurationManager.ConnectionStrings["ioopkakiDBCS"].ToString();

        //query for database
        public static void Query(string sqlQuery)
        {
            string sql1 = sqlQuery.ToLower();

            bool res1 = sql1.Contains("drop table");
            bool res2 = sql1.Contains("drop database");
            if (res1 == true || res2 == true)
            {
                MessageBox.Show("What are you doing?");
            }
            else
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        //non query return string array
        public static string[] NonQuery(string sqlNonQuery)
        {
            string sql2 = sqlNonQuery.ToLower();

            bool res1 = sql2.Contains("drop table");
            bool res2 = sql2.Contains("drop database");

            if (res1 == true || res2 == true)
            {
                MessageBox.Show("What are you doing?");
                return null;
            }
            else
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlNonQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                string[] result = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result[i] = reader[i].ToString();
                }
                reader.Close();
                conn.Close();
                return result;
            }
        }

        //non query return one string only
        public static string NonQuery1(string sqlNonQuery)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlNonQuery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string result = reader[0].ToString();
            reader.Close();
            conn.Close();
            return result;
        }

        //validate if exist
        public static Boolean Validation(string sqlNonQuery)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlNonQuery, conn);
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return count != 0;
        }
    }
}
