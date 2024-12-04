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
        public Clientes_Forms()
        {
            InitializeComponent();
        }

        private void Clientes_Forms_Load(object sender, EventArgs e)
        {
            conexionSQL conexion = new conexionSQL();
            conexion.abrir();
        }
    }
}
