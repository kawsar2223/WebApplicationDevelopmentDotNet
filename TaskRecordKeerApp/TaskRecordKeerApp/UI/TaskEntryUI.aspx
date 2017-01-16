<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskEntryUI.aspx.cs" Inherits="TaskRecordKeerApp.UI.TaskEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        
        <div class="taskEntryPage">
    
        <fieldset>
            <legend> Task Entry</legend>
        
        <table>
            <tbody>
                <tr>
                    <td>Title</td>
                    <td><input type="text" runat="server" id="titleTextBox" /></td>
                </tr> 
                <tr>
                    <td>Start time</td>
                    <td><input type="time" runat="server" id="startTimeTextBox"/></td>
                </tr>
                <tr>
                    <td>End Time</td>
                    <td><input type="time" runat="server" id="endTimeTextBox"/></td>
                </tr>
                <tr>
                    <td>Catagory</td>
                    <td>
                        <asp:DropDownList ID="categoryDropDownList" runat="server" width="100%"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Date</td>
                    <td>
                        <asp:TextBox ID="dateTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                        <input id="resetButton" type="reset" value="Reset" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Label runat="server" ID="messageLabel"></asp:Label></td>
                </tr>
                
            </tbody>
        </table>
        
       <asp:HyperLink runat="server" NavigateUrl="~/UI/ViewTaskUI.aspx">Search</asp:HyperLink>
            <asp:HyperLink runat="server" NavigateUrl="~/UI/IndexUI.aspx">BACK</asp:HyperLink>
       </fieldset>
    </div>

    <div>
    
    </div>
    </form>
</body>
</html>
