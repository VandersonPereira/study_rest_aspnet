using Microsoft.AspNetCore.Mvc;
using RestAspNet.Models;
using RestAspNet.Business;

namespace RestAspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPersonBusiness _personBusiness;

        public PeopleController(IPersonBusiness personBusiness) => _personBusiness = personBusiness;

        // GET api/people
        [HttpGet()]
        public IActionResult GetAll() => Ok(_personBusiness.FindAll());

        // GET api/people/5
        [HttpGet("{id}")]
        public IActionResult GetById(long id) => Ok(_personBusiness.FindById(id));

        // POST api/people
        [HttpPost()]
        public IActionResult Post([FromBody]Person person) => new ObjectResult(_personBusiness.Create(person));

        // PUT api/people
        [HttpPut()]
        public IActionResult Put([FromBody]Person person)
        {
            var retunrPersonToUpdate = _personBusiness.Update(person);

            if(retunrPersonToUpdate != null)
                return new ObjectResult(retunrPersonToUpdate);

            return BadRequest("Pessoa não encontrada.");
        }
        // DELETE api/people/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
