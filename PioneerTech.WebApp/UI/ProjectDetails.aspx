<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.ProjectDetails" %>

<asp:Content ID="ProjectDetailsID" ContentPlaceHolderID="ContentPlaceHolder" runat="server">




    <table style="width:100%;">
        <tr>
            <td style="width: 71px" class="auto-style1">Project Name</td>
            <td style="width: 153px" colspan="2">
            <asp:TextBox ID="ProjectNameTextBox" runat="server"  Width="245px"></asp:TextBox>

        </tr>
        <tr>
            <td style="width: 71px" class="auto-style1">Client Name</td>
            <td style="width: 153px" colspan="2">
            <asp:TextBox ID="ClientNameTextBox" runat="server"  Width="245px"></asp:TextBox>

        </tr>
        <tr>
            <td style="width: 71px" class="auto-style1">Location</td>
            <td style="width: 153px" colspan="2">
            <asp:TextBox ID="LocationTextBox" runat="server"  Width="245px"></asp:TextBox>

        </tr>
        <tr>
            <td style="width: 71px" class="auto-style1">Employee ID</td>
            <td style="width: 153px" colspan="2">
            <asp:TextBox ID="ProjectDetailsEmployeeIDTextBox" runat="server"  Width="245px"></asp:TextBox>

        </tr>
        <tr>
                    <td class="auto-style1" style="width: 200px">
                        <asp:Button ID="ProjectDetails_SaveButtonID" runat="server" Text="Save" Width="72px" OnClick="ProjectDetails_SaveButtonID_Click" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="ProjectDetails_EditButtonID" runat="server" Text="Edit" Width="72px" />
                    </td>
                    <td class="auto-style1" style="width: 20px">
                        <asp:Button ID="ProjectDetails_ClearButtonID" runat="server"  Text="Clear" Width="72px" />
                    </td>
                </tr>
        </table>
     


</asp:Content>
