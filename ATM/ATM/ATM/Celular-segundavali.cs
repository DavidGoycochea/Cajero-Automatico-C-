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
    public partial class Celular_segundavali : Form
    {
        public Celular_segundavali()
        {
            InitializeComponent();
        }

        private void app1_Click(object sender, EventArgs e)
        {
            Form formulario = new mensajevali();
            formulario.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            Close();
        }

        private void Celular_segundavali_Load(object sender, EventArgs e)
        {

        }
    }
}
