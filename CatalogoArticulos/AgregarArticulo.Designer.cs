namespace CatalogoArticulos
{
    partial class frmAgregarArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescrip = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbURLImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarURL = new System.Windows.Forms.Button();
            this.lbxListaImagenes = new System.Windows.Forms.ListBox();
            this.btnQuitarURL = new System.Windows.Forms.Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(67, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(67, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(67, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(67, 183);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(67, 240);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(67, 300);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Location = new System.Drawing.Point(67, 359);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(58, 13);
            this.lblImagenes.TabIndex = 6;
            this.lblImagenes.Text = "Url Imagen";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(154, 28);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 20);
            this.txbCodigo.TabIndex = 7;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(154, 77);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 8;
            // 
            // txbDescrip
            // 
            this.txbDescrip.Location = new System.Drawing.Point(154, 129);
            this.txbDescrip.Name = "txbDescrip";
            this.txbDescrip.Size = new System.Drawing.Size(100, 20);
            this.txbDescrip.TabIndex = 9;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(154, 183);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 10;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(154, 240);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 11;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(154, 300);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txbPrecio.TabIndex = 12;
            // 
            // txbURLImagen
            // 
            this.txbURLImagen.Location = new System.Drawing.Point(154, 359);
            this.txbURLImagen.Name = "txbURLImagen";
            this.txbURLImagen.Size = new System.Drawing.Size(100, 20);
            this.txbURLImagen.TabIndex = 13;
            // 
            // btnAgregarURL
            // 
            this.btnAgregarURL.Location = new System.Drawing.Point(293, 359);
            this.btnAgregarURL.Name = "btnAgregarURL";
            this.btnAgregarURL.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarURL.TabIndex = 14;
            this.btnAgregarURL.Text = "+ Agregar URL";
            this.btnAgregarURL.UseVisualStyleBackColor = true;
            this.btnAgregarURL.Click += new System.EventHandler(this.btnAgregarURL_Click);
            // 
            // lbxListaImagenes
            // 
            this.lbxListaImagenes.FormattingEnabled = true;
            this.lbxListaImagenes.Location = new System.Drawing.Point(154, 395);
            this.lbxListaImagenes.Name = "lbxListaImagenes";
            this.lbxListaImagenes.Size = new System.Drawing.Size(120, 43);
            this.lbxListaImagenes.TabIndex = 15;
            this.lbxListaImagenes.SelectedIndexChanged += new System.EventHandler(this.lbxListaImagenes_SelectedIndexChanged);
            // 
            // btnQuitarURL
            // 
            this.btnQuitarURL.Location = new System.Drawing.Point(293, 395);
            this.btnQuitarURL.Name = "btnQuitarURL";
            this.btnQuitarURL.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarURL.TabIndex = 16;
            this.btnQuitarURL.Text = "- Quitar URL";
            this.btnQuitarURL.UseVisualStyleBackColor = true;
            this.btnQuitarURL.Click += new System.EventHandler(this.btnQuitarURL_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(443, 334);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(199, 166);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImagen.TabIndex = 17;
            this.ptbImagen.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(70, 477);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(281, 181);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(119, 23);
            this.btnAgregarMarca.TabIndex = 20;
            this.btnAgregarMarca.Text = "+ Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(281, 240);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarCategoria.TabIndex = 21;
            this.btnAgregarCategoria.Text = "+ Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 512);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.btnQuitarURL);
            this.Controls.Add(this.lbxListaImagenes);
            this.Controls.Add(this.btnAgregarURL);
            this.Controls.Add(this.txbURLImagen);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txbDescrip);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lblImagenes);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAgregarArticulo";
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescrip;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbURLImagen;
        private System.Windows.Forms.Button btnAgregarURL;
        private System.Windows.Forms.ListBox lbxListaImagenes;
        private System.Windows.Forms.Button btnQuitarURL;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
    }
}