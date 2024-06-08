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
    public partial class ConfirmacionDeposito : Form
    {
        public ConfirmacionDeposito()
        {
            InitializeComponent();
        }

        private void ConfirmacionRetiro_Load(object sender, EventArgs e)
        {
            montoadepositar.Text = Session.depositoarealizar.ToString();
            cuentadestino.Text = Session.cuenta_destino.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saldoo = Session.estadobancario;
            int sumaa = Session.depositoarealizar;
            int operacion;

                operacion = saldoo + sumaa;
                CConexion objetoConexion = new CConexion();
                string query = "update cuentas set estadob='" + operacion + "' where dni ='" + Session.dni + "';";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                while (reader.Read())
                {

                }
                CConexion objetoConexion1 = new CConexion();
                string consulta = "select p_nombre, s_nombre, a_patt, a_matt, numero_telf from datos_personales where DNI='" + Session.dni + "'";
                MySqlCommand myComandd = new MySqlCommand(consulta, objetoConexion1.establecerConexion());
                MySqlDataReader lector = myComandd.ExecuteReader();
                if(lector.Read() == true)
                {
                    Session.p_nombre = lector["p_nombre"].ToString();
                    Session.s_nombre = lector["s_nombre"].ToString();
                    Session.a_patt = lector["a_patt"].ToString();
                    Session.a_matt = lector["a_matt"].ToString();
                    Session.numero_telf = lector["numero_telf"].ToString();
                }

            CConexion objetoConexion2 = new CConexion();
            string registro = "insert into historial_operaciones (id_operacion,dni,operacion,monto) values ('','" + Session.dni_deposito + "','deposito','" + Session.depositoarealizar + "');";
            MySqlCommand myComanddd = new MySqlCommand(registro, objetoConexion2.establecerConexion());
            MySqlDataReader sape = myComanddd.ExecuteReader();
            if (sape.Read() == true)
            {
                
            }
            Form formulario = new OperacionExitosaDeposito();
            formulario.Show();
            Close();
        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroDeposito();
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
