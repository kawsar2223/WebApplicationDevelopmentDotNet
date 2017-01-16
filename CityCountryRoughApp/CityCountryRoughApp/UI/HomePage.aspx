<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="CityCountryRoughApp.UI.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/HomeCSS.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
         <fieldset>
          <legend> Home Page</legend>
    <div>
    
        <table>
            <tr>
                
                <td><asp:LinkButton runat="server" ID="cityEntryButton" Text="City Entry" OnClick="cityEntryButton_Click"></asp:LinkButton></td>

            </tr>
            <tr>
                
                <td><asp:LinkButton runat="server" ID="countryEntryButton" Text="Country Entry" OnClick="countryEntryButton_Click"></asp:LinkButton></td>

            </tr>
            <tr>
                
                <td><asp:LinkButton runat="server" ID="viewCitiesButton" Text="View Cities" OnClick="viewCitiesButton_Click"></asp:LinkButton></td>

            </tr>
            <tr>
                
                <td><asp:LinkButton runat="server" ID="viewCountriesButton" Text="View Countries" OnClick="viewCountriesButton_Click"></asp:LinkButton></td>

            </tr>
        </table>
    </div>
      </fieldset>
    </form>
</body>
</html>
