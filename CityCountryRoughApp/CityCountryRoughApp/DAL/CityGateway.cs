using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CityCountryRoughApp.Models;

namespace CityCountryRoughApp.DAL
{
    public class CityGateway
    {

        string connectionString = WebConfigurationManager.ConnectionStrings["CountryCityDbConnString"].ConnectionString;

        public int InsertCity( City city)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Cities (Name,About,NoOfDwellers,Location,Weather,CountryId) VALUES(@name,@about,@noOfDwellers,@location,@weather,@countryId )";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = city.Name;

            command.Parameters.Add("about", SqlDbType.VarChar);
            command.Parameters["about"].Value = city.About;

            command.Parameters.Add("noOfDwellers", SqlDbType.BigInt);
            command.Parameters["noOfDwellers"].Value = city.NoOfDwellers;

            command.Parameters.Add("location", SqlDbType.VarChar);
            command.Parameters["location"].Value = city.Location;

            command.Parameters.Add("weather", SqlDbType.VarChar);
            command.Parameters["weather"].Value = city.Weather;

            command.Parameters.Add("countryId", SqlDbType.Int);
            command.Parameters["countryId"].Value = city.CountryId;
            
            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public City GetCityByName(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = " SELECT * FROM Cities WHERE Name = @name ";
   

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = name;

            connection.Open();
  
            SqlDataReader reader = command.ExecuteReader();

            City city = null;
            if (reader.Read())
            {

            
                city = new City();
                city.Id = Convert.ToInt32(reader["Id"].ToString());
                city.Name = reader["Name"].ToString();
                city.About = reader["About"].ToString();
                city.NoOfDwellers = Convert.ToInt64(reader["NoOfDwellers"].ToString());
                city.Location = reader["Location"].ToString();
                city.Weather = reader["Weather"].ToString();
                city.CountryId = Convert.ToInt32(reader["CountryId"].ToString());
             
            }


            reader.Close();
            connection.Close();

            return city;


        }
    
        public List<CountryViewModel> GetAllCities()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT ci.Id,ci.Name,ci.noOfDwellers,co.Name as CountryName From Cities as ci INNER JOIN Countries as co ON ci.CountryId = co.Id Order By ci.Name ";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<CountryViewModel> cityCountrylList = new List<CountryViewModel>();

            

            while (reader.Read())
            {



                CountryViewModel cityCountry = new CountryViewModel();
                cityCountry.Id = Convert.ToInt32(reader["Id"].ToString());
                cityCountry.Name = reader["Name"].ToString();
                cityCountry.NoOfDwellers = Convert.ToInt64(reader["NoOfDwellers"].ToString());
                cityCountry.CountryName = reader["CountryName"].ToString();


                cityCountrylList.Add(cityCountry);
            }


            reader.Close();
            connection.Close();

            return cityCountrylList;

        }
      
   
         public  List<City> GetAllCitiesForView()
       {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT ci.Id, ci.Name,ci.About,ci.noOfDwellers,ci.Location,ci.Weather, co.Name as CountryName , co.About as CountryAbout From Cities as ci LEFT OUTER Join Countries as co ON ci.CountryId = co.Id   ORDER BY CI.Name";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();


            List<City> cities = new List<City>();

            while (reader.Read())
            {

                City city =new City();

                city.Id = Convert.ToInt32(reader["Id"].ToString()); 
                city.Name = reader["Name"].ToString();
                city.About = HttpUtility.HtmlDecode(reader["About"].ToString());  
                city.NoOfDwellers = Convert.ToInt64(reader["NoOfDwellers"].ToString());
                city.Location = reader["Location"].ToString();
                city.Weather = reader["Weather"].ToString();
                city.CountryName = reader["CountryName"].ToString();
                city.CountryAbout = reader["CountryAbout"].ToString();
                cities.Add(city);
            }


            reader.Close();
            connection.Close();

            return cities;
       }


         public List<City> GetSearchByCity(string name)

