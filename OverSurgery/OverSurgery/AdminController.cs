using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class AdminController : Controller
    {
        // Create a new patient and pass it to the meta layer for insertion into the database.
        public bool AddPatient(String firstName,
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
            String telephoneNumber)
        {

            // Create a new member of staff with all of their details
            Patient newPatient = new Patient();
            newPatient.FirstName = EncodeMySql(firstName);
            newPatient.LastName = EncodeMySql(lastName);
            newPatient.AddressLine1 = EncodeMySql(addressLine1);
            newPatient.AddressLine2 = EncodeMySql(addressLine2);
            newPatient.City = EncodeMySql(city);
            newPatient.County = EncodeMySql(county);
            newPatient.PostCode = EncodeMySql(postCode);
            newPatient.DateOfBirth = dateOfBirth;
            newPatient.EmailAddress = EncodeMySql(emailAddress);
            newPatient.TelephoneNumber = EncodeMySql(telephoneNumber);
            newPatient.MaritalStatus = EncodeMySql(maritalStatus);
            newPatient.Gender = gender;

            return BusinessMetaLayer.AddPatientDetails(newPatient);

        }

        // Modify the details of a patient
        public bool ModifyPatient(Patient oldPatient,
            int ID,
            string firstName,
            string lastName,
            int genderInt,
            string dob,
            string status,
            string telNo,
            string address1,
            string address2,
            string city,
            string county,
            string postCode,
            string email)
        {
            Patient patient = new Patient();

            // set all attris
            PersonGender gender;
            Enum.TryParse<PersonGender>(genderInt.ToString(), out gender);
            DateTime dateOfBirth = Convert.ToDateTime(dob);

            patient.PatientID = ID;
            patient.FirstName = EncodeMySql(firstName);
            patient.LastName = EncodeMySql(lastName);
            patient.Gender = gender;
            patient.DateOfBirth = dateOfBirth;
            patient.MaritalStatus = EncodeMySql(status);
            patient.TelephoneNumber = EncodeMySql(telNo);
            patient.AddressLine1 = EncodeMySql(address1);
            patient.AddressLine2 = EncodeMySql(address2);
            patient.City = EncodeMySql(city);
            patient.County = EncodeMySql(county);
            patient.PostCode = EncodeMySql(postCode);
            patient.EmailAddress = EncodeMySql(email);

            return BusinessMetaLayer.ModifyPatientDetails(oldPatient, patient);
        }


        // Create a new appointment and pass it to the meta layer for insertion into the database
        public bool AddAppointment(DateTime startDate, DateTime endDate, Staff staff, Patient patient)
        {
            Appointment newAppointment = new Appointment();
            newAppointment.PatientID = patient.PatientID;
            newAppointment.StaffID = staff.StaffID;
            newAppointment.StartDate = startDate;
            newAppointment.EndDate = endDate;

            return BusinessMetaLayer.AddAppointment(newAppointment);
        }

        // Cancel an already existing appointment by passing it to the business meta layer
        public bool CancelAppointment(Appointment appointment)
        {
            return BusinessMetaLayer.CancelAppointment(appointment);
        }

        // Extend an existing prescription by 30 days if possible
        public bool ExtendPrescription(Prescription prescription)
        {
            if (!prescription.Extended)
            {
                return BusinessMetaLayer.ExtendPrescription(prescription);
            }

            return false;
        }
    }
}
