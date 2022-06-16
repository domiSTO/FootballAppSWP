
namespace FootballApp
{
    partial class Eredivisie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eredivisie));
            this.btn_back_er = new System.Windows.Forms.Button();
            this.lbl_eredevise = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_back_er
            // 
            this.btn_back_er.Location = new System.Drawing.Point(702, 415);
            this.btn_back_er.Name = "btn_back_er";
            this.btn_back_er.Size = new System.Drawing.Size(75, 23);
            this.btn_back_er.TabIndex = 0;
            this.btn_back_er.Text = "Zurück";
            this.btn_back_er.UseVisualStyleBackColor = true;
            this.btn_back_er.Click += new System.EventHandler(this.btn_back_er_Click);
            // 
            // lbl_eredevise
            // 
            this.lbl_eredevise.AutoSize = true;
            this.lbl_eredevise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eredevise.Location = new System.Drawing.Point(343, 6);
            this.lbl_eredevise.Name = "lbl_eredevise";
            this.lbl_eredevise.Size = new System.Drawing.Size(104, 24);
            this.lbl_eredevise.TabIndex = 3;
            this.lbl_eredevise.Text = "Eredevise";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ajax.png");
            // 
            // Eredivisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.lbl_eredevise);
            this.Controls.Add(this.btn_back_er);
            this.Name = "Eredivisie";
            this.Text = "Eredivisie";
            this.Load += new System.EventHandler(this.Eredivisie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_er;
        private System.Windows.Forms.Label lbl_eredevise;
        private System.Windows.Forms.ImageList imageList1;
    }
}