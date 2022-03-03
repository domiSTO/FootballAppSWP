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
    public partial class Ligue1 : Form
    {
        public Ligue1()
        {
            InitializeComponent();
        }

        private void btn_back_lig1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ligue1_Load(object sender, EventArgs e)
        {
            //Create a DataGridView with SQL-Connection for the Standings
            dataGridView1.DataSource = SQL_Connection.CheckDataGrid(4, "FootballApp");

        }

        public void Bgenerate(Properties.Resources res)
        {
            for (int i = 1; i < 21; i++)
            {
                Button b = new Button();
                b.BackgroundImage = res;
                b.Name = "btn_Ligue1" + i;
                b.Width = flp_Ligue1.Width / 6;
                b.Height = 70;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Margin = new Padding(0);
                flp_Ligue1.Controls.Add(b);
            }

        }
    }
}
