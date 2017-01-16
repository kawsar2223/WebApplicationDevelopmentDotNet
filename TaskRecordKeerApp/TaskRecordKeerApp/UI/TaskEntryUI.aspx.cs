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
    public partial class TaskEntryUI : System.Web.UI.Page
    {
        CatagoryManager categoryManager = new CatagoryManager();
        TaskManager tasksManager = new TaskManager();


        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                LoadAllCategories();
                DateTime dateTime = DateTime.Now;
                dateTextBox.Text = dateTime.ToShortDateString();    
            }

        }

        private void LoadAllCategories()
        {
            List<Catagory> categories = categoryManager.GetAll();
            categoryDropDownList.DataSource = categories;
            categoryDropDownList.DataTextField = "Name";
            categoryDropDownList.DataValueField = "Id";
            categoryDropDownList.DataBind();
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
             string title = titleTextBox.Value;
            
            string startTime = Convert.ToDateTime(startTimeTextBox.Value).TimeOfDay.ToString();
            string endTime = Convert.ToDateTime(endTimeTextBox.Value).TimeOfDay.ToString();
            string date = Convert.ToDateTime(dateTextBox.Text).Date.ToShortDateString();
            int categoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);

            if (saveButton.Text == "Save")
            {
                TaskSalf taskSalf = new TaskSalf(title, startTime, endTime, date, categoryId);
                taskSalf.CategoryId = categoryId;
                
                string message = tasksManager.Save(taskSalf);
                messageLabel.Text = message;
            }

        }
    }
}