namespace CatalogoArticulos
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.pnlCategoria = new System.Windows.Forms.Panel();
            this.lbltituloCategoria = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.pnlBotonesCategoria = new System.Windows.Forms.Panel();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.pnlCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.pnlBotonesCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoria
            // 
            this.pnlCategoria.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlCategoria.Controls.Add(this.lbltituloCategoria);
            this.pnlCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlCategoria.Name = "pnlCategoria";
            this.pnlCategoria.Size = new System.Drawing.Size(410, 42);
            this.pnlCategoria.TabIndex = 24;
            // 
            // lbltituloCategoria
            // 
            this.lbltituloCategoria.AutoSize = true;
            this.lbltituloCategoria.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltituloCategoria.Location = new System.Drawing.Point(3, 6);
            this.lbltituloCategoria.Name = "lbltituloCategoria";
            this.lbltituloCategoria.Size = new System.Drawing.Size(107, 30);
            this.lbltituloCategoria.TabIndex = 0;
            this.lbltituloCategoria.Text = "Categoria";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.Location = new System.Drawing.Point(12, 78);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.Size = new System.Drawing.Size(358, 168);
            this.dgvCategoria.TabIndex = 25;
            // 
            // pnlBotonesCategoria
            // 
            this.pnlBotonesCategoria.Controls.Add(this.btnEliminarCategoria);
            this.pnlBotonesCategoria.Controls.Add(this.btnAgregarCategoria);
            this.pnlBotonesCategoria.Location = new System.Drawing.Point(52, 280);
            this.pnlBotonesCategoria.Name = "pnlBotonesCategoria";
            this.pnlBotonesCategoria.Size = new System.Drawing.Size(318, 49);
            this.pnlBotonesCategoria.TabIndex = 26;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Image = global::CatalogoArticulos.Properties.Resources.close;
            this.btnEliminarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(160, 3);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(121, 37);
            this.btnEliminarCategoria.TabIndex = 1;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Image = global::CatalogoArticulos.Properties.Resources.plus;
            this.btnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(121, 37);
            this.btnAgregarCategoria.TabIndex = 0;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 351);
            this.Controls.Add(this.pnlBotonesCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.pnlCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.pnlCategoria.ResumeLayout(false);
            this.pnlCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.pnlBotonesCategoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoria;
        private System.Windows.Forms.Label lbltituloCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Panel pnlBotonesCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
    }
}