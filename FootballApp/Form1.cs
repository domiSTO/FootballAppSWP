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

        private void btn_Login_Click(object sender, EventArgs e)
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

        private void tb_DarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_DarkTheme.Checked)
            {
                this.BackColor = Color.DimGray;
                leagues_Title.ForeColor = Color.White;
                
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                leagues_Title.ForeColor = Color.Black;
            }
        }
    }
}
