namespace CatalogoArticulos
{
    partial class CatalogoArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoArticulos));
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.cbBoxMarca = new System.Windows.Forms.ComboBox();
            this.cbBoxCategoria = new System.Windows.Forms.ComboBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gxbFiltrado = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.txbLogo = new System.Windows.Forms.TextBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.pxbLogo = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrden = new System.Windows.Forms.ComboBox();
=======
            this.lblIndiceImagen = new System.Windows.Forms.Label();
>>>>>>> 4ec2343bec9d618ec1c64956d279abc929972d83
            this.pnlBotones.SuspendLayout();
            this.gxbFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroNombre.Location = new System.Drawing.Point(69, 20);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(81, 25);
            this.lblFiltroNombre.TabIndex = 2;
            this.lblFiltroNombre.Text = "Nombre";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Location = new System.Drawing.Point(23, 43);
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(167, 20);
            this.txtBusquedaNombre.TabIndex = 3;
            this.txtBusquedaNombre.TextChanged += new System.EventHandler(this.txtBusquedaNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categoria";
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroMarca.Location = new System.Drawing.Point(481, 20);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(65, 25);
            this.lblFiltroMarca.TabIndex = 5;
            this.lblFiltroMarca.Text = "Marca";
            // 
            // cbBoxMarca
            // 
            this.cbBoxMarca.FormattingEnabled = true;
            this.cbBoxMarca.Location = new System.Drawing.Point(436, 42);
            this.cbBoxMarca.Name = "cbBoxMarca";
            this.cbBoxMarca.Size = new System.Drawing.Size(147, 21);
            this.cbBoxMarca.TabIndex = 6;
            // 
            // cbBoxCategoria
            // 
            this.cbBoxCategoria.FormattingEnabled = true;
            this.cbBoxCategoria.Location = new System.Drawing.Point(237, 42);
            this.cbBoxCategoria.Name = "cbBoxCategoria";
            this.cbBoxCategoria.Size = new System.Drawing.Size(147, 21);
            this.cbBoxCategoria.TabIndex = 7;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 414);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(575, 49);
            this.pnlBotones.TabIndex = 11;
            // 
            // btnEditar
<<<<<<< HEAD
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::CatalogoArticulos.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(413, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 37);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CatalogoArticulos.Properties.Resources.close;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(253, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 37);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::CatalogoArticulos.Properties.Resources.plus;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregar.Location = new System.Drawing.Point(89, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 37);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(276, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(335, 38);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "CATALOGO PRODUCTOS";
            // 
            // gxbFiltrado
            // 
            this.gxbFiltrado.BackColor = System.Drawing.Color.MidnightBlue;
            this.gxbFiltrado.Controls.Add(this.cboOrden);
            this.gxbFiltrado.Controls.Add(this.cbBoxMarca);
            this.gxbFiltrado.Controls.Add(this.lblFiltroNombre);
            this.gxbFiltrado.Controls.Add(this.label2);
            this.gxbFiltrado.Controls.Add(this.lblFiltroMarca);
            this.gxbFiltrado.Controls.Add(this.txtBusquedaNombre);
            this.gxbFiltrado.Controls.Add(this.cbBoxCategoria);
            this.gxbFiltrado.Controls.Add(this.label1);
            this.gxbFiltrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gxbFiltrado.Location = new System.Drawing.Point(78, 0);
            this.gxbFiltrado.Name = "gxbFiltrado";
            this.gxbFiltrado.Size = new System.Drawing.Size(831, 80);
            this.gxbFiltrado.TabIndex = 13;
            this.gxbFiltrado.TabStop = false;
            this.gxbFiltrado.Text = "FILTRADO";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 134);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 47;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(644, 262);
            this.dgvArticulos.TabIndex = 14;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(676, 396);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 16;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(813, 396);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 17;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // txbLogo
            // 
            this.txbLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.txbLogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbLogo.Location = new System.Drawing.Point(-4, 45);
            this.txbLogo.Multiline = true;
            this.txbLogo.Name = "txbLogo";
            this.txbLogo.Size = new System.Drawing.Size(82, 35);
            this.txbLogo.TabIndex = 18;
            this.txbLogo.Text = "Catalog Manager";
            this.txbLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(647, 134);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(262, 262);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 15;
            this.pbxArticulo.TabStop = false;
            // 
            // pxbLogo
            // 
            this.pxbLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pxbLogo.Image = global::CatalogoArticulos.Properties.Resources.logo;
            this.pxbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pxbLogo.InitialImage")));
            this.pxbLogo.Location = new System.Drawing.Point(0, 0);
            this.pxbLogo.Name = "pxbLogo";
            this.pxbLogo.Size = new System.Drawing.Size(88, 46);
            this.pxbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxbLogo.TabIndex = 0;
            this.pxbLogo.TabStop = false;
            // 
            // label2
