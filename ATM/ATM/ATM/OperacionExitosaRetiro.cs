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
    public partial class OperacionExitosaRetiro : Form
    {
        public OperacionExitosaRetiro()
        {
            InitializeComponent();
        }

        private void OperacionExitosaRetiro_Load(object sender, EventArgs e)
        {
            montoaretirar.Text = Session.retiroarealizar.ToString();
            if(Session.retiroarealizar == 20)
            {
                veinte.Visible = true;
            }
            else
            {
                veinte.Visible = false;
            }
            if (Session.retiroarealizar == 50)
            {
                cincuenchinkue.Visible = true;
            }
            else
            {
                cincuenchinkue.Visible = false;
            }
            if (Session.retiroarealizar == 100)
            {
                sien.Visible = true;
            }
            else
            {
                sien.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
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
