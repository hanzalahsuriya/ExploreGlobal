using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExploreLuxury.Business.Domain.Entities
{
    public class Country
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
