<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="TaskRecordKeerApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <fieldset>
            <legend> Index</legend>
            <table>
            <tr>
                <td>
                <asp:LinkButton ID="SaveCatagoryLinkButton" runat="server" Width="200px" OnClick="SaveCatagoryLinkButton_Click" >Save Catagory</asp:LinkButton> <br/>
                </td>
                </tr>
            <tr>

            <td>
                 <asp:LinkButton ID="taskEntryLinkButton" runat="server" OnClick="taskEntryLinkButton_Click">Task Entry</asp:LinkButton> <br/>
            </td>  
                </tr>
            <tr>

            <td>
                <asp:LinkButton ID="viwetaskLinkButton" runat="server" OnClick="viwetaskLinkButton_Click">Viwe Task</asp:LinkButton>
            </td>
           </tr>
           </table>
            

        </fieldset>

    <div>
    
    </div>
    </form>
</body>
</html>
