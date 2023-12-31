﻿using Microsoft.AspNetCore.Mvc;
using WEB_Taller.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_Taller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            Client client = new Client();
            client.Id = id;
            client.Name = "Rendery";
            client.Description = "Frencuente 24/7";
            return client;
        }

        // POST api/<ClientController>
        [HttpPost]
        public StatusCodeResult Post([FromBody] Client client)
        {
            try
            {
                if (client.Name == "")
                    return StatusCode(400); // Client error (falla del usuario)

                return StatusCode(201); // Client succes (usuario ideal)
            }
            catch (Exception ex)
            {
                // Falla Guardada xD
                return StatusCode(500); // Server error (no eres tu, soy yo)
            }
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
