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
    public partial class segundavalidacion : Form
    {
        public segundavalidacion()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            codigovali.Text = codigovali.Text + "0";
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (Session.validacion.ToString() == codigovali.Text)
            {
                Form formulario = new MenuPrincipal();
                formulario.Show();
                Close();
            }
            else
            {
                codigovali.Text = "Codigo Incorrecto";
            }
        }

        private void celularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Celular_segundavali();
            formulario.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            codigovali.Text = "";
        }

        private void cambioDeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new ValidateDNI();
            formulario.Show();
            Close();
        }

        private void segundavalidacion_Load(object sender, EventArgs e)
        {

        }
    }
}
