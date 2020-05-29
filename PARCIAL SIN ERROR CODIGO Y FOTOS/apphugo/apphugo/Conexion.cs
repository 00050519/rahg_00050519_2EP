using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace apphugo
{
    public class Conexion
    {
        private static string cadenaconexion =
                             "Server = 127.0.0.1; Port = 5432; userId = postgres;   password = A$APMOB; Database = hugodatabase;";
                
                         public static DataTable realizarConsulta(string sql)
                         {
                             NpgsqlConnection con = new NpgsqlConnection(cadenaconexion);
                             DataSet ds = new DataSet();
                             
                             con.Open();
                             NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql,con);
                             da.Fill(ds);
                             con.Close();
                
                             return ds.Tables[0];
                
                         }
                
                         public static void realizarAccion(string sql)
                         {
                             NpgsqlConnection con = new NpgsqlConnection(cadenaconexion);
                             con.Open();
                             
                             NpgsqlCommand nc = new NpgsqlCommand(sql,con);
                             nc.ExecuteNonQuery(); 
                             con.Close();
        }

                         public static void cargarPersonas(DataGridView dgv)
                         {
                             NpgsqlConnection con = new NpgsqlConnection(cadenaconexion);
                             NpgsqlDataAdapter da;
                             DataTable dt = new DataTable();

                             try
                             {
                                 con.Open();
                                 da = new NpgsqlDataAdapter("select iduser, fullname, username from appuser", con);
                                 da.Fill(dt);
                                 dgv.DataSource = dt;
                                 con.Close();
                             }
                             catch (Exception ex)
                             {
                                 MessageBox.Show("hubo un error al cargar los datos", ex.ToString());
                             }
                         }
    }
}