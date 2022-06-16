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
    public partial class Team : Form
    {
        public string buttonname { get; set; }
        public Team()
        {
            InitializeComponent();
        }

        private void Team_Load(object sender, EventArgs e)
        {

            btn_favoritefilled.Visible = false;
            pbbox_formation.Image = Formations.Images[0];
            pbbox_playerlist.Image = Formations.Images[1];
            pb_currentform.Image = currentForms.Images[0];
            lbl_teamname.Text = buttonname;
            int index = Int32.Parse(buttonname) -1 ;

            lbl_formation.Text = "4-2-3-1";

            //Switch-Case für TeamName
            switch(buttonname)
            {
                case "1":
                    lbl_teamname.Text = "Manchester City";
                    break;
                case "2":
                    lbl_teamname.Text = "Arsenal";
                    break;
                case "3":
                    lbl_teamname.Text = "Aston Villa";
                    break;
                case "4":
                    lbl_teamname.Text = "Brentford";
                    break;
                case "5":
                    lbl_teamname.Text = "Brighton";
                    break;
                case "6":
                    lbl_teamname.Text = "´Burnley";
                    break;
                case "7":
                    lbl_teamname.Text = "Chelsea";
                    break;
                case "8":
                    lbl_teamname.Text = "Crystal Palace";
                    break;
                case "9":
                    lbl_teamname.Text = "Everton";
                    break;
                case "10":
                    lbl_teamname.Text = "Leeds";
                    break;
                case "11":
                    lbl_teamname.Text = "Leicester";
                    break;
                case "12":
                    lbl_teamname.Text = "Liverpool";
                    break;
                case "13":
                    lbl_teamname.Text = "Man United";
                    break;
                case "14":
                    lbl_teamname.Text = "Newcastle";
                    break;
                case "15":
                    lbl_teamname.Text = "Norwich";
                    break;
                case "16":
                    lbl_teamname.Text = "Southampton";
                    break;
                case "17":
                    lbl_teamname.Text = "Tottenham";
                    break;
                case "18":
                    lbl_teamname.Text = "Watford";
                    break;
                case "19":
                    lbl_teamname.Text = "Westham";
                    break;
                case "20":
                    lbl_teamname.Text = "Wolverhampton";
                    break;

            }
            //Switch-Case für die Logos
            switch(buttonname)
            {
                case "1":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "2":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "3":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "4":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "5":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "6":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "7":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "8":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "9":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "10":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "11":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "12":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "13":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "14":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "15":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "16":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "17":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "18":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "19":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
                case "20":
                    pictureBox1.Image = PremierLeague.Images[index];
                    break;
            }
            
        }

        private void btn_favorite_Click(object sender, EventArgs e)
        {
            btn_favorite.Visible = false;
            btn_favoritefilled.Visible = true;
        }

        private void btn_favoritefilled_Click(object sender, EventArgs e)
        {
            btn_favoritefilled.Visible = false;
            btn_favorite.Visible = true;
        }


    }
}
