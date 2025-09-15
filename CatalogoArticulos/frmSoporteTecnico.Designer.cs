namespace CatalogoArticulos
{
    partial class frmSoporteTecnico
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
            this.pnlSoporte = new System.Windows.Forms.Panel();
            this.lbltituloSt = new System.Windows.Forms.Label();
            this.dgvSoporte = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSoporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoporte)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSoporte
            // 
            this.pnlSoporte.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSoporte.Controls.Add(this.lbltituloSt);
            this.pnlSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSoporte.Location = new System.Drawing.Point(0, 0);
            this.pnlSoporte.Name = "pnlSoporte";
            this.pnlSoporte.Size = new System.Drawing.Size(536, 42);
            this.pnlSoporte.TabIndex = 23;
            // 
            // lbltituloSt
            // 
            this.lbltituloSt.AutoSize = true;
            this.lbltituloSt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloSt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltituloSt.Location = new System.Drawing.Point(3, 6);
            this.lbltituloSt.Name = "lbltituloSt";
            this.lbltituloSt.Size = new System.Drawing.Size(171, 30);
            this.lbltituloSt.TabIndex = 0;
            this.lbltituloSt.Text = "Soporte Técnico";
            // 
            // dgvSoporte
            // 
            this.dgvSoporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Mail});
            this.dgvSoporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSoporte.Location = new System.Drawing.Point(30, 48);
            this.dgvSoporte.MultiSelect = false;
            this.dgvSoporte.Name = "dgvSoporte";
            this.dgvSoporte.ReadOnly = true;
            this.dgvSoporte.Size = new System.Drawing.Size(475, 191);
            this.dgvSoporte.TabIndex = 24;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 35F;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.FillWeight = 65F;
            this.Mail.HeaderText = "MAIL";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // frmSoporteTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 287);
            this.Controls.Add(this.dgvSoporte);
            this.Controls.Add(this.pnlSoporte);
            this.Name = "frmSoporteTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte Técnico";
            this.Load += new System.EventHandler(this.frmSoporteTecnico_Load);
            this.pnlSoporte.ResumeLayout(false);
            this.pnlSoporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSoporte;
        private System.Windows.Forms.Label lbltituloSt;
        private System.Windows.Forms.DataGridView dgvSoporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    }
}