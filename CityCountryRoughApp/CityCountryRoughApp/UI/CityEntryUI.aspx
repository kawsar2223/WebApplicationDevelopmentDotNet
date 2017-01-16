﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntryUI.aspx.cs" Inherits="CityCountryRoughApp.UI.CityEntryUI" validateRequest="false" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="UTF-8">
    <title></title>
 
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_editor.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_style.css" rel="stylesheet" />
    <link href="../Content/style.css" rel="stylesheet" />

 
</head>
<body>
    
     <section>
    <form id="form1" runat="server">
        
       
              
              
          
      <fieldset>
          <legend> City Entry</legend>
          

    <div>
    <table>
        
         <tr>
                
                <td>Name</td>
                <td><asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox></td>

            </tr>
         <tr>
                
                <td>About</td>
                <td><textarea id="about" runat="server"></textarea></td>

            </tr>
         <tr>
                
                <td>No of dwellers</td>
                <td><asp:TextBox runat="server" ID="noOfDwellersTextBox"></asp:TextBox></td>

            </tr>
         <tr>
                
                <td>Location</td>
                <td><asp:TextBox runat="server" ID="locationTextBox"></asp:TextBox></td>

            </tr>
         <tr>
                
                <td>Weather</td>
                <td><asp:TextBox runat="server" ID="weatherTextBox"></asp:TextBox></td>

            </tr>
            
            <tr>        
                
                <td>Country</td>
                <td><asp:DropDownList runat="server" ID="countryDropdownList"/></td>
                <td><asp:Button runat="server" ID="saveButton" Text="Save" OnClick="saveButton_Click"/></td>
                <td><asp:Button runat="server" ID="cancelButton" Text="Cancel" OnClick="cancelButton_Click" style="height: 26px" CausesValidation="false" /></td>

            </tr>

          <tr>
                
                <td><asp:Label runat="server" ID="nameLabelHere" Font-Bold="True" ForeColor="Red" ></asp:Label></td>
            </tr>
    </table>

    </div>
        <asp:GridView runat="server" ID="cityEntryGridview" AutoGenerateColumns="False">
            <Columns>
                
            <asp:TemplateField HeaderText="SL#">
                <ItemTemplate>
                    <asp:Label runat="server" Text="<%#Container.DataItemIndex+1%>"></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Name">
                    
                    <ItemTemplate>
                     <asp:HiddenField runat="server" ID="countryIdHiddenField" Value='<%#Eval("Id") %>'/>
                     <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>   

                    </ItemTemplate>
                </asp:TemplateField >    
                <asp:TemplateField HeaderText="No Of dwellers">
                    <ItemTemplate>
                        
                   <asp:Label runat="server" Text='<%#Eval("NoOfDwellers") %>'></asp:Label>

                    </ItemTemplate>
               </asp:TemplateField>
                  <asp:TemplateField HeaderText="Country">
                    <ItemTemplate>
                        
                   <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>

                    </ItemTemplate>
               </asp:TemplateField>
           </Columns>
            
        </asp:GridView>
          
        </fieldset>
    </form>
              
         </section>
    
    
    
    
    
    
    
     <script src="../Scripts/t1codemirror.min.js"></script>
     <script src="../Scripts/jquery-2.2.0.js"></script>
    <script src="../froala_editor_1.2.7/js/froala_editor.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/tables.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/lists.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/colors.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/media_manager.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_family.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_size.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/video.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/block_styles.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/urls.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/file_upload.min.js"></script>

   
   
    

        <script>
            $(function () {
                $('#about').editable({ inlineMode: false, height: 300, alwaysBlank: true });
            });
  </script>

</body>
</html>
