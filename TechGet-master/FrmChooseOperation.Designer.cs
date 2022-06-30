namespace TechGet
{
    partial class FrmChooseOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChooseOperation));
            this.cboOdaberiNabavu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAzurirajNabavu = new System.Windows.Forms.DataGridView();
            this.txtOpisPredmetaAzuriranje = new System.Windows.Forms.TextBox();
            this.txtNazivProjektaAzuriranje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUrediNabavu = new System.Windows.Forms.Button();
            this.btnObrisiNabavu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAzurirajNabavu)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOdaberiNabavu
            // 
            this.cboOdaberiNabavu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.cboOdaberiNabavu.FormattingEnabled = true;
            this.cboOdaberiNabavu.Location = new System.Drawing.Point(134, 12);
            this.cboOdaberiNabavu.Name = "cboOdaberiNabavu";
            this.cboOdaberiNabavu.Size = new System.Drawing.Size(191, 21);
            this.cboOdaberiNabavu.TabIndex = 0;
            this.cboOdaberiNabavu.SelectedIndexChanged += new System.EventHandler(this.cboOdaberiNabavu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ODABERI NABAVU";
            // 
            // dgvAzurirajNabavu
            // 
            this.dgvAzurirajNabavu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.dgvAzurirajNabavu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAzurirajNabavu.Location = new System.Drawing.Point(1, 66);
            this.dgvAzurirajNabavu.Name = "dgvAzurirajNabavu";
            this.dgvAzurirajNabavu.Size = new System.Drawing.Size(1414, 106);
            this.dgvAzurirajNabavu.TabIndex = 2;
            // 
            // txtOpisPredmetaAzuriranje
            // 
            this.txtOpisPredmetaAzuriranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.txtOpisPredmetaAzuriranje.Location = new System.Drawing.Point(15, 278);
            this.txtOpisPredmetaAzuriranje.Multiline = true;
            this.txtOpisPredmetaAzuriranje.Name = "txtOpisPredmetaAzuriranje";
            this.txtOpisPredmetaAzuriranje.Size = new System.Drawing.Size(248, 206);
            this.txtOpisPredmetaAzuriranje.TabIndex = 3;
            this.txtOpisPredmetaAzuriranje.TextChanged += new System.EventHandler(this.txtIdAzuriranje_TextChanged);
            // 
            // txtNazivProjektaAzuriranje
            // 
            this.txtNazivProjektaAzuriranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.txtNazivProjektaAzuriranje.Location = new System.Drawing.Point(290, 278);
            this.txtNazivProjektaAzuriranje.Multiline = true;
            this.txtNazivProjektaAzuriranje.Name = "txtNazivProjektaAzuriranje";
            this.txtNazivProjektaAzuriranje.Size = new System.Drawing.Size(167, 86);
            this.txtNazivProjektaAzuriranje.TabIndex = 4;
            this.txtNazivProjektaAzuriranje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opis predmeta nabave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Naziv projekta";
            // 
            // btnUrediNabavu
            // 
            this.btnUrediNabavu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnUrediNabavu.ForeColor = System.Drawing.Color.White;
            this.btnUrediNabavu.Location = new System.Drawing.Point(845, 278);
            this.btnUrediNabavu.Name = "btnUrediNabavu";
            this.btnUrediNabavu.Size = new System.Drawing.Size(167, 67);
            this.btnUrediNabavu.TabIndex = 9;
            this.btnUrediNabavu.Text = "UREDI NABAVU";
            this.btnUrediNabavu.UseVisualStyleBackColor = false;
            this.btnUrediNabavu.Click += new System.EventHandler(this.btnUrediNabavu_Click);
            // 
            // btnObrisiNabavu
            // 
            this.btnObrisiNabavu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnObrisiNabavu.ForeColor = System.Drawing.Color.White;
            this.btnObrisiNabavu.Location = new System.Drawing.Point(1098, 278);
            this.btnObrisiNabavu.Name = "btnObrisiNabavu";
            this.btnObrisiNabavu.Size = new System.Drawing.Size(167, 67);
            this.btnObrisiNabavu.TabIndex = 10;
            this.btnObrisiNabavu.Text = "IZBRIŠI NABAVU";
            this.btnObrisiNabavu.UseVisualStyleBackColor = false;
            this.btnObrisiNabavu.Click += new System.EventHandler(this.btnObrisiNabavu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRETRAGA PREMA NAZIVU PROJEKTA";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.txtSearch.Location = new System.Drawing.Point(653, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(117, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(845, 415);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(167, 69);
            this.btnPretrazi.TabIndex = 13;
            this.btnPretrazi.Text = "PRETRAŽI PREMA NAZIVU PROJEKTA";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmChooseOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1416, 519);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnObrisiNabavu);
            this.Controls.Add(this.btnUrediNabavu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazivProjektaAzuriranje);
            this.Controls.Add(this.txtOpisPredmetaAzuriranje);
            this.Controls.Add(this.dgvAzurirajNabavu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOdaberiNabavu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChooseOperation";
            this.Text = "FrmUpdate";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAzurirajNabavu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOdaberiNabavu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAzurirajNabavu;
        private System.Windows.Forms.TextBox txtOpisPredmetaAzuriranje;
        private System.Windows.Forms.TextBox txtNazivProjektaAzuriranje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrediNabavu;
        private System.Windows.Forms.Button btnObrisiNabavu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPretrazi;
    }
}