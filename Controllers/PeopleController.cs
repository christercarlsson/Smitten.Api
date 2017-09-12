using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace Smitten.Api.Controllers
{
    [Route("api/people")]
    public class PeopleController : Controller
    {
        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(Models.SmittenDataObject.GetData.People);
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(Guid id)
        {
            var result = Models.SmittenDataObject.GetData.People.FirstOrDefault(p => p.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}