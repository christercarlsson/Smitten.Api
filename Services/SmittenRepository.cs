using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smitten.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Smitten.Api.Services
{
    public class SmittenRepository : ISmittenRepository
    {
        private SmittenContext _context;

        public SmittenRepository(SmittenContext context)
        {
            _context = context;
        }
        public void AddPerson(Person person)
        {
            person.Id = Guid.NewGuid();
            _context.People.Add(person);

            if (person.Smites.Any())
            {
                foreach (var smite in person.Smites)
                {
                    smite.Id = Guid.NewGuid();
                }
            }
        }

        public void AddSmiteForPerson(Guid personId, Smite smite)
        {
            var person = GetPerson(personId);
            if (person != null)
            {
                if (smite.Id == null)
                    smite.Id = Guid.NewGuid();
            }
            person.Smites.Add(smite);
        }

        public void DeletePerson(Person person)
        {
            _context.People.Remove(person);
        }

        public void DeleteSmite(Smite smite)
        {
            _context.Smites.Remove(smite);
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People.Include(p => p.Smites);
        }

        public Person GetPerson(Guid personId)
        {
            return _context.People.FirstOrDefault(p => p.Id == personId);
        }

        public Smite GetSmiteForPerson(Guid personId, Guid smiteId)
        {
            return _context.Smites
                .Where(s => s.PersonId == personId && s.Id == smiteId)
                .FirstOrDefault();
        }

        public IEnumerable<Smite> GetSmitesForPerson(Guid personId)
        {
            return _context.Smites
                .Where(s => s.PersonId == personId)
                .OrderBy(s => s.TimeOfSmite)
                .ToList();
        }

        public bool PersonExists(Guid personId)
        {
            return _context.People.Any(p => p.Id == personId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePerson(Person person)
        {
            // Empty
        }

        public void UpdateSmiteForPerson(Smite smite)
        {
            // Empty
        }
    }
}
