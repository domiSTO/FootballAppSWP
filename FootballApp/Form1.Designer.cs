﻿
namespace FootballApp
{
    partial class Frm_Leagues
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Leagues));
            this.leagues_Title = new System.Windows.Forms.Label();
            this.btn_Bundesliga = new System.Windows.Forms.Button();
            this.btn_PremierLeague = new System.Windows.Forms.Button();
            this.btn_Ligue1 = new System.Windows.Forms.Button();
            this.btn_SerieA = new System.Windows.Forms.Button();
            this.btn_LaLiga = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Eredivisie = new System.Windows.Forms.Button();
            this.tb_DarkTheme = new FootballApp.ToggleButton();
            this.SuspendLayout();
            // 
            // leagues_Title
            // 
            this.leagues_Title.AutoSize = true;
            this.leagues_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagues_Title.Location = new System.Drawing.Point(243, 31);
            this.leagues_Title.Name = "leagues_Title";
            this.leagues_Title.Size = new System.Drawing.Size(281, 31);
            this.leagues_Title.TabIndex = 0;
            this.leagues_Title.Text = "Wählen Sie ihre Liga";
            // 
            // btn_Bundesliga
            // 
            this.btn_Bundesliga.FlatAppearance.BorderSize = 0;
            this.btn_Bundesliga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bundesliga.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bundesliga.Image")));
            this.btn_Bundesliga.Location = new System.Drawing.Point(59, 106);
            this.btn_Bundesliga.Name = "btn_Bundesliga";
            this.btn_Bundesliga.Size = new System.Drawing.Size(203, 194);
            this.btn_Bundesliga.TabIndex = 1;
            this.btn_Bundesliga.UseVisualStyleBackColor = true;
            this.btn_Bundesliga.Click += new System.EventHandler(this.btn_Bundesliga_Click);
            // 
            // btn_PremierLeague
            // 
            this.btn_PremierLeague.FlatAppearance.BorderSize = 0;
            this.btn_PremierLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PremierLeague.Image = ((System.Drawing.Image)(resources.GetObject("btn_PremierLeague.Image")));
            this.btn_PremierLeague.Location = new System.Drawing.Point(304, 106);
            this.btn_PremierLeague.Name = "btn_PremierLeague";
            this.btn_PremierLeague.Size = new System.Drawing.Size(203, 194);
            this.btn_PremierLeague.TabIndex = 2;
            this.btn_PremierLeague.UseVisualStyleBackColor = true;
            this.btn_PremierLeague.Click += new System.EventHandler(this.btn_PremierLeague_Click);
            // 
            // btn_Ligue1
            // 
            this.btn_Ligue1.FlatAppearance.BorderSize = 0;
            this.btn_Ligue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ligue1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ligue1.Image")));
            this.btn_Ligue1.Location = new System.Drawing.Point(545, 106);
            this.btn_Ligue1.Name = "btn_Ligue1";
            this.btn_Ligue1.Size = new System.Drawing.Size(203, 194);
            this.btn_Ligue1.TabIndex = 3;
            this.btn_Ligue1.UseVisualStyleBackColor = true;
            this.btn_Ligue1.Click += new System.EventHandler(this.btn_Ligue1_Click);
            // 
            // btn_SerieA
            // 
            this.btn_SerieA.FlatAppearance.BorderSize = 0;
            this.btn_SerieA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerieA.Image = ((System.Drawing.Image)(resources.GetObject("btn_SerieA.Image")));
            this.btn_SerieA.Location = new System.Drawing.Point(59, 347);
            this.btn_SerieA.Name = "btn_SerieA";
            this.btn_SerieA.Size = new System.Drawing.Size(203, 194);
            this.btn_SerieA.TabIndex = 4;
            this.btn_SerieA.UseVisualStyleBackColor = true;
            this.btn_SerieA.Click += new System.EventHandler(this.btn_SerieA_Click);
            // 
            // btn_LaLiga
            // 
            this.btn_LaLiga.FlatAppearance.BorderSize = 0;
            this.btn_LaLiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LaLiga.Image = ((System.Drawing.Image)(resources.GetObject("btn_LaLiga.Image")));
            this.btn_LaLiga.Location = new System.Drawing.Point(545, 347);
            this.btn_LaLiga.Name = "btn_LaLiga";
            this.btn_LaLiga.Size = new System.Drawing.Size(203, 194);
            this.btn_LaLiga.TabIndex = 5;
            this.btn_LaLiga.UseVisualStyleBackColor = true;
            this.btn_LaLiga.Click += new System.EventHandler(this.btn_LaLiga_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.FlatAppearance.BorderSize = 2;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(641, 19);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(107, 43);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Eredivisie
            // 
            this.btn_Eredivisie.FlatAppearance.BorderSize = 0;
            this.btn_Eredivisie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eredivisie.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eredivisie.Image")));
            this.btn_Eredivisie.Location = new System.Drawing.Point(304, 347);
            this.btn_Eredivisie.Name = "btn_Eredivisie";
            this.btn_Eredivisie.Size = new System.Drawing.Size(203, 194);
            this.btn_Eredivisie.TabIndex = 7;
            this.btn_Eredivisie.UseVisualStyleBackColor = true;
            // 
            // tb_DarkTheme
            // 
            this.tb_DarkTheme.AutoSize = true;
            this.tb_DarkTheme.Location = new System.Drawing.Point(59, 31);
            this.tb_DarkTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.tb_DarkTheme.Name = "tb_DarkTheme";
            this.tb_DarkTheme.OffBackColor = System.Drawing.Color.Gray;
            this.tb_DarkTheme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tb_DarkTheme.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_DarkTheme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tb_DarkTheme.Size = new System.Drawing.Size(45, 22);
            this.tb_DarkTheme.TabIndex = 8;
            this.tb_DarkTheme.UseVisualStyleBackColor = true;
            this.tb_DarkTheme.CheckedChanged += new System.EventHandler(this.tb_DarkTheme_CheckedChanged);
            // 
            // Frm_Leagues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.tb_DarkTheme);
            this.Controls.Add(this.btn_Eredivisie);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_LaLiga);
            this.Controls.Add(this.btn_SerieA);
            this.Controls.Add(this.btn_Ligue1);
            this.Controls.Add(this.btn_PremierLeague);
            this.Controls.Add(this.btn_Bundesliga);
            this.Controls.Add(this.leagues_Title);
            this.Name = "Frm_Leagues";
            this.Text = "Ligen wählen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leagues_Title;
        private System.Windows.Forms.Button btn_Bundesliga;
        private System.Windows.Forms.Button btn_PremierLeague;
        private System.Windows.Forms.Button btn_Ligue1;
        private System.Windows.Forms.Button btn_SerieA;
        private System.Windows.Forms.Button btn_LaLiga;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Eredivisie;
        private ToggleButton tb_DarkTheme;
    }
}

