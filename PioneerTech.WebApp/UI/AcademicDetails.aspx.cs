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
    public partial class AcademicDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AcademicDetailsSaveButton_Click(object sender, EventArgs e)
        {
            AcademicQualificationModel acad_qualification = new AcademicQualificationModel()
            {
                CourseType = CourseSpecializationTextBox.Text,
                Specialization = CourseSpecializationTextBox.Text,
                GraduationDate = GraduationDateTextBox.Text
            };

            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.AddtoAcademicQualification(acad_qualification);



        }

        protected void AcademicDetailsEditButton_Click(object sender, EventArgs e)
        {
            AcademicQualificationModel acad_qualification = new AcademicQualificationModel()
            {
                CourseType = CourseSpecializationTextBox.Text,
                Specialization = CourseSpecializationTextBox.Text,
                GraduationDate = GraduationDateTextBox.Text
            };

            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.UpdateAcademicQualification(acad_qualification);

        }

        protected void AcademicDetailsClearButton_Click(object sender, EventArgs e)
        {
            EmployeeIDTextBox.Text = "";
            CourseSpecializationTextBox.Text = "";
            CourseTypeTextBox.Text = "";
            GraduationDateTextBox.Text = "";
        }
    }
}