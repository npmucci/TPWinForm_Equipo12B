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

        private int indiceImagenActual = 0;
        private List<Imagen> imagenesArticuloActual = new List<Imagen>();

        public CatalogoArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargarDatos();

        }

        private void cargarDatos()
        {
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
                pbxArticulo.Load(url);
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
            if (agregarArticulo.ArticuloAgregado)
            {
                cargarDatos();
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null) // Verifica que haya una fila seleccionada
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // Guardamos el articulo seleccionado

                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)   // El articulo tiene imagenes?
                {
                    imagenesArticuloActual = seleccionado.Imagenes;   // Guardamos la lista completa de imagenes del articulo

                    indiceImagenActual = 0;   // Reseteamos al primer índice

                    cargarImagen(imagenesArticuloActual[indiceImagenActual].Url);  // Cargamos la primer imagen
                }
                else
                {

                    imagenesArticuloActual.Clear(); // Si no tiene imagenes, limpiamos la lista y mostramos una imagen por defecto
                    indiceImagenActual = 0;
                    cargarImagen("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
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
                    cargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un artículo primero.");
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (imagenesArticuloActual.Count == 0) return; // Verifica si hay imagenes cargadas, si no hay, retorna (no hace nada)

            indiceImagenActual--;  // Baja el indice para ir a la imagen anterior

            if (indiceImagenActual < 0)
                indiceImagenActual = imagenesArticuloActual.Count - 1; // Si el indice es menor a 0 (es la primera imagen) vuelve al final, o sea hace efecto circular

            cargarImagen(imagenesArticuloActual[indiceImagenActual].Url); // Carga la imagen en el PictureBox con el indice actualizado
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (imagenesArticuloActual.Count == 0) return;

            indiceImagenActual++;

            if (indiceImagenActual >= imagenesArticuloActual.Count)
                indiceImagenActual = 0; // vuelve al inicio

            cargarImagen(imagenesArticuloActual[indiceImagenActual].Url);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregarArticulo modificarArticulo = new frmAgregarArticulo(seleccionado);
                modificarArticulo.ShowDialog();
                if (modificarArticulo.ArticuloAgregado)
                {
                    cargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un artículo primero.");

            }
        }

      
    }
}
