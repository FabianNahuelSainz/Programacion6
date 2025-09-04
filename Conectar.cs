using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Programacion6
{
    public class Conectar
    {
        private readonly string _connectionString;

        public Conectar(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Clubes")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión");
        }

        public SqlConnection GetConnection()
        {
            var conexion = new SqlConnection(_connectionString);
            conexion.Open();
            return conexion;
        }
    }
}
