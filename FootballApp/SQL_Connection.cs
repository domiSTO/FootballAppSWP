using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevOne.Security.Cryptography.BCrypt;


namespace FootballApp
{
    class SQL_Connection
    {
        public static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        private static SqlCommandBuilder cmdbuild = new SqlCommandBuilder();

        #region DatabaseCheck
        //Creates Database if not exists
        public static void CreateDatabase(string dbname)
        {
            try
            {
                con.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "if not exists(select * from sys.databases where name = '" + dbname + "') begin create database[" + dbname + "] end";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Database created!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #region Tables
        //Creates Table if not exists

        #region LoginTable
        public static void CreateTable(string dbname, string tablename)
        {
            try
            {
                con.Open();
                cmd.CommandText = "use [" + dbname + "] if not exists(select * from sysobjects where name = '" + tablename + "') begin create table " + tablename + "(Id int identity(1,1) primary Key,username varchar(20),password varchar(70)) end";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
        public static void CreateTable1(string dbname, string tablename)
        {
            try
            {
                con.Open();
                cmd.CommandText = "use [" + dbname + "] if not exists(select * from sysobjects where name = '" + tablename + "') begin create table " + tablename + "(Id int identity(1,1) primary Key,teamname varchar(30),liganr int, tore int, gegentore int, spiele int) end";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void CreateTable2(string dbname, string tablename)
        {
            try
            {
                con.Open();
                cmd.CommandText = "use [" + dbname + "] if not exists(select * from sysobjects where name = '" + tablename + "') begin create table " + tablename + "(Id int identity(1,1) primary Key,liganame varchar(30), land varchar(20)) end";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region InsertLeagues
        public static void InsertLeagues(string dbname, string tablename)
        {
            try
            {
                con.Open();
                cmd.CommandText = "use [" + dbname + "] if not exists(select 1 from " + tablename + ") begin insert into " + tablename + " (liganame, land) values ('Bundesliga','Deutschland')," +
                    "('Serie A','Italien')," +
                    "('La Liga','Spanien')," +
                    "('Ligue 1','Frankreich')," +
                    "('Premier League','England')," +
                    "('Eredevise','Niederlande') end";
                cmd.ExecuteNonQuery();
                con.Close();
            }


            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void InsertTeams(string dbname, string tablename, string teamname, int liganr)
        {
            try
            {
                con.Open();
                cmd.CommandText = "use [" + dbname + "] if not exists(select 1 from " + tablename + " where teamname = '" + teamname + "') begin insert into " + tablename + " (teamname, liganr, tore, gegentore, spiele) values ('" + teamname + "'," + liganr + ", 0, 0, 0 ) end";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Team erfolgreich hinzugefügt!");
            }


            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        #endregion

        #region LoginCheck

        //Login Check for the password
        public static bool CheckTable(string tablename, string v_username, string v_password)
        {
            string pw;
            try
            {
                con.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database=FootballApp";
                con.Open();
                cmd.CommandText = "Select password From Login Where username='" + v_username + "'";
                pw = (string)cmd.ExecuteScalar();
                //hashedpw = v_password;
                string salt = BCryptHelper.GenerateSalt(6);
                var passwordHash = BCryptHelper.HashPassword(pw, salt);

                bool value = BCryptHelper.CheckPassword(pw, passwordHash);
                if (passwordHash != null)
                {
                    if (BCrypt.CheckPassword(pw, passwordHash))
                    {
                        MessageBox.Show("Sie haben sich erfolgreich angemeldet!", "Sie sind angemeldet!");
                        
                    }
                }
                con.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Passwort oder User falsch!", "Ungültige Eingaben");
                con.Close();
                return false;
            }
        }

        //New Account inserts into the database 
        public static void InsertInto(string tablename, string v_username, string v_password)
        {

            try
            {
                con.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database=FootballApp";
                con.Open();
                cmd.CommandText = "INSERT INTO " + tablename + "(username,password) VALUES('" + v_username + "', '" + v_password + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region DataGridView

        public static DataTable CheckDataGrid(int liganr, string dbname)
        {

            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("use [" + dbname + "] select * from Teams where liganr = " + liganr + "", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        #endregion


    }

}
