using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementApp.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public Book(int id, string name, string isbnNumber, string author): this(name, isbnNumber, author)
        {
            Id = id;
        }
        public Book(string name, string isbn, string author)
        {
            Name = name;
            Isbn = isbn;
            Author = author;
        }

        public Book()
        {

        }
        
    }
}