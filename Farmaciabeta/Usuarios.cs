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
    public partial class Usuarios : Form
    {
        private int id;

        public Usuarios()
        {
            InitializeComponent();
            consultar();
            dgvUsuarios.Columns[0].Visible = false;
        }

        private void consultar()
        {

            dgvUsuarios.DataSource = new Conexion_Usuarios().consultar();
        }
        private void restablecerControles()
        {
            this.tbCedu.Clear();
            this.tbNombre.Clear();
            this.tbApellido.Clear();
            this.cbCargo.Refresh();
            this.tbEmail.Clear();
            this.tbContraseña.Clear();



        }
        private void obtenerId()
        {
            id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
        }

        private void filtrado(string filtro)
        {

            dgvUsuarios.DataSource = new Conexion_Usuarios().filtrar(filtro);

        }
        private void obtenerDatos()
        {
            obtenerId();
            tbCedu.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            tbNombre.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            tbApellido.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            cbCargo.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            tbContraseña.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();


        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            obtenerId();
            obtenerDatos();
            consultar();
            btnLimpiar.Visible = true;
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
           

           

        }

        private void btnEliminarEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            restablecerControles();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            if (new Conexion_Usuarios().insertar(new string[] {


                    this.tbCedu.Text,
            this.tbNombre.Text,
            this.tbApellido.Text,
            this.cbCargo.Text,
            this.tbEmail.Text,
            this.tbContraseña.Text
            }))
            {
                MessageBox.Show("REGISTRO INSERTADO CORRECTAMENTE");
                consultar();
                restablecerControles();
            }
            restablecerControles();
        }

        private void tbCedu_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (char.IsLetter(e.KeyChar))
                {

                e.Handled = true;
                MessageBox.Show("Solo se Permiten Numeros");

                }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            restablecerControles();
        }

        private void btnEditarUsuario_Click_1(object sender, EventArgs e)
        {
            if (new Conexion_Usuarios().actualizar(new object[] {
                id,
                    this.tbCedu.Text,
            this.tbNombre.Text,
            this.tbApellido.Text,
            this.cbCargo.Text,
            this.tbEmail.Text,
            this.tbContraseña.Text


        }))
            {
            }
            if (MessageBox.Show("Desea Modificar Este Registro?", "Modificando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                consultar();
                restablecerControles();
            }
        }

        private void btnEliminarEliminar_Click_1(object sender, EventArgs e)
        {
            new Conexion_Usuarios().eliminar(id);


            if (MessageBox.Show("Desea Eliminar Este Usuario?", "Eliminando Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                consultar();

                restablecerControles();

            }
        }
    }
}
