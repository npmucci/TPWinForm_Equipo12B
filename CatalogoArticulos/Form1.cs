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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
        }
    }
    
}
