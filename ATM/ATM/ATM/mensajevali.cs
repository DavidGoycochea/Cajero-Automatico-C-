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
    public partial class mensajevali : Form
    {
        public mensajevali()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void mensajevali_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            label3.Text = Session.validacion.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Celular_segundavali();
            formulario.Show();
            Close();
        }

        private void timercodigo_Tick(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            Session.validacion = aleatorio.Next(9999, 99999);
            label3.Text = Session.validacion.ToString();
        }

        private void mensajevali_FormClosing(object sender, FormClosingEventArgs e)
        {
            timercodigo.Enabled = false;
        }
    }
}
