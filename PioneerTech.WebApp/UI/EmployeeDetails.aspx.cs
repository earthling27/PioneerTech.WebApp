using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerTech.Consultancy.Sys.Model.Models;
using PioneerTech.Consultancy.Sys.Model;
using PioneerTech.Consultancy.DAL;

namespace PioneerTech.WebApp.UI
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void EmployeeDetails_SaveButtonID_Click(object sender, EventArgs e)
        {


            PersonalDetailsModel personal_details = new PersonalDetailsModel()
            {
                FirstName = FirstNameTextbox.Text,
                LastName = LastNameTextbox.Text,
                EmailID = EmailIDTextBox.Text,
                Contact = ContactTextBox.Text,
                Mobile = Convert.ToInt32(MobileTextBox.Text),
                Phone = Convert.ToInt64(PhoneTextBox.Text),
                Address1 = Address1TextBox.Text,
                Address2 = Address2TextBox.Text,
                HomeCountry = HomeTextBox.Text,
                CurrentCountry = CurrentCountryTextBox.Text,
                ZipCode = Convert.ToInt32(ZipCodeTextBox.Text)



            };


            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.AddtoPersonalDetails(personal_details);


        }

        protected void EmployeeDetails_EditButtonID_Click(object sender, EventArgs e)
        {

            PersonalDetailsModel personal_details = new PersonalDetailsModel()
            {
                FirstName = FirstNameTextbox.Text,
                LastName = LastNameTextbox.Text,
                EmailID = EmailIDTextBox.Text,
                Contact = ContactTextBox.Text,
                Mobile = Convert.ToInt32(MobileTextBox.Text),
                Phone = Convert.ToInt64(PhoneTextBox.Text),
                Address1 = Address1TextBox.Text,
                Address2 = Address2TextBox.Text,
                HomeCountry = HomeTextBox.Text,
                CurrentCountry = CurrentCountryTextBox.Text,
                ZipCode = Convert.ToInt32(ZipCodeTextBox.Text)



            };
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.UpdateToPersonalDetails(personal_details);
        }

        protected void LastNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EmailIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void MobileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Address1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Address2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void HomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CurrentCountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
    
