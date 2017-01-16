<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveCatagory.aspx.cs" Inherits="TaskRecordKeerApp.UI.SaveCatagory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <fieldset>
            <legend>Save Catagery</legend>
            <table>
                
                <tr>
                    <td>Name</td>
                    <td> <asp:TextBox ID="catageryNameTextBox" runat="server"></asp:TextBox> </td>
                    
                   
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" Height="26px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="savemassegLabel" runat="server" Text=""></asp:Label></td>
                </tr>

            </table>
            

        </fieldset>

    <div>
    
        <asp:HyperLink runat="server" NavigateUrl="~/UI/IndexUI.aspx">BACK</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
