using ATM.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Desencrypta : Form
    {
        public Desencrypta()
        {
            InitializeComponent();
        }

        private void Desencrypta_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Encrypt objeto = new Clases.Encrypt();

            CConexion objetoConexion1 = new CConexion();
            string consulta = "select PIN from cuentas where id_user='" + textBox1.Text + "';";
            MySqlCommand myComandd = new MySqlCommand(consulta, objetoConexion1.establecerConexion());
            MySqlDataReader lector = myComandd.ExecuteReader();
            if (lector.Read() == true)
            { 
                label1.Text = objeto.decrypt(lector["PIN"].ToString());
            }
            SoundPlayer sound = new SoundPlayer();
            sound.Play();
        }
    }
}
