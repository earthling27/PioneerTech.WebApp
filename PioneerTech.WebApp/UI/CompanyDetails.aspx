<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.CompanyDetails" %>

<asp:Content ID="CompanyDetailsID" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" style="width: 326px">Name</td>
            <td colspan="2">
                <input id="Company_NameID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Contact</td>
            <td colspan="2">
                <input id="Company_ContactID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Location</td>
            <td colspan="2">
                <input id="Company_LocationID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Website</td>
            <td colspan="2">
                <input id="Company_WebsiteID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Employee ID</td>
            <td colspan="2">
                <input id="Company_EmployeeIDID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
                    <td class="auto-style1" style="width: 200px">
                        <asp:Button ID="CompanyDetails_Save_ButtonID" runat="server" Text="Save" Width="72px" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="CompanyDetails_Edit_ButtonID" runat="server" Text="Edit" Width="72px" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="CompanyDetails_Clear_ButtonID" runat="server"  Text="Clear" Width="72px" />
                    </td>
                </tr>
        </table>
    
</asp:Content>
