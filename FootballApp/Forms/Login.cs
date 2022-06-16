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

        

        

        private void btn_Back_Login_Click(object sender, EventArgs e)
        {
            Frm_Leagues leagues = new Frm_Leagues();
            leagues.Show();
            this.Hide();
            this.Close();

        }

        private void cb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Handles Visible/invisible Password
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
            //Handles Visisble/Invisible Password
            if (cb_ShowPassword.Checked == false)
            {
                tb_Password_Login.UseSystemPasswordChar = true;
                
            }

            
        }
    }
}
