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
    public partial class SerieA : Form
    {
        public SerieA()
        {
            InitializeComponent();
        }

        private void btn_back_serA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerieA_Load(object sender, EventArgs e)
        {
            //Create a DataGridView with SQL-Connection for the Standings
            dataGridView1.DataSource = SQL_Connection.CheckDataGrid(2, "FootballApp");
        }
    }
}
