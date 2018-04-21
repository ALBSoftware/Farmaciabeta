using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmaciabeta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
     
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
       

  
            }else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
          
      
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape)
            {
                this.Close();
        }




        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            string server = ".\\SQLEXPRESS";
            string nombre = "FarmaciaBeta";


            SqlConnection cn = new SqlConnection("Data Source =" + server + "; Initial Catalog =" + nombre + "; Integrated Security = True");

            cn.Open();
            SqlCommand codigo = new SqlCommand();
            SqlConnection conectar = new SqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("SELECT * FROM login WHERE Cedula = '" + tbUsuario.Text + "' AND Contrasena = '" + tbPassword.Text + "' ");

            SqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read()==true)
            {

                MessageBox.Show("BIENVENIDOS AL SISTEMA :" + tbUsuario.Text);
                this.Hide();
                Form1 frm = new Form1();
                Program.Cargo = leer["Cargo"].ToString();
                Program.Nombre = leer["Nombre"].ToString();
                Program.Apellido = leer["Apellido"].ToString();
                frm.Show();

            }
            else
            {
                MessageBox.Show("REVISAR LOS CAMPOS!");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))

            {
                string server = ".\\SQLEXPRESS";
                string nombre = "FarmaciaBeta";


                SqlConnection cn = new SqlConnection("Data Source =" + server + "; Initial Catalog =" + nombre + "; Integrated Security = True");

                cn.Open();
                SqlCommand codigo = new SqlCommand();
                SqlConnection conectar = new SqlConnection();
                codigo.Connection = cn;
                codigo.CommandText = ("SELECT * FROM login WHERE Cedula = '" + tbUsuario.Text + "' AND Contrasena = '" + tbPassword.Text + "' ");

                SqlDataReader leer = codigo.ExecuteReader();

                if (leer.Read() == true)
                {

                    MessageBox.Show("BIENVENIDOS AL SISTEMA :" + tbUsuario.Text);
                    this.Hide();
                    Form1 frm = new Form1();
                    Program.Cargo = leer["Cargo"].ToString();
                    Program.Nombre = leer["Nombre"].ToString();
                    Program.Apellido = leer["Apellido"].ToString();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("REVISAR LOS CAMPOS!");
                }

            }


        }
    }
}

