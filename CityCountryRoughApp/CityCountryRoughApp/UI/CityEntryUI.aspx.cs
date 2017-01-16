using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityCountryRoughApp.BLL;
using CityCountryRoughApp.Models;

namespace CityCountryRoughApp.UI
{
    public partial class CityEntryUI : System.Web.UI.Page
    {
        CityManager cityManager = new CityManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                LoadAllCountries();
            }
            LoadCities();
            
        }


       public void LoadCities()
        {
              List<CountryViewModel> cities = cityManager.GetAllcities();

              cityEntryGridview.DataSource = cities;

              cityEntryGridview.DataBind();
        

        }

        private void LoadAllCountries()
        {
            List<Country> countries = cityManager.GetAllCountriesDropForViewCity();
            countryDropdownList.DataSource = countries;
            countryDropdownList.DataTextField = "Name";
            countryDropdownList.DataValueField = "Id";
            countryDropdownList.DataBind();
        }

          
        protected void saveButton_Click(object sender, EventArgs e)
        {

            long noOfDwellers = 0;
            string name = nameTextBox.Text;
            string about = Request.Form["about"];
            Int64.TryParse(noOfDwellersTextBox.Text,out noOfDwellers);
            string location = locationTextBox.Text;
            string weather = weatherTextBox.Text;
            int countryId = Convert.ToInt32(countryDropdownList.SelectedValue);


            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(about) || noOfDwellers == 0 || String.IsNullOrEmpty(location) || String.IsNullOrEmpty(weather))
            {
                nameLabelHere.Text = "Null Value Not Accepted";
            }
            else
            {
                

                 City city = new City(name, about, noOfDwellers, location, weather);
                 city.CountryId = countryId;
                 string message = cityManager.Save(city);
                 nameLabelHere.Text = message;
                 LoadCities();
             }
           

        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}