<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetails" %>

<asp:Content ID="EmployeeDetailsID" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table style="width:100%;">
                <tr>
                    <td class="auto-style2" style="width: 233px">First Name</td>
                    <td class="auto-style3" colspan="2">
                        <asp:TextBox ID="FirstNameTextbox" runat="server"  Width="245px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Last Name</td>
                    <td colspan="2">
                        <asp:TextBox ID="LastNameTextbox" runat="server"  Width="245px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="height: 26px; width: 233px">Email ID</td>
                    <td style="height: 26px" colspan="2">
                       <asp:TextBox ID="EmailIDTextBox" runat="server"  Width="245px"></asp:TextBox>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Contact</td>
                    <td colspan="2">
                       <asp:TextBox ID="ContactTextBox" runat="server"  Width="245px"></asp:TextBox>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Mobile</td>
                    <td colspan="2">
                        <asp:TextBox ID="MobileTextBox" runat="server"  Width="245px"></asp:TextBox>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Phone</td>
                    <td colspan="2">
                        <asp:TextBox ID="PhoneTextBox" runat="server"  Width="245px"></asp:TextBox>
                        
                <tr>
                    <td class="auto-style1" style="width: 233px">Address1</td>
                    <td colspan="2">
                   <asp:TextBox ID="Address1TextBox" runat="server"  Width="245px"></asp:TextBox>

                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Address2</td>
                    <td colspan="2">
                    <asp:TextBox ID="Address2TextBox" runat="server"  Width="245px"></asp:TextBox>

                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Home Country</td>
                    <td colspan="2">
                    <asp:TextBox ID="HomeTextBox" runat="server"  Width="245px"></asp:TextBox>

                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Current Country</td>
                    <td colspan="2">
                    <asp:TextBox ID="CurrentCountryTextBox" runat="server"  Width="245px"></asp:TextBox>

                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Zip Code</td>
                    <td colspan="2">
                    <asp:TextBox ID="ZipCodeTextBox" runat="server"  Width="245px" OnTextChanged="ZipCodeTextBox_TextChanged"></asp:TextBox>

                </tr>
                <tr>
                    <td class="auto-style1" style="width: 200px">
                        <asp:Button ID="EmployeeDetails_SaveButtonID" runat="server" Text="Save" Width="72px" OnClick="EmployeeDetails_SaveButtonID_Click" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="EmployeeDetails_EditButtonID" runat="server" Text="Edit" Width="72px" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="EmployeeDetails_ClearButtonID" runat="server"  Text="Clear" Width="72px" />
                    </td>
                </tr>
                </table>
    
</asp:Content>
