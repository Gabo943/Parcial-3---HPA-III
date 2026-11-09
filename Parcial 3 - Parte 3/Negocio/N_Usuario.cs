using Datos;
using Entidad;
using Negocio.Contratos;
using Negocio.Servicios;

namespace Negocio
{
    public class N_Usuario
    {
        private static readonly IVerificarHashService _verificador = new BCryptHashService();

        public static E_Usuarios Login(string strUsuario, string strPassword)
        {
            E_Usuarios usuario = D_Usuario.ObtenerPorUsuario(strUsuario);

            bool exitoso = usuario != null
                            && usuario.dsEstado == '1'
                            && _verificador.VerificarHash(strPassword, usuario.dsPassword);

            // Se registra el intento siempre, exista o no el usuario
            D_IntentoAcceso.Registrar(strUsuario, exitoso);

            return exitoso ? usuario : null;
        }
    }
}