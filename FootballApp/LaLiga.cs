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
    public partial class LaLiga : Form
    {
        public LaLiga()
        {
            InitializeComponent();
        }

        private void btn_back_ll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LaLiga_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQL_Connection.CheckDataGrid(3, "FootballApp");
        }
    }
}
