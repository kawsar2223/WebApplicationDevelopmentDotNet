using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCountryRoughApp.Models
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string About { get; set; }

        public long NoOfDwellers { get; set; }

        public string Location { get; set; }

        public string Weather { get; set; }

        public string CountryName { get; set; }
        public string CountryAbout   { get; set; }
    }
}