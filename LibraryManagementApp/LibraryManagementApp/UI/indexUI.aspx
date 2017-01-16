<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUI.aspx.cs" Inherits="LibraryManagementApp.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Index<br />
                <asp:LinkButton ID="addLinkButton" runat="server" OnClick="addLinkButton_Click">Add Book</asp:LinkButton>
                <br />
                <asp:LinkButton ID="showLinkButton" runat="server" OnClick="showLinkButton_Click">Show Book</asp:LinkButton>
            </legend>
    <div>
    <table>
     <tr>
         
     </tr>
    </table>
    </div>
            </fieldset>
    </form>
</body>
</html>
