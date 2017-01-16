<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addIndexUI.aspx.cs" Inherits="LibraryManagementApp.UI.addIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Add Book</legend>
    <div>
    <table>
        <tr>
            <td>Name</td>
            <td><asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td>ISBN</td>
            <td><asp:TextBox runat="server" ID="isbnTextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Author</td>
            <td><asp:TextBox runat="server" ID="authorTextBox"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="saveButton" Text="Save" OnClick="saveButton_Click"/></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Label runat="server" ID="messageLebel"> </asp:Label></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="homeButton" Text="Back" OnClick="homeButton_Click"/></td>
        </tr>
    </table>
    </div>
            <asp:GridView runat="server" ID="showBookGridView" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateColumns="False">
                       <Columns>
                            
                             <asp:TemplateField HeaderText="Book Name">
                               <ItemTemplate>
                                   <asp:Label runat="server" Text='<%#Eval("Name") %>'>'></asp:Label>
                               </ItemTemplate>
                           </asp:TemplateField>
                           <asp:TemplateField HeaderText="ISBN Number">
                               <ItemTemplate>
                                   <asp:Label runat="server" Text='<%#Eval("Isbn") %>'>'></asp:Label>
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
    </form>
</body>
</html>
