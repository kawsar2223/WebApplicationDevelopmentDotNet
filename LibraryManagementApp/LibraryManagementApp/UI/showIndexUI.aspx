<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showIndexUI.aspx.cs" Inherits="LibraryManagementApp.UI.showIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Show Book</legend>
    <div>
    <table>
        <tr>
            <td>Name</td>
            <td><asp:TextBox runat="server" ID="searchTextBox" Width="192px"></asp:TextBox><asp:Button runat="server" ID="searchButton" Text="Search" OnClick="searchButton_Click"/></td>
        </tr>
       <tr>
           <td colspan="2"><asp:Label runat="server" ID="messageLebel"> </asp:Label></td>
       </tr>
        
    </table>
        
    </div>
            <asp:GridView runat="server" ID="searchResultGridView" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateColumns="False">
                       <Columns>
                             <asp:TemplateField HeaderText="SL">
                               <ItemTemplate>
                                  <%#Container.DataItemIndex+1 %>
                               </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="ISBN Number">
                               <ItemTemplate>
                                   <asp:Label runat="server" Text='<%#Eval("Isbn") %>'>'></asp:Label>
                               </ItemTemplate>
                           </asp:TemplateField>
                           
                             <asp:TemplateField HeaderText="Book Name">
                               <ItemTemplate>
                                   <asp:Label runat="server" Text='<%#Eval("Name") %>'>'></asp:Label>
                               </ItemTemplate>
                           </asp:TemplateField>
                           
                             <asp:TemplateField HeaderText="Autor">
                               <ItemTemplate>
                                   <asp:Label runat="server" Text='<%#Eval("Author") %>'>'></asp:Label>
                               </ItemTemplate>
                           </asp:TemplateField>

                       </Columns>
                        
                         <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                
            </fieldset>
        <tr>
            <td><asp:Button runat="server" ID="homeButton" Text="Back" OnClick="backButton_Click"/></td>
        </tr>
    </form>
</body>
</html>
