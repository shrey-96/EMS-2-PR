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

        public UI()
        {
            InitializeComponent();

          //  Panel_Loading.BringToFront();
            LoadingLabel.Text = "EMS 2.0";
           // timer1.Enabled = true;

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
            } 
        }

        private void Btn_AddPatient_Click(object sender, EventArgs e)
        {
            Panel_AddPatient.BringToFront();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Panel_MainMenu.BringToFront();           
        }
    }
}