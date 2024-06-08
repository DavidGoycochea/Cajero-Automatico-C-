using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Session
    {
        //Informacion general
        public static string dni, pin, p_nombre, s_nombre, a_patt, a_matt, numero_telf;
        public static int estadobancario,validacion;
        //Informacion Depositos
        public static string numero_cuenta, cuenta_destino, dni_deposito, id_deposito;
        public static int depositoarealizar;
        //Informacion Retiros
        public static string s;
        public static int retiroarealizar;
        //Informacion Transferencias
        public static string cuenta_transferir, pnombre, snombre, apatt, amatt;
        public static int estadob,montotransferir;


    }
}
