namespace FootballApp
{
    partial class Team
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Team));
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.PremierLeague = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Formations = new System.Windows.Forms.ImageList(this.components);
            this.lbl_formation = new System.Windows.Forms.Label();
            this.pbbox_formation = new System.Windows.Forms.PictureBox();
            this.pbbox_playerlist = new System.Windows.Forms.PictureBox();
            this.lbl_playerlist = new System.Windows.Forms.Label();
            this.lbl_current_position = new System.Windows.Forms.Label();
            this.lbl_form = new System.Windows.Forms.Label();
            this.pb_currentform = new System.Windows.Forms.PictureBox();
            this.currentForms = new System.Windows.Forms.ImageList(this.components);
            this.lbl_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbox_formation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbox_playerlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_currentform)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamname.Location = new System.Drawing.Point(20, 165);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(115, 39);
            this.lbl_teamname.TabIndex = 1;
            this.lbl_teamname.Text = "label1";
            // 
            // PremierLeague
            // 
            this.PremierLeague.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PremierLeague.ImageStream")));
            this.PremierLeague.TransparentColor = System.Drawing.Color.Transparent;
            this.PremierLeague.Images.SetKeyName(0, "City.png");
            this.PremierLeague.Images.SetKeyName(1, "Arsenal.png");
            this.PremierLeague.Images.SetKeyName(2, "Aston_Villa.png");
            this.PremierLeague.Images.SetKeyName(3, "Brentford.png");
            this.PremierLeague.Images.SetKeyName(4, "Brighton.png");
            this.PremierLeague.Images.SetKeyName(5, "Burnley.png");
            this.PremierLeague.Images.SetKeyName(6, "Chelsea.png");
            this.PremierLeague.Images.SetKeyName(7, "Crystal_Palace.png");
            this.PremierLeague.Images.SetKeyName(8, "Everton.png");
            this.PremierLeague.Images.SetKeyName(9, "Leeds.png");
            this.PremierLeague.Images.SetKeyName(10, "Leicester.png");
            this.PremierLeague.Images.SetKeyName(11, "Liverpool.png");
            this.PremierLeague.Images.SetKeyName(12, "Man_United.png");
            this.PremierLeague.Images.SetKeyName(13, "Newcastle.png");
            this.PremierLeague.Images.SetKeyName(14, "Norwich.png");
            this.PremierLeague.Images.SetKeyName(15, "Southampton.png");
            this.PremierLeague.Images.SetKeyName(16, "Tottenham.png");
            this.PremierLeague.Images.SetKeyName(17, "Watford.png");
            this.PremierLeague.Images.SetKeyName(18, "Westham.png");
            this.PremierLeague.Images.SetKeyName(19, "Wolverhampton.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Formations
            // 
            this.Formations.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Formations.ImageStream")));
            this.Formations.TransparentColor = System.Drawing.Color.Transparent;
            this.Formations.Images.SetKeyName(0, "4-2-3-1-1.png");
            this.Formations.Images.SetKeyName(1, "Players_Arsenal.PNG");
            this.Formations.Images.SetKeyName(2, "Arsenal_form.PNG");
            // 
            // lbl_formation
            // 
            this.lbl_formation.AutoSize = true;
            this.lbl_formation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formation.Location = new System.Drawing.Point(596, 209);
            this.lbl_formation.Name = "lbl_formation";
            this.lbl_formation.Size = new System.Drawing.Size(76, 25);
            this.lbl_formation.TabIndex = 4;
            this.lbl_formation.Text = "label1";
            // 
            // pbbox_formation
            // 
            this.pbbox_formation.InitialImage = null;
            this.pbbox_formation.Location = new System.Drawing.Point(537, 12);
            this.pbbox_formation.Name = "pbbox_formation";
            this.pbbox_formation.Size = new System.Drawing.Size(251, 192);
            this.pbbox_formation.TabIndex = 0;
            this.pbbox_formation.TabStop = false;
            // 
            // pbbox_playerlist
            // 
            this.pbbox_playerlist.InitialImage = null;
            this.pbbox_playerlist.Location = new System.Drawing.Point(537, 244);
            this.pbbox_playerlist.Name = "pbbox_playerlist";
            this.pbbox_playerlist.Size = new System.Drawing.Size(192, 204);
            this.pbbox_playerlist.TabIndex = 5;
            this.pbbox_playerlist.TabStop = false;
            // 
            // lbl_playerlist
            // 
            this.lbl_playerlist.AutoSize = true;
            this.lbl_playerlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerlist.Location = new System.Drawing.Point(401, 338);
            this.lbl_playerlist.Name = "lbl_playerlist";
            this.lbl_playerlist.Size = new System.Drawing.Size(130, 25);
            this.lbl_playerlist.TabIndex = 6;
            this.lbl_playerlist.Text = "Spielerliste";
            // 
            // lbl_current_position
            // 
            this.lbl_current_position.AutoSize = true;
            this.lbl_current_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_position.Location = new System.Drawing.Point(6, 244);
            this.lbl_current_position.Name = "lbl_current_position";
            this.lbl_current_position.Size = new System.Drawing.Size(265, 31);
            this.lbl_current_position.TabIndex = 7;
            this.lbl_current_position.Text = "Aktuelle Position: 5";
            // 
            // lbl_form
            // 
            this.lbl_form.AutoSize = true;
            this.lbl_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form.Location = new System.Drawing.Point(6, 301);
            this.lbl_form.Name = "lbl_form";
            this.lbl_form.Size = new System.Drawing.Size(203, 31);
            this.lbl_form.TabIndex = 8;
            this.lbl_form.Text = "Aktuelle Form:";
            // 
            // pb_currentform
            // 
            this.pb_currentform.Location = new System.Drawing.Point(215, 306);
            this.pb_currentform.Name = "pb_currentform";
            this.pb_currentform.Size = new System.Drawing.Size(129, 30);
            this.pb_currentform.TabIndex = 9;
            this.pb_currentform.TabStop = false;
            // 
            // currentForms
            // 
            this.currentForms.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("currentForms.ImageStream")));
            this.currentForms.TransparentColor = System.Drawing.Color.Transparent;
            this.currentForms.Images.SetKeyName(0, "Arsenal_form.PNG");
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(251, 12);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(280, 39);
            this.lbl_header.TabIndex = 10;
            this.lbl_header.Text = "Team-Übersicht";
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.pb_currentform);
            this.Controls.Add(this.lbl_form);
            this.Controls.Add(this.lbl_current_position);
            this.Controls.Add(this.lbl_playerlist);
            this.Controls.Add(this.pbbox_playerlist);
            this.Controls.Add(this.pbbox_formation);
            this.Controls.Add(this.lbl_formation);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Team";
            this.Text = "i";
            this.Load += new System.EventHandler(this.Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbox_formation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbox_playerlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_currentform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.ImageList PremierLeague;
        private System.Windows.Forms.ImageList Formations;
        private System.Windows.Forms.Label lbl_formation;
        private System.Windows.Forms.PictureBox pbbox_formation;
        private System.Windows.Forms.PictureBox pbbox_playerlist;
        private System.Windows.Forms.Label lbl_playerlist;
        private System.Windows.Forms.Label lbl_current_position;
        private System.Windows.Forms.Label lbl_form;
        private System.Windows.Forms.PictureBox pb_currentform;
        private System.Windows.Forms.ImageList currentForms;
        private System.Windows.Forms.Label lbl_header;
    }
}