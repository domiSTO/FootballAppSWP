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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Register_Click(object sender, EventArgs e)
        {
            //RegisterCheck with BCrypt-Class
            string salt;
            string hashedpw;

            if (tb_Password_Register.Text == tb_PasswordConfirm_Register.Text)
            {
                salt = BCrypt.GenerateSalt();

                hashedpw = BCrypt.HashPassword(tb_PasswordConfirm_Register.Text, salt);

                SQL_Connection.InsertInto("Login", tb_Username_Register.Text, hashedpw);

                MessageBox.Show("Neuer Account wurde erstellt!", "Account erstellt!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein.", "Passwort Error!");
            }
        }

        private void cb_ShowPassword_Register_CheckedChanged(object sender, EventArgs e)
        {
            //Handles the Visible/Invisible Password
            if (cb_ShowPassword_Register.Checked == true)
            {
                tb_Password_Register.UseSystemPasswordChar = false;
                tb_PasswordConfirm_Register.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Password_Register.UseSystemPasswordChar = true;
                tb_PasswordConfirm_Register.UseSystemPasswordChar = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Handles the Visible/Invisible Password
            if(cb_ShowPassword_Register.Checked == false)
            {
                tb_Password_Register.UseSystemPasswordChar = true;
                tb_PasswordConfirm_Register.UseSystemPasswordChar = true;
            }
        }
    }
}
