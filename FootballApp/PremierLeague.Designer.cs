
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
            this.btn_back_pl = new System.Windows.Forms.Button();
            this.lbl_premierleague = new System.Windows.Forms.Label();
            this.btn_Teams_Bayern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back_pl
            // 
            this.btn_back_pl.Location = new System.Drawing.Point(686, 415);
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
            // btn_Teams_Bayern
            // 
            this.btn_Teams_Bayern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Teams_Bayern.Location = new System.Drawing.Point(338, 176);
            this.btn_Teams_Bayern.Name = "btn_Teams_Bayern";
            this.btn_Teams_Bayern.Size = new System.Drawing.Size(125, 99);
            this.btn_Teams_Bayern.TabIndex = 15;
            this.btn_Teams_Bayern.UseVisualStyleBackColor = true;
            // 
            // PremierLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Teams_Bayern);
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
        private System.Windows.Forms.Button btn_Teams_Bayern;
    }
}