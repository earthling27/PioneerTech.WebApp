using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerTech.Consultancy.Sys.Model.Models;
using PioneerTech.Consultancy.Sys.Model;

namespace PioneerTech.WebApp.UI
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void EmployeeDetails_SaveButtonID_Click(object sender, EventArgs e)
        {


            PersonalDetails personal_details = new PersonalDetails()
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
        }
    }
}

        
    
