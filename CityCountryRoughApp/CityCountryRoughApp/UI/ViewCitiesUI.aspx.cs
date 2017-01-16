using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityCountryRoughApp.BLL;
using CityCountryRoughApp.DAL;
using CityCountryRoughApp.Models;

namespace CityCountryRoughApp.UI
{
    public partial class ViewCitiesUI : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        CityManager cityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                LoadAllCountries();
            }
            LoadAll();
        }

        public void LoadAll()
        {
            List<City> citiesList = cityManager.GetAllCitiesForView();
            cityEntryGridview.DataSource = citiesList;


            cityEntryGridview.DataBind();
        }

        private void LoadAllCountries()
        {
            List<Country> countries = cityManager.GetAllCountriesDropForViewCity();
            countryNameDropdownList.DataSource = countries;
            countryNameDropdownList.DataTextField = "Name";
            countryNameDropdownList.DataValueField = "Id";
            countryNameDropdownList.DataBind();
        }
        protected void searchButton_Click(object sender, EventArgs e)
        {
           
            
             if (cityNameRadioButton.Checked == true)
            {
                  
                cityEntryGridview.DataSource = cityManager.GetSearchByCity(cityNameTextBox.Text);
                cityEntryGridview.DataBind();
                 
            }
            
            
            
             else if (countryNameRadioButton.Checked == true)
            {

                string country = countryNameDropdownList.SelectedItem.Text;
                //string country = Convert.ToInt32(countryNameDropdownList.SelectedValue).ToString();
                cityEntryGridview.DataSource = cityManager.GetSearchByCountryForCityView(country);
                cityEntryGridview.DataBind();

             
                
                
            }
        
        }

         

        protected void cityEntryGridview_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
        {

            if (cityNameRadioButton.Checked == true)
            {
                
                cityEntryGridview.DataSource = cityManager.GetSearchByCity(cityNameTextBox.Text);
                cityEntryGridview.PageIndex = e.NewPageIndex;
                cityEntryGridview.DataBind();

            }



            else if (countryNameRadioButton.Checked == true)
            {

                string country = countryNameDropdownList.SelectedItem.Text;
                
                //string country = Convert.ToInt32(countryNameDropdownList.SelectedValue).ToString();
                cityEntryGridview.DataSource = cityManager.GetSearchByCountryForCityView(country);
                cityEntryGridview.PageIndex = e.NewPageIndex;
                cityEntryGridview.DataBind();

            }
            else
            {
                cityEntryGridview.PageIndex = e.NewPageIndex;
                cityEntryGridview.DataBind();
                
            }

               

            
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}