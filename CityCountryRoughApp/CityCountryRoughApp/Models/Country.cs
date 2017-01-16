using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCountryRoughApp.Models
{
    public class Country
    {
        //public Country(int id, string name, string about):""
        //{
        //    Id = id;
        //}



        public Country(string name, string about):this()
        {
            Name = name;
            About = about;
        }
        
       public Country()
        {
            
        }

        


        public string Name { get; set; }
        public string About { get; set; }

        public int Id { get; set; }

        public int NoOfCities { get; set; }

        public long NoOfDwellers { get; set; }
        public long TotalNoOfDwellers { get; set; }
    }
}