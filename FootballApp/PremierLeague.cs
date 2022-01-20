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

        }

        private void btn_back_pl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
