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
    public partial class ViewCountriesUI : System.Web.UI.Page
    {
        CountryManager countryManager =new CountryManager();


    
        protected void Page_Load(object sender, EventArgs e)
        { 
                LoadAll();
            
           
        }
        private void LoadAll()
        {

            List<Country> countryList = countryManager.GetAllCountriesForViewCountries();
            countryEntryGridview.DataSource = countryList;


            countryEntryGridview.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string search = countryNameTextBox.Text;
            countryEntryGridview.DataSource = countryManager.GetBySearchCountries(search);
            countryEntryGridview.DataBind();
        }

       
        protected void countryEntryGridview_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
        {
           
            
            countryEntryGridview.PageIndex = e.NewPageIndex;
            string search = countryNameTextBox.Text;
            countryEntryGridview.DataSource = countryManager.GetBySearchCountries(search);
            countryEntryGridview.DataBind();
            
            
          
           
        }


        protected void backButtonHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}
