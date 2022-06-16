
namespace FootballApp
{
    partial class Register
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
            this.lbl_TItle_Register = new System.Windows.Forms.Label();
            this.lbl_Email_Register = new System.Windows.Forms.Label();
            this.tb_Username_Register = new System.Windows.Forms.TextBox();
            this.tb_Password_Register = new System.Windows.Forms.TextBox();
            this.lbl_Password_Register = new System.Windows.Forms.Label();
            this.tb_PasswordConfirm_Register = new System.Windows.Forms.TextBox();
            this.lbl_Passwordconfirm_Register = new System.Windows.Forms.Label();
            this.btn_Register_Register = new System.Windows.Forms.Button();
            this.cb_ShowPassword_Register = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_TItle_Register
            // 
            this.lbl_TItle_Register.AutoSize = true;
            this.lbl_TItle_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TItle_Register.Location = new System.Drawing.Point(41, 20);
            this.lbl_TItle_Register.Name = "lbl_TItle_Register";
            this.lbl_TItle_Register.Size = new System.Drawing.Size(171, 29);
            this.lbl_TItle_Register.TabIndex = 0;
            this.lbl_TItle_Register.Text = "Registrierung";
            // 
            // lbl_Email_Register
            // 
            this.lbl_Email_Register.AutoSize = true;
            this.lbl_Email_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Register.Location = new System.Drawing.Point(40, 127);
            this.lbl_Email_Register.Name = "lbl_Email_Register";
            this.lbl_Email_Register.Size = new System.Drawing.Size(116, 18);
            this.lbl_Email_Register.TabIndex = 1;
            this.lbl_Email_Register.Text = "Benutzername";
            // 
            // tb_Username_Register
            // 
            this.tb_Username_Register.Location = new System.Drawing.Point(56, 159);
            this.tb_Username_Register.Name = "tb_Username_Register";
            this.tb_Username_Register.Size = new System.Drawing.Size(156, 20);
            this.tb_Username_Register.TabIndex = 2;
            // 
            // tb_Password_Register
            // 
            this.tb_Password_Register.Location = new System.Drawing.Point(56, 242);
            this.tb_Password_Register.Name = "tb_Password_Register";
            this.tb_Password_Register.Size = new System.Drawing.Size(156, 20);
            this.tb_Password_Register.TabIndex = 4;
            // 
            // lbl_Password_Register
            // 
            this.lbl_Password_Register.AutoSize = true;
            this.lbl_Password_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_Register.Location = new System.Drawing.Point(40, 210);
            this.lbl_Password_Register.Name = "lbl_Password_Register";
            this.lbl_Password_Register.Size = new System.Drawing.Size(79, 18);
            this.lbl_Password_Register.TabIndex = 3;
            this.lbl_Password_Register.Text = "Passwort";
            // 
            // tb_PasswordConfirm_Register
            // 
            this.tb_PasswordConfirm_Register.Location = new System.Drawing.Point(56, 325);
            this.tb_PasswordConfirm_Register.Name = "tb_PasswordConfirm_Register";
            this.tb_PasswordConfirm_Register.Size = new System.Drawing.Size(156, 20);
            this.tb_PasswordConfirm_Register.TabIndex = 6;
            this.tb_PasswordConfirm_Register.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_PasswordConfirm_Register_KeyDown);
            // 
            // lbl_Passwordconfirm_Register
            // 
            this.lbl_Passwordconfirm_Register.AutoSize = true;
            this.lbl_Passwordconfirm_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwordconfirm_Register.Location = new System.Drawing.Point(40, 293);
            this.lbl_Passwordconfirm_Register.Name = "lbl_Passwordconfirm_Register";
            this.lbl_Passwordconfirm_Register.Size = new System.Drawing.Size(161, 18);
            this.lbl_Passwordconfirm_Register.TabIndex = 5;
            this.lbl_Passwordconfirm_Register.Text = "Passwort bestätigen";
            // 
            // btn_Register_Register
            // 
            this.btn_Register_Register.Location = new System.Drawing.Point(96, 391);
            this.btn_Register_Register.Name = "btn_Register_Register";
            this.btn_Register_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register_Register.TabIndex = 7;
            this.btn_Register_Register.Text = "Registrieren";
            this.btn_Register_Register.UseVisualStyleBackColor = true;
            this.btn_Register_Register.Click += new System.EventHandler(this.btn_Register_Register_Click);
            // 
            // cb_ShowPassword_Register
            // 
            this.cb_ShowPassword_Register.AutoSize = true;
            this.cb_ShowPassword_Register.Location = new System.Drawing.Point(43, 351);
            this.cb_ShowPassword_Register.Name = "cb_ShowPassword_Register";
            this.cb_ShowPassword_Register.Size = new System.Drawing.Size(115, 17);
            this.cb_ShowPassword_Register.TabIndex = 8;
            this.cb_ShowPassword_Register.Text = "Passwort anzeigen";
            this.cb_ShowPassword_Register.UseVisualStyleBackColor = true;
            this.cb_ShowPassword_Register.CheckedChanged += new System.EventHandler(this.cb_ShowPassword_Register_CheckedChanged);
            // 
            // Register
            // 
            this.AcceptButton = this.btn_Register_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.cb_ShowPassword_Register);
            this.Controls.Add(this.btn_Register_Register);
            this.Controls.Add(this.tb_PasswordConfirm_Register);
            this.Controls.Add(this.lbl_Passwordconfirm_Register);
            this.Controls.Add(this.tb_Password_Register);
            this.Controls.Add(this.lbl_Password_Register);
            this.Controls.Add(this.tb_Username_Register);
            this.Controls.Add(this.lbl_Email_Register);
            this.Controls.Add(this.lbl_TItle_Register);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TItle_Register;
        private System.Windows.Forms.Label lbl_Email_Register;
        private System.Windows.Forms.TextBox tb_Username_Register;
        private System.Windows.Forms.TextBox tb_Password_Register;
        private System.Windows.Forms.Label lbl_Password_Register;
        private System.Windows.Forms.TextBox tb_PasswordConfirm_Register;
        private System.Windows.Forms.Label lbl_Passwordconfirm_Register;
        private System.Windows.Forms.Button btn_Register_Register;
        private System.Windows.Forms.CheckBox cb_ShowPassword_Register;
    }
}