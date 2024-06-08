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
    public partial class confirmretiro : Form
    {
        public confirmretiro()
        {
            InitializeComponent();
        }

        private void Confirmación_Deposito_Load(object sender, EventArgs e)
        {
            montoaretirar.Text = Session.retiroarealizar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saldoo = Session.estadobancario;
            int restaa = Session.retiroarealizar;
            int operacion;

            operacion = saldoo - restaa;

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
            if (lector.Read() == true)
            {
                Session.p_nombre = lector["p_nombre"].ToString();
                Session.s_nombre = lector["s_nombre"].ToString();
                Session.a_patt = lector["a_patt"].ToString();
                Session.a_matt = lector["a_matt"].ToString();
                Session.numero_telf = lector["numero_telf"].ToString();
            }
            CConexion objetoConexion2 = new CConexion();
            string registro = "insert into historial_operaciones (id_operacion,dni,operacion,monto) values ('','" + Session.dni + "','retiro','" + Session.retiroarealizar + "');";
            MySqlCommand myComanddd = new MySqlCommand(registro, objetoConexion2.establecerConexion());
            MySqlDataReader sape = myComanddd.ExecuteReader();
            if (sape.Read() == true)
            {

            }
            Form formulario = new OperacionExitosaRetiro();
            formulario.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Retiro();
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
