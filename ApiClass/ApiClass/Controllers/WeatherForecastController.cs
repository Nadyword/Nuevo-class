using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ApiClass.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost(Name = "EnviarTexto")]
        public IActionResult EnviarTexto([FromBody] string texto)
        {
            string connectionString = "Data Source=DESCONOSIDO\\SAMUEL;Initial Catalog=2024-colpein;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                string query = $"INSERT INTO Test VALUES ('{texto + DateTime.Now}')"; // Reemplaza "TableName" con el nombre de tu tabla

                SqlCommand command = new(query,connection);
                if(command.ExecuteNonQuery() >0)
                {
                    return Ok("Se ha insertado correctamente");
                }
                else
                {
                    return Ok("No se ha insertado correctamente");
                }

            }
        }
    }
}
