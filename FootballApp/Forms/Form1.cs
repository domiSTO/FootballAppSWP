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

        private void btn_Eredivisie_Click_1(object sender, EventArgs e)
        {
            //links to the Eredivisie Form
            Eredivisie eredivisie = new Eredivisie();
            eredivisie.Show();
        }
       
        private void Frm_Leagues_Load(object sender, EventArgs e)
        {
            //Initializing the chromium browser
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);


        }

        private void Frm_Leagues_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_currentgames_Click(object sender, EventArgs e)
        {
            CurrentGames currentGames = new CurrentGames();
            currentGames.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
