using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TBD
{
    public partial class Clientes_Forms : Form
    {
        claseCliente cliente = new claseCliente();
        conexionSQL conexion = new conexionSQL();
        public Clientes_Forms()
        {
            InitializeComponent();
        }

        public void mostrarCliente()
        {
            try
            {
                DataTable dt = cliente.muestraCliente();
                if (dt != null)
                {
                    cliente_DGV.DataSource = dt;
                    cliente_DGV.AutoResizeColumns();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Clientes_Forms_Load(object sender, EventArgs e)
        {
            conexionSQL conexion = new conexionSQL();
            conexion.abrir();
            mostrarCliente();
        }

        private void agregar_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.nombre = nombre_Tbx.Text;
                cliente.claveCliente = int.Parse(claveCliente_Tbx.Text);
                cliente.direccion = direccion_Tbx.Text;
                cliente.telefono = telefono_Tbx.Text;

                cliente.agregarCliente(cliente);
                cliente.muestraCliente();
                MessageBox.Show("Cliente agregado exitosamente");

            }catch(Exception ex)
            {
                MessageBox.Show("Error:\n" + ex);
            }

            mostrarCliente();
        }

        private void actualizar_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.nombre = nombre_Tbx.Text;
                cliente.claveCliente = int.Parse(claveCliente_Tbx.Text);
                cliente.direccion = direccion_Tbx.Text;
                cliente.telefono = telefono_Tbx.Text;

                cliente.actualizarCliente(cliente);
                cliente.muestraCliente();
                MessageBox.Show("Cliente actualizado exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex);
            }
           mostrarCliente();
        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.nombre = nombre_Tbx.Text;
                cliente.claveCliente = int.Parse(claveCliente_Tbx.Text);
                cliente.direccion = direccion_Tbx.Text;
                cliente.telefono = telefono_Tbx.Text;

                cliente.eliminarCliente(cliente);
                cliente.muestraCliente();
                MessageBox.Show("Cliente eliminado exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex);
            }
            mostrarCliente();
        }

        private void salir_Btn_Click(object sender, EventArgs e)
        {
            conexion.cerrar();
            this.Close();
        }

        private void clave_cliente_lbl_Click(object sender, EventArgs e)
        {

        }
    }//fin class
}//fin namespace
