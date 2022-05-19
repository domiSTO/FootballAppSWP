
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_bundesliga = new System.Windows.Forms.Label();
            this.btn_Teams_Bayern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(640, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            // btn_Teams_Bayern
            // 
            this.btn_Teams_Bayern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Teams_Bayern.Location = new System.Drawing.Point(295, 139);
            this.btn_Teams_Bayern.Name = "btn_Teams_Bayern";
            this.btn_Teams_Bayern.Size = new System.Drawing.Size(125, 99);
            this.btn_Teams_Bayern.TabIndex = 14;
            this.btn_Teams_Bayern.UseVisualStyleBackColor = true;
            this.btn_Teams_Bayern.Click += new System.EventHandler(this.btn_Teams_Bayern_Click);
            // 
            // Bundesliga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btn_Teams_Bayern);
            this.Controls.Add(this.lbl_bundesliga);
            this.Controls.Add(this.btn_back);
            this.Name = "Bundesliga";
            this.Text = "Bundesliga";
            this.Load += new System.EventHandler(this.Bundesliga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_bundesliga;
        private System.Windows.Forms.Button btn_Teams_Bayern;
    }
}