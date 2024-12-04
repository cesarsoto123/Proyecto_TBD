using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TBD
{
    internal class conexionSQL
    {
        string cadenaConexion = "Data source=MTA_LAPTOP;Initial Catalog=proyecto_tbd; Integrated Security=True";
        public SqlConnection conexionBD = new SqlConnection();

        public string cadena()
        {
            return cadenaConexion;
        }

        public conexionSQL()
        {
            conexionBD.ConnectionString = cadenaConexion;
        }

        public void abrir()
        {
            try
            {
                conexionBD.Open();
                MessageBox.Show("Conexión abierta");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión:\n" + ex);
            }
        }//fin abrir

        public void cerrar()
        {
            conexionBD.Close();
        }//fi n cerrar




    }//fin class
}//fin namespace
