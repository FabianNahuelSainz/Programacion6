namespace Programacion6.Models
{
    public class Club
    {
        public string Nombre { get; set; }
        public int CantidadSocios { get; set; }
        public int CantidadTitulos { get; set; }
        public DateTime FechaFundacion { get; set; }
        public string UbicacionEstadio { get; set; }
        public string NombreEstadio {get; set; }
        public List<Socio> socio { get; set; }
        public List<Dirigente> dirigente { get; set; }

    }
}
