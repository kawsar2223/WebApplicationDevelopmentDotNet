using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp.UI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addLinkButton_Click(object sender, EventArgs e)
        {
         Response.Redirect("addIndexUI.aspx");
        }

        protected void showLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("showIndexUI.aspx");
        }
    }
}