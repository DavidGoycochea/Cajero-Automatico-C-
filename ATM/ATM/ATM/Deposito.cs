using ATM.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void Depositar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = depositoarealizar.Text + "0";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new RecomendacionesDeposito();
            formulario.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (depositoarealizar.Text != "")
            {
                int variable = Convert.ToInt32(depositoarealizar.Text);
                if (variable % 20 == 0 || variable % 50 == 0 || variable % 100 == 0)
                {
                    if (0 < variable && variable < 5000)
                    {
                        Session.depositoarealizar = Convert.ToInt32(depositoarealizar.Text);
                        Form formulario = new RegistroDeposito();
                        formulario.Show();
                        Close();
                    }
                    else
                    {
                        mensaje.Text= "Ingrese un deposito entre 20 - 5000";
                        Error.Visible= true;
                        continuar.Enabled = false;
                        volver.Enabled = false;
                    }
                }
                else
                {
                    mensaje.Text="Ingrese billetes de 20, 50 o 100";
                    Error.Visible= true;
                    volver.Enabled = false;
                    continuar.Enabled = false;
                }
            }
            else
            {
                mensaje.Text = "Ingrese billetes de 20, 50 o 100";
                Error.Visible = true;
                volver.Enabled = false;
                continuar.Enabled = false;
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            depositoarealizar.Text = "";
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

        private void Deposito_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Error.Visible= false;
            continuar.Enabled= true;
            volver.Enabled= true;
        }
    }
}
