using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public static class BusinessMetaLayer
    {
        // Check the user ID and password of a login attempt
        public static bool CheckLoginDetails(int staffID, String password)
        {
            Database db = Database.Instance();

            // Open the connection
            if (db.OpenConnection())
            {
                // Check the number of rows that are returned from the login query
                int numRows = db.Count("SELECT COUNT(*) FROM staffLogin WHERE staffID=" + staffID.ToString() + " AND password='" + password + "';");

                // If a user exists and there's one row
                if (numRows == 1)
                {
                    // The login will be successful
                    db.CloseConnection();
                    return true;
                }
            }

            // If there's less than one row it means there's no user
            // There shouldn't be more than one row!
            db.CloseConnection();
            return false;
        }

        // Return a member of staff and all of the details associated with it (includes login information)
        public static Staff GetStaffDetails(int staffID)
        {
            Database db = Database.Instance();

            Staff matchedStaff = new Staff();

            // Open the connection
            if (db.OpenConnection())
            {
                // Access the stafflogin table, get the appropriate record and then join to the staff details table
                DbDataReader dr = db.Select("SELECT staff.*, stafflogin.resetFlag FROM staff INNER JOIN stafflogin ON staff.staffID=stafflogin.staffID " +
                    "WHERE staff.staffID='" + staffID.ToString() + "';");

                // Create the staff data
                //Read the data and store them in the list
                while (dr.Read())
                {
                    matchedStaff.StaffID = dr.GetInt32(0);
                    matchedStaff.FirstName = dr.GetString(1);
                    matchedStaff.LastName = dr.GetString(2);
                    matchedStaff.DateOfBirth = dr.GetDateTime(3);
                    matchedStaff.Gender = (PersonGender) dr.GetInt32(4);
                    matchedStaff.TelephoneNumber = dr.GetString(5);
                    matchedStaff.EmailAddress = dr.GetString(6);
                    matchedStaff.AddressLine1 = dr.GetString(7);
                    matchedStaff.AddressLine2 = dr.GetString(8);
                    matchedStaff.City = dr.GetString(9);
                    matchedStaff.County = dr.GetString(10);
                    matchedStaff.PostCode = dr.GetString(11);
                    matchedStaff.MaritalStatus = dr.GetString(12);
                    matchedStaff.Permissions = (PermissionsFlag)dr.GetInt32(13);
                    matchedStaff.ResetPasswordFlag = dr.GetBoolean(14);
                }

                //close Data Reader
                dr.Close();

                db.CloseConnection();
            }

            // Return the newly created staff instance
            return matchedStaff;
        }

        // Get all of the details of a staff based on search criteria
        public static List<Staff> GetStaffDetails(List<String> queryStrings)
        {
            Database db = Database.Instance();

            List<Staff> staffList = new List<Staff>();

            // Open the connection
            if (db.OpenConnection())
            {
                if (queryStrings.Count > 0)
                {
                    String query = "";

                    for (int i = 0; i < queryStrings.Count; ++i)
                    {
                        query += queryStrings[i];

                        if (i != queryStrings.Count - 1) query += " AND ";
                    }

                    DbDataReader dr;

                    dr = db.Select("SELECT * FROM staff WHERE " + query + ";");

                    // Create the staff data
                    //Read the data and store them in the list
                    while (dr.Read())
                    {
                        Staff matchedStaff = new Staff();
                        matchedStaff.StaffID = dr.GetInt32(0);
                        matchedStaff.FirstName = dr.GetString(1);
                        matchedStaff.LastName = dr.GetString(2);
                        matchedStaff.DateOfBirth = dr.GetDateTime(3);
                        matchedStaff.Gender = (PersonGender)dr.GetInt32(4);
                        matchedStaff.TelephoneNumber = dr.GetString(5);
                        matchedStaff.EmailAddress = dr.GetString(6);
                        matchedStaff.AddressLine1 = dr.GetString(7);
                        matchedStaff.AddressLine2 = dr.GetString(8);
                        matchedStaff.City = dr.GetString(9);
                        matchedStaff.County = dr.GetString(10);
                        matchedStaff.PostCode = dr.GetString(11);
                        matchedStaff.MaritalStatus = dr.GetString(12);
                        matchedStaff.Permissions = (PermissionsFlag)dr.GetInt32(13);

                        staffList.Add(matchedStaff);
                    }

                    //close Data Reader
                    dr.Close();
                }
                db.CloseConnection();
            }

            // Return the newly created patient instance
            return staffList;
        }

        // Returns all appointments for one member of staff
        public static List<Appointment> GetStaffAppointments(int staffID)
        {
            Database db = Database.Instance();
            List<Appointment> _appointments = new List<Appointment>();

            if (db.OpenConnection())
            {
                String query;

                query = "SELECT apps.* FROM appointments apps " +
                        "INNER JOIN staff s " +
                        "ON s.staffID=apps.staffID " +
                        "WHERE s.staffID=" + staffID +
                        ";";

                DbDataReader dr = db.Select(query);

                // Create the staff data
                // Read the data and store them in the list
                while (dr.Read())
                {
                    Appointment newAppointment = new Appointment();
                    newAppointment.AppointmentID = dr.GetInt32(0);
                    newAppointment.PatientID = dr.GetInt32(1);
                    newAppointment.StaffID = dr.GetInt32(2);
                    newAppointment.StartDate = dr.GetDateTime(3);
                    newAppointment.EndDate = dr.GetDateTime(4);
                    newAppointment.AppointmentNotes = dr.IsDBNull(5) ? "" : dr.GetString(5);

                    _appointments.Add(newAppointment);
                }

                dr.Close();
                db.CloseConnection();
            }

            return _appointments;
        }

        // Returns all absences for one member of staff
        public static List<Absence> GetStaffAbsences(int staffID)
        {
            Database db = Database.Instance();
            List<Absence> _absences = new List<Absence>();

            if (db.OpenConnection())
            {
                String query;

                query = "SELECT * FROM absence " +
                        "WHERE absence.staffID=" + staffID + " ORDER BY absence.startDate DESC;";

                DbDataReader dr = db.Select(query);

                // Create the staff data
                // Read the data and store them in the list
                while (dr.Read())
                {
                    Absence absence = new Absence();
                    absence.StaffID = dr.GetInt32(1);
                    absence.AbsenceType = (AbsenceType) dr.GetInt32(2);
                    absence.StartDate = dr.GetDateTime(3);
                    absence.EndDate = dr.GetDateTime(4);

                    _absences.Add(absence);
                }

                dr.Close();
                db.CloseConnection();
            }

            return _absences;
        }
        
        // Gets the ID number of the next member of staff to be added
        public static int GetNextStaffID()
        {
            Database db = Database.Instance();

            int nextID = -1;

            // Open the connection
            if (db.OpenConnection())
            {
                // Access the stafflogin table, get the appropriate record and then join to the staff details table
                DbDataReader dr = db.Select("SHOW TABLE STATUS FROM " + db.DatabaseName + " WHERE Name='staff';");

                // Create the staff data
                //Read the data and store them in the list
                while (dr.Read())
                {
                    nextID = dr.GetInt32(10);
                }

                //close Data Reader
                dr.Close();

                db.CloseConnection();
            }

            // Return the newly created staff instance
            return nextID;
        }

        // Update the details of a member of staff
        public static bool ModifyStaffDetails(Staff oldStaff, Staff staff)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                if (StaffExists(oldStaff))
                {
                    // Build the query string
                    String newPatientQuery;
                    String sqlFormattedDate = staff.DateOfBirth.Date.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    newPatientQuery = "UPDATE staff SET firstName='" + staff.FirstName +
                    "', lastName='" + staff.LastName +
                    "', DoB='" + sqlFormattedDate +
                    "', gender='" + (int)staff.Gender +
                    "', telNo='" + staff.TelephoneNumber +
                    "', email='" + staff.EmailAddress +
                    "', addressLine1='" + staff.AddressLine1 +
                    "', addressLine2='" + staff.AddressLine2 +
                    "', city='" + staff.City +
                    "', county='" + staff.County +
                    "', postCode='" + staff.PostCode +
                    "', maritalStatus='" + staff.MaritalStatus + "' WHERE staffID=" + staff.StaffID + ";";

                    // Insert the entry into the database
                    db.Update(newPatientQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            return false;
        }

        // Flag a member of staff for a password reset
        public static bool ResetStaffPassword(int staffID, String newPassword)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                // Build the query string
                String newPatientQuery;

                // Create the query string to be inserted
                newPatientQuery = "UPDATE stafflogin SET password='" + newPassword + "', resetFlag=1 WHERE staffID=" + staffID + ";";

                // Insert the entry into the database
                db.Update(newPatientQuery);

                // Close the connection
                db.CloseConnection();
                return true;
                db.CloseConnection();
            }
            return false;
        }

        // Update a staff password and unflag for change
        public static bool SetStaffPassword(Staff staff, string password)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                if (StaffExists(staff))
                {
                    // Build the query string
                    String newPatientQuery;

                    // Create the query string to be inserted
                    newPatientQuery = "UPDATE stafflogin SET password='" + password + "', resetFlag=0 " +
                        "WHERE staffID=" + staff.StaffID + ";";

                    // Insert the entry into the database
                    db.Update(newPatientQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            return false;
        }

        // Check if a staff member already exists in the database
        public static bool StaffExists(Staff staff)
        {
            Database db = Database.Instance();

            String sqlFormattedDate = staff.DateOfBirth.Date.ToString("yyyy-MM-dd HH:mm:ss");

            // Check the number of rows that are returned
            int numRows = db.Count("SELECT COUNT(*) FROM staff WHERE firstName='" + staff.FirstName + 
                "'and lastName='" + staff.LastName + 
                "'and DoB='" + sqlFormattedDate + 
                "'and gender='" + (int)staff.Gender + 
                "'and telNo='" + staff.TelephoneNumber + 
                "'and email='" + staff.EmailAddress + 
                "'and addressLine1='" + staff.AddressLine1 + 
                "'and addressLine2='" + staff.AddressLine2 + 
                "'and city='" + staff.City + 
                "'and county='" + staff.County +
                "'and postCode='" + staff.PostCode + 
                "'and maritalStatus='" + staff.MaritalStatus + "';");

            // If a user exists and there's one row
            if (numRows > 0)
            {
                // The person exists already
                return true;
            }
            
            return false;
        }

        // Checks if a patient details are already stored
        public static bool PatientExists(Patient patient)
        {
            Database db = Database.Instance();

            String sqlFormattedDate = patient.DateOfBirth.Date.ToString("yyyy-MM-dd HH:mm:ss");

            // Check the number of rows that are returned
            int numRows = db.Count("SELECT COUNT(*) FROM patients WHERE firstName='" + patient.FirstName +
                "'and lastName='" + patient.LastName +
                "'and DoB='" + sqlFormattedDate +
                "'and gender='" + (int)patient.Gender +
                "'and telNo='" + patient.TelephoneNumber +
                "'and email='" + patient.EmailAddress +
                "'and addressLine1='" + patient.AddressLine1 +
                "'and addressLine2='" + patient.AddressLine2 +
                "'and city='" + patient.City +
                "'and county='" + patient.County +
                "'and postCode='" + patient.PostCode +
                "'and maritalStatus='" + patient.MaritalStatus + "';");

            // If a user exists and there's one row
            if (numRows > 0)
            {
                // The person exists already
                return true;
            }

            return false;
        }

        // Checks if an appointment already exists
        public static bool AppointmentExists(Appointment appointment)
        {
            Database db = Database.Instance();

            // Format the appointment start and end time for mysql
            String sqlFormattedStartDate = appointment.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
            String sqlFormattedEndDate = appointment.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

            // Check the number of rows that are returned
            int numRows = db.Count("SELECT COUNT(*) FROM appointments WHERE patientID='" + appointment.PatientID +
                "'and staffID='" + appointment.StaffID +
                "'and date='" + sqlFormattedStartDate +
                "'and endDate='" + sqlFormattedEndDate + "';");

            // If an appointment exists and there's one row
            if (numRows > 0)
            {
                // The appointment exists already
                return true;
            }

            return false;
        }

        // Checks if an absence already exists
        public static bool AbsenceExists(Absence absence)
        {
            Database db = Database.Instance();

            // Format the appointment start and end time for mysql
            String sqlFormattedStartDate = absence.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
            String sqlFormattedEndDate = absence.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

            // Check the number of rows that are returned
            int numRows = db.Count("SELECT COUNT(*) FROM absence WHERE staffID='" + absence.StaffID +
                "'and startDate='" + sqlFormattedStartDate +
                "'and endDate='" + sqlFormattedEndDate + "';");

            // If an appointment exists and there's one row
            if (numRows > 0)
            {
                // The appointment exists already
                return true;
            }

            return false;
        }

        // Checks if a test already exists
        public static bool TestExists(Test test)
        {
            Database db = Database.Instance();

            // Format the test date
            String sqlFormattedStartDate = test.TestDate.ToString("yyyy-MM-dd HH:mm:ss");

            // Check the number of rows that are returned
            int numRows = db.Count("SELECT COUNT(*) FROM testresults WHERE patientID='" + test.PatientID + 
                "' and staffID='" + test.StaffID + 
                "' and testDate='" + sqlFormattedStartDate +
                "' and testType='" + (int) test.TestType + 
                "' and testResult='" + test.TestResult + "';");

            // If a test exists and there's one row
            if (numRows > 0)
            {
                // The test exists already
                return true;
            }

            return false;
        }

        // Check if a prescription already exists
        public static bool PrescriptionExists(Prescription prescription)
        {
            Database db = Database.Instance();

            // Format the test date
            String sqlFormattedStartDate = prescription.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
            String sqlFormattedEndDate = prescription.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

            // Check the number of rows that are returned
            int numRows = db.Count("SELECT COUNT(*) FROM prescriptions p " +
                "WHERE p.patientID='" + prescription.PatientID +
                "' and p.staffID='" + prescription.StaffID +
                "' and p.startDate='" + sqlFormattedStartDate +
                "' and p.endDate='" + sqlFormattedEndDate +
                "' and p.extended=" + Convert.ToInt32(prescription.Extended) + ";");

            // If a test exists and there's one row
            if (numRows > 0)
            {
                // The test exists already
                return true;
            }

            return false;
        }

        // Add a new absence for a staff member
        public static bool AddAbsence(Absence absence)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                // Check if the user details currently exist
                if (!AbsenceExists(absence))
                {
                    // Build the query string
                    String absenceQuery;
                    String startDate = absence.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
                    String endDate = absence.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    absenceQuery = "INSERT INTO absence VALUES(NULL, " + absence.StaffID +
                        ", " + (int)absence.AbsenceType + ", '" + startDate + "', '" + endDate + "');";

                    // Insert the entry into the database and return the new staffID
                    db.Insert(absenceQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            return false;
        }

        // Remove an absence for a staff member
        public static bool RemoveAbsence(Absence absence)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                // Check if the user details currently exist
                if (AbsenceExists(absence))
                {
                    // Build the query string
                    String absenceQuery;
                    String startDate = absence.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
                    String endDate = absence.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    absenceQuery = "DELETE FROM absence WHERE staffID='" + absence.StaffID +
                    "'and startDate='" + startDate +
                     "'and endDate='" + endDate + "';";

                    // Insert the entry into the database and return the new staffID
                    db.Delete(absenceQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            return false;
        }

        // Store the new staff member in the database
        public static bool AddStaffDetails(Staff newStaff, String password)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                // Check if the user details currently exist
                if (!StaffExists(newStaff))
                {
                    // Build the query string
                    String newStaffQuery, newStaffLoginQuery;
                    String sqlFormattedDate = newStaff.DateOfBirth.Date.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    newStaffQuery = "INSERT INTO staff VALUES(NULL, '" + newStaff.FirstName + "'," +
                        "'" + newStaff.LastName + "'," +
                        "'" + sqlFormattedDate + "'," +
                        "'" + (int)newStaff.Gender + "'," +
                        "'" + newStaff.TelephoneNumber + "'," +
                        "'" + newStaff.EmailAddress + "'," +
                        "'" + newStaff.AddressLine1 + "'," +
                        "'" + newStaff.AddressLine2 + "'," +
                        "'" + newStaff.City + "'," +
                        "'" + newStaff.County + "'," +
                        "'" + newStaff.PostCode + "'," +
                        "'" + newStaff.MaritalStatus + "', " +
                        (int)newStaff.Permissions +
                        "); SELECT @@IDENTITY;";

                    // Insert the entry into the database and return the new staffID
                    int staffID = db.InsertScalar(newStaffQuery);

                    // Insert the entry into the login table with the new staffID
                    newStaffLoginQuery = "INSERT INTO staffLogin VALUES(" + staffID + ",'" + password + "', 1);";
                    db.Insert(newStaffLoginQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }           
            return false;            
        }

        // Store the new patient in the database
        public static bool AddPatientDetails(Patient newPatient)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                if (!PatientExists(newPatient))
                {
                    // Build the query string
                    String newPatientQuery;
                    String sqlFormattedDate = newPatient.DateOfBirth.Date.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    newPatientQuery = "INSERT INTO patients VALUES(NULL, '" + newPatient.FirstName + "'," +
                        "'" + newPatient.LastName + "'," +
                        "'" + sqlFormattedDate + "'," +
                        "'" + (int)newPatient.Gender + "'," +
                        "'" + newPatient.TelephoneNumber + "'," +
                        "'" + newPatient.EmailAddress + "'," +
                        "'" + newPatient.AddressLine1 + "'," +
                        "'" + newPatient.AddressLine2 + "'," +
                        "'" + newPatient.City + "'," +
                        "'" + newPatient.County + "'," +
                        "'" + newPatient.PostCode + "'," +
                        "'" + newPatient.MaritalStatus + "');";

                    // Insert the entry into the database
                    db.Insert(newPatientQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            
            return false;            
        }

        // Store the new appointment in the database
        public static bool AddAppointment(Appointment newAppointment)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                if (!AppointmentExists(newAppointment))
                {
                    // Build the query string
                    String newAppointmentQuery;
                    String sqlFormattedStartDate = newAppointment.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
                    String sqlFormattedEndDate = newAppointment.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the new appointment query
                    newAppointmentQuery = "INSERT INTO appointments VALUES(NULL,'" + newAppointment.PatientID + "'," +
                        "'" + newAppointment.StaffID + "'," +
                        "'" + sqlFormattedStartDate + "'," +
                        "'" + sqlFormattedEndDate + "', NULL);";

                    // Insert the appointment into the database
                    db.Insert(newAppointmentQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }

            return false;  
        }

        // Cancel a stored appointment if it already exists
        public static bool CancelAppointment(Appointment appointment)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                if (AppointmentExists(appointment))
                {
                    // Build the query string
                    String cancelAppointmentQuery;
                    String sqlFormattedStartDate = appointment.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
                    String sqlFormattedEndDate = appointment.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the new appointment query
                    cancelAppointmentQuery = "DELETE FROM appointments WHERE patientID=" + appointment.PatientID +
                        " and date='" + sqlFormattedStartDate + "'" +
                        " and endDate='" + sqlFormattedEndDate + "'";

                    // Insert the appointment into the database
                    db.Delete(cancelAppointmentQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }

            return false;  
        }

        // Add the notes for the appointment to the database
        public static bool SaveAppointmentNotes(Appointment appointment, String notes)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                if (AppointmentExists(appointment))
                {
                    // Build the query string
                    String updateAppointmentQuery;

                    // Create the new appointment query
                    updateAppointmentQuery = "UPDATE appointments SET appointmentNotes='" + notes + "' " +
                        "WHERE appointmentID=" + appointment.AppointmentID + ";";

                    // Insert the appointment into the database
                    db.Delete(updateAppointmentQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }

            return false;  
        }

        // Get a list of staff members at work on a set day
        public static List<Staff> CheckOnDutyStaff(DateTime date)
        {
            Database db = Database.Instance();
            List<Staff> _onDutyStaff = new List<Staff>();

            if (db.OpenConnection())
            {
                String query;
                String sqlFormattedDate = date.Date.ToString("yyyy-MM-dd HH:mm:ss");

                query = "SELECT s.* " +
                        "FROM staff s " +
                        "LEFT OUTER JOIN " +
                        "(SELECT * " +
                        "FROM absence a " +
                        "WHERE '" + sqlFormattedDate + "' BETWEEN a.startDate AND a.endDate) y " +
                        "ON s.staffID=y.staffID WHERE y.staffID IS NULL AND (s.role=" + (int)PermissionsFlag.Doctor + " OR s.role=" + (int)PermissionsFlag.Nurse + ");";

                DbDataReader dr = db.Select(query);

                // Create the staff data
                //Read the data and store them in the list
                while (dr.Read())
                {
                    Staff newStaff = new Staff();
                    newStaff.StaffID = dr.GetInt32(0);
                    newStaff.FirstName = dr.GetString(1);
                    newStaff.LastName = dr.GetString(2);
                    newStaff.DateOfBirth = dr.GetDateTime(3);
                    newStaff.Gender = (PersonGender)dr.GetInt32(4);
                    newStaff.TelephoneNumber = dr.GetString(5);
                    newStaff.EmailAddress = dr.GetString(6);
                    newStaff.AddressLine1 = dr.GetString(7);
                    newStaff.AddressLine2 = dr.GetString(8);
                    newStaff.City = dr.GetString(9);
                    newStaff.County = dr.GetString(10);
                    newStaff.PostCode = dr.GetString(11);
                    newStaff.MaritalStatus = dr.GetString(12);
                    newStaff.Permissions = (PermissionsFlag)dr.GetInt32(13);

                    _onDutyStaff.Add(newStaff);
                }

                dr.Close();
                db.CloseConnection();
            }

            return _onDutyStaff;
        }

        // Get a list of appointments for a member of staff on a set day
        public static List<Appointment> GetStaffAvailability(Staff staff, DateTime date)
        {
            Database db = Database.Instance();
            List<Appointment> _appointments = new List<Appointment>();

            if (db.OpenConnection())
            {
                String query;
                String sqlFormattedDate = date.Date.ToString("yyyy-MM-dd HH:mm:ss");

                query = "SELECT apps.* FROM appointments apps " +
                        "INNER JOIN staff s " +
                        "ON s.staffID=apps.staffID " +
                        "WHERE s.staffID=" + staff.StaffID + " AND (s.role=" + (int)PermissionsFlag.Doctor + " OR s.role=" + (int) PermissionsFlag.Nurse + ") AND date(apps.date)='" + sqlFormattedDate + "';";

                 DbDataReader dr = db.Select(query);

                // Create the staff data
                // Read the data and store them in the list
                while (dr.Read())
                {
                    Appointment newAppointment = new Appointment();
                    newAppointment.AppointmentID = dr.GetInt32(0);
                    newAppointment.PatientID = dr.GetInt32(1);
                    newAppointment.StaffID = dr.GetInt32(2);
                    newAppointment.StartDate = dr.GetDateTime(3);
                    newAppointment.EndDate = dr.GetDateTime(4);

                    newAppointment.AppointmentNotes = dr.IsDBNull(5) ? "" : dr.GetString(5);

                    _appointments.Add(newAppointment);
                }

                dr.Close();
                db.CloseConnection();
            }

            return _appointments;
        }

        // Get all of the details about a certain patient (used within appointments etc so far)
        public static Patient GetPatientDetails(int patientID)
        {
            Database db = Database.Instance();

            Patient patientDetails = new Patient();

            // Open the connection
            if (db.OpenConnection())
            {
                // Access the patient table and get all matching rows (should only be one).
                DbDataReader dr = db.Select("SELECT patients.* FROM patients WHERE patientID='" + patientID.ToString() + "';");

                //Read the data and store it in the new patient instance
                while (dr.Read())
                {
                    patientDetails.PatientID = dr.GetInt32(0);
                    patientDetails.FirstName = dr.GetString(1);
                    patientDetails.LastName = dr.GetString(2);
                    patientDetails.DateOfBirth = dr.GetDateTime(3);
                    patientDetails.Gender = (PersonGender)dr.GetInt32(4);
                    patientDetails.TelephoneNumber = dr.GetString(5);
                    patientDetails.EmailAddress = dr.GetString(6);
                    patientDetails.AddressLine1 = dr.GetString(7);
                    patientDetails.AddressLine2 = dr.GetString(8);
                    patientDetails.City = dr.GetString(9);
                    patientDetails.County = dr.GetString(10);
                    patientDetails.PostCode = dr.GetString(11);
                    patientDetails.MaritalStatus = dr.GetString(12);
                }

                //close Data Reader
                dr.Close();

                db.CloseConnection();
            }

            // Return the newly created patient instance
            return patientDetails;
        }

        // Return all appointments for a specific patient
        public static List<Appointment> GetPatientAppointments(int patientID)
        {
            Database db = Database.Instance();
            List<Appointment> _appointments = new List<Appointment>();

            if (db.OpenConnection())
            {
                String query;

                query = "SELECT apps.* FROM appointments apps " +
                        "INNER JOIN patients p " +
                        "ON p.patientID=apps.patientID " +
                        "WHERE p.patientID=" + patientID + 
                        " ORDER BY apps.date DESC;";

                DbDataReader dr = db.Select(query);

                // Create the staff data
                // Read the data and store them in the list
                while (dr.Read())
                {
                    Appointment newAppointment = new Appointment();
                    newAppointment.AppointmentID = dr.GetInt32(0);
                    newAppointment.PatientID = dr.GetInt32(1);
                    newAppointment.StaffID = dr.GetInt32(2);
                    newAppointment.StartDate = dr.GetDateTime(3);
                    newAppointment.EndDate = dr.GetDateTime(4);

                    newAppointment.AppointmentNotes = dr.IsDBNull(5) ? "" : dr.GetString(5);

                    _appointments.Add(newAppointment);
                }

                dr.Close();
                db.CloseConnection();
            }

            return _appointments;
        }

        // Return all prescriptions for a specific patient
        public static List<Prescription> GetPatientPrescriptions(int patientID)
        {
            Database db = Database.Instance();
            List<Prescription> _prescriptions = new List<Prescription>();

            if (db.OpenConnection())
            {
                String query;

                query = "SELECT * FROM prescriptions p " +
                        "WHERE p.patientID=" + patientID + ";";

                DbDataReader dr = db.Select(query);

                // Create the staff data
                // Read the data and store them in the list
                while (dr.Read())
                {
                    Prescription newPrescription = new Prescription();
                    newPrescription.PrescriptionID = dr.GetInt32(0);
                    newPrescription.PatientID = dr.GetInt32(1);
                    newPrescription.StaffID = dr.GetInt32(2);
                    newPrescription.StartDate = dr.GetDateTime(3);
                    newPrescription.EndDate = dr.GetDateTime(4);
                    newPrescription.Extended = Convert.ToBoolean(dr.GetInt32(5));
                    _prescriptions.Add(newPrescription);
                }
                dr.Close();

                foreach (Prescription p in _prescriptions)
                {
                    p.Medicines = GetPrescriptionMedicines(p.PrescriptionID);
                }

                db.CloseConnection();
            }

            return _prescriptions;
        }

        // Return all medicines for a prescription
        public static List<Medicine> GetPrescriptionMedicines(int prescriptionID)
        {
            Database db = Database.Instance();

            List<Medicine> _medicine = new List<Medicine>();

            String query = "SELECT * FROM prescriptions_medicine pm " +
                    "INNER JOIN medicine m ON pm.medicineID=m.medicineID " +
                    "WHERE pm.prescriptionID=" + prescriptionID + ";";

            DbDataReader dr = db.Select(query);

            // Create the staff data
            // Read the data and store them in the list
            while (dr.Read())
            {
                Medicine newMedicine = new Medicine();
                newMedicine.MedicineID = dr.GetInt32(3);
                newMedicine.MedicineName = dr.GetString(4);
                newMedicine.Dosage = dr.GetString(5);
                newMedicine.Extendable = dr.GetBoolean(6);
                _medicine.Add(newMedicine);
            }

            dr.Close();

            return _medicine;
        }

        // Get all of the details of a patient based on search criteria
        public static List<Patient> GetPatientDetails(List<String> queryStrings)
        {
            Database db = Database.Instance();

            List<Patient> patientList = new List<Patient>();

            // Open the connection
            if (db.OpenConnection())
            {
                if (queryStrings.Count > 0)
                {
                    String query = "";

                    for (int i = 0; i < queryStrings.Count; ++i)
                    {
                        query += queryStrings[i];

                        if (i != queryStrings.Count - 1) query += " AND ";
                    }

                    // Access the patient table and get all matching rows (should only be one).
                    DbDataReader dr = db.Select("SELECT patients.* FROM patients WHERE " + query + ";");

                    //Read the data and store it in the new patient instance
                    while (dr.Read())
                    {
                        Patient patientDetails = new Patient();
                        patientDetails.PatientID = dr.GetInt32(0);
                        patientDetails.FirstName = dr.GetString(1);
                        patientDetails.LastName = dr.GetString(2);
                        patientDetails.DateOfBirth = dr.GetDateTime(3);
                        patientDetails.Gender = (PersonGender)dr.GetInt32(4);
                        patientDetails.TelephoneNumber = dr.GetString(5);
                        patientDetails.EmailAddress = dr.GetString(6);
                        patientDetails.AddressLine1 = dr.GetString(7);
                        patientDetails.AddressLine2 = dr.GetString(8);
                        patientDetails.City = dr.GetString(9);
                        patientDetails.County = dr.GetString(10);
                        patientDetails.PostCode = dr.GetString(11);
                        patientDetails.MaritalStatus = dr.GetString(12);

                        patientList.Add(patientDetails);
                    }

                    //close Data Reader
                    dr.Close();
                }
                db.CloseConnection();
            }


            // Return the newly created patient instance
            return patientList;
        }

        // Return all tests for a specific patient
        public static List<Test> GetPatientTests(int patientID)
        {
            Database db = Database.Instance();

            List<Test> testList = new List<Test>();

            // Open the connection
            if (db.OpenConnection())
            {
                // Access the patient table and get all matching rows (should only be one).
                DbDataReader dr = db.Select("SELECT * FROM testresults WHERE patientID=" + patientID + " ORDER BY testDate DESC;");

                //Read the data and store it in the new patient instance
                while (dr.Read())
                {
                    Test testDetails = new Test();
                    testDetails.PatientID = dr.GetInt32(1);
                    testDetails.StaffID = dr.GetInt32(2);
                    testDetails.TestDate = dr.GetDateTime(3);
                    testDetails.TestType = (TestType) dr.GetInt32(4);
                    testDetails.TestResult = dr.GetString(5);

                    testList.Add(testDetails);
                }

                //close Data Reader
                dr.Close();
                db.CloseConnection();
            }

            // Return the newly created patient instance
            return testList;
        }

        // Update a patients details
        public static bool ModifyPatientDetails(Patient oldPatientDetails, Patient patient)
        {
            Database db = Database.Instance();
                      
            if (db.OpenConnection())
            {
                if (PatientExists(oldPatientDetails))
                {
                    // Build the query string
                    String newPatientQuery;
                    String sqlFormattedDate = patient.DateOfBirth.Date.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    newPatientQuery = "UPDATE patients SET firstName='" + patient.FirstName +
                    "', lastName='" + patient.LastName +
                    "', DoB='" + sqlFormattedDate +
                    "', gender='" + (int)patient.Gender +
                    "', telNo='" + patient.TelephoneNumber +
                    "', email='" + patient.EmailAddress +
                    "', addressLine1='" + patient.AddressLine1 +
                    "', addressLine2='" + patient.AddressLine2 +
                    "', city='" + patient.City +
                    "', county='" + patient.County +
                    "', postCode='" + patient.PostCode +
                    "', maritalStatus='" + patient.MaritalStatus + "' WHERE patientID=" + patient.PatientID + ";";

                    // Insert the entry into the database
                    db.Update(newPatientQuery);

                    // Close the connection
                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }

            return false;
        }

        // Attempt to add a new test to the database
        public static bool AddTest(Test test)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                // Check if the test doesn't already exist
                if (!TestExists(test))
                {
                    String newTestQuery;
                    String sqlFormattedDate = test.TestDate.Date.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    newTestQuery = "INSERT INTO testresults VALUES(NULL, '" + test.PatientID + "'," +
                    "" + test.StaffID + "," +
                    "'" + sqlFormattedDate + "'," +
                    "" + (int)test.TestType + "," +
                    "'" + test.TestResult + "');";

                    // Insert the entry into the database
                    db.Insert(newTestQuery);

                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            return false;
        }

        // Attempt to add a new test to the database
        //public static bool RemoveTest(Test test)
        //{
        //    Database db = Database.Instance();

        //    if (db.OpenConnection())
        //    {
        //        // Check if the test doesn't already exist
        //        if (TestExists(test))
        //        {
        //            String removeTestQuery;
        //            String sqlFormattedDate = test.TestDate.Date.ToString("yyyy-MM-dd HH:mm:ss");

        //            // Create the query string to be inserted
        //            removeTestQuery = "DELETE FROM testresults WHERE patientID='" + test.PatientID + 
        //            "' and staffID='" + test.StaffID + 
        //            "' and testDate='" + sqlFormattedDate +
        //            "' and testType='" + (int) test.TestType + 
        //            "' and testResult='" + test.TestResult + "';";

        //            // Insert the entry into the database
        //            db.Delete(removeTestQuery);

        //            db.CloseConnection();
        //            return true;
        //        }
        //        db.CloseConnection();
        //    }
        //    return false;
        //}

        // Add a new prescription to a patient
        public static bool AddPrescription(Prescription prescription)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                // Check if the test doesn't already exist
                if (!PrescriptionExists(prescription))
                {
                    String newPrescriptionQuery;

                    // Format the test date
                    String sqlFormattedStartDate = prescription.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
                    String sqlFormattedEndDate = prescription.EndDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    newPrescriptionQuery = "INSERT INTO prescriptions VALUES(NULL, '" + prescription.PatientID + "'," +
                    "'" + prescription.StaffID + "'," +
                    "'" + sqlFormattedStartDate + "'," +
                    "'" + sqlFormattedEndDate + "'," +
                    "'" + Convert.ToInt32(prescription.Extended) + "'); SELECT @@IDENTITY;";

                    // Insert the entry into the database
                    int prescriptionID = db.InsertScalar(newPrescriptionQuery);

                    foreach (Medicine m in prescription.Medicines)
                    {
                        // Insert the entry into the login table with the new staffID
                        String addMedicinesQuery = "INSERT INTO prescriptions_medicine VALUES(NULL, " + prescriptionID + ",'" + m.MedicineID + "');";
                        db.Insert(addMedicinesQuery);
                    }

                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            return false;
        }

        // Extend the duration of a current prescription
        public static bool ExtendPrescription(Prescription prescription)
        {
            Database db = Database.Instance();

            if (db.OpenConnection())
            {
                // Check if the test doesn't already exist
                if (PrescriptionExists(prescription))
                {
                    String newPrescriptionQuery;

                    // Format the test date
                    String sqlFormattedEndDate = prescription.EndDate.AddDays(30).ToString("yyyy-MM-dd HH:mm:ss");

                    // Create the query string to be inserted
                    newPrescriptionQuery = "UPDATE prescriptions SET endDate='" + sqlFormattedEndDate +"', extended=1 " +
                    "WHERE prescriptionID=" + prescription.PrescriptionID + ";";

                    // Insert the entry into the database
                    db.Update(newPrescriptionQuery);

                    db.CloseConnection();
                    return true;
                }
                db.CloseConnection();
            }
            return false;
        }

        // Get a list of all stored medicines
        public static List<Medicine> GetAllMedicines()
        {
            Database db = Database.Instance();
            List<Medicine> _medicines = new List<Medicine>();

            if (db.OpenConnection())
            {
                //Build the query String
                String newMedicineQuery;

                //Create the query to be inserted
                newMedicineQuery = "SELECT * FROM Medicine";

                DbDataReader dr = db.Select(newMedicineQuery);
                while (dr.Read())
                {
                    Medicine medicine = new Medicine();
                    medicine.MedicineID = dr.GetInt32(0);
                    medicine.MedicineName = dr.GetString(1);
                    medicine.Dosage = dr.GetString(2);

                    _medicines.Add(medicine);
                }

                db.CloseConnection();
                
            }
            return _medicines;            
        }

    }
}
