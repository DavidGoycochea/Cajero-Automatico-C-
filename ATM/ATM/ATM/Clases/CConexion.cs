using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "bbva";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";

        static string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + db + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }

            catch (Exception e)
            {
                MessageBox.Show("No se encontro la base de datos");
                conex.Close();
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
