<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetails" %>

<asp:Content ID="EmployeeDetailsID" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table style="width:100%;">
                <tr>
                    <td class="auto-style2" style="width: 233px">First Name</td>
                    <td class="auto-style3" colspan="2">
                        <input id="FirstNameID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Last Name</td>
                    <td colspan="2">
                        <input id="LastNameID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="height: 26px; width: 233px">Email ID</td>
                    <td style="height: 26px" colspan="2">
                        <input id="EmailID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Contact</td>
                    <td colspan="2">
                        <input id="ContactID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Mobile</td>
                    <td colspan="2">
                        <input id="MobileID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Phone</td>
                    <td colspan="2">
                        <input id="PhoneID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Address1</td>
                    <td colspan="2">
                        <input id="Address1ID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Address2</td>
                    <td colspan="2">
                        <input id="Address2ID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Home Country</td>
                    <td colspan="2">
                        <input id="HomeCountryID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Current Country</td>
                    <td colspan="2">
                        <input id="CurrentCountryID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 233px">Zip Code</td>
                    <td colspan="2">
                        <input id="ZipCodeID" style="width: 252px" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="width: 200px">
                        <asp:Button ID="Button1" runat="server" Text="Save" Width="72px" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="Button2" runat="server" Text="Edit" Width="72px" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="Button3" runat="server"  Text="Clear" Width="72px" />
                    </td>
                </tr>
                </table>
    
</asp:Content>
