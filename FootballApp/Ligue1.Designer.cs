
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
            this.btn_back_lig1 = new System.Windows.Forms.Button();
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
            // Ligue1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_lig1);
            this.Name = "Ligue1";
            this.Text = "Ligue1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back_lig1;
    }
}