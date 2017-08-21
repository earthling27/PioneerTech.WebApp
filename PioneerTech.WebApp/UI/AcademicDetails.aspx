<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="AcademicDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.AcademicDetails" %>
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
            <td style="width: 223px">
                <asp:Label ID="CourseTypeLabel" runat="server" Text="Course Type"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CourseTypeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 223px">
                <asp:Label ID="GraduationDateLabel" runat="server" Text="Graduation Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="GraduationDateTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 223px">
                <asp:Label ID="CourseSpecializationLabel" runat="server" Text="Course Specialization"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CourseSpecializationTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
      <table style="width: 100%">
          <td>
              <asp:Button ID="AcademicDetailsSaveButton" runat="server" Text="Save" OnClick="AcademicDetailsSaveButton_Click" />
          </td>
          <td>
              <asp:Button ID="AcademicDetailsEditButton" runat="server" Text="Edit" OnClick="AcademicDetailsEditButton_Click" />
          </td>
          <td>
              <asp:Button ID="AcademicDetailsClearButton" runat="server" Text="Clear" OnClick="AcademicDetailsClearButton_Click" />
          </td>
          </table>
</asp:Content>
