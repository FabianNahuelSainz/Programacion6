using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Programacion6.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Programacion6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        
        [HttpPost]
        /*public Persona Post(Persona persona)
        {
            return persona;
        }
        */

        public List<Persona> ListarPersonas (Persona persona)
        {
            List<Persona> lista = new List<Persona>();

            for (int i=0; i<5; i++)
            {
                lista.Add(persona);
            }

            return lista;
        }
    }
}
