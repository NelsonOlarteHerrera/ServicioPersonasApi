using System.Net.Http.Json;
using ServicioPersonasApi.Modelos;

namespace ServicioPersonasApi.Servicios
{
    public class ServicioPersonas
    {
        private readonly HttpClient _http;

        public ServicioPersonas(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<PersonaDto>> ObtenerPersonasAleatoriasAsync(int cantidad = 10)
        {
            var respuesta = await _http.GetFromJsonAsync<RespuestaApi>($"https://randomuser.me/api/?results={cantidad}");

            var lista = new List<PersonaDto>();
            foreach (var p in respuesta.Results)
            {
                lista.Add(new PersonaDto
                {
                    NombreCompleto = $"{p.Name.First} {p.Name.Last}",
                    Genero = p.Gender,
                    Ubicacion = $"{p.Location.City}, {p.Location.Country}",
                    CorreoElectronico = p.Email,
                    FechaNacimiento = DateTime.Parse(p.Dob.Date),
                    Fotografia = p.Picture.Medium
                });
            }

            return lista;
        }
    }
}
