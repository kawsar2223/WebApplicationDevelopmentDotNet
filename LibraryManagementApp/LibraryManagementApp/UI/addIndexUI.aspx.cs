using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementApp.BusinessLogicLayer;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.UI
{
    public partial class addIndex : System.Web.UI.Page
    {
       BookManeger bookManager = new BookManeger();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("indexUI.aspx");
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string isbn = isbnTextBox.Text;
            string author = authorTextBox.Text;
            Book book = new Book(name,isbn,author);
            if (isbnTextBox.Text.Length !=13)
            {
                messageLebel.Text = "Entre the 13 number ID..!";
                return;
            }
            string message = bookManager.Save(book);
            messageLebel.Text = message;
            //ShowAllBooks();
            
        }

        
    }
}