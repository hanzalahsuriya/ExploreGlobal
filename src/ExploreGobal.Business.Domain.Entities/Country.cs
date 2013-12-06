using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreGobal.Business.Domain.Entities
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
