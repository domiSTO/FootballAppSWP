﻿
namespace FootballApp
{
    partial class LaLiga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaLiga));
            this.btn_back_ll = new System.Windows.Forms.Button();
            this.lbl_laliga = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_back_ll
            // 
            this.btn_back_ll.Location = new System.Drawing.Point(713, 415);
            this.btn_back_ll.Name = "btn_back_ll";
            this.btn_back_ll.Size = new System.Drawing.Size(75, 23);
            this.btn_back_ll.TabIndex = 0;
            this.btn_back_ll.Text = "Zurück";
            this.btn_back_ll.UseVisualStyleBackColor = true;
            this.btn_back_ll.Click += new System.EventHandler(this.btn_back_ll_Click);
            // 
            // lbl_laliga
            // 
            this.lbl_laliga.AutoSize = true;
            this.lbl_laliga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laliga.Location = new System.Drawing.Point(366, 6);
            this.lbl_laliga.Name = "lbl_laliga";
            this.lbl_laliga.Size = new System.Drawing.Size(77, 24);
            this.lbl_laliga.TabIndex = 3;
            this.lbl_laliga.Text = "La Liga";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Real.png");
            // 
            // LaLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_laliga);
            this.Controls.Add(this.btn_back_ll);
            this.Name = "LaLiga";
            this.Text = "LaLiga";
            this.Load += new System.EventHandler(this.LaLiga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_ll;
        private System.Windows.Forms.Label lbl_laliga;
        private System.Windows.Forms.ImageList imageList1;
    }
}