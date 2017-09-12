using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Smitten.Api.Entities
{
    public class Person {
        [Key]
        public Guid Id {get;set;}
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string ImageUri { get; set; }
        public ICollection<Smite> Smites { get; set; }
            = new List<Smite>();
    }
}