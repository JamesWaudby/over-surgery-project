using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class ManagementController : AdminController
    {

        public ManagementController()
        {

        }

        // Add a new member of staff based on user entered data
        public bool AddStaff(int staffID, String firstName, 
            String lastName,
            String addressLine1, 
            String addressLine2,
            String city, 
            String county,
            String postCode, 
            DateTime dateOfBirth,
            String emailAddress, 
            PersonGender gender,
            String maritalStatus, 
            String telephoneNumber,
            PermissionsFlag permissions, 
            String password)
        {
            // Create a new member of staff with all of their details
            Staff newStaff = new Staff();
            newStaff.StaffID = staffID;
            newStaff.FirstName = EncodeMySql(firstName);
            newStaff.LastName = EncodeMySql(lastName);
            newStaff.AddressLine1 = EncodeMySql(addressLine1);
            newStaff.AddressLine2 = EncodeMySql(addressLine2);
            newStaff.City = EncodeMySql(city);
            newStaff.County = EncodeMySql(county);
            newStaff.PostCode = EncodeMySql(postCode);
            newStaff.DateOfBirth = dateOfBirth;
            newStaff.EmailAddress = EncodeMySql(emailAddress);
            newStaff.TelephoneNumber = EncodeMySql(telephoneNumber);
            newStaff.MaritalStatus = EncodeMySql(maritalStatus);
            newStaff.Gender = gender;
            newStaff.Permissions = permissions;

            SavePasswordFile(newStaff, password);

            return BusinessMetaLayer.AddStaffDetails(newStaff, GetSHAHash(password));
        }
        
        // Update a specific member of staff based on user entered data
        public bool ModifyStaff(Staff oldStaff, int ID, string firstName, string lastName, int genderInt, string dob, string status,
                                        string telNo, string address1, string address2, string city, string county,
                                            string postCode, string email)
        {
            Staff staff = new Staff();

            // set all attris
            PersonGender gender;
            Enum.TryParse<PersonGender>(genderInt.ToString(), out gender);
            DateTime dateOfBirth = Convert.ToDateTime(dob);

            staff.StaffID = ID;
            staff.FirstName = firstName;
            staff.LastName = lastName;
            staff.Gender = gender;
            staff.DateOfBirth = dateOfBirth;
            staff.MaritalStatus = status;
            staff.TelephoneNumber = telNo;
            staff.AddressLine1 = address1;
            staff.AddressLine2 = address2;
            staff.City = city;
            staff.County = county;
            staff.PostCode = postCode;
            staff.EmailAddress = email;

            return BusinessMetaLayer.ModifyStaffDetails(oldStaff, staff);
        }

        // Add a new absence for a member of staff
        public bool AddAbsence(int staffID, int absenceType, string startDate, string endDate)
        {
            Absence absence = new Absence();
            absence.StaffID = staffID;
            absence.AbsenceType = (AbsenceType)absenceType;
            absence.StartDate = Convert.ToDateTime(startDate);
            absence.EndDate = Convert.ToDateTime(endDate);

            return BusinessMetaLayer.AddAbsence(absence);
        }

        // Remove an absence for a member of staff
        public bool RemoveAbsence(Absence absence)
        {
            return BusinessMetaLayer.RemoveAbsence(absence);
        }

        /*public bool ModifyAbsence()
        {
            //return BusinessMetaLayer.ModifyAbsence();
        }*/

        // Flag a member of staff for a password reset
        public bool ResetPassword(int staffID, String newPassword)
        {
            return BusinessMetaLayer.ResetStaffPassword(staffID, GetSHAHash(newPassword));
        }

        // Return the value of the next staff member to be added
        public int GetNextStaffID()
        {
            return BusinessMetaLayer.GetNextStaffID();
        }
    }
}
