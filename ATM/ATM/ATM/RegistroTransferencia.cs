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
    public partial class RegistroTransferencia : Form
    {
        public RegistroTransferencia()
        {
            InitializeComponent();
        }

        private void RegistroTransferencia_Load(object sender, EventArgs e)
        {
            cuentadestino.Text= Session.cuenta_transferir.ToString();
            nombrebeneficiario.Text= Session.pnombre.ToString() + " " + Session.apatt + " " + Session.amatt.ToString();
            monto.Text = Session.montotransferir.ToString();
        }

        private void hazlo_Click(object sender, EventArgs e)
        {
            int saldoo = Session.estadob;
            int sumaa = Session.montotransferir;
            int operacion;

            operacion = saldoo + sumaa;
            CConexion objetoConexion = new CConexion();
            string query = "update cuentas set estadob='" + operacion + "' where numero_cuenta ='" + Session.cuenta_transferir+ "';";
            MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader reader = myComand.ExecuteReader();
            while (reader.Read())
            {

            }

            CConexion objetoConexion2 = new CConexion();
            string registro = "insert into historial_operaciones (id_operacion,dni,operacion,monto,destinatario) values ('','" + Session.dni + "','transferencia','" + Session.montotransferir.ToString() + "','" + Session.cuenta_transferir.ToString() + "');";
            MySqlCommand myComanddd = new MySqlCommand(registro, objetoConexion2.establecerConexion());
            MySqlDataReader sape = myComanddd.ExecuteReader();
            if (sape.Read() == true)
            {

            }
            int saldooo = Session.estadobancario;
            int restaa = Session.montotransferir;
            int operacioon;

            operacioon = saldooo - restaa;

            CConexion objetoConexion1 = new CConexion();
            string queryy = "update cuentas set estadob='" + operacioon + "' where dni ='" + Session.dni + "';";
            MySqlCommand myComandd = new MySqlCommand(queryy, objetoConexion1.establecerConexion());
            MySqlDataReader readerr = myComandd.ExecuteReader();
            while (readerr.Read())
            {

            }


            Form formulario = new OperacionExitosaTransferencia();
            formulario.Show();
            Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new DatosDeCuentaATransf();
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
