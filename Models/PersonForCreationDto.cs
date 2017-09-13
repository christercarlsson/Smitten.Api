using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Smitten.Api.Models
{
    public class PersonForCreationDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ImageUri { get; set; }
        public ICollection<SmiteForCreationDto> Smites { get; set; } = new List<SmiteForCreationDto>();
    }
}