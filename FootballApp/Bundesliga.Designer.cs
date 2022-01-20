
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teamname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liganr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gegentore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spiele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(129, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 384);
            this.dataGridView1.TabIndex = 12;
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
            // Bundesliga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Name = "Bundesliga";
            this.Text = "Bundesliga";
            this.Load += new System.EventHandler(this.Bundesliga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teamname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liganr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gegentore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spiele;
    }
}