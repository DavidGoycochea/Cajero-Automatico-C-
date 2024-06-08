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
    public partial class Encrypta : Form
    {
        public Encrypta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Encrypt objetonew = new Clases.Encrypt();

            CConexion objetoConexion2 = new CConexion();
            string registro = "insert into cuentas values ('" + dni.Text + "','" + estadob.Text + "','" + objetonew.encrypt(textBox2.Text) + "','" + numerocuenta.Text + "','" + iduser.Text + "');";
            MySqlCommand myComanddd = new MySqlCommand(registro, objetoConexion2.establecerConexion());
            MySqlDataReader sape = myComanddd.ExecuteReader();
            if (sape.Read() == true)
            {

            }

        }

        private void Encrypta_Load(object sender, EventArgs e)
        {

        }
    }
}
