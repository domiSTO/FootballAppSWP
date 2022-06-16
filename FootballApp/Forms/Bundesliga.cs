using CefSharp.WinForms;
using CefSharp;
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
    public partial class Bundesliga : Form
    {
        public Bundesliga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        ChromiumWebBrowser browser;
        private void Bundesliga_Load(object sender, EventArgs e)
        {

            var adress = $@"{Application.StartupPath}\html-resources\BuliStandings.html";
            browser = new ChromiumWebBrowser(adress);

            pnl_browser.Controls.Add(browser);
            
           



        }

        private void btn_Teams_Bayern_Click(object sender, EventArgs e)
        {
            
        }
    }
}
