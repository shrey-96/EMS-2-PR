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

        // add_status:  true -- if patient is being added
        //              false -- if patient is being updated
        public void PatientDataValidation(bool add_status)
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

            // check if everything is validated, and check for pre-existing string if and only if
            // new patient is being added. Don't check for pre-existence if patient is being updated
            if(AllClear && add_status)
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
                   add_status, HCN, LastName, FirstName, mInitial, DOB, sex, 
                   HeadOfHouse, AddressL1, AddressL2,
                   City, Province, Phone);
                
            }

            
        }




        public bool LookForPatient()
        {
            string HCN = ui.Box_HCN.Text;
            string msg = ValidateHCN(HCN);
            Error(ui.Box_HCN, msg);
            bool status = false;

            string result = "";
            string Table = "Demographics";

            try
            {
                if (msg == "")
                {
                    result = db.GetPatientData(Table, "HCN", HCN);
                    if (result == "")
                    {
                        MessageBox.Show("Could not find the patient. Try again.", "Error");
                        return status;
                    }

                    ui.Field_HCN.Text = result;
                    ui.Field_LastName.Text = db.GetPatientData(Table, "LastName", HCN);
                    ui.Field_FirstName.Text = db.GetPatientData(Table, "FirstName", HCN);
                    ui.Field_mInitial.Text = db.GetPatientData(Table, "mInitial", HCN);
                    ui.Field_DOB.Text = db.GetPatientData(Table, "DOB", HCN);
                    ui.Field_Sex.Text = db.GetPatientData(Table, "sex", HCN);
                    ui.Field_HeadOfHouse.Text = db.GetPatientData(Table, "HOH_HCN", HCN);
                    ui.Field_AL1.Text = db.GetPatientData(Table, "addL1", HCN);
                    ui.Field_AL2.Text = db.GetPatientData(Table, "addL2", HCN);
                    ui.Field_City.Text = db.GetPatientData(Table, "city", HCN);
                    ui.Field_Province.Text = db.GetPatientData(Table, "province", HCN);
                    ui.Field_Phone.Text = db.GetPatientData(Table, "Phone", HCN);

                    status = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while getting patient data from the database.\n " + ex.ToString(), "Error");
            }

            return status;
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
