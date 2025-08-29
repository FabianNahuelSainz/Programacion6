using Microsoft.AspNetCore.Mvc;
using Programacion6.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Programacion6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        [HttpGet]
        [Route("v1/Lista-Club")]
        public Club ObtenerClub()
        {
            Club club = new Club();
            return club;
        }
    }
}
