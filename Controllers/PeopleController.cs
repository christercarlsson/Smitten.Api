using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using Smitten.Api.Services;

namespace Smitten.Api.Controllers
{
    [Route("api/people")]
    public class PeopleController : Controller
    {
        private ISmittenRepository _repository;

        public PeopleController(ISmittenRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(_repository.GetPeople());
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(Guid id)
        {
            var result = _repository.GetPerson(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}