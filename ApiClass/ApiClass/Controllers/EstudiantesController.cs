using Microsoft.AspNetCore.Mvc;

namespace ApiClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        // GET: api/<EstudiantesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EstudiantesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EstudiantesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EstudiantesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EstudiantesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
