using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityCountryRoughApp.DAL;
using CityCountryRoughApp.Models;

namespace CityCountryRoughApp.BLL
{
    public class CityManager
    {

           CityGateway cityGateway = new CityGateway();
           CountryGateway countryGateway =new CountryGateway();

        public string Save(City city)
        {
            bool isCityExists = IsCityExists(city);
            string message = "";
            if (isCityExists)
            {
                message = "City Already Exists ...!";
                return message;
            }

            int rowAffected = cityGateway.InsertCity(city);

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

        public bool IsCityExists(City aCity)
        {
           City city = cityGateway.GetCityByName(aCity.Name);
            if (city != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<CountryViewModel> GetAllcities()
        {
            List<CountryViewModel> citiList = cityGateway.GetAllCities();

            return citiList;
        }

        public List<Country> GetAllCountriesDropForViewCity()
        {
            List<Country> countries = cityGateway.GetAllCountriesDropForViewCity();
            return countries;
        }
        public List<City> GetAllCitiesForView()
        {
            List<City> cities = cityGateway.GetAllCitiesForView();
            return cities;
        }

        public List<City> GetSearchByCity( string name)
        {
            List<City> cities = cityGateway.GetSearchByCity(name);
            return cities;
        }

        public List<CountryViewModel> GetSearchByCountryForCityView(string name)
        {
            List<CountryViewModel> cityCountryViewModels =cityGateway.GetSearchByCountryForCityView(name);
            return cityCountryViewModels;
        }
    }

    }
