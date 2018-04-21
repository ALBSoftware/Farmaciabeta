using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farmaciabeta
{
    class Conexion_Producto
    {

        private SqlConnection cn = null; //PARA LA CONEXION
        private SqlCommand cmd = null; //PARA EJERCUTAR LOS COMANDOS EN mysql
        private SqlDataReader reader = null; //Para almacenar los datos que voy a recibir 
        private DataTable table = null; //Para organizar la informacion recibida



        public DataTable consultar()
        {
            try
            {
                nombresColumnas();
                string query = " SELECT * FROM profesor";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new SqlCommand(query, cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    table.Rows.Add(new object[] {
                        reader["id_profesor"],
                        reader["nombre"],
                        reader["apellido"],
                        reader["fecha_nacimiento"],
                        reader["cedula"],
                        reader["telefono"],
                        reader["correo"],
                        reader["direccion"],
                        reader["Licensiatura"] });

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
        private void nombresColumnas()
        {
            table = new DataTable();
            table.Columns.Add("ID  ");
            table.Columns.Add("NOMBRE  ");
            table.Columns.Add("APELLIDO  ");
            table.Columns.Add("FECHA_NACIMIENTO  ");
            table.Columns.Add("CEDULA  ");
            table.Columns.Add("TELEFONO  ");
            table.Columns.Add("CORREO  ");
            table.Columns.Add("DIRECCION  ");
            table.Columns.Add("PROFESION  ");




        }

    }
}
