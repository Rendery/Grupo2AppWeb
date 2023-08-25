using Microsoft.AspNetCore.Mvc;
using WEB_Taller.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_Taller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : ControllerBase
    {
        // GET: api/<ComponentsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ComponentsController>/5
        [HttpGet("{id}")]
        public Components Get(int id)
        {
            Components componente=new Components();
            componente.Id = id;
            componente.Name = "name";
            componente.Description = "description";
            componente.Price = 8;
            return componente;
        }

        // POST api/<ComponentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComponentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComponentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
