using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerTech.Consultancy.Sys.Model;
using PioneerTech.Consultancy.Sys.Model.Models;
using PioneerTech.Consultancy.DAL;

namespace PioneerTech.WebApp.UI
{
    public partial class ProjectDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProjectDetails_SaveButtonID_Click(object sender, EventArgs e)
        {
            ProjectDetailsModel proj_details = new ProjectDetailsModel
            {
                ProjectName = ProjectNameTextBox.Text,
                ClientName = ClientNameTextBox.Text,
                Location = LocationTextBox.Text,
                Role = "",
                EmployeeID = Convert.ToInt16(ProjectDetailsEmployeeIDTextBox.Text)
            };
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.AddtoProjectDetails(proj_details);



        }

        protected void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ClientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ProjectDetailsEmployeeIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}