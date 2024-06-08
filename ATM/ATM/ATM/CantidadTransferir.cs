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
    public partial class CantidadTransferir : Form
    {
        public CantidadTransferir()
        {
            InitializeComponent();
        }

        private void hazlo_Click(object sender, EventArgs e)
        {
            int saldo = Session.estadobancario;

            if (montotransferir.Text != "" )
            {
                int variable = Convert.ToInt32(montotransferir.Text);
                if (saldo < variable)
                {
                    mensaje.Text = "Saldo Insuficiente";
                    Error.Visible=true;
                }
                else
                {
                    if ( 0 < variable && variable < 3500)
                    {
                        Session.montotransferir = Convert.ToInt32(montotransferir.Text);
                        Form formulario = new DatosDeCuentaATransf();
                        formulario.Show();
                        Close();
                    }
                    else
                    {
                        mensaje.Text = "Ingrese un monto entre 1 y 3500";
                        Error.Visible= true;
                        btnsalir.Enabled=false;
                        hazlo.Enabled=false;
                    }
                }
            }
            else
            {
                mensaje.Text = "Ingrese una cantidad";
                Error.Visible = true;
                btnsalir.Enabled = false;
                hazlo.Enabled = false;
            }

        }

        private void CantidadTransferir_Load(object sender, EventArgs e)
        {
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new Transferencia();
            formulario.Show();
            Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            montotransferir.Text = montotransferir.Text + "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            montotransferir.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Error.Visible= false;
            btnsalir.Enabled = true;
            hazlo.Enabled = true;
        }
    }
}
