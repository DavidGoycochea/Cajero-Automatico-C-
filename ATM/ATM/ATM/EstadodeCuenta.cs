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
    public partial class EstadodeCuenta : Form
    {
        public EstadodeCuenta()
        {
            InitializeComponent();
        }

        private void EstadodeCuenta_Load(object sender, EventArgs e)
        {
            CConexion segundaconexion = new CConexion();
            string sasa = "select estadob from cuentas where dni='" + Session.dni + "'";
            MySqlCommand micomando = new MySqlCommand(sasa, segundaconexion.establecerConexion());
            MySqlDataReader lector = micomando.ExecuteReader();
            if (lector.Read() == true)
            {
                saldoactual.Text = lector["estadob"].ToString();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {

     
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
        }

        private void labelestadocuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnvermivimientos_Click(object sender, EventArgs e)
        {
            Form formulario = new MovimientosRecientes();
            formulario.Show();
            Close();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }
    }
}
