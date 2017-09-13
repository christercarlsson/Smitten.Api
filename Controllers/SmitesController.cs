using Microsoft.AspNetCore.Mvc;
using Smitten.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Smitten.Api.Models;
using Smitten.Api.Entities;

namespace Smitten.Api.Controllers
{
    [Route("api/people/{personId}/smites")]
    public class SmitesController : Controller
    {
        private ISmittenRepository _repository;

        public SmitesController(ISmittenRepository repository)
        {
            _repository = repository;
        }

        [HttpGet()]
        public IActionResult GetSmitesForPerson(Guid personId)
        {
            if (!_repository.PersonExists(personId))
                return NotFound();
            var smitesFromRepo = _repository.GetSmitesForPerson(personId);

            var smitesForPerson = Mapper.Map<IEnumerable<SmiteDto>>(smitesFromRepo);
            return Ok(smitesForPerson);
        }

        [HttpGet("{smiteId}", Name = nameof(GetSmiteForPerson))]
        public IActionResult GetSmiteForPerson(Guid personId, Guid smiteId)
        {
            if (!_repository.PersonExists(personId))
                return NotFound();

            var smiteFromRepo = _repository.GetSmiteForPerson(personId, smiteId);
            if (smiteFromRepo == null)
                return NotFound();

            var smiteForPerson = Mapper.Map<SmiteDto>(smiteFromRepo);
            return Ok(smiteForPerson);
        }

        [HttpPost()]
        public IActionResult CreateSmiteForPerson(Guid personId, [FromBody]SmiteForCreationDto smite)
        {
            if (smite == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return new StatusCodeResult(422); // Fix this later...
            if (!_repository.PersonExists(personId))
                return NotFound();

            var smiteEntity = Mapper.Map<Smite>(smite);

            _repository.AddSmiteForPerson(personId, smiteEntity);

            if (!_repository.Save())
                throw new Exception($"Creating smite for person {personId} failed, try again later...");

            var smiteToReturn = Mapper.Map<SmiteDto>(smiteEntity);

            return CreatedAtRoute(
                nameof(GetSmiteForPerson),
                new
                {
                    personId = personId,
                    smiteId = smiteEntity.Id
                },
                smiteToReturn
            );
        }
    }
}
