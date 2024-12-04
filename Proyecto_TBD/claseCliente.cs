using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TBD
{
    internal class claseCliente
    {
        public int claveCliente;
        public string nombre;
        public string direccion;
        public string telefono;


        conexionSQL conexion = new conexionSQL();

        public DataTable muestraCliente()
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connect = new SqlConnection(conexion.cadena()))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("VISUALIZAR_CLIENTES", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Usamos un SqlDataAdapter para llenar el DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar clientes: {ex.Message}");
            }

            return table; // Devuelve el DataTable lleno o vacío si hubo un error
        }//fin mostrar cliente

        public void agregarCliente(claseCliente cl)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conexion.cadena()))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERTA_CLIENTE", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_nombre", cl.nombre);
                        cmd.Parameters.AddWithValue("@p_clave_cliente", cl.claveCliente);
                        cmd.Parameters.AddWithValue("@p_direccion", cl.direccion);
                        cmd.Parameters.AddWithValue("@p_telefono", cl.telefono);

                        cmd.ExecuteNonQuery();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin método agregar cliente

        public void eliminarCliente(claseCliente cl)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conexion.cadena()))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("ELIMINAR_CLIENTES", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_clave_cliente", cl.claveCliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin eliminarCliente

        public void actualizarCliente(claseCliente cl)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conexion.cadena()))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("MODIFICAR_CLIENTE", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@clave_cliente", cl.claveCliente);
                        cmd.Parameters.AddWithValue("@nom_cliente", cl.nombre);
                        cmd.Parameters.AddWithValue("@direccion", cl.direccion);
                        cmd.Parameters.AddWithValue("@telefono", cl.telefono);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//fin actualizar


    }//fin class
}//fin namespace
