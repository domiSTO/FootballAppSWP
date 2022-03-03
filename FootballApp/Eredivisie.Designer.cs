
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
            this.btn_back_er = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teamname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liganr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gegentore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spiele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_eredevise = new System.Windows.Forms.Label();
            this.flp_Eredivisie = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(760, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(17, 18);
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
            // flp_Eredivisie
            // 
            this.flp_Eredivisie.Location = new System.Drawing.Point(30, 41);
            this.flp_Eredivisie.Name = "flp_Eredivisie";
            this.flp_Eredivisie.Size = new System.Drawing.Size(701, 368);
            this.flp_Eredivisie.TabIndex = 5;
            // 
            // Eredivisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flp_Eredivisie);
            this.Controls.Add(this.lbl_eredevise);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back_er);
            this.Name = "Eredivisie";
            this.Text = "Eredivisie";
            this.Load += new System.EventHandler(this.Eredivisie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_er;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teamname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liganr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gegentore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spiele;
        private System.Windows.Forms.Label lbl_eredevise;
        private System.Windows.Forms.FlowLayoutPanel flp_Eredivisie;
    }
}