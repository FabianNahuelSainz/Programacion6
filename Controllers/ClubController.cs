using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Programacion6.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Programacion6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly Conectar conectar;

        // El constructor recibe la clase Conectar por inyección de dependencias
        public ClubController(Conectar _conectar)
        {
            conectar = _conectar;
        }

        [HttpGet]
        [Route("v1/Lista-Club")]
        public List<Club> ObtenerClub()
        {
            List<Club> clubes = new List<Club>();

            using SqlConnection conexion = conectar.GetConnection();
            using SqlCommand comando = new("SELECT nombre, cantidadSocios, cantidadTitulos, fechaFundacion, ubicacionEstadio, nombreEstadio FROM club", conexion);
            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                clubes.Add(new Club
                {
                    Nombre = lector.GetString(0),
                    CantidadSocios = lector.GetInt32(1),
                    CantidadTitulos = lector.GetInt32(2),
                    FechaFundacion = lector.GetDateTime(3),
                    UbicacionEstadio = lector.GetString(4),
                    NombreEstadio = lector.GetString(5)
                });
            }

            return clubes;
        }
    }
}
