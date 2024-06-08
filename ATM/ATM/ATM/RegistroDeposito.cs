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
    public partial class RegistroDeposito : Form
    {
        public RegistroDeposito()
        {
            InitializeComponent();
        }

        private void RegistroDeposito_Load(object sender, EventArgs e)
        {
            montoadepositar.Text = Session.depositoarealizar.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new Deposito();
            formulario.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new ConfirmacionDeposito();
            formulario.Show();
            Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
