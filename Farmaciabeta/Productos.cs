using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmaciabeta
{
    public partial class Productos : Form
    {
        private int id;

        public Productos()
        {
            InitializeComponent();
            consultar();
            dgvProductos.Columns[0].Visible = false;
            Privilegio();
        }

        private void Privilegio()

        {
         if (Program.Cargo!="Administrador")

            {

                btnAgregarProducto.Visible = false;
                btnEditarProducto.Visible = false;
                btnEliminarProducto.Visible = false;
        
            }

        }

        

        private void consultar()
        {

            dgvProductos.DataSource = new Conexion_Producto().consultar();
        }

        private void obtenerId()
        {
            id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
        }

      
        

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerId();
   
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
