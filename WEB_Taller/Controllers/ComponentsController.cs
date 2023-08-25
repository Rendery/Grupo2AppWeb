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
            componente.Price = 9.99;
            return componente;
        }

        // POST api/<ComponentsController>
        [HttpPost]
        public StatusCodeResult Post([FromBody] Components components)
        {
            try
            {
                if (components.Name == "")
                    return StatusCode(400); // Client error (falla del usuario)

                return StatusCode(201); // Client succes (usuario ideal)
            }
            catch (Exception ex)
            {
                // Falla Guardada xD
                return StatusCode(500); // Server error (no eres tu, soy yo)
            }
        }

        // PUT api/<ComponentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComponentsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                return Ok("User deleted successfully.");//Eliminado de la faz de la tierra
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing the request.");//F
            }
        }
    

        
    }
}
