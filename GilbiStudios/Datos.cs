using System.Data;
using System.Data.SqlClient;

namespace GilbiStudios
{
    class Datos
    {
        private static string cadenaConexion = "Server = localhost ;Database = GilbiStudios; Trusted_Connection = True;";
        private static SqlConnection conexion = new SqlConnection(cadenaConexion);

        public static int EjecutarConsulta(string consulta)
        {
            int registroAfectados = 0;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            registroAfectados = comando.ExecuteNonQuery();
            conexion.Close();
            return registroAfectados;
        }

        public static void AgregarDataTable(DataSet ds, string consulta, string nombreTabla)
        {
            SqlDataAdapter da = new SqlDataAdapter(consulta, cadenaConexion);
            da.Fill(ds, nombreTabla);
        }
    }
}
