using PioneerTech.Consultancy.Sys.Model;
using PioneerTech.Consultancy.Sys.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PioneerTech.Consultancy.DAL
{
    public class EmployeeDataAccessLayer
    {
        public int AddtoPersonalDetails(PersonalDetailsModel p_detail)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
           "Integrated Security=true");

            conn.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO PersonalDetails VALUES(" +
            //           "'" + p_detail.FirstName + "','" + p_detail.LastName + "','" + p_detail.EmailID + "'," +
            //            p_detail.Mobile + "," + p_detail.Phone + ",'" + p_detail.Address1 + "','" + p_detail.Address2 +
            //           "','" + p_detail.CurrentCountry + "','" + p_detail.HomeCountry + "'," + p_detail.ZipCode + ")", conn);

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_addEmployeePersonalDetails";
            command.Parameters.AddWithValue("@firstName", p_detail.FirstName);
            command.Parameters.AddWithValue("@lastName", p_detail.LastName);
            command.Parameters.AddWithValue("@emailID", p_detail.EmailID);
            command.Parameters.AddWithValue("@mobileNumber", p_detail.Mobile);
            command.Parameters.AddWithValue("@alternateMobileNumber", p_detail.Phone);
            command.Parameters.AddWithValue("@Adress1", p_detail.Address1);
            command.Parameters.AddWithValue("@Address2", p_detail.Address2);
            command.Parameters.AddWithValue("@currentCountry", p_detail.CurrentCountry);
            command.Parameters.AddWithValue("@homeCountry", p_detail.HomeCountry);
            command.Parameters.AddWithValue("@zipCode", p_detail.ZipCode);
            //command.Parameters.AddWithValue("@employeeID", p_detail.EmployeeID);

            int result = command.ExecuteNonQuery();


            conn.Close();

            return result;


        }

        public int AddtoCompanyDetails(CompanyDetailsModel comp_details)
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

        public int AddtoProjectDetails(ProjectDetailsModel proj_details)
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

        public int AddtoAcademicQualification(AcademicQualificationModel acad_qualification)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
               "Initial Catalog=EmployeeDataBaseManagementSystem;" +
               "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO AcademicAchievements VALUES(" +
                       "'" + acad_qualification.CourseType + "','" + acad_qualification.GraduationDate + "','" + acad_qualification.Specialization +"',"+acad_qualification.EmployeeID+ ")", conn);

            int result = command.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int AddtoTechnicalQualification(TechnicalQualificationModel tech_qualification)
        {

            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
               "Initial Catalog=EmployeeDataBaseManagementSystem;" +
               "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TechnicalDetails VALUES(" +"'" + 
                       tech_qualification.UserInterface + "','" + 
                       tech_qualification.ProgrammingLanguage + "','" + 
                       tech_qualification.ORM_Technology + "','" + 
                       tech_qualification.Database + "'," + 
                       tech_qualification.EmployeeID+
                       "[WHERE EmployeeID IS NULL];"+")", conn);

         int result = command.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int UpdateToPersonalDetails(PersonalDetailsModel p_detail)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
           "Integrated Security=true");

            conn.Open();
            //SqlCommand command = new SqlCommand("UPDATE PersonalDetails SET " +"First Name = "+
            //           "'" + p_detail.FirstName + "','" + "Last Name = " +p_detail.LastName + "','" + "EmailID = " +  p_detail.EmailID + "'," + "mobile Number = " +
            //            p_detail.Mobile + "," + "Alternate Mobile Number = " + p_detail.Phone + ",'" +
            //            " Address 1= " + p_detail.Address1 + "','" + "Address 2 = " + p_detail.Address2 +
            //           "','" + "Current Country = " + p_detail.CurrentCountry + "','" +
            //           "Home Country = " + p_detail.HomeCountry + "'," + "Zip Code = "  + p_detail.ZipCode + ")", conn);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_editEmployeePersonalDetails";
            //command.CommandText = "UPDATE PersonalDetails SET [First Name] = @firstName, [Last Name] = @lastName,[Email ID] = @emailID," +
            //    "[mobile Number] =@mobileNumber,[Alternate Mobile Number] = @alternateMobileNumber,[Address 1] = @Adress1,[Address 2] =@Address2,[Current Country] = @currentCountry,[Home Country] = @homeCountry,[ZipCode] =@zipCode WHERE EmployeeID = @employeeID";

            
            command.Parameters.AddWithValue("@firstName", p_detail.FirstName);
            command.Parameters.AddWithValue("@lastName", p_detail.LastName);
            command.Parameters.AddWithValue("@emailID", p_detail.EmailID);
            command.Parameters.AddWithValue("@mobileNumber", p_detail.Mobile);
            command.Parameters.AddWithValue("@alternateMobileNumber", p_detail.Phone);
            command.Parameters.AddWithValue("@Adress1", p_detail.Address1);
            command.Parameters.AddWithValue("@Address2", p_detail.Address2);
            command.Parameters.AddWithValue("@currentCountry", p_detail.CurrentCountry);
            command.Parameters.AddWithValue("@homeCountry", p_detail.HomeCountry);
            command.Parameters.AddWithValue("@zipCode", p_detail.ZipCode);
            command.Parameters.AddWithValue("@employeeID", p_detail.EmployeeID);

            int   result = command.ExecuteNonQuery();


            conn.Close();

            return result;
        }

        public int UpdateToProjectDetails(ProjectDetailsModel proj_details)
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

        public int UpdateToCompanyDetails(CompanyDetailsModel comp_details)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
             "Initial Catalog=EmployeeDataBaseManagementSystem;" +
             "Integrated Security=true");
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE [Company Details] SET [EmployeeName] = @employeeName, [ContactNumber] = @contactNumber,[CompanyLocation] = @companyLocation," +
                "[Website] =@websiteAddress WHERE [EmployeeID] = @employeeID";


            command.Parameters.AddWithValue("@employeeName", comp_details.EmployeeName);
            command.Parameters.AddWithValue("@contactNumber", comp_details.Contact);
            command.Parameters.AddWithValue("@companyLocation", comp_details.CompanyLocation);
            command.Parameters.AddWithValue("@websiteAddress", comp_details.CompanyWebsite);
            command.Parameters.AddWithValue("@employeeID", comp_details.EmployeeID);
            
            

            int result = command.ExecuteNonQuery();


            conn.Close();

            return result;
        }

        public int UpdateTechnicalQualification(TechnicalQualificationModel tech_qualification)

        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
                           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
                           "Integrated Security=true");

            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE TechnicalDetails SET " +
                "[UserInterface] = @UserInterface," +
                "[Programming Languages] = @ProgrammingLanguages," +
                "[ORM Technologies] = @OrmTechnologies," +
                "[DataBases] =@DataBases,";                                ;


            command.Parameters.AddWithValue("@UserInterface", tech_qualification.UserInterface);
            command.Parameters.AddWithValue("@ProgrammingLanguages", tech_qualification.ProgrammingLanguage);
            command.Parameters.AddWithValue("@OrmTechnologies", tech_qualification.ORM_Technology);
            command.Parameters.AddWithValue("@DataBases", tech_qualification.Database);
           

            int result = command.ExecuteNonQuery();


            conn.Close();

            return result;
        }

        public int UpdateAcademicQualification(AcademicQualificationModel acad_qualification)
        {

            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
                           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
                           "Integrated Security=true");

            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE AcademicAchievements SET " +
                "[CourseType] = @courseType," +
                "[GraduationDate] = @graduationDate," +
                "[CourseSpecialization] = @courseSpecialization,";


            command.Parameters.AddWithValue("@courseType", acad_qualification.CourseType);
            command.Parameters.AddWithValue("@graduationDate",acad_qualification.GraduationDate);
            command.Parameters.AddWithValue("@courseSpecialization",  acad_qualification.Specialization);
            


            int result = command.ExecuteNonQuery();


            conn.Close();

            return result;
        }
    }
        
}

