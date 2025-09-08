using Dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoArticulos
{
    public partial class CatalogoArticulos : Form
    {

        private int indiceImagenActual;

        public CatalogoArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargarDatos();

        }

        private void cargarDatos() {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                dgvArticulos.DataSource = negocio.Listar();
                dgvArticulos.Columns["ID"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      
private void cargarImagen(string url)
        {
         
            try
            {
                pbxArticulo.LoadAsync(url); // Carga en segundo plano
            }
            catch
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

         
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            /*Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            

            cargarImagen(seleccionado.Imagenes[0].Url.ToString());*/
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                {
                    cargarImagen(seleccionado.Imagenes[0].Url);
                }
                else
                {
                    // Si no hay imágenes, mostramos una por defecto
                    cargarImagen("https://via.placeholder.com/300x300?text=Sin+Imagen");
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show(
                    $"¿Seguro que desea eliminar el artículo '{seleccionado.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.Eliminar(seleccionado.Id);

                    // Refrescar grilla
                    dgvArticulos.DataSource = negocio.Listar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un artículo primero.");
            }
        }
    }

}
