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

            Frm_Leagues leagues = new Frm_Leagues();
            leagues.Show();
            this.Hide();
            this.Close();
        }
    }
}
