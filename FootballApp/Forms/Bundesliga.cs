﻿using CefSharp;
using CefSharp.SchemeHandler;
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

        public ChromiumWebBrowser browser;
        private void Bundesliga_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;

            

            string page = string.Format(@"{0}\html-resources\BuliStandings.html", Application.StartupPath);

            
            browser = new ChromiumWebBrowser(page);  
            pnl_browser.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            BrowserSettings browsersettings = new BrowserSettings();
            
          


            //Erstellen der Buttons der Teams
            //int count = 1;
            //int X = 0;
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

        private void pnl_browser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}