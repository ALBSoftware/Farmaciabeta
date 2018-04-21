using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Farmaciabeta
{
    public partial class Form1 : Form
    {
      
     
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,  int wparam , int lparam);

        private void privilegioUsuario()
        {
            if (Program.Cargo != "Administrador")
            {
       
                btnEmpleados.Visible = false;
                btnProveedores.Visible = false;
                btnReportes.Visible = false;
                btnUsuarios.Visible = false;
            }
        }

private void MostrarUsuarioActivo()
        {
            lblCargo.Text = Program.Cargo;
            lbNombre.Text = Program.Nombre;
            lbApellido.Text = Program.Apellido;
        }
private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            privilegioUsuario();
            MostrarUsuarioActivo();

      
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width==250)
            {
                MenuVertical.Width = 70;
                lblHora.Visible = false;
                lblFecha.Visible = false;
                lblCargo.Visible = false;
                lbNombre.Visible = false;
                lbApellido.Visible = false;
         

            }
            else
            {
                MenuVertical.Width = 250;
                lblHora.Visible = true;
                lblFecha.Visible = true;
                lblCargo.Visible = true;
                lbNombre.Visible = true;
                lbApellido.Visible = true;

            }
          
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
               }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoRestaurar.Visible = true;
            IconoMazimizar.Visible = false;
        }

        private void IconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoRestaurar.Visible = false;
            IconoMazimizar.Visible = true ;
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
      
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
        ReleaseCapture();
        SendMessage(this.Handle,0x112,0xf012,0);
    }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrilFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();



        }


        private void btnProducto_Click(object sender, EventArgs e)
        {
   
                AbrilFormInPanel(new Productos());
            lbMantenimientoProductos.Visible = true;
            lblUsuario.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BarraTitulo_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoRestaurar.Visible = true;
            IconoMazimizar.Visible = false;
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrilFormInPanel(new Usuarios());
            lbMantenimientoProductos.Visible = false;
            lblUsuario.Visible = true;
        }

        private void btnProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                AbrilFormInPanel(new Productos());
                lbMantenimientoProductos.Visible = true;
                lblUsuario.Visible = false;

            }
            else
            {
                if (e.KeyData == Keys.F7)
                {
                    
                    AbrilFormInPanel(new Usuarios());
                    lbMantenimientoProductos.Visible = false;
                    lblUsuario.Visible = true;

                }

            }
        }

        private void btnUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
