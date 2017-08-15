using PioneerTech.Consultancy.DAL;
using PioneerTech.Consultancy.Sys.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PioneerTech.WebApp.UI
{
    public partial class CompanyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CompanyWebSiteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CompanyContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CompanyDetails_EditButtonID_Click(object sender, EventArgs e)
        {

        }

        protected void CompanyDetails_AddCompanyButtonID_Click(object sender, EventArgs e)
        {
            CompanyDetailsModel comp_details = new CompanyDetailsModel
            {
                EmployeeName = CompanyNameTextBox.Text,
                Contact = Convert.ToInt64(CompanyContactTextBox.Text),
                CompanyLocation = CompanyLocationTextBox.Text,
                CompanyWebsite = CompanyWebSiteTextBox.Text,
                EmployeeID = Convert.ToInt16(CompanyEmployeeIDTextBox.Text)
            

            };
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.UpdateToCompanyDetails(comp_details);


        }

        protected void CompanyEmployeeIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CompanyLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}