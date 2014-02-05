using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreLuxury.Business.Domain.Entities;

namespace ExploreLuxury.Presentation.ModelView
{
    public class CityCountries
    {
        public List<Country> Countries { get; set; }
        public City City { get; set; }
    }
}
