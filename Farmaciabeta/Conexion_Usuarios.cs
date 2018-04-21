using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farmaciabeta
{
    class Conexion_Usuarios
    {

        private SqlConnection cn = null; //PARA LA CONEXION
        private SqlCommand cmd = null; //PARA EJERCUTAR LOS COMANDOS EN mysql
        private SqlDataReader reader = null; //Para almacenar los datos que voy a recibir 
        private DataTable table = null; //Para organizar la informacion recibida


        public bool insertar(string[] data)
        {
            try
            {
                string query = "INSERT INTO Login (Cedula,Nombre,Apellido,Cargo,Email,Contrasena)VALUES('" + data[0] + "' , '" + data[1] + "', '" + data[2] + "', '" + data[3] + "', '" + data[4] + "', '" + data[5] + "')";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new SqlCommand(query, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return false;
        }


        public bool actualizar(object[] data)
        {
            try
            {
                string query = "UPDATE Login SET Cedula='" + data[1] + " ', Nombre='" + data[2] + " ', Apellido='" + data[3] + " ', Cargo='" + data[4] + " ', Email='" + data[5] + " ', Contrasena='" + data[6] + " ' WHERE id ='" + data[0] + "'";

                cn = Conexion.conectar();
                cn.Open();
                cmd = new SqlCommand(query, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }

            catch (NullReferenceException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }


            return false;
        }

        public DataTable consultar()
        {
            try
            {
                nombresColumnas();
                string query = " SELECT * FROM Login";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new SqlCommand(query, cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    table.Rows.Add(new object[] {
                        reader["id"],
                        reader["Cedula"],
                        reader["Nombre"],
                        reader["Apellido"],
                        reader["Cargo"],
                        reader["Email"],
                        reader["Contrasena"]



                    });

                }
                reader.Close();
                cn.Close();
                return table;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ocurrio un error en el proceso");
            }

            catch (NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ocurrio un error en el proceso");
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ocurrio un error en el proceso");
            }

            return table;
        }
        public DataTable filtrar(string filtro)
        {
            try
            {
                nombresColumnas();
                string query = "SELECT * FROM Login where (Cedula LIKE '" + filtro + "%') OR Email LIKE '" + filtro + "%' ";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new SqlCommand(query, cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    table.Rows.Add(new object[] {
                      reader["id"],
                        reader["Cedula"],
                        reader["Nombre"],
                        reader["Apellido"],
                        reader["Cargo"],
                        reader["Email"],
                        reader["Contrasena"]
                        });
                }
                reader.Close();
                cn.Close();
                return table;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ocurrio un error en el proceso");
            }

            catch (NullReferenceException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }

            return table;
        }
        public bool eliminar(int id)
        {
            try
            {

                string query = "DELETE FROM Login WHERE id = '" + id + "'";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new SqlCommand(query, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }
            }

            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }

            catch (NullReferenceException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ocurrio un error en el proceso");
            }
            return false;

        }


        private void nombresColumnas()
        {
            table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Cedula ");
            table.Columns.Add("Nombre ");
            table.Columns.Add("Apellido ");
            table.Columns.Add("Cargo ");
            table.Columns.Add("Email ");
            table.Columns.Add("Contrasena ");
        }























































    }
}
