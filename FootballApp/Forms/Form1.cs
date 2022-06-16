using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp
{
    public partial class Frm_Leagues : Form
    {
        public Frm_Leagues()
        {
            InitializeComponent();
        }

        private void btn_Bundesliga_Click(object sender, EventArgs e)
        {
            //Links to the BUndesliga Form
            Bundesliga bundesliga = new Bundesliga();
            bundesliga.Show();
            //this.Hide();
        }

        private void btn_PremierLeague_Click(object sender, EventArgs e)
        {
            // links to the Premier League Form
            PremierLeague premierleague = new PremierLeague();
            premierleague.Show();
        }

        private void btn_Premierleague_Darkmode_Click(object sender, EventArgs e)
        {
            PremierLeague premierleague = new PremierLeague();
            premierleague.Show();
        }

        private void btn_Ligue1_Click(object sender, EventArgs e)
        {
            //links to the Ligue 1 Form
            Ligue1 ligue1 = new Ligue1();
            ligue1.Show();
        }

        private void btn_SerieA_Click(object sender, EventArgs e)
        {
            //links to the Serie A Form
            SerieA seriea = new SerieA();
            seriea.Show();
        }

        private void btn_LaLiga_Click(object sender, EventArgs e)
        {
            //links to the LaLiga Form
            LaLiga laliga = new LaLiga();
            laliga.Show();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            //links to the Login Form
            Login login_start = new Login();
            login_start.Show();
            this.Hide();
            
        }

        private void btn_Eredivisie_Click(object sender, EventArgs e)
        {
            //links to the Eredivisie Form
            Eredivisie eredivisie = new Eredivisie();
            eredivisie.Show();
        }

        private void btn_Eredivisie_Darkmode_Click(object sender, EventArgs e)
        {
            Eredivisie eredivisie = new Eredivisie();
            eredivisie.Show();
        }

        private void tb_DarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            //Changes Pictures according to selected Mode (White/Dark)
            if (tb_DarkTheme.Checked)
            {


                this.BackColor = Color.DimGray;
                leagues_Title.ForeColor = Color.WhiteSmoke;
                btn_Login.ForeColor = Color.WhiteSmoke;
                btn_Premierleague_Darkmode.Show();
                btn_PremierLeague.Hide();
                btn_Eredivisie_Darkmode.Show();
                btn_Eredivisie.Hide();
                pb_DarkMode.Show();
                pb_LightMode.Hide();
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                leagues_Title.ForeColor = Color.Black;
                btn_Login.ForeColor = Color.Black;
                btn_Premierleague_Darkmode.Hide();
                btn_PremierLeague.Show();
                btn_Eredivisie_Darkmode.Hide();
                btn_Eredivisie.Show();
                pb_DarkMode.Hide();
                pb_LightMode.Show();
            }
        }

        private void Frm_Leagues_Load(object sender, EventArgs e)
        {

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Create Database and Tables with SQL-Connection
            SQL_Connection.CreateDatabase("FootballApp");
            SQL_Connection.CreateTable("FootballApp", "Login");

            SQL_Connection.CreateTable1("FootballApp", "Teams");
            SQL_Connection.CreateTable2("FootballApp", "Ligen");

            SQL_Connection.InsertLeagues("FootballApp", "Ligen");


            pb_LightMode.Show();
            pb_DarkMode.Hide();

        }

        private void btn_Eredivisie_Click_1(object sender, EventArgs e)
        {
            Eredivisie eredivisie = new Eredivisie();
            eredivisie.Show();
        }

        private void btn_addteams_Click(object sender, EventArgs e)
        {
            Favoriten addteams = new Favoriten();
            addteams.Show();

        }

        private void Frm_Leagues_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
