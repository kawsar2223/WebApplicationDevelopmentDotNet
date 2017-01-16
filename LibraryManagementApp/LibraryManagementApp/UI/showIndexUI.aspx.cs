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
    public partial class showIndex : System.Web.UI.Page
    {
        BookManeger bookManager = new BookManeger();
        protected void Page_Load(object sender, EventArgs e)
        {

            ShowAllBooks();
        }

        private void ShowAllBooks()
        {
            List<Book> abookList = bookManager.GetAllBooks();
            searchResultGridView.DataSource = abookList;
            searchResultGridView.DataBind();
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("indexUI.aspx");
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            searchResultGridView.DataSource = bookManager.SearchBook(searchTextBox.Text);
            searchResultGridView.DataBind();

        }
    }
}