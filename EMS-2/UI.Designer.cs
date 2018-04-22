namespace EMS_2
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.Panel_Loading = new System.Windows.Forms.Panel();
            this.FakeBar = new System.Windows.Forms.ProgressBar();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.Panel_MainMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_DisplayMB = new System.Windows.Forms.Button();
            this.Btn_BillableCode = new System.Windows.Forms.Button();
            this.Btn_UpdatePatient = new System.Windows.Forms.Button();
            this.Btn_ScheduleApt = new System.Windows.Forms.Button();
            this.Btn_GenerateMB = new System.Windows.Forms.Button();
            this.Btn_SearchPatient = new System.Windows.Forms.Button();
            this.Btn_AddPatient = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_AddPatient = new System.Windows.Forms.Panel();
            this.Field_City = new System.Windows.Forms.TextBox();
            this.Field_AL2 = new System.Windows.Forms.TextBox();
            this.Field_AL1 = new System.Windows.Forms.TextBox();
            this.Field_DOB = new System.Windows.Forms.DateTimePicker();
            this.Field_LastName = new System.Windows.Forms.TextBox();
            this.Field_Phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Field_Province = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Submit_Update = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Field_HeadOfHouse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Field_mInitial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Field_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Field_Sex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Field_HCN = new System.Windows.Forms.TextBox();
            this.Panel_Loading.SuspendLayout();
            this.Panel_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_AddPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Loading
            // 
            this.Panel_Loading.BackColor = System.Drawing.SystemColors.ControlText;
            this.Panel_Loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Loading.Controls.Add(this.FakeBar);
            this.Panel_Loading.Controls.Add(this.LoadingLabel);
            this.Panel_Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Loading.Location = new System.Drawing.Point(0, 0);
            this.Panel_Loading.Name = "Panel_Loading";
            this.Panel_Loading.Size = new System.Drawing.Size(1137, 651);
            this.Panel_Loading.TabIndex = 1;
            // 
            // FakeBar
            // 
            this.FakeBar.Location = new System.Drawing.Point(460, 338);
            this.FakeBar.Name = "FakeBar";
            this.FakeBar.Size = new System.Drawing.Size(224, 23);
            this.FakeBar.TabIndex = 1;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadingLabel.Location = new System.Drawing.Point(397, 214);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(350, 91);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "EMS 2.0";
            // 
            // Panel_MainMenu
            // 
            this.Panel_MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel_MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_MainMenu.Controls.Add(this.pictureBox1);
            this.Panel_MainMenu.Controls.Add(this.Btn_Exit);
            this.Panel_MainMenu.Controls.Add(this.Btn_DisplayMB);
            this.Panel_MainMenu.Controls.Add(this.Btn_BillableCode);
            this.Panel_MainMenu.Controls.Add(this.Btn_UpdatePatient);
            this.Panel_MainMenu.Controls.Add(this.Btn_ScheduleApt);
            this.Panel_MainMenu.Controls.Add(this.Btn_GenerateMB);
            this.Panel_MainMenu.Controls.Add(this.Btn_SearchPatient);
            this.Panel_MainMenu.Controls.Add(this.Btn_AddPatient);
            this.Panel_MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainMenu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_MainMenu.Name = "Panel_MainMenu";
            this.Panel_MainMenu.Size = new System.Drawing.Size(1137, 651);
            this.Panel_MainMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Exit.BackgroundImage")));
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Exit.Location = new System.Drawing.Point(767, 519);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(268, 70);
            this.Btn_Exit.TabIndex = 7;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Btn_DisplayMB
            // 
            this.Btn_DisplayMB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_DisplayMB.BackgroundImage")));
            this.Btn_DisplayMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DisplayMB.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DisplayMB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_DisplayMB.Location = new System.Drawing.Point(767, 396);
            this.Btn_DisplayMB.Name = "Btn_DisplayMB";
            this.Btn_DisplayMB.Size = new System.Drawing.Size(268, 68);
            this.Btn_DisplayMB.TabIndex = 6;
            this.Btn_DisplayMB.Text = "Display Monthly Billing";
            this.Btn_DisplayMB.UseVisualStyleBackColor = true;
            // 
            // Btn_BillableCode
            // 
            this.Btn_BillableCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BillableCode.BackgroundImage")));
            this.Btn_BillableCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BillableCode.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BillableCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BillableCode.Location = new System.Drawing.Point(144, 396);
            this.Btn_BillableCode.Name = "Btn_BillableCode";
            this.Btn_BillableCode.Size = new System.Drawing.Size(268, 68);
            this.Btn_BillableCode.TabIndex = 5;
            this.Btn_BillableCode.Text = "Give Billable Code";
            this.Btn_BillableCode.UseVisualStyleBackColor = true;
            // 
            // Btn_UpdatePatient
            // 
            this.Btn_UpdatePatient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_UpdatePatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_UpdatePatient.BackgroundImage")));
            this.Btn_UpdatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_UpdatePatient.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdatePatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_UpdatePatient.Location = new System.Drawing.Point(767, 151);
            this.Btn_UpdatePatient.Name = "Btn_UpdatePatient";
            this.Btn_UpdatePatient.Size = new System.Drawing.Size(268, 72);
            this.Btn_UpdatePatient.TabIndex = 4;
            this.Btn_UpdatePatient.Text = "Update Patient";
            this.Btn_UpdatePatient.UseVisualStyleBackColor = false;
            // 
            // Btn_ScheduleApt
            // 
            this.Btn_ScheduleApt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ScheduleApt.BackgroundImage")));
            this.Btn_ScheduleApt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ScheduleApt.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ScheduleApt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ScheduleApt.Location = new System.Drawing.Point(767, 273);
            this.Btn_ScheduleApt.Name = "Btn_ScheduleApt";
            this.Btn_ScheduleApt.Size = new System.Drawing.Size(268, 75);
            this.Btn_ScheduleApt.TabIndex = 3;
            this.Btn_ScheduleApt.Text = "Schedule Appointment";
            this.Btn_ScheduleApt.UseVisualStyleBackColor = true;
            // 
            // Btn_GenerateMB
            // 
            this.Btn_GenerateMB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_GenerateMB.BackgroundImage")));
            this.Btn_GenerateMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GenerateMB.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerateMB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_GenerateMB.Location = new System.Drawing.Point(144, 519);
            this.Btn_GenerateMB.Name = "Btn_GenerateMB";
            this.Btn_GenerateMB.Size = new System.Drawing.Size(268, 70);
            this.Btn_GenerateMB.TabIndex = 2;
            this.Btn_GenerateMB.Text = "Generate Monthly Billing";
            this.Btn_GenerateMB.UseVisualStyleBackColor = true;
            // 
            // Btn_SearchPatient
            // 
            this.Btn_SearchPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_SearchPatient.BackgroundImage")));
            this.Btn_SearchPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SearchPatient.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_SearchPatient.Location = new System.Drawing.Point(144, 273);
            this.Btn_SearchPatient.Name = "Btn_SearchPatient";
            this.Btn_SearchPatient.Size = new System.Drawing.Size(268, 75);
            this.Btn_SearchPatient.TabIndex = 1;
            this.Btn_SearchPatient.Text = "Search Patient";
            this.Btn_SearchPatient.UseVisualStyleBackColor = true;
            // 
            // Btn_AddPatient
            // 
            this.Btn_AddPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_AddPatient.BackgroundImage")));
            this.Btn_AddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddPatient.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_AddPatient.Location = new System.Drawing.Point(144, 151);
            this.Btn_AddPatient.Name = "Btn_AddPatient";
            this.Btn_AddPatient.Size = new System.Drawing.Size(268, 72);
            this.Btn_AddPatient.TabIndex = 0;
            this.Btn_AddPatient.Text = "Add Patient";
            this.Btn_AddPatient.UseVisualStyleBackColor = true;
            this.Btn_AddPatient.Click += new System.EventHandler(this.Btn_AddPatient_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel_AddPatient
            // 
            this.Panel_AddPatient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel_AddPatient.Controls.Add(this.Field_City);
            this.Panel_AddPatient.Controls.Add(this.Field_AL2);
            this.Panel_AddPatient.Controls.Add(this.Field_AL1);
            this.Panel_AddPatient.Controls.Add(this.Field_DOB);
            this.Panel_AddPatient.Controls.Add(this.Field_LastName);
            this.Panel_AddPatient.Controls.Add(this.Field_Phone);
            this.Panel_AddPatient.Controls.Add(this.label12);
            this.Panel_AddPatient.Controls.Add(this.Field_Province);
            this.Panel_AddPatient.Controls.Add(this.label10);
            this.Panel_AddPatient.Controls.Add(this.label11);
            this.Panel_AddPatient.Controls.Add(this.Btn_Submit_Update);
            this.Panel_AddPatient.Controls.Add(this.Btn_Home);
            this.Panel_AddPatient.Controls.Add(this.label9);
            this.Panel_AddPatient.Controls.Add(this.label8);
            this.Panel_AddPatient.Controls.Add(this.Field_HeadOfHouse);
            this.Panel_AddPatient.Controls.Add(this.label7);
            this.Panel_AddPatient.Controls.Add(this.label6);
            this.Panel_AddPatient.Controls.Add(this.label5);
            this.Panel_AddPatient.Controls.Add(this.Field_mInitial);
            this.Panel_AddPatient.Controls.Add(this.label4);
            this.Panel_AddPatient.Controls.Add(this.Field_FirstName);
            this.Panel_AddPatient.Controls.Add(this.label3);
            this.Panel_AddPatient.Controls.Add(this.label2);
            this.Panel_AddPatient.Controls.Add(this.Field_Sex);
            this.Panel_AddPatient.Controls.Add(this.label1);
            this.Panel_AddPatient.Controls.Add(this.Field_HCN);
            this.Panel_AddPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_AddPatient.Location = new System.Drawing.Point(0, 0);
            this.Panel_AddPatient.Name = "Panel_AddPatient";
            this.Panel_AddPatient.Size = new System.Drawing.Size(1137, 651);
            this.Panel_AddPatient.TabIndex = 9;
            // 
            // Field_City
            // 
            this.Field_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_City.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_City.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_City.Location = new System.Drawing.Point(413, 404);
            this.Field_City.Name = "Field_City";
            this.Field_City.Size = new System.Drawing.Size(308, 25);
            this.Field_City.TabIndex = 55;
            // 
            // Field_AL2
            // 
            this.Field_AL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_AL2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_AL2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_AL2.Location = new System.Drawing.Point(414, 358);
            this.Field_AL2.Name = "Field_AL2";
            this.Field_AL2.Size = new System.Drawing.Size(308, 25);
            this.Field_AL2.TabIndex = 54;
            // 
            // Field_AL1
            // 
            this.Field_AL1.AccessibleDescription = "";
            this.Field_AL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_AL1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_AL1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_AL1.Location = new System.Drawing.Point(414, 313);
            this.Field_AL1.Name = "Field_AL1";
            this.Field_AL1.Size = new System.Drawing.Size(308, 25);
            this.Field_AL1.TabIndex = 53;
            // 
            // Field_DOB
            // 
            this.Field_DOB.Location = new System.Drawing.Point(413, 186);
            this.Field_DOB.Name = "Field_DOB";
            this.Field_DOB.Size = new System.Drawing.Size(308, 22);
            this.Field_DOB.TabIndex = 52;
            // 
            // Field_LastName
            // 
            this.Field_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_LastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_LastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_LastName.Location = new System.Drawing.Point(413, 62);
            this.Field_LastName.Name = "Field_LastName";
            this.Field_LastName.Size = new System.Drawing.Size(308, 25);
            this.Field_LastName.TabIndex = 51;
            // 
            // Field_Phone
            // 
            this.Field_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_Phone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_Phone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_Phone.Location = new System.Drawing.Point(413, 493);
            this.Field_Phone.Name = "Field_Phone";
            this.Field_Phone.Size = new System.Drawing.Size(308, 25);
            this.Field_Phone.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.MenuText;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(329, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "Phone:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field_Province
            // 
            this.Field_Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Field_Province.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_Province.FormattingEnabled = true;
            this.Field_Province.Items.AddRange(new object[] {
            "Sportsworld",
            "Guelph Auto Mall",
            "Waterloo"});
            this.Field_Province.Location = new System.Drawing.Point(413, 450);
            this.Field_Province.Name = "Field_Province";
            this.Field_Province.Size = new System.Drawing.Size(308, 26);
            this.Field_Province.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.MenuText;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(311, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "Province:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.MenuText;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(339, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "City:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Submit_Update
            // 
            this.Btn_Submit_Update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Submit_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Submit_Update.BackgroundImage")));
            this.Btn_Submit_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Submit_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Submit_Update.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit_Update.Location = new System.Drawing.Point(351, 555);
            this.Btn_Submit_Update.Name = "Btn_Submit_Update";
            this.Btn_Submit_Update.Size = new System.Drawing.Size(445, 52);
            this.Btn_Submit_Update.TabIndex = 44;
            this.Btn_Submit_Update.Text = "Submit";
            this.Btn_Submit_Update.UseVisualStyleBackColor = false;
            this.Btn_Submit_Update.Click += new System.EventHandler(this.Btn_Submit_Update_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Home.BackgroundImage")));
            this.Btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Home.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Location = new System.Drawing.Point(12, 555);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(177, 52);
            this.Btn_Home.TabIndex = 43;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.MenuText;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(258, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Address Line 2:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuText;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(254, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Address Line 1:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field_HeadOfHouse
            // 
            this.Field_HeadOfHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_HeadOfHouse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_HeadOfHouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_HeadOfHouse.Location = new System.Drawing.Point(413, 268);
            this.Field_HeadOfHouse.Name = "Field_HeadOfHouse";
            this.Field_HeadOfHouse.Size = new System.Drawing.Size(308, 25);
            this.Field_HeadOfHouse.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.MenuText;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(258, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Head Of House:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuText;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(348, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sex:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.MenuText;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(268, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Date of Birth:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field_mInitial
            // 
            this.Field_mInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_mInitial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_mInitial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_mInitial.Location = new System.Drawing.Point(413, 145);
            this.Field_mInitial.Name = "Field_mInitial";
            this.Field_mInitial.Size = new System.Drawing.Size(308, 25);
            this.Field_mInitial.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuText;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(268, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Middle Initial:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field_FirstName
            // 
            this.Field_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_FirstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_FirstName.Location = new System.Drawing.Point(413, 105);
            this.Field_FirstName.Name = "Field_FirstName";
            this.Field_FirstName.Size = new System.Drawing.Size(308, 25);
            this.Field_FirstName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(283, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "First Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuText;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(289, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Name: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field_Sex
            // 
            this.Field_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Field_Sex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_Sex.FormattingEnabled = true;
            this.Field_Sex.Items.AddRange(new object[] {
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.Field_Sex.Location = new System.Drawing.Point(413, 225);
            this.Field_Sex.Name = "Field_Sex";
            this.Field_Sex.Size = new System.Drawing.Size(308, 26);
            this.Field_Sex.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(333, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "HCN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field_HCN
            // 
            this.Field_HCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field_HCN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field_HCN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Field_HCN.Location = new System.Drawing.Point(413, 16);
            this.Field_HCN.Name = "Field_HCN";
            this.Field_HCN.Size = new System.Drawing.Size(308, 25);
            this.Field_HCN.TabIndex = 25;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 651);
            this.Controls.Add(this.Panel_AddPatient);
            this.Controls.Add(this.Panel_MainMenu);
            this.Controls.Add(this.Panel_Loading);
            this.Name = "UI";
            this.Text = "EMS";
            this.Panel_Loading.ResumeLayout(false);
            this.Panel_Loading.PerformLayout();
            this.Panel_MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_AddPatient.ResumeLayout(false);
            this.Panel_AddPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Loading;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Panel Panel_MainMenu;
        private System.Windows.Forms.Button Btn_SearchPatient;
        private System.Windows.Forms.Button Btn_AddPatient;
        private System.Windows.Forms.Button Btn_BillableCode;
        private System.Windows.Forms.Button Btn_UpdatePatient;
        private System.Windows.Forms.Button Btn_ScheduleApt;
        private System.Windows.Forms.Button Btn_GenerateMB;
        private System.Windows.Forms.Button Btn_DisplayMB;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ProgressBar FakeBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_AddPatient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Submit_Update;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Field_HCN;
        public System.Windows.Forms.TextBox Field_Phone;
        public System.Windows.Forms.ComboBox Field_Province;
        public System.Windows.Forms.TextBox Field_HeadOfHouse;
        public System.Windows.Forms.TextBox Field_mInitial;
        public System.Windows.Forms.TextBox Field_FirstName;
        public System.Windows.Forms.ComboBox Field_Sex;
        public System.Windows.Forms.TextBox Field_City;
        public System.Windows.Forms.TextBox Field_AL2;
        public System.Windows.Forms.TextBox Field_AL1;
        public System.Windows.Forms.DateTimePicker Field_DOB;
        public System.Windows.Forms.TextBox Field_LastName;
    }
}

