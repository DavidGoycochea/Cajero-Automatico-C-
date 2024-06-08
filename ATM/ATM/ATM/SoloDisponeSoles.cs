using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class SoloDisponeSoles : Form
    {
        public SoloDisponeSoles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Retiro();
            formulario.Show();
            Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();  
            Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void SoloDisponeSoles_Load(object sender, EventArgs e)
        {

        }
    }
}
