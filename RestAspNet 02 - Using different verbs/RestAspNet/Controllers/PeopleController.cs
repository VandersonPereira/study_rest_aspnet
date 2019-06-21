using Microsoft.AspNetCore.Mvc;
using RestAspNet.Models;
using RestAspNet.Sevices;

namespace RestAspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPersonService _personService;

        public PeopleController(IPersonService personService) => _personService = personService;

        // GET api/person
        [HttpGet()]
        public IActionResult GetAll() => Ok(_personService.FindAll());

        // GET api/person/5
        [HttpGet("{id}")]
        public IActionResult GetById(long id) => Ok(_personService.FindById(id));

        // POST api/person
        [HttpPost()]
        public IActionResult Post([FromBody]Person person) => new ObjectResult(_personService.Create(person));

        // PUT api/person
        [HttpPut()]
        public IActionResult Put([FromBody]Person person) => new ObjectResult(_personService.Update(person));

        // DELET api/person/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
