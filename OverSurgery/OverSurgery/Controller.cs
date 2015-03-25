using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OverSurgery
{
    public abstract class Controller
    {
        public Controller()
        {
        }
    
        // Allows any form to logout
        public void Logout()
        {
            UserSession _userSession = UserSession.Instance();
            _userSession.CurrentUser = null;
        }

        // Return a patient based on patient ID
        public Staff GetStaffDetails(int staffID)
        {
            return BusinessMetaLayer.GetStaffDetails(staffID);
        }

        // Return a list of staff based on name and post code
        public List<Staff> GetStaffDetails(String staffID, String firstName, String lastName)
        {
            List<String> queryString = new List<string>();

            if (staffID != "")
            {
                int sID;

                if (Int32.TryParse(staffID, out sID))
                    queryString.Add("staff.staffID=" + sID);
            }

            if (firstName != "")
                queryString.Add("firstName LIKE '" + EncodeMySql(firstName) + "%'");

            if (lastName != "")
                queryString.Add("lastName LIKE '" + EncodeMySql(lastName) + "%'");

            return BusinessMetaLayer.GetStaffDetails(queryString);
        }

        public List<Absence> GetStaffAbsences(int staffID)
        {
            return BusinessMetaLayer.GetStaffAbsences(staffID);
        }

        // Get a list of staff who are on duty on a specfic date
        public List<Staff> GetOnDutyStaff(DateTime date)
        {
            return BusinessMetaLayer.CheckOnDutyStaff(date);
        }

        // Query the meta layer for a staff's appointment
        public List<Appointment> GetStaffAvailability(Staff staff, DateTime date)
        {
            return BusinessMetaLayer.GetStaffAvailability(staff, date);
        }

        // Get a list of appointments for a member of staff
        public List<Appointment> GetStaffAppointments(int staffID)
        {
            return BusinessMetaLayer.GetStaffAppointments(staffID);
        }

        // Return a patient based on patient ID
        public Patient GetPatientDetails(int patientID)
        {
            return BusinessMetaLayer.GetPatientDetails(patientID);
        }

        // Return a list of patient appointments
        public List<Appointment> GetPatientAppointments(int patientID)
        {
            return BusinessMetaLayer.GetPatientAppointments(patientID);
        }

        // Return a list of patients based on name and post code
        public List<Patient> GetPatientDetails(String patientID, String firstName, String lastName, String dateOfBirth, String postCode)
        {
            // Create a new list of strings
            List<String> queryString = new List<string>();

            // Check if the patient ID has been searched for
            if (patientID != "")
            {
                int pID;

                if (Int32.TryParse(patientID, out pID))
                    queryString.Add("patientID=" + pID);
            }

            // Check if the first name has been searched for
            if (firstName != "")
                queryString.Add("firstName LIKE '" + EncodeMySql(firstName) + "%'");

            // Check if the last name has been searched for
            if (lastName != "")
                queryString.Add("lastName LIKE '" + EncodeMySql(lastName) + "%'");

            // Check if date of birth has been searched for
            if (dateOfBirth != "")
            {
                DateTime dob;

                if (DateTime.TryParse(dateOfBirth, out dob))
                    queryString.Add("DoB='" + dob.Date.ToString("yyyy-MM-dd HH:mm:ss") + "'");
            }

            // Check if post code has been searched for
            if (postCode != "")
                queryString.Add("postCode LIKE '%" + EncodeMySql(postCode) + "%'");

            return BusinessMetaLayer.GetPatientDetails(queryString);
        }

        // Get a list of test for a patient
        public List<Test> GetPatientTests(int patientID)
        {
            return BusinessMetaLayer.GetPatientTests(patientID);
        }

        // Get a list of prescriptions for a patient
        public List<Prescription> GetPatientPrescriptions(int patientID)
        {
            return BusinessMetaLayer.GetPatientPrescriptions(patientID);
        }

        // Get a list of all stored medicines
        public List<Medicine> GetAllMedicines()
        {
            return BusinessMetaLayer.GetAllMedicines();
        }

        // Format strings for correct entry into a MySql database
        public string EncodeMySql(string value)
        {
            return Regex.Replace(value, @"[\r\n\x00\x1a\\'""]", @"\$0");
        }


        public string GetSHAHash(string text)
        {
            // SHA hash to store the password
            SHA256 passwordSHA = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(EncodeMySql(text));
            byte[] hashValue = passwordSHA.ComputeHash(bytes);

            string hash = "";

            foreach (byte bit in hashValue)
            {
                hash += bit.ToString("x2");
            }

            return hash;
        }

        public void SavePasswordFile(Staff staff, string password)
        {
            using (StreamWriter fs = new StreamWriter(staff.StaffID + " temp password.txt"))
            {
                fs.WriteLine("ID: " + staff.StaffID);
                fs.WriteLine("Password: " + password);
            }
        }
    }
}
