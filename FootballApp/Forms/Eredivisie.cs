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
    public partial class Eredivisie : Form
    {
        public Eredivisie()
        {
            InitializeComponent();
        }

        


        ChromiumWebBrowser browser;

        private void Eredivisie_Load(object sender, EventArgs e)
        {
            //opens the chromium browser
            var adress = $@"{Application.StartupPath}\html-resources\EredeviseStandings.html";
            browser = new ChromiumWebBrowser(adress);

            this.Controls.Add(browser);
        }

    }
}
