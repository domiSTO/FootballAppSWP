﻿using CefSharp;
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

        public ChromiumWebBrowser browser;
        private void LaLiga_Load(object sender, EventArgs e)
        {

            CefSettings settings = new CefSettings();

            string page = string.Format(@"{0}\html-resources\LaLigaStandings.html", Application.StartupPath);

            
            browser = new ChromiumWebBrowser(page);
            pnl_browser.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            BrowserSettings browsersettings = new BrowserSettings();

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;

            //int count = 1;
            //int index = 0;
            //Point newLocation = new Point(20, 35);

            //for (int i = 0; i < 1; i++)
            //{


            //    Button btn = new Button();
            //    btn.Name = count.ToString();
            //    btn.Size = new Size(100, 100);
            //    btn.Location = newLocation;
            //    btn.FlatAppearance.BorderSize = 0;
            //    btn.FlatStyle = FlatStyle.Flat;
            //    btn.Image = imageList1.Images[index];

            //    newLocation.Offset(btn.Width + 10, 0);
            //    if (newLocation.X >= 750)
            //    {
            //        newLocation.Offset(-newLocation.X + 20, 110);
            //    }

            //    count++;
            //    index++;
            //    Controls.Add(btn);
        }
    }
}
