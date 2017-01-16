using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaskRecordKeerApp.BLL;
using TaskRecordKeerApp.Model;

namespace TaskRecordKeerApp.UI
{
    public partial class SaveCatagory : System.Web.UI.Page
    {
        CatagoryManager catagoryManager = new CatagoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = catageryNameTextBox.Text;
              


            if (saveButton.Text == "Save")
            {
                Catagory category = new Catagory(name);
                string message = catagoryManager.Save(category);
                savemassegLabel.Text = message;
            }
        }
    }
}