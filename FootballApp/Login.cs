﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_Register_Login_Click(object sender, EventArgs e)
        {
            Register register_login = new Register();
            register_login.Show();

        }

        private void btn_Login_Login_Click(object sender, EventArgs e)
        {
            //Checking if the Textboxes are filled in correctly and if not it displasy a reminder
            if(tb_Username_Login.Text.Equals("") || tb_Password_Login.Text.Equals(""))
            {
                MessageBox.Show("Ungültige Eingabe! Bitte überprüfen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!tb_Username_Login.Text.Equals("") && !tb_Password_Login.Text.Equals(""))
            {
                MessageBox.Show("Erfolgreich angemeldet","Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SQL_Connection.CheckTable("Login", tb_Username_Login.Text, tb_Password_Login.Text);

            Environment.Exit(0);

            Frm_Leagues leagues = new Frm_Leagues();
            leagues.Show();
            this.Hide();
            this.Close();
        }

        private void btn_Back_Login_Click(object sender, EventArgs e)
        {
            Frm_Leagues leagues = new Frm_Leagues();
            leagues.Show();
            this.Hide();
            this.Close();

        }

        private void cb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPassword.Checked == true)
            {
                tb_Password_Login.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Password_Login.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQL_Connection.CreateDatabase("FootballApp");
            SQL_Connection.CreateTable("FootballApp", "Login");
        }
    }
}
