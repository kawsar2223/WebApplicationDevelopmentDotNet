using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TaskRecordKeerApp.UI
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveCatagoryLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SaveCatagory.aspx");
           
        }

        protected void taskEntryLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TaskEntryUI.aspx");
        }

        protected void viwetaskLinkButton_Click(object sender, EventArgs e)
        {
             Response.Redirect("ViewTaskUI.aspx");
        }
    }
}