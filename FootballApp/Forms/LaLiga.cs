using CefSharp.WinForms;
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


        ChromiumWebBrowser browser;
        private void LaLiga_Load(object sender, EventArgs e)
        {

            //Chromiumbrowser öffnen
            var adress = $@"{Application.StartupPath}\html-resources\LaLigaStandings.html";
            browser = new ChromiumWebBrowser(adress);

            this.Controls.Add(browser);
        }
    }
}
