using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityCountryRoughApp.DAL;
using CityCountryRoughApp.Models;

namespace CityCountryRoughApp.BLL
{
    
    public class CountryManager
    {
        CountryGateway countryGateway = new CountryGateway();

        public string Save(Country country)
        {
            bool isCountryExists = IsCountryExists(country);
            string message = "";
            if (isCountryExists)
            {
                message = "Country Already Exists ...!";
                return message;
            }

            int rowAffected = countryGateway.InsertCountry(country);

            if (rowAffected>0)
            {
                message = "Saved Succesfully ...!";
            }
            else
            {
                message = "Insertion Failed";
            }

            return message;

        }

        public bool IsCountryExists(Country acountry)
        {
            Country country = countryGateway.GetCountryByName(acountry.Name);
            if (country != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Country> GetAllCountriesOrdered()
        {
            List<Country> countries = countryGateway.GetAllCountriesOrdered();

            return countries;
        }

        public List<Country> GetAllCountriesForViewCountries()
        {
            List<Country> countries = countryGateway.GetCountriesForView();
            return countries;
        }

        public List<Country> GetBySearchCountries(string name)
        {
            List<Country> countries = countryGateway.GetCountrySearchList(name);
            return countries;
        }

        
    }
}