
namespace FootballApp
{
    partial class SerieA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerieA));
            this.btn_back_serA = new System.Windows.Forms.Button();
            this.lbl_seriea = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_back_serA
            // 
            this.btn_back_serA.Location = new System.Drawing.Point(713, 415);
            this.btn_back_serA.Name = "btn_back_serA";
            this.btn_back_serA.Size = new System.Drawing.Size(75, 23);
            this.btn_back_serA.TabIndex = 0;
            this.btn_back_serA.Text = "zurück";
            this.btn_back_serA.UseVisualStyleBackColor = true;
            this.btn_back_serA.Click += new System.EventHandler(this.btn_back_serA_Click);
            // 
            // lbl_seriea
            // 
            this.lbl_seriea.AutoSize = true;
            this.lbl_seriea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seriea.Location = new System.Drawing.Point(362, 6);
            this.lbl_seriea.Name = "lbl_seriea";
            this.lbl_seriea.Size = new System.Drawing.Size(79, 24);
            this.lbl_seriea.TabIndex = 3;
            this.lbl_seriea.Text = "Serie A";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Milan.png");
            // 
            // SerieA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_seriea);
            this.Controls.Add(this.btn_back_serA);
            this.Name = "SerieA";
            this.Text = "SerieA";
            this.Load += new System.EventHandler(this.SerieA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_serA;
        private System.Windows.Forms.Label lbl_seriea;
        private System.Windows.Forms.ImageList imageList1;
    }
}