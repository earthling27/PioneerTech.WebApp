<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="TechnicalDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.TechnicalDetals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table style="width: 100%">
         <tr>
            <td style="width: 223px">
                <asp:Label ID="EmployeeIDLabel" runat="server" Text="Employee ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="EmployeeIDTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 221px">
                <asp:Label ID="UserInterfaceLabel" runat="server" Text="User Interface"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="UserInterfaceTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 221px">
                <asp:Label ID="ProgrammingLanguageLabel" runat="server" Text="Programming Language"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ProgrammingLanguageTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 221px">
                <asp:Label ID="OrmTechnologiesLabel" runat="server" Text="ORM Technologies"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="OrmTechnologiesTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 221px">
                <asp:Label ID="DatabaseLabel" runat="server" Text="Database"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="DatabaseTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
    <table style="width: 100%">
        <td> 
            <asp:Button ID="TechnicalDetailsSaveButton" runat="server" Text="Save" OnClick="TechnicalDetailsSaveButton_Click" />
        </td>
        <td> 
            <asp:Button ID="TechnicalDetailsEditButton" runat="server" Text="Edit" OnClick="TechnicalDetailsEditButton_Click" />
        </td>
        <td> 
            <asp:Button ID="TechnicalDetailsClearButton" runat="server" Text="Clear" OnClick="TechnicalDetailsClearButton_Click" />
        </td>
        </table>
</asp:Content>
