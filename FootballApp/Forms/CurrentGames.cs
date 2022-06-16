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
    public partial class CurrentGames : Form
    {
        public CurrentGames()
        {
            InitializeComponent();
        }


        ChromiumWebBrowser browser;

        private void CurrentGames_Load(object sender, EventArgs e)
        {
            //Chromium Browser öffnen
            var adress = $@"{Application.StartupPath}\html-resources\CurrentFixtures.html";
            browser = new ChromiumWebBrowser(adress);

           this.Controls.Add(browser);
        }
    }
}
