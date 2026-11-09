using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_IntentoAcceso : D_Conexion
    {
        public static void Registrar(string strUsuario, bool exitoso)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_RegistrarIntentoAcceso", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dsUsuario", strUsuario);
                        cmd.Parameters.AddWithValue("@bExitoso", exitoso);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // No interrumpas el login si falla el registro del intento;
                // solo lo omitimos silenciosamente (o podrías loguearlo a un archivo).
            }
        }
    }
}