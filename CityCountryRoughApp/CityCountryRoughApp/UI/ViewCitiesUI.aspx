<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCitiesUI.aspx.cs" Inherits="CityCountryRoughApp.UI.ViewCitiesUI" validateRequest="false" %>

<!DOCTYPE html>

<html >
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-2.2.0.js"></script>
    <link href="../Content/style.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css"  href="//cdn.datatables.net/1.10.10/css/jquery.dataTables.min.css"/>
    <script type="text/javascript" src="//cdn.datatables.net/1.10.10/js/jquery.dataTables.min.js"></script>
    
    
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_editor.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_style.css" rel="stylesheet" />
    <link href="../Content/style.css" rel="stylesheet" />
</head>
<body style="font-family: Arial">
    <form id="form1" runat="server">
        <fieldset>
            <legend > View Cities</legend>
    <div>
        <table>
             
            
            <tr>        
                
                
                <td class="auto-style1"><asp:RadioButton runat="server" Text="City Name" ID="cityNameRadioButton" GroupName="radioGroup"/></td>
                <td class="auto-style1"><asp:TextBox runat="server" ID="cityNameTextBox" Width="350px"></asp:TextBox></td>
                
               

            </tr>
            <tr>
            
                <td><asp:RadioButton runat="server" Text="Country" ID="countryNameRadioButton" GroupName="radioGroup"/></td>
                <td><asp:DropDownList runat="server" ID="countryNameDropdownList" Width="350px"/></td>
                <td><asp:Button runat="server" ID="searchButton" Text="Search" OnClick="searchButton_Click" /></td>    
            </tr>
            

    </table>

    </div>
             <asp:GridView runat="server" ID="cityEntryGridview" AutoGenerateColumns="False" AllowPaging="True"  PageSize="3" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="cityEntryGridview_SelectedIndexChanged">
            <Columns>
                
            <asp:TemplateField HeaderText="SL#">
                <ItemTemplate>
                    <asp:HiddenField runat="server" ID="cityIdHiddenField" Value='<%#Eval("Id") %>'/>
                    <asp:Label runat="server" Text="<%#Container.DataItemIndex+1%>"></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
                
                <asp:TemplateField HeaderText="City Name">
                    
                    <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>   

                    </ItemTemplate>
                </asp:TemplateField >    
            
                
                <asp:TemplateField HeaderText="About">
                    
                    <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("About") %>'></asp:Label>   

                    </ItemTemplate>
                </asp:TemplateField >    
                    <asp:TemplateField HeaderText="No Of dwellers">
                    <ItemTemplate>
                        
                   <asp:Label runat="server" Text='<%#Eval("NoOfDwellers") %>'></asp:Label>

                    </ItemTemplate>
               </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Location">
                    
                    <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("Location") %>'></asp:Label>   

                    </ItemTemplate>
                </asp:TemplateField >    
                
                <asp:TemplateField HeaderText="Weather">
                    
                    <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("Weather") %>'></asp:Label>   

                    </ItemTemplate>
                </asp:TemplateField >    
                  <asp:TemplateField HeaderText="Country">
                    <ItemTemplate>
                        
                   <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>

                    </ItemTemplate>
               </asp:TemplateField>
                 <asp:TemplateField HeaderText="About Country">
                    <ItemTemplate>
                        
                   <asp:Label runat="server" Text='<%#Eval("CountryAbout") %>'></asp:Label>

                    </ItemTemplate>
               </asp:TemplateField>
           </Columns>
            
        </asp:GridView>
            </fieldset>
    
      <script>


          $(document).ready(function () {
              $('#cityEntryGridview').DataTable();

              $(function () {
                  $('#about').editable({ inlineMode: false, height: 300, alwaysBlank: true });
              });
          });
          
 </script>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="backButton" runat="server" Text="Back To Home" OnClick="backButton_Click" />
    </form>
    
      </body>
</html>
