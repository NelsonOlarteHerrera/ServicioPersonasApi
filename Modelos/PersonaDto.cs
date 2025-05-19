namespace ServicioPersonasApi.Modelos
{
    public class PersonaDto
    {
        public string NombreCompleto { get; set; }
        public string Genero { get; set; }
        public string Ubicacion { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Fotografia { get; set; }
    }
}
