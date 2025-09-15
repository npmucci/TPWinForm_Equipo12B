namespace CatalogoArticulos
{
    partial class frmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.lbltituloMarca = new System.Windows.Forms.Label();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.pnlBotonesMarca = new System.Windows.Forms.Panel();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.pnlMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.pnlBotonesMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMarca
            // 
            this.pnlMarca.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMarca.Controls.Add(this.lbltituloMarca);
            this.pnlMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(410, 42);
            this.pnlMarca.TabIndex = 25;
            // 
            // lbltituloMarca
            // 
            this.lbltituloMarca.AutoSize = true;
            this.lbltituloMarca.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltituloMarca.Location = new System.Drawing.Point(3, 6);
            this.lbltituloMarca.Name = "lbltituloMarca";
            this.lbltituloMarca.Size = new System.Drawing.Size(73, 30);
            this.lbltituloMarca.TabIndex = 0;
            this.lbltituloMarca.Text = "Marca";
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarca.Location = new System.Drawing.Point(26, 91);
            this.dgvMarca.MultiSelect = false;
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.Size = new System.Drawing.Size(358, 168);
            this.dgvMarca.TabIndex = 26;
            // 
            // pnlBotonesMarca
            // 
            this.pnlBotonesMarca.Controls.Add(this.btnEliminarMarca);
            this.pnlBotonesMarca.Controls.Add(this.btnAgregarMarca);
            this.pnlBotonesMarca.Location = new System.Drawing.Point(52, 290);
            this.pnlBotonesMarca.Name = "pnlBotonesMarca";
            this.pnlBotonesMarca.Size = new System.Drawing.Size(318, 49);
            this.pnlBotonesMarca.TabIndex = 27;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Image = global::CatalogoArticulos.Properties.Resources.close;
            this.btnEliminarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMarca.Location = new System.Drawing.Point(160, 3);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(121, 37);
            this.btnEliminarMarca.TabIndex = 1;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Image = global::CatalogoArticulos.Properties.Resources.plus;
            this.btnAgregarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMarca.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(121, 37);
            this.btnAgregarMarca.TabIndex = 0;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 351);
            this.Controls.Add(this.pnlBotonesMarca);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.pnlMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            this.pnlMarca.ResumeLayout(false);
            this.pnlMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.pnlBotonesMarca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.Label lbltituloMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Panel pnlBotonesMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
    }
}