using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drink.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace drink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<people> Get()
        {
            List<people> allPeopple = new List<people>()
            {
                new people() { id = 0, name = "Evelym", document = "123"},
                new people() { id = 1, name = "Evelym 1", document = "123"},
                new people() { id = 2, name = "Evelym 2", document = "123"},
                new people() { id = 3, name = "Evelym 3", document = "123"},
                new people() { id = 4, name = "Evelym 4", document = "123"},
                new people() { id = 5, name = "Evelym 5", document = "123"},
                new people() { id = 6, name = "Evelym 6", document = "123"}
            };
            return allPeopple;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
