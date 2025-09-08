namespace CatalogoArticulos
{
    partial class frmAgregarMarca
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
            this.tbxNuevaMarca = new System.Windows.Forms.TextBox();
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnCancelarAgregarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNuevaMarca
            // 
            this.tbxNuevaMarca.Location = new System.Drawing.Point(111, 28);
            this.tbxNuevaMarca.Name = "tbxNuevaMarca";
            this.tbxNuevaMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxNuevaMarca.TabIndex = 0;
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Location = new System.Drawing.Point(27, 31);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(78, 13);
            this.lblNuevaMarca.TabIndex = 1;
            this.lblNuevaMarca.Text = "Nueva Marca: ";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(48, 66);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 2;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnCancelarAgregarMarca
            // 
            this.btnCancelarAgregarMarca.Location = new System.Drawing.Point(162, 66);
            this.btnCancelarAgregarMarca.Name = "btnCancelarAgregarMarca";
            this.btnCancelarAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregarMarca.TabIndex = 3;
            this.btnCancelarAgregarMarca.Text = "Cancelar";
            this.btnCancelarAgregarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarMarca.Click += new System.EventHandler(this.btnCancelarAgregarMarca_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 101);
            this.Controls.Add(this.btnCancelarAgregarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblNuevaMarca);
            this.Controls.Add(this.tbxNuevaMarca);
            this.Name = "frmAgregarMarca";
            this.Text = "Agregar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNuevaMarca;
        private System.Windows.Forms.Label lblNuevaMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnCancelarAgregarMarca;
    }
}