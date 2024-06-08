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
    public partial class MovimientosRecientes : Form
    {
        public MovimientosRecientes()
        {
            InitializeComponent();
            try
            {
                CConexion objetoConexion = new CConexion();
                string query = "select operacion, monto from historial_operaciones where dni='" + Session.dni + "'";
                dataGridViewmovi.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewmovi.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {

            }
        }

            private void MovimientosRecientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new EstadodeCuenta();
            formulario.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewmovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }
    }
}
