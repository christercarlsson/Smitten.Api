using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using Smitten.Api.Services;
using AutoMapper;
using Smitten.Api.Models;
using System.Collections.Generic;

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
            var peopleFromRepo = _repository.GetPeople();

            var people = Mapper.Map<IEnumerable<PersonDto>>(peopleFromRepo);
            return Ok(people);
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(Guid id)
        {
            var personFromRepo = _repository.GetPerson(id);
            if (personFromRepo == null)
            {
                return NotFound();
            }
            var person = Mapper.Map<PersonDto>(personFromRepo);
            return Ok(person);
        }

    }
}