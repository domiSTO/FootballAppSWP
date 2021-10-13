
namespace FootballApp
{
    partial class Anmeldung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_login_Title = new System.Windows.Forms.Label();
            this.lbl_Login_Email = new System.Windows.Forms.Label();
            this.lbl_login_Password = new System.Windows.Forms.Label();
            this.tb_login_Email = new System.Windows.Forms.TextBox();
            this.tb_login_Password = new System.Windows.Forms.TextBox();
            this.btn_login_Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login_Title
            // 
            this.lbl_login_Title.AutoSize = true;
            this.lbl_login_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_Title.Location = new System.Drawing.Point(173, 29);
            this.lbl_login_Title.Name = "lbl_login_Title";
            this.lbl_login_Title.Size = new System.Drawing.Size(129, 25);
            this.lbl_login_Title.TabIndex = 0;
            this.lbl_login_Title.Text = "Anmeldung";
            // 
            // lbl_Login_Email
            // 
            this.lbl_Login_Email.AutoSize = true;
            this.lbl_Login_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Email.Location = new System.Drawing.Point(45, 124);
            this.lbl_Login_Email.Name = "lbl_Login_Email";
            this.lbl_Login_Email.Size = new System.Drawing.Size(79, 25);
            this.lbl_Login_Email.TabIndex = 1;
            this.lbl_Login_Email.Text = "E-Mail";
            // 
            // lbl_login_Password
            // 
            this.lbl_login_Password.AutoSize = true;
            this.lbl_login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_Password.Location = new System.Drawing.Point(45, 226);
            this.lbl_login_Password.Name = "lbl_login_Password";
            this.lbl_login_Password.Size = new System.Drawing.Size(108, 25);
            this.lbl_login_Password.TabIndex = 2;
            this.lbl_login_Password.Text = "Passwort";
            // 
            // tb_login_Email
            // 
            this.tb_login_Email.Location = new System.Drawing.Point(50, 153);
            this.tb_login_Email.Name = "tb_login_Email";
            this.tb_login_Email.Size = new System.Drawing.Size(204, 20);
            this.tb_login_Email.TabIndex = 3;
            // 
            // tb_login_Password
            // 
            this.tb_login_Password.Location = new System.Drawing.Point(50, 254);
            this.tb_login_Password.Name = "tb_login_Password";
            this.tb_login_Password.Size = new System.Drawing.Size(204, 20);
            this.tb_login_Password.TabIndex = 4;
            // 
            // btn_login_Login
            // 
            this.btn_login_Login.Location = new System.Drawing.Point(78, 369);
            this.btn_login_Login.Name = "btn_login_Login";
            this.btn_login_Login.Size = new System.Drawing.Size(75, 47);
            this.btn_login_Login.TabIndex = 5;
            this.btn_login_Login.Text = "Anmelden";
            this.btn_login_Login.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Account anlegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Anmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login_Login);
            this.Controls.Add(this.tb_login_Password);
            this.Controls.Add(this.tb_login_Email);
            this.Controls.Add(this.lbl_login_Password);
            this.Controls.Add(this.lbl_Login_Email);
            this.Controls.Add(this.lbl_login_Title);
            this.Name = "Anmeldung";
            this.Text = "Anmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_Title;
        private System.Windows.Forms.Label lbl_Login_Email;
        private System.Windows.Forms.Label lbl_login_Password;
        private System.Windows.Forms.TextBox tb_login_Email;
        private System.Windows.Forms.TextBox tb_login_Password;
        private System.Windows.Forms.Button btn_login_Login;
        private System.Windows.Forms.Button button1;
    }
}