using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
using CityCountryRoughApp.BLL;
using CityCountryRoughApp.Models;

namespace CityCountryRoughApp.UI
{
    public partial class CountryEntryUI : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
                LoadCountries();
           

        }
        public void LoadCountries()
        {
            List<Country> countries = countryManager.GetAllCountriesOrdered();


            countryEntryGridview.DataSource = countries;

            countryEntryGridview.DataBind();

        }


        protected void saveButton_Click(object sender, EventArgs e)
        {


            string name = nameTextBox.Text;
            string about = Request.Form["about"];



            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(about))
            {
                nameLabelHere.Text = "Null Value Not Accepted";
            }
            else
            {

                Country country = new Country(name, about);
                nameLabelHere.Text = countryManager.Save(country);
                LoadCountries();
            }




        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}