using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreLuxury.Business.Domain.Entities
{
    public class City
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
