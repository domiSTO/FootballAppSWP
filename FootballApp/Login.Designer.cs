
namespace FootballApp
{
    partial class Login
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
            this.lbl_Title_Login = new System.Windows.Forms.Label();
            this.lbl_Username_Login = new System.Windows.Forms.Label();
            this.tb_Username_Login = new System.Windows.Forms.TextBox();
            this.tb_Password_Login = new System.Windows.Forms.TextBox();
            this.lbl_Password_Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Register_Login = new System.Windows.Forms.Button();
            this.btn_Login_Login = new System.Windows.Forms.Button();
            this.btn_Back_Login = new System.Windows.Forms.Button();
            this.cb_ShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_Title_Login
            // 
            this.lbl_Title_Login.AutoSize = true;
            this.lbl_Title_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_Login.Location = new System.Drawing.Point(91, 31);
            this.lbl_Title_Login.Name = "lbl_Title_Login";
            this.lbl_Title_Login.Size = new System.Drawing.Size(144, 29);
            this.lbl_Title_Login.TabIndex = 0;
            this.lbl_Title_Login.Text = "Anmeldung";
            // 
            // lbl_Username_Login
            // 
            this.lbl_Username_Login.AutoSize = true;
            this.lbl_Username_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username_Login.Location = new System.Drawing.Point(28, 109);
            this.lbl_Username_Login.Name = "lbl_Username_Login";
            this.lbl_Username_Login.Size = new System.Drawing.Size(116, 18);
            this.lbl_Username_Login.TabIndex = 1;
            this.lbl_Username_Login.Text = "Benutzername";
            // 
            // tb_Username_Login
            // 
            this.tb_Username_Login.Location = new System.Drawing.Point(31, 139);
            this.tb_Username_Login.Name = "tb_Username_Login";
            this.tb_Username_Login.Size = new System.Drawing.Size(191, 20);
            this.tb_Username_Login.TabIndex = 2;
            // 
            // tb_Password_Login
            // 
            this.tb_Password_Login.Location = new System.Drawing.Point(31, 231);
            this.tb_Password_Login.Name = "tb_Password_Login";
            this.tb_Password_Login.Size = new System.Drawing.Size(191, 20);
            this.tb_Password_Login.TabIndex = 4;
            // 
            // lbl_Password_Login
            // 
            this.lbl_Password_Login.AutoSize = true;
            this.lbl_Password_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_Login.Location = new System.Drawing.Point(28, 201);
            this.lbl_Password_Login.Name = "lbl_Password_Login";
            this.lbl_Password_Login.Size = new System.Drawing.Size(79, 18);
            this.lbl_Password_Login.TabIndex = 3;
            this.lbl_Password_Login.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Haben Sie noch keinen Account?";
            // 
            // lbl_Register_Login
            // 
            this.lbl_Register_Login.FlatAppearance.BorderSize = 0;
            this.lbl_Register_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Register_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register_Login.Location = new System.Drawing.Point(214, 293);
            this.lbl_Register_Login.Name = "lbl_Register_Login";
            this.lbl_Register_Login.Size = new System.Drawing.Size(88, 23);
            this.lbl_Register_Login.TabIndex = 6;
            this.lbl_Register_Login.Text = "Registrieren";
            this.lbl_Register_Login.UseVisualStyleBackColor = true;
            this.lbl_Register_Login.Click += new System.EventHandler(this.lbl_Register_Login_Click);
            // 
            // btn_Login_Login
            // 
            this.btn_Login_Login.Location = new System.Drawing.Point(121, 341);
            this.btn_Login_Login.Name = "btn_Login_Login";
            this.btn_Login_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login_Login.TabIndex = 7;
            this.btn_Login_Login.Text = "Anmelden";
            this.btn_Login_Login.UseVisualStyleBackColor = true;
            this.btn_Login_Login.Click += new System.EventHandler(this.btn_Login_Login_Click);
            // 
            // btn_Back_Login
            // 
            this.btn_Back_Login.Location = new System.Drawing.Point(12, 341);
            this.btn_Back_Login.Name = "btn_Back_Login";
            this.btn_Back_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Back_Login.TabIndex = 8;
            this.btn_Back_Login.Text = "Zurück";
            this.btn_Back_Login.UseVisualStyleBackColor = true;
            this.btn_Back_Login.Click += new System.EventHandler(this.btn_Back_Login_Click);
            // 
            // cb_ShowPassword
            // 
            this.cb_ShowPassword.AutoSize = true;
            this.cb_ShowPassword.Location = new System.Drawing.Point(31, 258);
            this.cb_ShowPassword.Name = "cb_ShowPassword";
            this.cb_ShowPassword.Size = new System.Drawing.Size(116, 17);
            this.cb_ShowPassword.TabIndex = 9;
            this.cb_ShowPassword.Text = "Passwort Anzeigen";
            this.cb_ShowPassword.UseVisualStyleBackColor = true;
            this.cb_ShowPassword.CheckedChanged += new System.EventHandler(this.cb_ShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 391);
            this.Controls.Add(this.cb_ShowPassword);
            this.Controls.Add(this.btn_Back_Login);
            this.Controls.Add(this.btn_Login_Login);
            this.Controls.Add(this.lbl_Register_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Password_Login);
            this.Controls.Add(this.lbl_Password_Login);
            this.Controls.Add(this.tb_Username_Login);
            this.Controls.Add(this.lbl_Username_Login);
            this.Controls.Add(this.lbl_Title_Login);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmeldung";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title_Login;
        private System.Windows.Forms.Label lbl_Username_Login;
        private System.Windows.Forms.TextBox tb_Username_Login;
        private System.Windows.Forms.TextBox tb_Password_Login;
        private System.Windows.Forms.Label lbl_Password_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lbl_Register_Login;
        private System.Windows.Forms.Button btn_Login_Login;
        private System.Windows.Forms.Button btn_Back_Login;
        private System.Windows.Forms.CheckBox cb_ShowPassword;
    }
}