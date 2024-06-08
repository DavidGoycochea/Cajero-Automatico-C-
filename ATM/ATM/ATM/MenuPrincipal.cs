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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            labeldeposito.Visible = true;
            labelestadocuenta.Visible = true;
            labelretiro.Visible = true;
            labelsalir.Visible = true;
            btnDeposito.Enabled = true;
            btnEstadoCuenta.Enabled = true;
            btnRetiro.Enabled = true;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;
            btnenter.Enabled = false;
            btnclear.Enabled = false;
            btnsalir.Enabled = true;
            
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            Form formulario = new EstadodeCuenta();
            formulario.Show();
            Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulaio = new ValidateDNI();
            formulaio.Show();
            Close();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Form formulario = new SoloDisponeSoles();
            formulario.Show();
            Close();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Form formulario = new ElegirCuentaDeposito();
            formulario.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Transferencia();
            formulario.Show();
            Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }
    }
}
