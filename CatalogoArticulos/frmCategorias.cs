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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategoria.DataSource = categoriaNegocio.Listar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria agregarCategoria = new frmAgregarCategoria();
            agregarCategoria.ShowDialog();
            if (agregarCategoria.SeAgrego)
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                dgvCategoria.DataSource = categoriaNegocio.Listar();
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que desea eliminar la categoría '{seleccionado.Descripcion}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        categoriaNegocio.EliminarCategoria(seleccionado.Id);
                        MessageBox.Show("Categoría eliminada con éxito");
                        dgvCategoria.DataSource = categoriaNegocio.Listar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                    }
                }
            }
        }
    }
}
