using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        static List<Languages> listLanguages = new List<Languages>();
        // GET: api/<LanguagesController>
        [HttpGet]
        public List<Languages> GetLanguages()
        {
            if (listLanguages.Count == 0)
            {
                listLanguages.Add(new Languages { Id = 1, Name = "Java" });
                listLanguages.Add(new Languages { Id = 2, Name = ".NET" });
                listLanguages.Add(new Languages { Id = 3, Name = "NodeJS" });
                listLanguages.Add(new Languages { Id = 4, Name = "Advanced Vanilla JS" });
                listLanguages.Add(new Languages { Id = 5, Name = "React" });
                listLanguages.Add(new Languages { Id = 6, Name = "Angular" });
                listLanguages.Add(new Languages { Id = 7, Name = "Kotlin" });
            }
            return listLanguages;
        }
        // GET api/<LanguagesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LanguagesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LanguagesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LanguagesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
