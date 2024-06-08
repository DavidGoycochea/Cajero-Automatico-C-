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
    public partial class Transferencia : Form
    {
        public Transferencia()
        {
            InitializeComponent();
        }

        private void hazlo_Click(object sender, EventArgs e)
        {
            if (cuenta_transferir.Text != "")
            {
                if (cuenta_transferir.Text == Session.numero_cuenta)
                {
                    mensaje.Text = "No puedes transferirte a ti mismo \n Realiza un deposito para ello.";
                    Error.Visible = true;
                    btnsalir.Enabled = false;
                    hazlo.Enabled = false; ;
                    btncancel.Enabled = false;
                }
                else
                {
                    CConexion objetoConexion1 = new CConexion();
                    string consulta = "SELECT cuentas.estadob, datos_personales.p_nombre, datos_personales.s_nombre, datos_personales.a_patt, datos_personales.a_matt from cuentas INNER JOIN datos_personales ON cuentas.id_user=datos_personales.id_user WHERE cuentas.numero_cuenta='" + cuenta_transferir.Text + "';";
                    MySqlCommand myComandd = new MySqlCommand(consulta, objetoConexion1.establecerConexion());
                    MySqlDataReader lector = myComandd.ExecuteReader();
                    if (lector.Read() == true)
                    {
                        Session.estadob = Convert.ToInt32(lector["estadob"].ToString());
                        Session.pnombre = lector["p_nombre"].ToString();
                        Session.snombre = lector["s_nombre"].ToString();
                        Session.apatt = lector["a_patt"].ToString();
                        Session.amatt = lector["a_matt"].ToString();
                        Session.cuenta_transferir = cuenta_transferir.Text;
                        Form formulario = new CantidadTransferir();
                        formulario.Show();
                        Close();
                    }
                    else
                    {
                        mensaje.Text = "Cuenta no encontrada.";
                        Error.Visible = true;
                        btnsalir.Enabled = false;
                        hazlo.Enabled = false;
                        btncancel.Enabled = false;
                    }

                }
            }
            else
            {
                mensaje.Text = "Ingrese una cuenta para la transferencia.";
                Error.Visible = true;
                btnsalir.Enabled = false;
                hazlo.Enabled = false;
            }
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cuenta_transferir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = cuenta_transferir.Text + "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cuenta_transferir.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Error.Visible = false;
            btnsalir.Enabled = true;
            hazlo.Enabled = true;
            btncancel.Enabled = true;
        }
    }
}
