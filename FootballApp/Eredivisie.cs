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
    public partial class Eredivisie : Form
    {
        public Eredivisie()
        {
            InitializeComponent();
        }

        private void btn_back_er_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Eredivisie_Load(object sender, EventArgs e)
        {
            //Create a DataGridView with SQL-Connection for the Standings
            //dataGridView1.DataSource = SQL_Connection.CheckDataGrid(6, "FootballApp");
        }

        //public void Bgenerate(Properties.Resources res)
        //{
        //    for (int i = 1; i < 19; i++)
        //    {
        //        Button b = new Button();
        //        b.BackgroundImage = res;
        //        b.Name = "btn_Eredivisie" + i;
        //        b.Width = flp_Eredivisie.Width / 6;
        //        b.Height = 70;
        //        b.FlatStyle = FlatStyle.Flat;
        //        b.FlatAppearance.BorderSize = 0;
        //        b.Margin = new Padding(0);
        //        flp_Eredivisie.Controls.Add(b);
        //    }

        //}

    }
}
