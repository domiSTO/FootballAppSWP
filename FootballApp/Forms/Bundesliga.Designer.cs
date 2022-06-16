
namespace FootballApp
{
    partial class Bundesliga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bundesliga));
            this.lbl_bundesliga = new System.Windows.Forms.Label();
            this.pnl_browser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_bundesliga
            // 
            this.lbl_bundesliga.AutoSize = true;
            this.lbl_bundesliga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bundesliga.Location = new System.Drawing.Point(306, 0);
            this.lbl_bundesliga.Name = "lbl_bundesliga";
            this.lbl_bundesliga.Size = new System.Drawing.Size(114, 24);
            this.lbl_bundesliga.TabIndex = 13;
            this.lbl_bundesliga.Text = "Bundesliga";
            // 
            // pnl_browser
            // 
            this.pnl_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_browser.Location = new System.Drawing.Point(0, 0);
            this.pnl_browser.Name = "pnl_browser";
            this.pnl_browser.Size = new System.Drawing.Size(743, 450);
            this.pnl_browser.TabIndex = 14;
            // 
            // Bundesliga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.pnl_browser);
            this.Controls.Add(this.lbl_bundesliga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bundesliga";
            this.Text = "Bundesliga";
            this.Load += new System.EventHandler(this.Bundesliga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_bundesliga;
        private System.Windows.Forms.Panel pnl_browser;
    }
}