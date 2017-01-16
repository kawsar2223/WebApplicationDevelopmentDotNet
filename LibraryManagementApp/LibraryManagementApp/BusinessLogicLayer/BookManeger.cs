using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementApp.DataAccessLayer;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.BusinessLogicLayer
{
    public class BookManeger
    {
        BookGetway bookGetway = new BookGetway();
        string message = "";
        public string Save(Book book)
        {

            bool isBookExist = IsBookExist(book);
            if (isBookExist)
            {
                message = "Alraday Exist";
                return message;
            }

            int rowAffacted = bookGetway.Insert(book);
            if (rowAffacted > 0)
            {
                message = "Book Saved";
            }
            else
            {
                message = "Not Saved Problem";
            }
            return message;
        }

        private bool IsBookExist(Book abook)
        {
            Book book = bookGetway.GetBookByIsbn(abook.Isbn);
            if (book != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> booklList = bookGetway.GetAllBook();
            return booklList;
        }

        public List<Book> SearchBook(string name)
        {

            return bookGetway.SearchBook(name);
        } 
    }
}