            {
             SqlConnection connection = new SqlConnection(connectionString);

             string query = "SELECT ci.Id, ci.Name as [Name],ci.About as [About],ci.noOfDwellers as [NoOfDwellers],ci.Location as [Location],ci.Weather as [Weather], co.Name as [CountryName] , co.About as [CountryAbout] From Cities as ci LEFT OUTER Join Countries as co ON ci.CountryId = co.Id  WHERE  ci.Name like '%' + @name + '%' ORDER BY ci.Name";

             SqlCommand command = new SqlCommand(query, connection);
             command.Parameters.Clear();
             command.Parameters.Add("@name", name);
             connection.Open();

             SqlDataReader reader = command.ExecuteReader();

             List<City> cities = new List<City>();

             while (reader.Read())
             {

                 City city = new City();

                 city.Id = Convert.ToInt32(reader["Id"].ToString());
                 city.Name = reader["Name"].ToString();
                 city.About = HttpUtility.HtmlDecode(reader["About"].ToString());
                 city.NoOfDwellers = Convert.ToInt64(reader["NoOfDwellers"].ToString());
                 city.Location = reader["Location"].ToString();
                 city.Weather = reader["Weather"].ToString();
                 city.CountryName = reader["CountryName"].ToString();
                 city.CountryAbout = reader["CountryAbout"].ToString();
                 cities.Add(city);
             }

             reader.Close();
             connection.Close();
             return cities;
         }
         public List<CountryViewModel> GetSearchByCountryForCityView(string name)
         {
             SqlConnection connection = new SqlConnection(connectionString);
             string query = "SELECT ci.Id as[Id], ci.Name as[Name],ci.About as [About],ci.noOfDwellers as[noOfDwellers],ci.Location as [Location],ci.Weather as [Weather], co.Name as CountryName , co.About as CountryAbout From Cities as ci LEFT OUTER Join Countries as co ON ci.CountryId = co.Id  WHERE  co.Name like '%' + @name + '%' ORDER BY co.Name";

             SqlCommand command = new SqlCommand(query, connection);
             command.Parameters.Clear();
             command.Parameters.Add("@name", name);
             connection.Open();

             SqlDataReader reader = command.ExecuteReader();


             List<CountryViewModel> citiesCountryViewModels = new List<CountryViewModel>();

             while (reader.Read())
             {

                 CountryViewModel citiesCountryViewModel = new CountryViewModel();

                 citiesCountryViewModel.Id = Convert.ToInt32(reader["Id"].ToString());
                 citiesCountryViewModel.Name = reader["Name"].ToString();
                 citiesCountryViewModel.About = HttpUtility.HtmlDecode(reader["About"].ToString());
                 citiesCountryViewModel.NoOfDwellers = Convert.ToInt64(reader["NoOfDwellers"].ToString());
                 citiesCountryViewModel.Location = reader["Location"].ToString();
                 citiesCountryViewModel.Weather = reader["Weather"].ToString();
                 citiesCountryViewModel.CountryName = reader["CountryName"].ToString();
                 citiesCountryViewModel.CountryAbout = reader["CountryAbout"].ToString();
                 citiesCountryViewModels.Add(citiesCountryViewModel);
             }


             reader.Close();
             connection.Close();

             return citiesCountryViewModels;
         }
         public List<Country> GetAllCountriesDropForViewCity()
         {
             SqlConnection connection = new SqlConnection(connectionString);

             string query = " SELECT co.Id as Id,co.Name as CountryName,co.About as CountryAbout FROM COUNTRIES as co";

             SqlCommand command = new SqlCommand(query, connection);

             connection.Open();

             SqlDataReader reader = command.ExecuteReader();


             List<Country> countries = new List<Country>();

             while (reader.Read())
             {

                 Country country = new Country();
                 country.Id = Convert.ToInt32(reader["Id"].ToString());
                 country.Name = reader["CountryName"].ToString();
                 country.About = reader["CountryAbout"].ToString();
                 //country.CountryId = reader["CountryId"].ToString();
                 countries.Add(country);
             }


             reader.Close();
             connection.Close();

             return countries;

         }


    }
}