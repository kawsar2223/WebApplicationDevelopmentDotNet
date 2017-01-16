using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CityCountryRoughApp.UI
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cityEntryButton_Click(object sender, EventArgs e)
        {
         
              Response.Redirect("CityEntryUI.aspx");

        }

        protected void countryEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CountryEntryUI.aspx");
        }

        protected void viewCitiesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCitiesUI.aspx");
        }

        protected void viewCountriesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCountriesUI.aspx");
        }
    }
}