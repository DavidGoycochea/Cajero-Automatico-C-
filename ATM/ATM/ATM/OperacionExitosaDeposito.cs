using ATM.Clases;
using MySql.Data.MySqlClient;
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
    public partial class OperacionExitosaDeposito : Form
    {
        public OperacionExitosaDeposito()
        {
            InitializeComponent();
        }

        private void OperacionExitosaDeposito_Load(object sender, EventArgs e)
        {
            montoadepositar.Text = Session.depositoarealizar.ToString();
            cuentadestino.Text = Session.cuenta_destino.ToString();
            nombrebeneficiario.Text = Session.p_nombre.ToString() + " " + Session.a_patt.ToString();
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
    }
}
