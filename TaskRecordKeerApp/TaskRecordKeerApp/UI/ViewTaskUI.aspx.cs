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
    public partial class ViewTaskUI : System.Web.UI.Page

    {
        TaskManager taskManager = new TaskManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowAllTaskses();
                LoadAllDate();
            }

        }

        private void LoadAllDate()
        {
            List<TaskSalf> taskses = taskManager.GetAllDate();
            dateDropDownList.DataSource = taskses;
            dateDropDownList.DataTextField = "Date";
            dateDropDownList.DataValueField = "Date";
            dateDropDownList.DataBind();
        }
        private void ShowAllTaskses()
        {
            List<TaskSalf> taskses = taskManager.GetAllTaskses();
            viewTaskGridView.DataSource = taskses;
            viewTaskGridView.DataBind();
        }


        protected void searchButton_Click(object sender, EventArgs e)
        {
            viewTaskGridView.DataSource = taskManager.ShowTaskses(dateDropDownList.SelectedValue);
            viewTaskGridView.DataBind();

        }
    }
}