using Microsoft.AspNetCore.Mvc;
using WEB_Taller.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_Taller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/<Category>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Category>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            Category category = new Category();
            category.id = id;
            category.name = "Name" + id.ToString();
            category.Count = 10;
            return category;
        }

        // POST api/<Category>
        [HttpPost]
        public StatusCodeResult Post([FromBody] Category category)
        {
            try
            {
                if (category.name == "")
                    return StatusCode(400); // Client error (falla del usuario)

                return StatusCode(201); // Client succes (usuario ideal)
            }
            catch (Exception ex)
            {
                // Falla Guardada xD
                return StatusCode(500); // Server error (no eres tu, soy yo)
            }
        }

        // PUT api/<Category>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Category>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
    }
}
