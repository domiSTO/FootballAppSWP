
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
            this.btn_back_ll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teamname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liganr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gegentore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spiele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_laliga = new System.Windows.Forms.Label();
            this.flp_LaLiga = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(768, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(20, 23);
            this.dataGridView1.TabIndex = 2;
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
            // flp_LaLiga
            // 
            this.flp_LaLiga.Location = new System.Drawing.Point(35, 41);
            this.flp_LaLiga.Name = "flp_LaLiga";
            this.flp_LaLiga.Size = new System.Drawing.Size(701, 368);
            this.flp_LaLiga.TabIndex = 5;
            // 
            // LaLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flp_LaLiga);
            this.Controls.Add(this.lbl_laliga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back_ll);
            this.Name = "LaLiga";
            this.Text = "LaLiga";
            this.Load += new System.EventHandler(this.LaLiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_ll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teamname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liganr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gegentore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spiele;
        private System.Windows.Forms.Label lbl_laliga;
        private System.Windows.Forms.FlowLayoutPanel flp_LaLiga;
    }
}