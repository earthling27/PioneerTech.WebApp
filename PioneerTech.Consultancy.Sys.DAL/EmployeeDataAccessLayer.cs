using PioneerTech.Consultancy.Sys.Model;
using PioneerTech.Consultancy.Sys.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PioneerTech.Consultancy.DAL
{
    public class EmployeeDataAccessLayer
    {
        public int InjectPersonalDetails(PersonalDetails p_detail)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
           "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO PersonalDetails VALUES(" +
                       "'" + p_detail.FirstName + "','" + p_detail.LastName + "','" + p_detail.EmailID + "'," +
                        p_detail.Mobile + "," + p_detail.Phone + ",'" + p_detail.Address1 + "','" + p_detail.Address2 +
                       "','" + p_detail.CurrentCountry + "','" + p_detail.HomeCountry + "'," + p_detail.ZipCode + ")", conn);
            int result = command.ExecuteNonQuery();


            conn.Close();

            return result;


        }

        public int InjectCompanyDetails(CompanyDetailsModel comp_details)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
             "Initial Catalog=EmployeeDataBaseManagementSystem;" +
             "Integrated Security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Company Details] VALUES(" +
                       "'" + comp_details.EmployeeName + "','" + comp_details.Contact + "','" + comp_details.CompanyLocation + "','" +
                        comp_details.CompanyWebsite + "'," + comp_details.EmployeeID + ")", conn);
            


            
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;


        }


        public int InjectProjectDetails(ProjectDetailsModel proj_details)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
                "Initial Catalog=EmployeeDataBaseManagementSystem;" +
                "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO ProjectDetails VALUES(" +
                       "'" + proj_details.ProjectName + "','" + proj_details.ClientName + "','" + proj_details.Location + "','" +
                        proj_details.Role + "'," + proj_details.EmployeeID + ")", conn);

            int result = command.ExecuteNonQuery();

            conn.Close();
            return result;


        }
        public int InjectAcademicQualification(AcademicQualificationModel acad_qualification)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
               "Initial Catalog=EmployeeDataBaseManagementSystem;" +
               "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO AcademicAchievements VALUES(" +
                       "'" + acad_qualification.CourseLevel + "','" + acad_qualification.Specialization + "','" + acad_qualification.GraduationDate + ")", conn);

            int result = command.ExecuteNonQuery();

            conn.Close();
            return result;
        }
        public int InjectTechnicalQualification(TechnicalQualificationModel tech_qualification)
        {

            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
               "Initial Catalog=EmployeeDataBaseManagementSystem;" +
               "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TechnicalDetails VALUES(" +
                       "'" + tech_qualification.UserInterface + "','" + tech_qualification.ProgrammingLanguage + "','" + tech_qualification.ORM_Technology+"','"+tech_qualification.Database+"'," + ")", conn);

            int result = command.ExecuteNonQuery();

            conn.Close();
            return result;
        }

    }
}
