using System.Data;
using Npgsql;

namespace HugoApp
{
    public static class Conexion
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
    }

    
}