using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCountryRoughApp.Models
{
    public class City
    {
        //public City(string name, string about, long noOfDwellers, string location, string weather)
        //{
        //    Name = name;
        //    About = about;
        //    NoOfDwellers = noOfDwellers;
        //    Location = location;
        //    Weather = weather;
        //}

       

        public City(string name, string about ,long noOfDwellers, string location, string weather): this(name)
        {

            About = about;
            NoOfDwellers = noOfDwellers;
            Location = location;
            Weather = weather;
        }
        public City(string name):this()
        {
            Name = name;
        }
        public City()
        {

        }

        public string Name { get; set; }

        public string About { get; set; }

        public long NoOfDwellers { get; set; }

        public string Location { get; set; }

        public string Weather { get; set; }

        public int CountryId  { get; set; }

        public int Id { get; set; }

        public string CountryName { get; set; }

        public string CountryAbout { get; set; } 

        

    }
}