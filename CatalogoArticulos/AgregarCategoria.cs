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
    public partial class frmAgregarCategoria : Form
    {
        public bool SeAgrego { get; private set; } = false;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        public void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria nuevaCat = new Categoria();
            nuevaCat.Descripcion = tbxNuevaCategoria.Text;
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                negocio.AgregarCategoria(nuevaCat);
                SeAgrego = true;
                MessageBox.Show("Categoría agregada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar categoría: " + ex.Message);
            }
        }

        private void btnCancelarAgregarCategoria_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
