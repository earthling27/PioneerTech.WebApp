<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.CompanyDetails" %>

<asp:Content ID="CompanyDetailsID" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" style="width: 326px">Employee ID</td>
            <td colspan="2">
            <asp:TextBox ID="CompanyEmployeeIDTextBox" runat="server"  Width="245px" OnTextChanged="CompanyEmployeeIDTextBox_TextChanged"></asp:TextBox>

        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Name</td>
            <td colspan="2">
            <asp:TextBox ID="CompanyNameTextBox" runat="server"  Width="245px" OnTextChanged="CompanyNameTextBox_TextChanged"></asp:TextBox>

        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Contact</td>
            <td colspan="2">
            <asp:TextBox ID="CompanyContactTextBox" runat="server"  Width="245px" OnTextChanged="CompanyContactTextBox_TextChanged"></asp:TextBox>

        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Location</td>
            <td colspan="2">
            <asp:TextBox ID="CompanyLocationTextBox" runat="server"  Width="245px" OnTextChanged="CompanyLocationTextBox_TextChanged"></asp:TextBox>

        </tr>
        <tr>
            <td class="auto-style1" style="width: 326px">Website</td>
            <td colspan="2">
            <asp:TextBox ID="CompanyWebSiteTextBox" runat="server"  Width="245px" OnTextChanged="CompanyWebSiteTextBox_TextChanged"></asp:TextBox>

        </tr>
        <tr>
                    <td class="auto-style1" style="width: 200px">
                        <asp:Button ID="CompanyDetails_AddCompanyButtonID" runat="server" Text="Add Company" Width="144px" OnClick="CompanyDetails_AddCompanyButtonID_Click" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="CompanyDetails_EditButtonID" runat="server" Text="Edit" Width="72px" OnClick="CompanyDetails_EditButtonID_Click" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="CompanyDetails_ClearButtonID" runat="server"  Text="Clear" Width="72px" />
                    </td>
                </tr>
        </table>
    
</asp:Content>
