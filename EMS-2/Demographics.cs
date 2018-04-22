using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            MessageBox.Show(HCN + "\n" +
                LastName + "\n" +
                FirstName + "\n" +
                mInitial + "\n" +
                DOB + "\n" +
                sex + "\n" +
                HeadOfHouse + "\n" +
                AddressL1 + "\n" +
                AddressL2 + "\n" +
                City + "\n" +
                Province + "\n" +
                Phone + "\n" );
        }



    }
}