=======
>>>>>>> 4ec2343bec9d618ec1c64956d279abc929972d83
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ordenar Precio";
            // 
            // cboOrden
            // 
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Location = new System.Drawing.Point(643, 42);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(147, 21);
            this.cboOrden.TabIndex = 6;
            this.cboOrden.SelectedIndexChanged += new System.EventHandler(this.cboOrden_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(276, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(388, 45);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "CATALOGO PRODUCTOS";
            // 
            // gxbFiltrado
            // 
            this.gxbFiltrado.BackColor = System.Drawing.Color.MidnightBlue;
            this.gxbFiltrado.Controls.Add(this.cbBoxMarca);
            this.gxbFiltrado.Controls.Add(this.lblFiltroNombre);
            this.gxbFiltrado.Controls.Add(this.lblFiltroMarca);
            this.gxbFiltrado.Controls.Add(this.txtBusquedaNombre);
            this.gxbFiltrado.Controls.Add(this.cbBoxCategoria);
            this.gxbFiltrado.Controls.Add(this.label1);
            this.gxbFiltrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gxbFiltrado.Location = new System.Drawing.Point(78, 0);
            this.gxbFiltrado.Name = "gxbFiltrado";
            this.gxbFiltrado.Size = new System.Drawing.Size(831, 80);
            this.gxbFiltrado.TabIndex = 13;
            this.gxbFiltrado.TabStop = false;
            this.gxbFiltrado.Text = "FILTRADO";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 134);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 47;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(644, 262);
            this.dgvArticulos.TabIndex = 14;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(676, 398);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 16;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(813, 398);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 17;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // txbLogo
            // 
            this.txbLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.txbLogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbLogo.Location = new System.Drawing.Point(-4, 45);
            this.txbLogo.Multiline = true;
            this.txbLogo.Name = "txbLogo";
            this.txbLogo.Size = new System.Drawing.Size(82, 35);
            this.txbLogo.TabIndex = 18;
            this.txbLogo.Text = "Catalog Manager";
            this.txbLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(647, 134);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(262, 237);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 15;
            this.pbxArticulo.TabStop = false;
            // 
            // pxbLogo
            // 
            this.pxbLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pxbLogo.Image = global::CatalogoArticulos.Properties.Resources.logo;
            this.pxbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pxbLogo.InitialImage")));
            this.pxbLogo.Location = new System.Drawing.Point(0, 0);
            this.pxbLogo.Name = "pxbLogo";
            this.pxbLogo.Size = new System.Drawing.Size(88, 46);
            this.pxbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxbLogo.TabIndex = 0;
            this.pxbLogo.TabStop = false;
            // 
            // lblIndiceImagen
            // 
            this.lblIndiceImagen.AutoSize = true;
            this.lblIndiceImagen.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiceImagen.Location = new System.Drawing.Point(730, 376);
            this.lblIndiceImagen.Name = "lblIndiceImagen";
            this.lblIndiceImagen.Size = new System.Drawing.Size(86, 15);
            this.lblIndiceImagen.TabIndex = 19;
            this.lblIndiceImagen.Text = "Imagen 0 de 0";
            // 
            // CatalogoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(909, 470);
            this.Controls.Add(this.lblIndiceImagen);
            this.Controls.Add(this.txbLogo);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.gxbFiltrado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pxbLogo);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBotones.ResumeLayout(false);
            this.gxbFiltrado.ResumeLayout(false);
            this.gxbFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbLogo;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.ComboBox cbBoxMarca;
        private System.Windows.Forms.ComboBox cbBoxCategoria;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gxbFiltrado;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.TextBox txbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOrden;
        private System.Windows.Forms.Label lblIndiceImagen;
    }
}

