using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class LoginController : Controller
    {
        public LoginController()
        {

        }

        // Attempt to login based on user input
        public bool Login(int userID, String password)
        {
            // Check if the user id and password match an entry in the database
            if (BusinessMetaLayer.CheckLoginDetails(userID, GetSHAHash(password)))
            {
                UserSession _userSession = UserSession.Instance();

                // Retrieve all of the data about that staff member
                _userSession.CurrentUser = BusinessMetaLayer.GetStaffDetails(userID);
                return true;
            }
            return false;
        }

        // Update the staff password
        public bool SetStaffPassword(Staff staff, string password)
        {
            staff.FirstName = EncodeMySql(staff.FirstName);
            staff.LastName = EncodeMySql(staff.LastName);
            staff.AddressLine1 = EncodeMySql(staff.AddressLine1);
            staff.AddressLine2 = EncodeMySql(staff.AddressLine2);
            staff.City = EncodeMySql(staff.City);
            staff.County = EncodeMySql(staff.County);
            staff.PostCode = EncodeMySql(staff.PostCode);
            staff.DateOfBirth = staff.DateOfBirth;
            staff.EmailAddress = EncodeMySql(staff.EmailAddress);
            staff.TelephoneNumber = EncodeMySql(staff.TelephoneNumber);
            staff.MaritalStatus = EncodeMySql(staff.MaritalStatus);
            staff.Gender = staff.Gender;
            staff.Permissions = staff.Permissions;

            return BusinessMetaLayer.SetStaffPassword(staff, GetSHAHash(password));
        }
    }
}
