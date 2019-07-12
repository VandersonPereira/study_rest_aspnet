using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookBusiness _bookBusiness;

        public BookController(IBookBusiness bookBusiness) => _bookBusiness = bookBusiness;

        // GET api/people
        [HttpGet()]
        public IActionResult GetAll() => Ok(_bookBusiness.FindAll());

        // GET api/people/5
        [HttpGet("{id}")]
        public IActionResult GetById(long id) => Ok(_bookBusiness.FindById(id));

        // POST api/people
        [HttpPost()]
        public IActionResult Post([FromBody]Book book) => new ObjectResult(_bookBusiness.Create(book));

        // PUT api/people
        [HttpPut()]
        public IActionResult Put([FromBody]Book book)
        {
            var retunrPersonToUpdate = _bookBusiness.Update(book);

            if (retunrPersonToUpdate != null)
                return new ObjectResult(retunrPersonToUpdate);

            return BadRequest("Pessoa não encontrada.");
        }
        // DELETE api/people/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }

    }
}