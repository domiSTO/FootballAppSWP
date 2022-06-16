
namespace FootballApp
{
    partial class Ligue1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ligue1));
            this.btn_back_lig1 = new System.Windows.Forms.Button();
            this.lbl_ligue1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_browser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_back_lig1
            // 
            this.btn_back_lig1.Location = new System.Drawing.Point(713, 415);
            this.btn_back_lig1.Name = "btn_back_lig1";
            this.btn_back_lig1.Size = new System.Drawing.Size(75, 23);
            this.btn_back_lig1.TabIndex = 0;
            this.btn_back_lig1.Text = "Zurück";
            this.btn_back_lig1.UseVisualStyleBackColor = true;
            this.btn_back_lig1.Click += new System.EventHandler(this.btn_back_lig1_Click);
            // 
            // lbl_ligue1
            // 
            this.lbl_ligue1.AutoSize = true;
            this.lbl_ligue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ligue1.Location = new System.Drawing.Point(345, 9);
            this.lbl_ligue1.Name = "lbl_ligue1";
            this.lbl_ligue1.Size = new System.Drawing.Size(79, 24);
            this.lbl_ligue1.TabIndex = 2;
            this.lbl_ligue1.Text = "Ligue 1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Paris.png");
            // 
            // pnl_browser
            // 
            this.pnl_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_browser.Location = new System.Drawing.Point(0, 0);
            this.pnl_browser.Name = "pnl_browser";
            this.pnl_browser.Size = new System.Drawing.Size(800, 450);
            this.pnl_browser.TabIndex = 3;
            // 
            // Ligue1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_browser);
            this.Controls.Add(this.lbl_ligue1);
            this.Controls.Add(this.btn_back_lig1);
            this.Name = "Ligue1";
            this.Text = "anel";
            this.Load += new System.EventHandler(this.Ligue1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_lig1;
        private System.Windows.Forms.Label lbl_ligue1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_browser;
    }
}