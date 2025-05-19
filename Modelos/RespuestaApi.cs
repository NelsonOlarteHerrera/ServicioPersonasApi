namespace ServicioPersonasApi.Modelos
{
    public class RespuestaApi
    {
        public List<PersonaApi> Results { get; set; }
    }

    public class PersonaApi
    {
        public NombreApi Name { get; set; }
        public string Gender { get; set; }
        public UbicacionApi Location { get; set; }
        public string Email { get; set; }
        public FechaApi Dob { get; set; }
        public FotoApi Picture { get; set; }
    }

    public class NombreApi
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class UbicacionApi
    {
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class FechaApi
    {
        public string Date { get; set; }
    }

    public class FotoApi
    {
        public string Medium { get; set; }
    }
}
