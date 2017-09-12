using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Smitten.Api.Entities
{
    public class Smite
    {
        [Key]
        public Guid Id { get; set; }
        public DateTimeOffset TimeOfSmite { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        public Guid PersonId { get; set; }
    }
}
