using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class CandidatesController : ControllerBase
    {
        ICandidatesService _candidatesService;
        public CandidatesController(ICandidatesService candidatesService)
        {
            _candidatesService = candidatesService;
        }
        // GET: api/<CandidatesController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public async Task<string> Get()
        {
            var candidates = await _candidatesService.GetC();
            return candidates;

        }
        // GET api/<CandidatesController>/5
        [HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        public async Task<ActionResult<IEnumerable<Candidates>>> GetCandidates( int? Year, [FromQuery] int?[] Languages)
        {
            IEnumerable<Candidates> candidates = (List<Candidates>)await _candidatesService.GetCandidates(Year, Languages);
            if (candidates == null)
                return BadRequest();
            return Ok(candidates);
        }

        
    }
}
