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
    public partial class RecomendacionesDeposito : Form
    {
        public RecomendacionesDeposito()
        {
            InitializeComponent();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Form formulario = new Deposito();
            formulario.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new ElegirCuentaDeposito();
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
