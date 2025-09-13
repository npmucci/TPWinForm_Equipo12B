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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }
        private void frmMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            dgvMarca.DataSource = marcaNegocio.Listar();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarcaForm = new frmAgregarMarca();
            agregarMarcaForm.ShowDialog();
            if (agregarMarcaForm.SeAgrego)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                dgvMarca.DataSource = marcaNegocio.Listar();
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
          if (dgvMarca.CurrentRow != null)
            {
                Marca seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
               
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que desea eliminar el artículo '{seleccionado.Descripcion}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
    );
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        marcaNegocio.EliminarMarca(seleccionado.Id);
                        MessageBox.Show("Marca eliminada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvMarca.DataSource = marcaNegocio.Listar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la marca: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una marca para eliminar.", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
