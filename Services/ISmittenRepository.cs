using Smitten.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smitten.Api.Services
{
    public interface ISmittenRepository
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(Guid personId);
        void AddPerson(Person person);
        void DeletePerson(Person person);
        void UpdatePerson(Person person);
        bool PersonExists(Guid personId);
        IEnumerable<Smite> GetSmitesForPerson(Guid personId);
        Smite GetSmiteForPerson(Guid personId, Guid smiteId);
        void AddSmiteForPerson(Guid personId, Smite smite);
        void UpdateSmiteForPerson(Smite smite);
        void DeleteSmite(Smite smite);
        bool Save();
    }
}
