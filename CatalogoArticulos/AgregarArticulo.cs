using Dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace CatalogoArticulos
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        //sobrecarga del constructor para modificar
        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
            lbltitulo.Text = "Modificar Artículo";
            btnAceptar.Text = "Modificar";

        }

        public void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                cbxMarca.DataSource = marcaNegocio.Listar();
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.ValueMember = "Id";
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                cbxCategoria.DataSource = categoriaNegocio.Listar();
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "Id";
                ptbImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxdAOY_-vITFVI-ej84s2U_ErxhOly-z3y_Q&s");
               
                if(articulo != null)
                {
                    txbCodigo.Text = articulo.Codigo;
                    txbNombre.Text = articulo.Nombre;
                    txbDescrip.Text = articulo.Descripcion;
                    txbPrecio.Text = articulo.Precio.ToString();
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    imagenes = new List<Imagen>(articulo.Imagenes);
                    foreach (var img in imagenes)
                    {
                        lbxListaImagenes.Items.Add(img);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private List<Imagen> imagenes = new List<Imagen>();
        public bool ArticuloAgregado { get; private set; } = false;

        private void btnAgregarURL_Click(object sender, EventArgs e)
        {
            string url = txbURLImagen.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {

                Imagen nuevaImagen = new Imagen { Url = url };
                imagenes.Add(nuevaImagen);
                lbxListaImagenes.Items.Add(nuevaImagen);
                txbURLImagen.Clear();
            }
        }

        private void btnQuitarURL_Click(object sender, EventArgs e)
        {
            if (lbxListaImagenes.SelectedItem != null)
            {

                Imagen imagenSeleccionada = (Imagen)lbxListaImagenes.SelectedItem;
                imagenes.Remove(imagenSeleccionada);
                lbxListaImagenes.Items.Remove(imagenSeleccionada);
            }
        }

        private void lbxListaImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxListaImagenes.SelectedItem != null)
                    ptbImagen.Load(lbxListaImagenes.SelectedItem.ToString());
                else
                    ptbImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxdAOY_-vITFVI-ej84s2U_ErxhOly-z3y_Q&s");

            }
            catch (Exception ex)
            {
                ptbImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxdAOY_-vITFVI-ej84s2U_ErxhOly-z3y_Q&s");
            }
        }

        private bool SoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c) && c != '.' && c != ',')
                    return false;
            }
            return true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbCodigo.Text) || !esCodigoValido(txbCodigo.Text))
            {
                MessageBox.Show("El campo 'Código' debe ser un número válido.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txbDescrip.Text))
            {
                MessageBox.Show("El campo 'Descripción' no puede estar vacío.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txbPrecio.Text) || !SoloNumeros(txbPrecio.Text))
            {
                MessageBox.Show("El campo 'Precio' debe ser un número válido.");
                return false;
            }
            else if (cbxMarca.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una Marca.");
                return false;
            }
            else if (cbxCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una Categoría.");
                return false;
            }

            return true;
        }
        private bool esCodigoValido(string codigo)
        {
            foreach (char c in codigo)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                // Si articulo es null, significa que estamos creando uno nuevo
                if (articulo == null)
                    articulo = new Articulo();

                
                articulo.Codigo = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescrip.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Imagenes = new List<Imagen>(imagenes);

                if (articulo.Id != 0) // Si tiene un ID válido, es modificación
                {
                    negocio.Modificar(articulo); 
                    imagenNegocio.ModificarImagenes(articulo.Imagenes, articulo.Id);
                    MessageBox.Show("Artículo modificado con éxito.");
                }
                else // Alta de nuevo artículo
                {
                    int idGenerado = negocio.AgregarArticulo(articulo);
                    imagenNegocio.AgregarImagenes(articulo.Imagenes, idGenerado);
                    MessageBox.Show("Artículo agregado con éxito.");
                }

                ArticuloAgregado = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }



        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();

            if (agregarMarca.SeAgrego)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                cbxMarca.DataSource = marcaNegocio.Listar();
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.ValueMember = "Id";
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria agregarCategoria = new frmAgregarCategoria();
            agregarCategoria.ShowDialog();

            if (agregarCategoria.SeAgrego)
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                cbxCategoria.DataSource = negocio.Listar();
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "Id";
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}