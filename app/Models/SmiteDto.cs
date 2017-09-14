using System;

namespace Smitten.Api.Models
{
    public class SmiteDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset TimeOfSmite { get; set; }
        public Guid PersonId { get; set; }
    }
}