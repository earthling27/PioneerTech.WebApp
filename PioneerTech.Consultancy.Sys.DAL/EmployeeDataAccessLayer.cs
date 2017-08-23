using PioneerTech.Consultancy.Sys.Model;
using PioneerTech.Consultancy.Sys.Model.Models;
using System.Data.SqlClient;
using System.Data;


namespace PioneerTech.Consultancy.DAL
{
    public class EmployeeDataAccessLayer
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private string storedProcedureName;
        public int AddtoPersonalDetails(PersonalDetailsModel p_detail)
        {
            SqlConnection sqlConnection = OpenConnection();
            sqlConnection.Open();
            storedProcedureName = "sp_addEmployeePersonalDetails";
            sqlCommand = createSqlCommand(sqlConnection, storedProcedureName);

            sqlCommand.Parameters.AddWithValue("@firstName", p_detail.FirstName);
            sqlCommand.Parameters.AddWithValue("@lastName", p_detail.LastName);
            sqlCommand.Parameters.AddWithValue("@emailID", p_detail.EmailID);
            sqlCommand.Parameters.AddWithValue("@mobileNumber", p_detail.Mobile);
            sqlCommand.Parameters.AddWithValue("@alternateMobileNumber", p_detail.Phone);
            sqlCommand.Parameters.AddWithValue("@Adress1", p_detail.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", p_detail.Address2);
            sqlCommand.Parameters.AddWithValue("@currentCountry", p_detail.CurrentCountry);
            sqlCommand.Parameters.AddWithValue("@homeCountry", p_detail.HomeCountry);
            sqlCommand.Parameters.AddWithValue("@zipCode", p_detail.ZipCode);
            //command.Parameters.AddWithValue("@employeeID", p_detail.EmployeeID);

            int result = sqlCommand.ExecuteNonQuery();

            closeConnection(sqlConnection);

            return result;


        }

        private SqlCommand createSqlCommand(SqlConnection sqlConnection,string storedProcedureName)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedureName;
            return sqlCommand;
        }

        private void closeConnection(SqlConnection sqlConnection)
           
        {
           sqlConnection.Dispose();
           sqlConnection.Close();
        }

        public int AddtoCompanyDetails(CompanyDetailsModel comp_details)
        {
            sqlConnection = OpenConnection();
            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO [Company Details] VALUES(" +
                       "'" + comp_details.EmployeeName + "','" + comp_details.Contact + "','" + comp_details.CompanyLocation + "','" +
                        comp_details.CompanyWebsite + "'," + comp_details.EmployeeID + ")", sqlConnection);




            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;


        }

        public int AddtoProjectDetails(ProjectDetailsModel proj_details)
        {
            sqlConnection = OpenConnection();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO ProjectDetails VALUES(" +
                       "'" + proj_details.ProjectName + "','" + proj_details.ClientName + "','" + proj_details.Location + "','" +
                        proj_details.Role + "'," + proj_details.EmployeeID + ")", sqlConnection);

            int result = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return result;


        }

        public int AddtoAcademicQualification(AcademicQualificationModel acad_qualification)
        {
            sqlConnection = OpenConnection();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO AcademicAchievements VALUES(" +
                       "'" + acad_qualification.CourseType + "','" + acad_qualification.GraduationDate + "','" + acad_qualification.Specialization +"',"+acad_qualification.EmployeeID+ ")", sqlConnection);

            int result = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return result;
        }

        public int AddtoTechnicalQualification(TechnicalQualificationModel tech_qualification)
        {

            sqlConnection = OpenConnection();
            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO TechnicalDetails VALUES(" +"'" + 
                       tech_qualification.UserInterface + "','" + 
                       tech_qualification.ProgrammingLanguage + "','" + 
                       tech_qualification.ORM_Technology + "','" + 
                       tech_qualification.Database + "'," + 
                       tech_qualification.EmployeeID+
                       "[WHERE EmployeeID IS NULL];"+")", sqlConnection);

         int result = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return result;
        }

