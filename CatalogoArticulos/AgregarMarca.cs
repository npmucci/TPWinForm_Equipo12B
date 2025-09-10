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
    public partial class frmAgregarMarca : Form     
    {
        public bool SeAgrego { get; private set; } = false;
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            nuevaMarca.Descripcion = tbxNuevaMarca.Text;
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                marcaNegocio.AgregarMarca(nuevaMarca);
                SeAgrego = true;
                MessageBox.Show("Marca agregada con éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Marca: " + ex.Message);
            }
        }

        private void btnCancelarAgregarMarca_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

    
    }
}
