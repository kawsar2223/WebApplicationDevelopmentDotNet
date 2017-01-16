<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTaskUI.aspx.cs" Inherits="TaskRecordKeerApp.UI.ViewTaskUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div id="viewTaskPage">
        <fieldset>
            <legend>Search</legend>
        
        <asp:Label runat="server" Text="Date"></asp:Label>
            <asp:DropDownList ID="dateDropDownList" runat="server" Width="157px"></asp:DropDownList>
        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
        <asp:GridView ID="viewTaskGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" Caption="Task Report" CellPadding="4">
            <Columns>
                <asp:TemplateField HeaderText="SL#">
                    <ItemTemplate>
                        <%#Container.DisplayIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Start Time">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("StartTime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="End time">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("EndTime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
            <asp:HiddenField runat="server" ID="tasksIdHiddenField" Value='<%#Eval("Id") %>'/>
        <asp:HyperLink runat="server" NavigateUrl="~/UI/TaskEntryUI.aspx">Back</asp:HyperLink>
            </fieldset>
    </div>

    <div>
    
    </div>
    </form>
</body>
</html>
