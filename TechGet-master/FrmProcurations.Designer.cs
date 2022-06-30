namespace TechGet
{
    partial class FrmProcurations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcurations));
            this.dgvProcurations = new System.Windows.Forms.DataGridView();
            this.btnGotoInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcurations
            // 
            this.dgvProcurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurations.Location = new System.Drawing.Point(2, 1);
            this.dgvProcurations.Name = "dgvProcurations";
            this.dgvProcurations.Size = new System.Drawing.Size(1823, 317);
            this.dgvProcurations.TabIndex = 0;
            this.dgvProcurations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcurations_CellContentClick);
            // 
            // btnGotoInput
            // 
            this.btnGotoInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnGotoInput.ForeColor = System.Drawing.Color.White;
            this.btnGotoInput.Location = new System.Drawing.Point(612, 453);
            this.btnGotoInput.Name = "btnGotoInput";
            this.btnGotoInput.Size = new System.Drawing.Size(190, 87);
            this.btnGotoInput.TabIndex = 1;
            this.btnGotoInput.Text = "VRATI SE NA UNOS NABAVA";
            this.btnGotoInput.UseVisualStyleBackColor = false;
            this.btnGotoInput.Click += new System.EventHandler(this.btnGotoInput_Click);
            // 
            // FrmProcurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1604, 674);
            this.Controls.Add(this.btnGotoInput);
            this.Controls.Add(this.dgvProcurations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProcurations";
            this.Text = "Prikaz nabava";
            this.Load += new System.EventHandler(this.FrmProcurations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcurations;
        private System.Windows.Forms.Button btnGotoInput;
    }
}