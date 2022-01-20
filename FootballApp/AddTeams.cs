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
    public partial class AddTeams : Form
    {
        public AddTeams()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {
            int liganr = comboBox1.SelectedIndex + 1;

            

            SQL_Connection.InsertTeams("FootballApp", "Teams", txtbox_teamname.Text, liganr);
        }

        private void AddTeams_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_addteams_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
