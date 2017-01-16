using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.DataAccessLayer
{
    public class BookGetway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["LibraryManagementConString"].ConnectionString;
        public int Insert(Book book)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string quary = "INSERT INTO Book (Name,Isbn,Author) VALUES ('" + book.Name + "','" + book.Isbn + "','" + book.Author + "')";
            SqlCommand command = new SqlCommand(quary, connection);
            connection.Open();
            int rowAffacted = command.ExecuteNonQuery();
            connection.Close();
            return rowAffacted;
        }

        public Book GetBookByIsbn(string isbnNumber)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            String quary = "SELECT * FROM Book WHERE Isbn LIKE '%"+isbnNumber+"%'";
            SqlCommand command = new SqlCommand(quary, connection);
            connection.Open();
            //SqlDataReader reader = command.ExecuteReader();
            SqlDataReader reader = command.ExecuteReader();
            Book book = null;
            if (reader.Read())
            {
                book = new Book();
                book.Id = Convert.ToInt32(reader["Id"].ToString());
                book.Name = reader["Name"].ToString();
                book.Isbn = reader["Isbn"].ToString();
                book.Author = reader["Author"].ToString();
            }
            reader.Close();
            connection.Close();
            return book;
        }

        public List<Book> GetAllBook()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Book";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();

            List<Book> abook = new List<Book>();
       
            while (reader.Read())
            {
                Book book = new Book();
                
                book.Name = reader["Name"].ToString();
                book.Isbn = reader["Isbn"].ToString();
                book.Author = reader["Author"].ToString();
                abook.Add(book);
            }
            reader.Close();
            connection.Close();
            return abook;
        }

        public List<Book> SearchBook(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string quary = "SELECT * FROM Book WHERE Name LIKE '%" + name + "%'";
            SqlCommand command = new SqlCommand(quary, connection);
            connection.Open();
            List<Book> bookList = new List<Book>();
            SqlDataReader reader = command.ExecuteReader();
            Book book = null;
            while (reader.Read())
            {
                book = new Book();
                book.Id = Convert.ToInt32(reader["Id"].ToString());
                book.Name = reader["Name"].ToString();
                book.Isbn = reader["Isbn"].ToString();
                book.Author = reader["Author"].ToString();
                bookList.Add(book);
            }
            reader.Close();
            connection.Close();
            return bookList;
        }

    }
}