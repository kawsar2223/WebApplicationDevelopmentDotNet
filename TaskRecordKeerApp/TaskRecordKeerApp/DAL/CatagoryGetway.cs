using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using TaskRecordKeerApp.Model;

namespace TaskRecordKeerApp.DAL
{
    public class CatagoryGetway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["TasksConString"].ConnectionString;

        public int Insert(Catagory category)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Catagory(Name)VALUES('" + category.Name + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Catagory> GetAll()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Catagory";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Catagory> categories = new List<Catagory>();
            while (reader.Read())
            {
                Catagory category = new Catagory();
                category.Name = reader["Name"].ToString();
                category.Id = Convert.ToInt32(reader["Id"].ToString());
                categories.Add(category);
            }
            reader.Close();
            connection.Close();
            return categories;
        }
    }
}