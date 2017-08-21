using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerTech.Consultancy.Sys.Model.Models;
    using PioneerTech.Consultancy.DAL;
using PioneerTech.Consultancy.Sys.Model;

namespace PioneerTech.WebApp.UI
{
    public partial class TechnicalDetals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TechnicalDetailsSaveButton_Click(object sender, EventArgs e)
        {
            TechnicalQualificationModel technical_details_save = new TechnicalQualificationModel()
            {

                UserInterface = UserInterfaceTextBox.Text,
                ProgrammingLanguage = ProgrammingLanguageTextBox.Text,
                ORM_Technology = OrmTechnologiesTextBox.Text,
                Database = DatabaseTextBox.Text

            };

            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.AddtoTechnicalQualification(technical_details_save);

        }

        protected void TechnicalDetailsEditButton_Click(object sender, EventArgs e)
        {
            TechnicalQualificationModel technical_details_edit = new TechnicalQualificationModel()
            {

                UserInterface = UserInterfaceTextBox.Text,
                ProgrammingLanguage = ProgrammingLanguageTextBox.Text,
                ORM_Technology = OrmTechnologiesTextBox.Text,
                Database = DatabaseTextBox.Text

            };

            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.UpdateTechnicalQualification(technical_details_edit);
        }

        protected void TechnicalDetailsClearButton_Click(object sender, EventArgs e)
        {
            UserInterfaceTextBox.Text = "";
            ProgrammingLanguageTextBox.Text = "";
            DatabaseTextBox.Text = "";
        }
    }
}