using System;
using System.Collections.Generic;

namespace Smitten.Api.Models
{
    public class PersonDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Uri ImageUri { get; set; }
        //public ICollection<SmiteDto> Smites = new List<SmiteDto>();
        public int NumberOfSmites { get; set; }
    }
}