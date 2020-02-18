using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace RegistrationDemo
{
    public partial class Register : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=RegisterDB;Integrated Security=True";
            con.Open();
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            String MsgText = "";
            int rsltcount = 0;

            //First Name Validation
            if(FNameText.Text == "")
            {
                rsltcount += 1;
                MsgText += "First name field cannot be empty";
            }

            //Last Name Validation
            if (LNameText.Text == "")
            {
                rsltcount += 1;
                MsgText += "Last name field cannot be empty";
            }

            //Password Validation
            if (PasswordText.Text == "")
            {
                rsltcount += 1;
                MsgText += "Password field cannot be empty";
            }

            // Phone No Validation
            if (MobileText.Text == "")
            {
                rsltcount += 1;
                MsgText += "Phone number field cannot be empty";
            }
            bool mobileValStatus = VerifyNumericValue(MobileText.Text);
            if (mobileValStatus == false)
            {
                rsltcount += 1;
                MsgText += "Invalid mobile number or mobile number required.</br>";
            }
            if (mobileValStatus == true)
            {
                if (MobileText.Text.Length != 10)
                {
                    rsltcount += 1;
                    MsgText += "Check your entered mobile number.</br>";
                }
            }
            
            //Date Validation
            if (DateTextBox.Text == "")
            {
                rsltcount += 1;
                MsgText += "Date field cannot be empty";
            }

            //Email Validation
            if (EmailText.Text == "")
            {
                rsltcount += 1;
                MsgText += "Email field cannot be empty";
            }
            bool emailidValStatus = VerifyEmailID(EmailText.Text);
            if (emailidValStatus == false)
            {
                rsltcount += 1;
                MsgText += "Invalid email id or email id required.</br>";
            }


            //DataBase Commands
            SqlCommand cmd = new SqlCommand("insert into UserDatabase" + "(firstname,lastname,password,mobile,email,country,state,city,gender,stream,date)values(@firstname,@lastname,@password,@mobile,@email,@country,@state,@city,@gender,@stream,@date)", con);
            cmd.Parameters.AddWithValue("@firstname",FNameText.Text);
            cmd.Parameters.AddWithValue("@lastname", LNameText.Text);
            cmd.Parameters.AddWithValue("@password", PasswordText.Text);
            cmd.Parameters.AddWithValue("@mobile", MobileText.Text);
            cmd.Parameters.AddWithValue("@email", EmailText.Text);
            cmd.Parameters.AddWithValue("@country", CountryDropDownList.SelectedValue);
            cmd.Parameters.AddWithValue("@state", StateDropDownList.SelectedValue);
            cmd.Parameters.AddWithValue("@city", CityDropDownList.SelectedValue);
            cmd.Parameters.AddWithValue("@gender", GenderButtonList.SelectedValue);
            cmd.Parameters.AddWithValue("@stream", StreamCheckBoxList.SelectedValue);
            cmd.Parameters.AddWithValue("@date", DateTextBox.Text);

            cmd.ExecuteNonQuery();
            
        }

        //Function for Mobile Number verification
        public static bool VerifyNumericValue(string ValueToCheck)
        {
            Int32 numval;
            bool rslt = false;
            rslt = Int32.TryParse(ValueToCheck, out numval);
            return rslt;
        }

        //Function for Email Validation
        public static bool VerifyEmailID(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //Function to validate the CheckBox List
        protected void Stream_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int count = 0;
            for (int j = 0; j < StreamCheckBoxList.Items.Count; j++)
            {
                if (StreamCheckBoxList.Items[j].Selected == true)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                args.IsValid = false;
                CheckBoxRequired.ErrorMessage = "This field is required ";
            }
            else if (count > 1)
            {
                args.IsValid = false;
                CheckBoxRequired.ErrorMessage = "More than one Stream is choosen ";
            }
            else
            {
                args.IsValid = true;
            }
        }
        
        //Function to validate the Gender radio button
        protected void Gender_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int count = 0;
            for (int j = 0; j < GenderButtonList.Items.Count; j++)
            {
                if (GenderButtonList.Items[j].Selected == true)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                args.IsValid = false;
                RadioButtonvalidator.ErrorMessage = "This field is required ";
            }

            else
            {
                args.IsValid = true;
            }
        }
    }
}