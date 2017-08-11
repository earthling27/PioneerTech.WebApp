<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.ProjectDetails" %>

<asp:Content ID="ProjectDetailsID" ContentPlaceHolderID="ContentPlaceHolder" runat="server">




    <table style="width:100%;">
        <tr>
            <td style="width: 71px" class="auto-style1">Project Name</td>
            <td style="width: 153px" colspan="2">
                <input id="ProjectNameID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
            <td style="width: 71px" class="auto-style1">Client Name</td>
            <td style="width: 153px" colspan="2">
                <input id="ClientNameID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
            <td style="width: 71px" class="auto-style1">Location</td>
            <td style="width: 153px" colspan="2">
                <input id="LocationID" style="width: 252px" type="text" /></td>
        </tr>
        <tr>
            <td style="width: 71px" class="auto-style1">Employee ID</td>
            <td style="width: 153px" colspan="2">
                <input id="EmployeeIDID" style="width: 252px" type="text" /></td>
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
