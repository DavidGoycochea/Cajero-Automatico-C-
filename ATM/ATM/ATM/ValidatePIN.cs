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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
    public partial class ValidatePIN : Form
    {
        public ValidatePIN()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            valiPIN.Text = valiPIN.Text + "1";
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            Clases.Encrypt objetonew = new Clases.Encrypt();
            CConexion objetoConexion = new CConexion();

            string query = "select PIN, numero_cuenta, estadob from cuentas where dni ='" + Session.dni + "'";
            MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader reader = myComand.ExecuteReader();
            if (reader.Read() == true)
            {
                if (objetonew.decrypt(reader["PIN"].ToString()) == valiPIN.Text)
                {
                    Random aleatorio = new Random(); 
                    Session.validacion = aleatorio.Next(9999, 99999);
                    Session.estadobancario = int.Parse(reader["estadob"].ToString());
                    Session.numero_cuenta = reader["numero_cuenta"].ToString();

                    Form formulario = new segundavalidacion();
                    formulario.Show();
                    Close();

                }
                else
                {
                    valiPIN.Text = "PIN Invalido";
                }
            }
            else
            {
                valiPIN.Text = "PIN Invalido";

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            valiPIN.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form formulario = new ValidateDNI();
            formulario.Show();
            Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            valiPIN.Text = valiPIN.Text + "0";
        }

        private void ValidatePIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {

        }

        private void valiPIN_Click(object sender, EventArgs e)
        {

        }

        private void labelpin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
