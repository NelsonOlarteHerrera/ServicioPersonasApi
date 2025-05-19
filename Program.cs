
using ServicioPersonasApi.Servicios;

namespace ServicioPersonasApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Servicio HttpClient inyectado
            builder.Services.AddHttpClient<ServicioPersonas>();
            //Activar CORS para el front end
            builder.Services.AddCors(opciones =>
            {
                opciones.AddPolicy("PermitirTodo", politica =>
                {
                    politica.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            //Activar cors
            app.UseCors("PermitirTodo");


            app.UseDefaultFiles(); // Opcional: sirve index.html por defecto
            app.UseStaticFiles();  // Permite servir HTML, CSS, JS desde wwwroot

            app.MapControllers();

            app.Run();
        }
    }
}
