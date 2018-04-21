using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Farmaciabeta
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            string server = ".\\SQLEXPRESS";
            string database = "FarmaciaBeta";

            SqlConnection cn = new SqlConnection
                ("Data source=" + server + "; Initial catalog=" + database + "; Integrated Security=True");
            return cn;

        }







    }
}
