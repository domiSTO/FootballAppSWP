using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FootballApp
{
    class SQL_Connection
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand com = new SqlCommand();

        private static string ip;

        public static string IP
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }

        private static string username;

        public static string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        private static string password;

        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public static void buildDatabase()
        {
            bool db = false;
            bool tb = false;
            try
            {
                con.Open();
                DataTable dt = con.GetSchema("Databases");

                foreach(DataRow dr in dt.Rows)
                {
                    if (dr[0].Equals("Football_Login"))
                    {
                        db = true;
                    }
                }
                con.Close();
                if (!db)
                {
                    com.Connection = con;
                    com.CommandText = "Create Database Football_Login";
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                con.ConnectionString += ";Database = Football_Login";
                con.Open();
                DataTable dtt = con.GetSchema("Tables");
                foreach(DataRow dr in dtt.Rows)
                {
                    if(dr.Field<string>("table_name").Equals("login"))
                    {
                        tb = true;
                    }
                }
                con.Close();
                if(!tb)
                {
                    com.Connection = con;
                    com.CommandText = "Create Table Login(user_id int )";
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
