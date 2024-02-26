using Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace docker_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        // GET: api/<MathController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MathController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            MathLib lib = new MathLib();
            return lib.Add(id, id).ToString();
        }

        // POST api/<MathController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MathController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MathController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
