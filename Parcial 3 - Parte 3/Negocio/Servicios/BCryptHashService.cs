using Negocio.Contratos;
using BCrypt.Net;

namespace Negocio.Servicios
{
    public class BCryptHashService : IHashService, IVerificarHashService
    {
        public string GenerarHash(string passwordPlano)
        {
            // WorkFactor 12 es un valor estándar y seguro para la mayoría de los casos
            return BCrypt.Net.BCrypt.HashPassword(passwordPlano, workFactor: 12);
        }

        public bool VerificarHash(string passwordPlano, string hashAlmacenado)
        {
            return BCrypt.Net.BCrypt.Verify(passwordPlano, hashAlmacenado);
        }
    }
}