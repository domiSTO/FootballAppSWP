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

        ChromiumWebBrowser browser;
        private void Bundesliga_Load(object sender, EventArgs e)
        {
            //Chromiumbrowser öffnen
            var adress = $@"{Application.StartupPath}\html-resources\BuliStandings.html";
            browser = new ChromiumWebBrowser(adress);

            this.Controls.Add(browser);

        }

        
    }
}
