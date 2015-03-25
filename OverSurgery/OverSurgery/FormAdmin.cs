using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OverSurgery;
using System.Data.Common;

namespace OverSurgeryForms
{
    public partial class FormAdmin : Form
    {
        protected List<Staff> staffList;
        private AdminController _adminController;

        public FormAdmin()
        {   
            InitializeComponent();

            _adminController = new AdminController();

            FormRefresh();

            // Shows the currently logged in user's name in the status bar.
            loggedInLabel.Text = "Logged In As: " + UserSession.Instance().CurrentUser.ToString();

            if (UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Management)
            {
                addStaffToolStripMenuItem1.Enabled = true;
            }
        }

        // Refreshes the data on the form
        public void FormRefresh()
        {
            this.ActiveControl = tableLayoutPanel1;

            // Get a list of staff working on the selected day
            staffList = null;
            staffList = _adminController.GetOnDutyStaff(monthCalendar1.SelectionRange.Start);

            // Default table column
            int column = 0;

            // Clear old controls
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.ColumnCount = 0;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Controls.Clear();

            if (monthCalendar1.SelectionRange.Start.DayOfWeek != DayOfWeek.Sunday)
            {
                // Loop through each of the staff members
                foreach (Staff s in staffList)
                {
                    // Get each staff member's appointments
                    s.Appointments = _adminController.GetStaffAvailability(s, monthCalendar1.SelectionRange.Start);

                    // Get the Patient's details to display patient name etc
                    foreach (Appointment a in s.Appointments)
                    {
                        a.Patient = _adminController.GetPatientDetails(a.PatientID);
                    }

                    // Create a new flow panel for each of the doctors
                    AppointmentFlowPanel newFlowPanel = new AppointmentFlowPanel(s, monthCalendar1.SelectionRange.Start, this);
                    newFlowPanel.LabelDoubleClicked += AppointmentLabelClick;

                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210));
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel1.Controls.Add(newFlowPanel, column, 0);
                    ++column;
                }
            }
            tableLayoutPanel1.ResumeLayout();
        }

        // If the user has changed the selected date, clear the current data and reload
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            FormRefresh();
        }

        // Move focus to the table layout
        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!tableLayoutPanel1.Focused)
                tableLayoutPanel1.Focus();
        }

        // Triggered when an appointment label is clicked
        private void AppointmentLabelClick(AppointmentLabel sender, EventArgs e)
        {
            AppointmentLabel ap = sender;
            DialogResult result;

            DateTime _currentDate = monthCalendar1.SelectionRange.Start;
            DateTime dateCheck = _currentDate.Add(ap.StartTime);

            // Check if there is already an appointment on this day
            if (ap.Appointment != null)
            {
                ap.Appointment.Patient = BusinessMetaLayer.GetPatientDetails(ap.Appointment.PatientID);
                ap.Appointment.Staff = ap.AppointmentFlow.AppointmentStaff;

                // Open the add appointment form with the data from the form
                using (var appForm = new FormAppointmentDetails(ap.Appointment))
                {
                    result = appForm.ShowDialog();
                }

                // Refresh the admin form once the appointment has been added
                if (result == DialogResult.OK)
                {
                    // Tell the label you have added an appointment
                    FormRefresh();
                }
            }
            else
            {
                if (dateCheck >= DateTime.Now)
                {
                    // Open the add appointment form with the data from the form
                    using (var addForm = new FormAddAppointment(_currentDate, ap.StartTime, ap.EndTime, ap.AppointmentFlow.AppointmentStaff))
                    {
                        result = addForm.ShowDialog();
                    }

                    // Refresh the admin form once the appointment has been added
                    if (result == DialogResult.OK)
                    {
                        // Tell the label you have added an appointment
                        FormRefresh();
                    }
                }
            }
        }

        // Handle the logout option
        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Allow the user to confirm logging out
        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you would like to logout?", "Confirm Logout",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    e.Cancel = true;
            }
        }

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

            _adminController.Logout();
            base.Dispose(disposing);
        }

        // Open the Add Staff form from tool strip
        private void addStaffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Open the add appointment form with the data from the form
            using (var addForm = new FormAddStaff())
            {
                result = addForm.ShowDialog();
            }

            // Refresh the admin form once the appointment has been added
            if (result == DialogResult.OK)
            {
                MessageBox.Show("New Staff Member Added");
            }

            FormRefresh();
        }

        // Open the Add Patient form from the toolstrip
        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Open the add appointment form with the data from the form
            using (var addForm = new FormAddPatient())
            {
                result = addForm.ShowDialog();
            }

            // Refresh the admin form once the appointment has been added
            if (result == DialogResult.OK)
            {

            }

            FormRefresh();
        }

        // Open the Find Staff Details form from the toolstrip
        private void findStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Open the add appointment form with the data from the form
            using (var addForm = new FormFindStaff())
            {
                result = addForm.ShowDialog();
            }

            // Refresh the admin form once the appointment has been added
            if (result == DialogResult.OK)
            {

            }

            FormRefresh();
        }

        // Open the Find Patient Details form from the toolstrip
        private void findPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Open the add appointment form with the data from the form
            using (var addForm = new FormFindPatient())
            {
                result = addForm.ShowDialog();
            }

            // Refresh the admin form once the appointment has been added
            if (result == DialogResult.OK)
            {

            }

            FormRefresh();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("user guide.pdf");
        }
    }

    // Creates a flow panel for each of the doctors
    public class AppointmentFlowPanel : FlowLayoutPanel
    {
        // Holds all of the appointment labels to add to the control
        private List<AppointmentLabel> labels = new List<AppointmentLabel>();

        // The staff member that is attached to this panel
        private Staff _staff;

        // Currently selected date in the form
        private DateTime _currentDate;

        // Hold the parent form for refresh after adding appointments
        private Form _parentForm;

        // Staff member attached to this panel
        public Staff AppointmentStaff
        {
            get { return _staff; }
        }

        public AppointmentFlowPanel(Staff staff, DateTime currentDate, Form parentForm)
        {
            // Get needed information from the form
            _staff = staff;
            _currentDate = currentDate;
            _parentForm = parentForm;

            // Column Title
            if(_staff.Permissions == PermissionsFlag.Doctor)
                this.Controls.Add(new TitleLabel("Dr " + staff.LastName));
            else
                this.Controls.Add(new TitleLabel("Nurse " + staff.LastName));

            // Create the day labels for the timeline
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = startTime.Add(new TimeSpan(0, 15, 0));

            this.SuspendLayout();

            // Add all of the needed labels per appointment
            //  36 = number of timeslots between 9 and 6
            for (int i = 0; i < 36; ++i)
            {
                // Add all possible labels
                labels.Add(new AppointmentLabel(this, startTime, endTime, true));

                // Increase the time for the next label
                startTime = startTime.Add(new TimeSpan(0, 15, 0));
                endTime = startTime.Add(new TimeSpan(0, 15, 0));
            }

            // Compare each appointment against labels and change text
            foreach (Appointment a in _staff.Appointments)
            {
                // Loop through all labels to perform comparison
                for (int i = 0; i < labels.Count; ++i)
                {
                    // Check if the appointment time matches
                    if (labels[i].Text == a.AppointmentTime)
                    {
                        // Replace the label text with the appointment details
                        labels[i].Text = a.Patient.ToString() + Environment.NewLine + " " + a.AppointmentTime;
                        labels[i].BackColor = Color.LightGreen;
                        labels[i].Appointment = a;
                    }

                }
            }

            // Add the labels to the flowpanel controls
            foreach(AppointmentLabel al in labels)
            {
                // Add an event handler for the click
                al.DoubleClick += al_Click;
                al.MouseEnter += al_MouseHover;
                al.MouseLeave += al_MouseLeave;

                // Add the control
                this.Controls.Add(al);
            }

            // Set the width of the flow panel
            this.Width = 200;
            //this.AutoScroll = true;
            this.FlowDirection = FlowDirection.TopDown;
            this.AutoSize = true;
            this.Height = 500;

            this.ResumeLayout();
        }

        // Create a customer event handler
        public delegate void LabelClicked(AppointmentLabel sender, EventArgs e);
        public event LabelClicked LabelDoubleClicked;

        // Handle double clicking a label - customer event handler
        public void al_Click(object sender, EventArgs e)
        {
            if (this.LabelDoubleClicked != null)
                this.LabelDoubleClicked((AppointmentLabel) sender, e);
        }

        // Change the colour of the label background on mouse hover
        void al_MouseHover(object sender, EventArgs e)
        {
            AppointmentLabel ap = (AppointmentLabel)sender;
            DateTime dateCheck = _currentDate.Add(ap.StartTime);

            if (dateCheck >= DateTime.Now)
            {
                if (ap.Appointment == null)
                    ap.BackColor = Color.LightBlue;
                else
                    ap.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                ap.BackColor = Color.LightSalmon;
            }
        }

        // Change the colour back to normal when the mouse isn't over the label
        void al_MouseLeave(object sender, EventArgs e)
        {
            AppointmentLabel ap = (AppointmentLabel)sender;

            if (ap.Appointment == null) ap.BackColor = Color.LightGray;
            else ap.BackColor = Color.LightGreen;
        }

        // Display a timespan as a string
        public string GetTimeSpanAsString(TimeSpan input)
        {
            return input.ToString(@"hh\:mm");
        }
    }

    // Flow Panel "column" title label
    public class TitleLabel : Label
    {
        public TitleLabel(String text)
        {
            this.Width = 200;
            this.Height = 20;
            this.Text = text;
            this.Margin = new Padding(0, 3, 0, 5);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = Color.White;
        }
    }

    public class AppointmentLabel : Label
    {
        // Attach an appointment if one exists
        private Appointment _appointment;

        // Parent flow panel of this label
        private AppointmentFlowPanel _appointmentFlow;

        // Time span of the potential appointment
        private TimeSpan _startTime, _endTime;

        public TimeSpan StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public TimeSpan EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public Appointment Appointment
        {
            get { return _appointment; }
            set { _appointment = value; }
        }

        public AppointmentFlowPanel AppointmentFlow
        {
            get { return _appointmentFlow; }
            set { _appointmentFlow = value; }
        }

        public AppointmentLabel(AppointmentFlowPanel ap, TimeSpan startTime, TimeSpan endTime, bool newApp)
        {
            // Set the attributes from the flow panel
            _appointmentFlow = ap;
            _startTime = startTime;
            _endTime = endTime;

            this.Height = 35;
            this.Width = 200;

            this.Text = GetTimeSpanAsString(startTime) + " - " + GetTimeSpanAsString(endTime);

            this.Margin = new Padding(0, 0, 0, 5);
            this.TextAlign = ContentAlignment.MiddleCenter;
            
            // Set the colour of the label
            if (!newApp) this.BackColor = Color.LightGreen;
            else this.BackColor = Color.LightGray;

        }

        public string GetTimeSpanAsString(TimeSpan input)
        {
            return input.ToString(@"hh\:mm");
        }
    }

    public class DoubleBufferedTable : TableLayoutPanel
    {
        public DoubleBufferedTable()
        {
            DoubleBuffered = true;
        }
    }
}
