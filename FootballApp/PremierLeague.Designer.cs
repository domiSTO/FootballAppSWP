
namespace FootballApp
{
    partial class PremierLeague
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PremierLeague));
            this.btn_back_pl = new System.Windows.Forms.Button();
            this.lbl_premierleague = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_back_pl
            // 
            this.btn_back_pl.Location = new System.Drawing.Point(687, 415);
            this.btn_back_pl.Name = "btn_back_pl";
            this.btn_back_pl.Size = new System.Drawing.Size(75, 23);
            this.btn_back_pl.TabIndex = 0;
            this.btn_back_pl.Text = "Zurück";
            this.btn_back_pl.UseVisualStyleBackColor = true;
            this.btn_back_pl.Click += new System.EventHandler(this.btn_back_pl_Click);
            // 
            // lbl_premierleague
            // 
            this.lbl_premierleague.AutoSize = true;
            this.lbl_premierleague.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_premierleague.Location = new System.Drawing.Point(326, 6);
            this.lbl_premierleague.Name = "lbl_premierleague";
            this.lbl_premierleague.Size = new System.Drawing.Size(159, 24);
            this.lbl_premierleague.TabIndex = 3;
            this.lbl_premierleague.Text = "Premier League";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "City.png");
            this.imageList1.Images.SetKeyName(1, "Arsenal.png");
            this.imageList1.Images.SetKeyName(2, "Aston_Villa.png");
            this.imageList1.Images.SetKeyName(3, "Brentford.png");
            this.imageList1.Images.SetKeyName(4, "Brighton.png");
            this.imageList1.Images.SetKeyName(5, "Burnley.png");
            this.imageList1.Images.SetKeyName(6, "Chelsea.png");
            this.imageList1.Images.SetKeyName(7, "Crystal_Palace.png");
            this.imageList1.Images.SetKeyName(8, "Everton.png");
            this.imageList1.Images.SetKeyName(9, "Leeds.png");
            this.imageList1.Images.SetKeyName(10, "Leicester.png");
            this.imageList1.Images.SetKeyName(11, "Liverpool.png");
            this.imageList1.Images.SetKeyName(12, "Man_United.png");
            this.imageList1.Images.SetKeyName(13, "Newcastle.png");
            this.imageList1.Images.SetKeyName(14, "Norwich.png");
            this.imageList1.Images.SetKeyName(15, "Southampton.png");
            this.imageList1.Images.SetKeyName(16, "Tottenham.png");
            this.imageList1.Images.SetKeyName(17, "Watford.png");
            this.imageList1.Images.SetKeyName(18, "Westham.png");
            this.imageList1.Images.SetKeyName(19, "Wolverhampton.png");
            // 
            // PremierLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_premierleague);
            this.Controls.Add(this.btn_back_pl);
            this.Name = "PremierLeague";
            this.Text = "PremierLeague";
            this.Load += new System.EventHandler(this.PremierLeague_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_pl;
        private System.Windows.Forms.Label lbl_premierleague;
        private System.Windows.Forms.ImageList imageList1;
    }
}