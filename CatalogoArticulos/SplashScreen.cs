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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Centra el PictureBox en el formulario
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2;

            timer1.Interval = 3000;
            timer1.Start(); // Inicia el timer al cargar la ventana de presentación
        
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();    // Detiene el timer para que no se repita
            this.Close();     // Cierra la ventana de presentación (SplashScreen)
        }

       
    }
}
