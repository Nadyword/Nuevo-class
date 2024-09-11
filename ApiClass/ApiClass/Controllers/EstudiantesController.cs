using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace ApiClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]                                                                                                                                                                                                                                                                                     
    public class EstudiantesController : ControllerBase
    {
        [HttpGet(Name = "TraerEstudiante")]
        public IActionResult EnviarTexto(string texto)
        {
            string connectionString = "Data Source=DESCONOSIDO\\SAMUEL;Initial Catalog=2024-colpein;Integrated Security=True;Encrypt=False;";
            using SqlConnection connection = new(connectionString);
            connection.Open();
            string query = $"SELECT * FROM alumnos WHERE cod_alum = '{texto}'";

            SqlCommand command = new(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                var result = new List<Dictionary<string, object>>();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader.GetValue(i);
                    }
                    result.Add(row);
                }

                string jsonResult = JsonConvert.SerializeObject(result);
                return Ok(jsonResult);
            }
            else
            {
                return Ok("No se ha encontrado ningún estudiante");
            }
        }
    }
}
