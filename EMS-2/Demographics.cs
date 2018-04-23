using System;
using System.Collections.Generic;
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
        public Demographics(UI form)
        {
            // constructor does nothing
            ui = form;
        }


        public void PatientDataValidation()
        {
            string msg = "";
            bool HoH = true;
            bool AllClear = true;

            // get all the strings from input fields
            string HCN = ui.Field_HCN.Text;
            string LastName = ui.Field_LastName.Text;
            string FirstName = ui.Field_FirstName.Text;
            string mInitial = ui.Field_mInitial.Text;
            string DOB = ui.Field_DOB.Text;
            string sex = ui.Field_Sex.Text;
            string HeadOfHouse = ui.Field_HeadOfHouse.Text;
            string AddressL1 = ui.Field_AL1.Text;
            string AddressL2 = ui.Field_AL2.Text;
            string City = ui.Field_City.Text;
            string Province = ui.Field_Province.Text;
            string Phone = ui.Field_Phone.Text;

            // validate HCN
            // ------------- create and call hcn validation class -----------
            msg = IsNotBlank(HCN, false);
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
                //MessageBox.Show("blank hoh");
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


            if (AllClear)
                MessageBox.Show("All Clear");



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



        public static bool ValidatePhone(string phoneNum, bool HoH_Flag)
        {
            // since phone number is optional mandatory, it's valid to be empty
            if (phoneNum == "" && HoH_Flag)
            {
                return true;
            }

            return Regex.Match(phoneNum, @"^[0-9]{10}$").Success;
        }

        public string IsNotBlank(string str, bool NumberAllowed)
        {
            string msg = "";

            // check is string i blank and set flag to false if it is
            if (str.Equals(""))
            {
                msg = "Field cannot be blank";
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



    }
}
