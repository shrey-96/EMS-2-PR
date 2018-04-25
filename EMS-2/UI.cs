using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EMS_2
{
    public partial class UI : Form
    {
        int inc_val = 5;
        DataAccess db;
        Demographics demographics;
        
        // initialize the components of the form
        public UI()
        {
            InitializeComponent();
            Field_DOB.MaxDate = DateTime.Today;
            
            //  demographics = new Demographics();

            Panel_Loading.BringToFront();
            LoadingLabel.Text = "EMS 2.0";
            timer1.Enabled = true;
            
        }

        // EMS load screen
        private void timer1_Tick(object sender, EventArgs e)
        {
            FakeBar.Increment(inc_val);
            FakeBar.Update();

            if(FakeBar.Value == 95)
            {
                inc_val = 1;
            }

            // go to main menu once the loading is done
            if (FakeBar.Value == 100)
            {
                Thread.Sleep(500);
                Panel_MainMenu.BringToFront();
                timer1.Enabled = false;
                db = new DataAccess();
                demographics = new Demographics(this, db);
            } 
        }

        // Add patient event
        private void Btn_AddPatient_Click(object sender, EventArgs e)
        {
            Panel_AddPatient.BringToFront();
            Btn_Submit_Update.Text = "Submit";
            
        }

        // Go to Main Menu (Home) panel
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            Panel_MainMenu.BringToFront();           
        }

        // Button on main patient data form
        private void Btn_Submit_Update_Click(object sender, EventArgs e)
        {
            // validate all the fields
            bool add_status = true;
            if(Btn_Submit_Update.Text == "Update")
            {
                add_status = false;
            }

            demographics.PatientDataValidation(add_status);
        }

        // update button on home page
        private void Btn_UpdatePatient_Click(object sender, EventArgs e)
        {
            Btn_Submit_Update.Text = "Update";
            Panel_LookForPatient.BringToFront();
        }

        // looking for using HCN string entered by the user
        private void Btn_LookupPatient_Click(object sender, EventArgs e)
        {

            // search patient, if found, go to update/add patient panel
            if (demographics.LookForPatient())
            {
                Panel_AddPatient.BringToFront();
                Field_HCN.ReadOnly = true;
            }
        }

        private void ClearAllFields()
        {
            Field_HCN.ReadOnly = false;
            Btn_Submit_Update.Visible = true;

            // clear all on patient form page
            Field_HCN.Clear();
            Field_LastName.Clear();
            Field_FirstName.Clear();
            Field_mInitial.Clear();
            Field_HeadOfHouse.Clear();
            Field_HeadOfHouse.Clear();
            Field_AL1.Clear();
            Field_AL2.Clear();
            Field_City.Clear();
            Field_Phone.Clear();

            // clear Textbox on panel that takes HCN to look patient up
            Box_HCN.Clear();


        }

        private void Btn_SearchPatient_Click(object sender, EventArgs e)
        {
            Panel_LookForPatient.BringToFront();
            Btn_Submit_Update.Visible = false;
        }

        // exit application
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to exit the application?", 
                "Confirm", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}