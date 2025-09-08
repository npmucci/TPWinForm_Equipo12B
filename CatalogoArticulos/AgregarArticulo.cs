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
        
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

       

        private List<Imagen> imagenes = new List<Imagen>();

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

       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            nuevo.Codigo = txbCodigo.Text;
            nuevo.Nombre = txbNombre.Text;
            nuevo.Descripcion = txbDescrip.Text;
            nuevo.Precio = decimal.Parse(txbPrecio.Text);
            nuevo.Marca = (Marca)cbxMarca.SelectedItem;
            nuevo.Categoria = (Categoria)cbxCategoria.SelectedItem;
            nuevo.Imagenes = new List<Imagen>(imagenes);

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                // 1. Guardar artículo
                int idGenerado = negocio.AgregarArticulo(nuevo);

                // 2. Guardar imágenes con ese id
                negocio.AgregarImagenes(nuevo.Imagenes, idGenerado);

                MessageBox.Show("Artículo guardado con éxito junto a sus imágenes.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarca.DataSource = marcaNegocio.Listar();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = categoriaNegocio.Listar();

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
    }
}
