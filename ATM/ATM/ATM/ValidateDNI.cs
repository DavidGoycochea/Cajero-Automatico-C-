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
    public partial class ValidateDNI : Form
    {
        public ValidateDNI()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "3";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            valiDNI.Text = valiDNI.Text + "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            valiDNI.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new InicioCajero();
            formulario.Show();
            Close();
        }
        
        private void btnenter_Click(object sender, EventArgs e)
        {
            CConexion objetoConexion = new CConexion();

            string query = "select DNI from cuentas where DNI='" + valiDNI.Text + "'";
            MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader reader = myComand.ExecuteReader();
            if (reader.Read() == true)
            {
                Session.dni = valiDNI.Text;
                Form formulario = new ValidatePIN();
                formulario.Show();
                Close();
            }
            else
            {
                valiDNI.Text = "DNI Invalido";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void labeldni_Click(object sender, EventArgs e)
        {

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Form formulario = new Encrypta();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Desencrypta();
            formulario.Show();
        }
    }
}
