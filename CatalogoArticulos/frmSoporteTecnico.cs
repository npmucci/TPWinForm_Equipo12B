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
    public partial class frmSoporteTecnico : Form
    {
        public frmSoporteTecnico()
        {
            InitializeComponent();
        }

        private void frmSoporteTecnico_Load(object sender, EventArgs e)
        {
            dgvSoporte.Rows.Add("Lucas Berlingeri", "lucas.berlingeri@alumnos.frgp.utn.edu.ar");
            dgvSoporte.Rows.Add("Mateo Maciel", "mateo.maciel@alumnos.frgp.utn.edu.ar");
            dgvSoporte.Rows.Add("Natalia Mucci", "natalia.mucci@alumnos.frgp.utn.edu.ar");
        }
    }
}
