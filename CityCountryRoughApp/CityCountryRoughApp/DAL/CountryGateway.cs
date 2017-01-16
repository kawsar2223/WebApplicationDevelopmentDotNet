using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Xml.Linq;
using CityCountryRoughApp.Models;

namespace CityCountryRoughApp.DAL
{
    public class CountryGateway
    {

        string connectionString = WebConfigurationManager.ConnectionStrings["CountryCityDbConnString"].ConnectionString;

        public int InsertCountry(Country country)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = " INSERT INTO Countries (Name,About) VALUES(@name,@about)";
            
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = country.Name;
            command.Parameters.Add("about", SqlDbType.VarChar);
            command.Parameters["about"].Value = country.About;
            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowAffected;
        }

        public Country GetCountryByName(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = " SELECT * FROM COUNTRIES WHERE Name =@name";

            SqlCommand command = new SqlCommand(query, connection);    
            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = name;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Country country = null;
            if (reader.Read())
            {
                
               country = new Country();

                country.Id = Convert.ToInt32(reader["Id"].ToString());
                country.Name = reader["Name"].ToString();
                country.About = reader["About"].ToString();
                

            }
            

            reader.Close();
            connection.Close();

            return country;


        }

        public List<Country> GetAllCountriesOrdered()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = " SELECT * FROM COUNTRIES ORDER BY Name";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();


            List<Country> countries = new List<Country>();
   
            while (reader.Read())
            {

                Country country = new Country();

                country.Id = Convert.ToInt32(reader["Id"].ToString());
                country.Name = reader["Name"].ToString();
                country.About = reader["About"].ToString();
                countries.Add(country);
            }


            reader.Close();
            connection.Close();

            return countries;

        }
        public List<Country> GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = " SELECT * FROM COUNTRIES";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();


            List<Country> countries = new List<Country>();

            while (reader.Read())
            {

                Country country = new Country();

                country.Id = Convert.ToInt32(reader["Id"].ToString());
                country.Name = reader["Name"].ToString();
                country.About = reader["About"].ToString();
                //country.CountryId = reader["CountryId"].ToString();
                countries.Add(country);
            }


            reader.Close();
            connection.Close();

            return countries;

        }
        //public List<Country> GetAllCountryDropList()
        //{
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    string query = "SELECT Name FROM Countries";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    connection.Open();

        //    SqlDataReader reader = command.ExecuteReader();


        //    List<Country> countries = new List<Country>();

        //    while (reader.Read())
        //    {

        //        Country country = new Country();
        //        //country.Id = Convert.ToInt32(reader["Id"].ToString());
        //        country.Name = reader["Name"].ToString();

        //        countries.Add(country);
        //    }


        //    reader.Close();
        //    connection.Close();

        //    return countries;

        //}

        public List<Country> GetCountriesForView()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT co.Id , co.Name as [CountryName],co.About as [About],COUNT(ci.Id) as [NoOfCities] , ISNULL(SUM(ci.NoOfDwellers),0) as [TotalNoOfDwellers] FROM Countries  as co FULL OUTER Join  Cities as ci ON  co.Id =  ci.CountryId GROUP BY  co.Id,co.Name,co.About ORDER BY co.Name";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();


            List<Country> countries = new List<Country>();

            while (reader.Read())
            {

                Country country = new Country();

                country.Id = Convert.ToInt32(reader["Id"].ToString());
                country.Name = reader["CountryName"].ToString();
                country.About = HttpUtility.HtmlDecode(reader["About"].ToString());
                country.NoOfCities = Convert.ToInt32(reader["NoOfCities"].ToString());
               country.TotalNoOfDwellers = Convert.ToInt64(reader["TotalNoOfDwellers"]);
                countries.Add(country);
            }
           

            reader.Close();
            connection.Close();

            return countries;
        }
        public List<Country> GetCountrySearchList(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT co.Id , co.Name as [CountryName],co.About as [About],COUNT(ci.Id) as [NoOfCities]  , ISNULL(SUM(ci.NoOfDwellers),0) as [TotalNoOfDwellers] FROM Countries  as co FULL OUTER Join  Cities as ci ON  co.Id =  ci.CountryId WHERE  co.Name LIKE '%' + @name + '%' GROUP BY co.Id, co.Name,co.About ORDER BY co.Name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("@name", name);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            

            List<Country> countries = new List<Country>();

            while (reader.Read())
            {

                Country country = new Country();

                country.Id = Convert.ToInt32(reader["Id"].ToString());
                country.Name = reader["CountryName"].ToString();
                country.About = reader["About"].ToString();
                country.NoOfCities = Convert.ToInt32(reader["NoOfCities"].ToString());
               country.TotalNoOfDwellers = Convert.ToInt64(reader["TotalNoOfDwellers"].ToString());
                countries.Add(country);
            }
           

            reader.Close();
            connection.Close();

            return countries;

        }

       public Country GetCountryByNameforViewCity(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            string query = " SELECT * FROM COUNTRIES WHERE Name = @name";

            SqlCommand command = new SqlCommand(query, connection);    
            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = name;
            

            //string query = " SELECT * FROM COUNTRIES WHERE Name = '" + name + "' ";

            //SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Country country = null;
            if (reader.Read())
            {

                country = new Country();

                country.Id = Convert.ToInt32(reader["Id"].ToString());
                country.Name = reader["Name"].ToString();
                country.About = reader["About"].ToString();


            }


            reader.Close();
            connection.Close();

            return country;


        }

       



    }
}