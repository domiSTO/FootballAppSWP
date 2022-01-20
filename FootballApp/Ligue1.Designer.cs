
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ligue1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teamname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liganr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gegentore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spiele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Teamname,
            this.Liganr,
            this.Tore,
            this.Gegentore,
            this.Spiele});
            this.dataGridView1.Location = new System.Drawing.Point(162, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 384);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbl_ligue1
            // 
            this.lbl_ligue1.AutoSize = true;
            this.lbl_ligue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ligue1.Location = new System.Drawing.Point(345, 13);
            this.lbl_ligue1.Name = "lbl_ligue1";
            this.lbl_ligue1.Size = new System.Drawing.Size(79, 24);
            this.lbl_ligue1.TabIndex = 2;
            this.lbl_ligue1.Text = "Ligue 1";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Teamname
            // 
            this.Teamname.DataPropertyName = "teamname";
            this.Teamname.HeaderText = "Team";
            this.Teamname.Name = "Teamname";
            // 
            // Liganr
            // 
            this.Liganr.DataPropertyName = "liganr";
            this.Liganr.HeaderText = "Liga";
            this.Liganr.Name = "Liganr";
            this.Liganr.Visible = false;
            // 
            // Tore
            // 
            this.Tore.DataPropertyName = "tore";
            this.Tore.HeaderText = "Tore";
            this.Tore.Name = "Tore";
            // 
            // Gegentore
            // 
            this.Gegentore.DataPropertyName = "gegentore";
            this.Gegentore.HeaderText = "Gegentore";
            this.Gegentore.Name = "Gegentore";
            // 
            // Spiele
            // 
            this.Spiele.DataPropertyName = "spiele";
            this.Spiele.HeaderText = "Spiele";
            this.Spiele.Name = "Spiele";
            // 
            // Ligue1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ligue1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back_lig1);
            this.Name = "Ligue1";
            this.Text = "Ligue1";
            this.Load += new System.EventHandler(this.Ligue1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_lig1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ligue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teamname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liganr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gegentore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spiele;
    }
}