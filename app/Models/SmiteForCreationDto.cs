using System;
using System.ComponentModel.DataAnnotations;

namespace Smitten.Api.Models
{
    public class SmiteForCreationDto
    {
        [Required]
        public DateTimeOffset TimeOfSmite { get; set; }
    }
}