        public int UpdateToPersonalDetails(PersonalDetailsModel p_detail)
        {
            sqlConnection = OpenConnection();

            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_editEmployeePersonalDetails";


            sqlCommand.Parameters.AddWithValue("@firstName", p_detail.FirstName);
            sqlCommand.Parameters.AddWithValue("@lastName", p_detail.LastName);
            sqlCommand.Parameters.AddWithValue("@emailID", p_detail.EmailID);
            sqlCommand.Parameters.AddWithValue("@mobileNumber", p_detail.Mobile);
            sqlCommand.Parameters.AddWithValue("@alternateMobileNumber", p_detail.Phone);
            sqlCommand.Parameters.AddWithValue("@Adress1", p_detail.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", p_detail.Address2);
            sqlCommand.Parameters.AddWithValue("@currentCountry", p_detail.CurrentCountry);
            sqlCommand.Parameters.AddWithValue("@homeCountry", p_detail.HomeCountry);
            sqlCommand.Parameters.AddWithValue("@zipCode", p_detail.ZipCode);
            sqlCommand.Parameters.AddWithValue("@employeeID", p_detail.EmployeeID);

            int result = sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();

            return result;
        }

        private  SqlConnection OpenConnection()
        {
            sqlConnection = new SqlConnection("Data Source=EARTHLING;" +
           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
           "Integrated Security=true");

            
            return sqlConnection;
        }

        public int UpdateToProjectDetails(ProjectDetailsModel proj_details)
        {
            sqlConnection = OpenConnection();

            sqlConnection.Open();
            sqlCommand= new SqlCommand("INSERT INTO ProjectDetails VALUES(" +
                       "'" + proj_details.ProjectName + "','" + proj_details.ClientName + "','" + proj_details.Location + "','" +
                        proj_details.Role + "'," + proj_details.EmployeeID + ")", sqlConnection);

            int result = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return result;
        }

        public int UpdateToCompanyDetails(CompanyDetailsModel comp_details)
        {
             sqlConnection = OpenConnection();
            sqlConnection.Open();
             sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "UPDATE [Company Details] SET [EmployeeName] = @employeeName, [ContactNumber] = @contactNumber,[CompanyLocation] = @companyLocation," +
                "[Website] =@websiteAddress WHERE [EmployeeID] = @employeeID";


            sqlCommand.Parameters.AddWithValue("@employeeName", comp_details.EmployeeName);
            sqlCommand.Parameters.AddWithValue("@contactNumber", comp_details.Contact);
            sqlCommand.Parameters.AddWithValue("@companyLocation", comp_details.CompanyLocation);
            sqlCommand.Parameters.AddWithValue("@websiteAddress", comp_details.CompanyWebsite);
            sqlCommand.Parameters.AddWithValue("@employeeID", comp_details.EmployeeID);
            
            

            int result = sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();

            return result;
        }

        public int UpdateTechnicalQualification(TechnicalQualificationModel tech_qualification)

        {
             sqlConnection = OpenConnection();

            sqlConnection.Open();
             sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "UPDATE TechnicalDetails SET " +
                "[UserInterface] = @UserInterface," +
                "[Programming Languages] = @ProgrammingLanguages," +
                "[ORM Technologies] = @OrmTechnologies," +
                "[DataBases] =@DataBases,";                                ;


            sqlCommand.Parameters.AddWithValue("@UserInterface", tech_qualification.UserInterface);
            sqlCommand.Parameters.AddWithValue("@ProgrammingLanguages", tech_qualification.ProgrammingLanguage);
            sqlCommand.Parameters.AddWithValue("@OrmTechnologies", tech_qualification.ORM_Technology);
            sqlCommand.Parameters.AddWithValue("@DataBases", tech_qualification.Database);
           

            int result = sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();

            return result;
        }

        public int UpdateAcademicQualification(AcademicQualificationModel acad_qualification)
        {

             sqlConnection = OpenConnection();

            sqlConnection.Open();
             sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "UPDATE AcademicAchievements SET " +
                "[CourseType] = @courseType," +
                "[GraduationDate] = @graduationDate," +
                "[CourseSpecialization] = @courseSpecialization,";


            sqlCommand.Parameters.AddWithValue("@courseType", acad_qualification.CourseType);
            sqlCommand.Parameters.AddWithValue("@graduationDate",acad_qualification.GraduationDate);
            sqlCommand.Parameters.AddWithValue("@courseSpecialization",  acad_qualification.Specialization);
            


            int result = sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();

            return result;
        }
    }
}


