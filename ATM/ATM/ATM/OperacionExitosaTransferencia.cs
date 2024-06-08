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
    public partial class OperacionExitosaTransferencia : Form
    {
        public OperacionExitosaTransferencia()
        {
            InitializeComponent();
        }

        private void hazlo_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void OperacionExitosaTransferencia_Load(object sender, EventArgs e)
        {
            nombrebeneficiario.Text = Session.pnombre.ToString() + " " + Session.apatt.ToString() + " " + Session.amatt.ToString();
            cuentadestino.Text = Session.cuenta_transferir.ToString();
            montotrans.Text = Session.montotransferir.ToString();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }
    }
}
