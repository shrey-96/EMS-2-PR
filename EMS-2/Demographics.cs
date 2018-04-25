using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_2
{
    class Demographics
    {
        public UI ui;
        DataAccess db;

        public Demographics(UI form, DataAccess db_)
        {
            // constructor does nothing
            ui = form;
            db = db_;
        }


        public void PatientDataValidation()
        {
            string msg = "";
            bool HoH = true;
            string query = "";
            bool AllClear = true;

            // get all the strings from input fields
            string HCN = ui.Field_HCN.Text;
            string LastName = ui.Field_LastName.Text;
            string FirstName = ui.Field_FirstName.Text;
            string mInitial = ui.Field_mInitial.Text;
            string DOB = ui.Field_DOB.Value.Date.ToString("yyyy-MM-dd");
         //   MessageBox.Show(DOB);
            string sex = ui.Field_Sex.Text;
            string HeadOfHouse = ui.Field_HeadOfHouse.Text;
            string AddressL1 = ui.Field_AL1.Text;
            string AddressL2 = ui.Field_AL2.Text;
            string City = ui.Field_City.Text;
            string Province = ui.Field_Province.Text;
            string Phone = ui.Field_Phone.Text;

            // validate HCN
            // ------------- create and call hcn validation class -----------
            msg = ValidateHCN(HCN);            
            if (msg != "") AllClear = false; 
            Error(ui.Field_HCN, msg);

            // validate last name
            msg = IsNotBlank(LastName, false);
            if (msg != "") AllClear = false;
            Error(ui.Field_LastName, msg);

            // validate first name
            msg = IsNotBlank(FirstName, false);
            if (msg != "") AllClear = false;
            Error(ui.Field_FirstName, msg);

            if (HeadOfHouse == "")
            {
                // validate HCN and set the flag to false 
                HoH = false;
                Error(ui.Field_HeadOfHouse, msg);
                //MessageBox.Show("blank hoh");
            }

            if (HoH)
            {
                msg = ValidateHCN(HeadOfHouse);               

                if (msg == "")
                {
                    query = "SELECT HCN FROM Demographics where HCN = '" + HeadOfHouse + "'";
                    string result = db.GetColumnData(query, "HCN");
                    if(result == "")
                    {
                        msg = "Could not find Head of House in the database";
                        MessageBox.Show(msg);
                        AllClear = false;
                    }
                    Error(ui.Field_HeadOfHouse, msg);
                 //   return;
                }
                else
                {
                    Error(ui.Field_HeadOfHouse, msg);
                    AllClear = false;
                }
               
            }

            msg = IsNotBlank(sex, false);
            if (msg != "") AllClear = false;
            Error(ui.Field_Sex, msg);          

            
            msg = ConditionalValidations(AddressL1, HoH);
            if (msg != "") AllClear = false;
            Error(ui.Field_AL1, msg);

            msg = ConditionalValidations(AddressL2, HoH);
            if (msg != "") AllClear = false;
            Error(ui.Field_AL2, msg);

            msg = ConditionalValidations(City, HoH);
            if (msg != "") AllClear = false;
            Error(ui.Field_City, msg);

            msg = ConditionalValidations(Province, HoH);
            if (msg != "") AllClear = false;
            Error(ui.Field_Province, msg);

            if (!ValidatePhone(Phone, HoH))
            {
                ui.ep.SetError(ui.Field_Phone, "Invalid phone number");
                AllClear = false;
            }
            else
                ui.ep.SetError(ui.Field_Phone, "");

            
            if(AllClear)
            {
                query = "select HCN from Demographics where HCN = '" + HCN + "'";
                if(db.GetColumnData(query, "HCN") != "" )                    
                {
                    MessageBox.Show("A patient with same HCN already exist", "Error");
                    AllClear = false;
                }
            }


            // if Head of house is provided
            if(HoH && AllClear)
            {
                if (ui.Field_AL1.Text == "")
                {
                    query = "select addL1 from Demographics where HCN = '" + HeadOfHouse + "'";
                    ui.Field_AL1.Text = AddressL1 = db.GetColumnData(query, "addL1");
                }

                if (ui.Field_AL2.Text == "")
                {
                    query = "select addL2 from Demographics where HCN = '" + HeadOfHouse + "'";
                    ui.Field_AL2.Text = AddressL2 = db.GetColumnData(query, "addL2");
                }

                if (ui.Field_City.Text == "")
                {
                    query = "select city from Demographics where HCN = '" + HeadOfHouse + "'";
                    ui.Field_City.Text = City = db.GetColumnData(query, "city");
                }

                if (ui.Field_Province.Text == "")
                {
                    query = "select province from Demographics where HCN = '" + HeadOfHouse + "'";
                    ui.Field_Province.Text = Province = db.GetColumnData(query, "province");
                }

                if (ui.Field_Phone.Text == "")
                {
                    query = "select phone from Demographics where HCN = '" + HeadOfHouse + "'";
                    ui.Field_Phone.Text = Phone = db.GetColumnData(query, "phone");
                }

            }
            //-----------------------------------------------------------------
            // getting past this point means all the data has been validated

            if (AllClear)
            {
                MessageBox.Show("All Clear");
               db.Add_Update_Patient(
                   true, HCN, LastName, FirstName, mInitial, DOB, sex, 
                   HeadOfHouse, AddressL1, AddressL2,
                   City, Province, Phone);
                
            }



            // MessageBox.Show(HCN + "\n" +
            //     LastName + "\n" +
            //     FirstName + "\n" +
            //     mInitial + "\n" +
            //     DOB + "\n" +
            //     sex + "\n" +
            //     HeadOfHouse + "\n" +
            //     AddressL1 + "\n" +
            //     AddressL2 + "\n" +
            //     City + "\n" +
            //     Province + "\n" +
            //     Phone + "\n" );
        }




        public void LookForPatient()
        {
            string HCN = ui.Box_HCN.Text;
            string msg = ValidateHCN(HCN);

            if(msg == "")
            {

            }
        }

        public static bool ValidatePhone(string phoneNum, bool HoH_Flag)
        {
            // since phone number is optional mandatory, it's valid to be empty
            if (phoneNum == "" && HoH_Flag)
            {
                return true;
            }

            return Regex.Match(phoneNum, @"^[0-9]{10}$").Success;
        }

        // check if the string is not blank, also check for numbers based on bool paramater
        public string IsNotBlank(string str, bool NumberAllowed)
        {
            string msg = "";

            // check is string i blank and set flag to false if it is
            if (str.Equals(""))
            {
                msg = "Field cannot be blank";
                return msg;
            }

            if(SpecialCharCheck(str))
            {
                msg = "Field cannot contain special characters";
                return msg;
            }

            if (NumberAllowed == false)
            {
                // check if string contains any number, set flag to false if it does
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        msg = "This field can't contain numbers\n";
                        break;
                    }
                }
            }

            return msg;
        }

        // head of house based fields validation
        public string ConditionalValidations(string field, bool HoH_flag)
        {
            string msg = "";

            if (field == "" && HoH_flag)
                msg = "";
            else
                if (field == "" && HoH_flag == false)
                    msg = "Field is mandatory (if head of house is not entered)";
            else
                if (field == "" && HoH_flag == false)
                     msg = "";

            return msg;
        }

        // validate the hcn
        public static string ValidateHCN(string HCN)
        {
            
            bool flag = true;
            string msg = "";

            

            // make sure the length of HCN is 12
            if (HCN.Length != 12)
            {
                flag = false;
                msg = "Invalid HCN. Try again!";
                return msg;
            }

            // make sure that first 10 characters are numeric
            for (int i = 0; i < HCN.Length - 2; i++)
            {
                if (!char.IsDigit(HCN[i]))
                {
                    flag = false;
                }
            }

            // make sure that last two characters are letters
            for (int i = HCN.Length - 2; i < HCN.Length; i++)
            {
                if (!char.IsLetter(HCN[i]))
                {
                    flag = false;
                }
            }

            // print error if invalid
            if (!flag)
                msg = "Invalid HCN. Try again!n";

            return msg;
        }

        // show error
        private void Error(Control control, string msg)
        {
            try
            {
                ui.ep.SetError(control, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        // check for special characters
        public static bool SpecialCharCheck(string temp)
        {
            bool flag = true;
            Regex r = new Regex("^[a-zA-Z0-9]*$");

            if (r.IsMatch(temp))
                flag = false;

            return flag;
        }



    }
}
