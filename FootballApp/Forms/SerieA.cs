﻿using CefSharp.WinForms;
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

        ChromiumWebBrowser browser;
        private void SerieA_Load(object sender, EventArgs e)
        {
            var adress = $@"{Application.StartupPath}\html-resources\SerieAStandings.html";
            browser = new ChromiumWebBrowser(adress);

            pnl_browser.Controls.Add(browser);
        }

        //public void Bgenerate(Properties.Resources res)
        //{
        //    for (int i = 1; i < 21; i++)
        //    {
        //        Button b = new Button();
        //        b.BackgroundImage = res;
        //        b.Name = "btn_SerieA" + i;
        //        b.Width = flp_SerieA.Width / 6;
        //        b.Height = 70;
        //        b.FlatStyle = FlatStyle.Flat;
        //        b.FlatAppearance.BorderSize = 0;
        //        b.Margin = new Padding(0);
        //        flp_SerieA.Controls.Add(b);
        //    }

        //}
    }
}
