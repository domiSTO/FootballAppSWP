namespace FootballApp
{
    partial class AddTeams
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
            this.a = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.txtbox_teamname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_league = new System.Windows.Forms.Label();
            this.btn_back_addteams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.FlatAppearance.BorderSize = 2;
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(336, 383);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(133, 55);
            this.a.TabIndex = 14;
            this.a.Text = "Hinzufügen";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(298, 18);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(205, 25);
            this.lbl_header.TabIndex = 15;
            this.lbl_header.Text = "Teams hinzufügen";
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamname.Location = new System.Drawing.Point(247, 103);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(127, 25);
            this.lbl_teamname.TabIndex = 16;
            this.lbl_teamname.Text = "Teamname";
            // 
            // txtbox_teamname
            // 
            this.txtbox_teamname.Location = new System.Drawing.Point(403, 103);
            this.txtbox_teamname.Multiline = true;
            this.txtbox_teamname.Name = "txtbox_teamname";
            this.txtbox_teamname.Size = new System.Drawing.Size(100, 25);
            this.txtbox_teamname.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bundesliga",
            "Serie A",
            "La Liga",
            "Ligue 1",
            "Premier League",
            "Eredevise"});
            this.comboBox1.Location = new System.Drawing.Point(403, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_league
            // 
            this.lbl_league.AutoSize = true;
            this.lbl_league.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_league.Location = new System.Drawing.Point(247, 154);
            this.lbl_league.Name = "lbl_league";
            this.lbl_league.Size = new System.Drawing.Size(57, 25);
            this.lbl_league.TabIndex = 19;
            this.lbl_league.Text = "Liga";
            // 
            // btn_back_addteams
            // 
            this.btn_back_addteams.FlatAppearance.BorderSize = 2;
            this.btn_back_addteams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_addteams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_addteams.Location = new System.Drawing.Point(696, 383);
            this.btn_back_addteams.Name = "btn_back_addteams";
            this.btn_back_addteams.Size = new System.Drawing.Size(83, 55);
            this.btn_back_addteams.TabIndex = 20;
            this.btn_back_addteams.Text = "Zurück";
            this.btn_back_addteams.UseVisualStyleBackColor = true;
            this.btn_back_addteams.Click += new System.EventHandler(this.btn_back_addteams_Click);
            // 
            // AddTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_addteams);
            this.Controls.Add(this.lbl_league);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtbox_teamname);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.a);
            this.Name = "AddTeams";
            this.Text = "xt";
            this.Load += new System.EventHandler(this.AddTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button a;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.TextBox txtbox_teamname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_league;
        public System.Windows.Forms.Button btn_back_addteams;
    }
}