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
            dataGridView1.DataSource = SQL_Connection.CheckDataGrid(6, "FootballApp");
        }
    }
}
