using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class UserSession
    {
        // Only possible instance of this class.
        private static UserSession _instance;

        // Tracks the currently logged in user
        private Staff _currentUser;

        // Return the singleton instance if it exists
        // If not, create the instance
        public static UserSession Instance()
        {
            // Check if the instance already exists
            if (null == _instance)
            {
                // If no instance exists, create one
                _instance = new UserSession();
            }

            return _instance;
        }

        // Set and get the current staff using the system
        public Staff CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

    }
}
