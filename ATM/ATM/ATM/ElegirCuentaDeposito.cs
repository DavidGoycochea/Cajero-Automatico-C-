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
    public partial class ElegirCuentaDeposito : Form
    {
        public ElegirCuentaDeposito()
        {
            InitializeComponent();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Session.cuenta_destino = Session.numero_cuenta;
            CConexion objetoConexion1 = new CConexion();
            string consulta = "select dni from cuentas where numero_cuenta='" + Session.cuenta_destino + "'";
            MySqlCommand myComandd = new MySqlCommand(consulta, objetoConexion1.establecerConexion());
            MySqlDataReader lector = myComandd.ExecuteReader();
            if (lector.Read() == true)
            {
                Session.dni_deposito = lector["dni"].ToString();
            }
            Form formulario = new RecomendacionesDeposito();
            formulario.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Mostrar numero de cuenta
            if (lblnumerocuenta.Text == "***********")
            {
                lblnumerocuenta.Text = Session.numero_cuenta;
                lblmostrar.Text = "Ocultar Cuenta";
            }
            else
            {
                lblnumerocuenta.Text =  "***********";
                lblmostrar.Text = "Mostrar Cuenta";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void ElegirCuentaDeposito_Load(object sender, EventArgs e)
        {

        }
    }
}
