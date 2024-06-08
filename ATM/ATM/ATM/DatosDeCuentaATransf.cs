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
    public partial class DatosDeCuentaATransf : Form
    {
        public DatosDeCuentaATransf()
        {
            InitializeComponent();
        }

        private void DatosDeCuentaATransf_Load(object sender, EventArgs e)
        {
            nombrecuenta.Text = Session.pnombre.ToString() + " " + Session.apatt.ToString() + " " + Session.amatt.ToString();
            numerocuenta.Text = Session.cuenta_transferir.ToString();
        }

        private void hazlo_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroTransferencia();
            formulario.Show();
            Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new CantidadTransferir();
            formulario.Show();
            Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }
    }
}
