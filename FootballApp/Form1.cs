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
            //verlinkt auf das Bundesliga Form
            Bundesliga bundesliga = new Bundesliga();
            bundesliga.Show();
            this.Hide();
        }

        private void btn_PremierLeague_Click(object sender, EventArgs e)
        {
            //verlinkt auf das Premier League Form
            PremierLeague premierleague = new PremierLeague();
            premierleague.Show();
            this.Hide();
        }

        private void btn_Premierleague_Darkmode_Click(object sender, EventArgs e)
        {
            PremierLeague premierleague = new PremierLeague();
            premierleague.Show();
            this.Hide();
        }

        private void btn_Ligue1_Click(object sender, EventArgs e)
        {
            //verlinkt auf das Ligue 1 Form
            Ligue1 ligue1 = new Ligue1();
            ligue1.Show();
            this.Hide();
        }

        private void btn_SerieA_Click(object sender, EventArgs e)
        {
            //verlinkt auf das Serie A Form
            SerieA seriea = new SerieA();
            seriea.Show();
            this.Hide();
        }

        private void btn_LaLiga_Click(object sender, EventArgs e)
        {
            //verlinkt auf das LaLiga Form
            LaLiga laliga = new LaLiga();
            laliga.Show();
            this.Hide();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            //Öffnet das Login Fenster
            Login login_start = new Login();
            login_start.Show();
            this.Hide();
        }

        private void btn_Eredivisie_Click(object sender, EventArgs e)
        {
            Eredivisie eredivisie = new Eredivisie();
            eredivisie.Show();
            this.Hide();
        }

        private void btn_Eredivisie_Darkmode_Click(object sender, EventArgs e)
        {
            Eredivisie eredivisie = new Eredivisie();
            eredivisie.Show();
            this.Hide();
        }

        private void tb_DarkTheme_CheckedChanged(object sender, EventArgs e)
        {
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
            pb_LightMode.Show();
            pb_DarkMode.Hide();
        }
    }
}
