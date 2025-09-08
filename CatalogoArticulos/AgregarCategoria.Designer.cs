namespace CatalogoArticulos
{
    partial class frmAgregarCategoria
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
            this.tbxNuevaCategoria = new System.Windows.Forms.TextBox();
            this.lblNuevaCategoria = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarAgregarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNuevaCategoria
            // 
            this.tbxNuevaCategoria.Location = new System.Drawing.Point(135, 46);
            this.tbxNuevaCategoria.Name = "tbxNuevaCategoria";
            this.tbxNuevaCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbxNuevaCategoria.TabIndex = 0;
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Location = new System.Drawing.Point(37, 46);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(95, 13);
            this.lblNuevaCategoria.TabIndex = 1;
            this.lblNuevaCategoria.Text = "Nueva Categoría: ";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(50, 87);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnCancelarAgregarCategoria
            // 
            this.btnCancelarAgregarCategoria.Location = new System.Drawing.Point(192, 86);
            this.btnCancelarAgregarCategoria.Name = "btnCancelarAgregarCategoria";
            this.btnCancelarAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregarCategoria.TabIndex = 3;
            this.btnCancelarAgregarCategoria.Text = "Cancelar";
            this.btnCancelarAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarCategoria.Click += new System.EventHandler(this.btnCancelarAgregarCategoria_Click);
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 125);
            this.Controls.Add(this.btnCancelarAgregarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblNuevaCategoria);
            this.Controls.Add(this.tbxNuevaCategoria);
            this.Name = "frmAgregarCategoria";
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNuevaCategoria;
        private System.Windows.Forms.Label lblNuevaCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarAgregarCategoria;
    }
}