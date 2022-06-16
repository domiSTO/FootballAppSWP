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
    public partial class PremierLeague : Form
    {
        public PremierLeague()
        {
            InitializeComponent();
        }

        private void PremierLeague_Load(object sender, EventArgs e)
        {
            //Create a DataGridView with SQL-Connection for the Standings
            
        }

        //public void Bgenerate(Properties.Resources res)
        //{
        //    for (int i = 1; i < 21; i++)
        //    {
        //        Button b = new Button();
        //        b.BackgroundImage = res;
        //        b.Name = "btn_PremierLeague" + i;
        //        b.Width = flp_PremierLeague.Width / 6;
        //        b.Height = 70;
        //        b.FlatStyle = FlatStyle.Flat;
        //        b.FlatAppearance.BorderSize = 0;
        //        b.Margin = new Padding(0);
        //        flp_PremierLeague.Controls.Add(b);
        //    }

        //}

        private void btn_back_pl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
