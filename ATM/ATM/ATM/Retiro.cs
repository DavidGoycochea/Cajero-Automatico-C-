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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            numerocuenta.Text = Session.numero_cuenta.ToString();


        }

        private void hazlo_Click(object sender, EventArgs e)
        {
            int saldoo = Session.estadobancario;
            if (resta.Text == "" || Convert.ToInt32(resta.Text) == 0)
            {
                mensaje.Text="Porfavor escoja o ingrese una cantidad";
                Error.Visible= true;
                button1.Enabled= false;
                button2.Enabled= false;
                button3.Enabled= false;
                button4.Enabled= false;
                btnsalir.Enabled= false;
                hazlo.Enabled= false;
                btncancel.Enabled = false;

            }
            else
            {
                int restaa = Convert.ToInt32(resta.Text);
                if (saldoo > restaa)
                {
                    if (restaa % 20 == 0 || restaa % 50 == 0 || restaa % 100 == 0)
                    {
                        if (restaa < 3001)
                        {
                            Session.retiroarealizar = restaa;
                            Form formulario = new confirmretiro();
                            formulario.Show();
                            Close();
                        }
                        else
                        {
                            mensaje.Text = "No puede retirar mas de 3000";
                            Error.Visible = true;
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            btnsalir.Enabled = false;
                            hazlo.Enabled = false;
                            btncancel.Enabled = false;
                        }
                    }
                    else
                    {
                        mensaje.Text = "Ingrese un valor correcto";
                        Error.Visible = true;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        btnsalir.Enabled = false;
                        hazlo.Enabled = false;
                        btncancel.Enabled = false;
                    }
                }
                else
                {
                    mensaje.Text = "Saldo Insuficiente";
                    Error.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnsalir.Enabled = false;
                    hazlo.Enabled = false;
                    btncancel.Enabled = false;
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "6";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            resta.Text = resta.Text + "9";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saldoo = Session.estadobancario;
            int restaa = 20;

            if (saldoo > restaa)
            {
                Session.retiroarealizar = restaa;
                Form formulario = new confirmretiro();
                formulario.Show();
                Close();
            }
            else
            {
                mensaje.Text = "Ingrese un valor correcto";
                Error.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnsalir.Enabled = false;
                hazlo.Enabled = false;
                btncancel.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int saldoo = Session.estadobancario;
            int restaa = 50;
            int operacion;

            if (saldoo > restaa)
            {
                Session.retiroarealizar = restaa;
                Form formulario = new confirmretiro();
                formulario.Show();
                Close();
            }
            else
            {
                mensaje.Text = "Ingrese un valor correcto";
                Error.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnsalir.Enabled = false;
                hazlo.Enabled = false;
                btncancel.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int saldoo = Session.estadobancario;
            int restaa = 100;

            if (saldoo > restaa)
            {
                Session.retiroarealizar = restaa;
                Form formulario = new confirmretiro();
                formulario.Show();
                Close();
            }
            else
            {
                mensaje.Text = "Ingrese un valor correcto";
                Error.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnsalir.Enabled = false;
                hazlo.Enabled = false;
                btncancel.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saldodisponible.Text == "******")
            {
                saldodisponible.Text = Session.estadobancario.ToString();
                mostrar.Text = "Ocultar Saldo";
            }
            else
            {
                saldodisponible.Text = "******";
                mostrar.Text = "Mostrar Saldo";
            }

        }

        private void numerocuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            resta.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Error.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnsalir.Enabled = true;
            hazlo.Enabled = true;
            btncancel.Enabled = true;
        }
    }
}
