using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreGobal.Business.Domain.Entities
{
    public class Address
    {
        public Guid Id { get; set; }

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Line5 { get; set; }

        public string Code { get; set; }

        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }

        public virtual City City { get; set; }
        public virtual  Country Country { get; set; }
    }
}
