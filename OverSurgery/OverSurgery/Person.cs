using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    //This enum allows the gender to be stored in the database as an integer and read in as a string to be
    //displayed on the program
    public enum PersonGender { Male = 0, Female }

    public class Person
    {
        private String _firstName;
        private String _lastName;
        private String _addressLine1;
        private String _addressLine2;
        private String _city;
        private String _county;
        private String _postCode;
        private DateTime _dateOfBirth;
        private String _emailAddress;
        private PersonGender _gender;
        private String _maritalStatus;

        private String _telephoneNumber;

        //Properties for the variables, so they can be accessed from other parts of the system
        public String AddressLine1
        {
            set { _addressLine1 = value; }
            get { return _addressLine1; }
        }

        public String AddressLine2
        {
            set { _addressLine2 = value; }
            get { return _addressLine2; }
        }

        public String City
        {
            set { _city = value; }
            get { return _city; }
        }

        public String County
        {
            set { _county = value; }
            get { return _county; }
        }

        public DateTime DateOfBirth
        {
            set { _dateOfBirth = value; }
            get { return _dateOfBirth; }
        }

        public String EmailAddress
        {
            set { _emailAddress = value; }
            get { return _emailAddress; }
        }

        public String FirstName
        {
            set { _firstName = value; }
            get { return _firstName; }
        }

        public PersonGender Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }

        public String LastName
        {
            set { _lastName = value; }
            get { return _lastName; }
        }

        public String MaritalStatus
        {
            set { _maritalStatus = value; }
            get { return _maritalStatus; }
        }

        public String PostCode
        {
            set { _postCode = value; }
            get { return _postCode; }
        }

        public String TelephoneNumber
        {
            set { _telephoneNumber = value; }
            get { return _telephoneNumber; }
        }

        public String Name
        {
            get { return _firstName + " " + _lastName; }
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null || !this.GetType().Equals(obj.GetType())))
            {
                return false;
            }

            Person a = (Person)obj;
            return ((this._addressLine1==a._addressLine1) && (this._addressLine2==a._addressLine2)
                && (this._city==a._city) && (this._county==a._county) && (this._dateOfBirth==a._dateOfBirth)
                && (this._emailAddress==a._emailAddress) && (this._firstName==a._firstName) 
                && (this._gender==a._gender) && (this._lastName==a._lastName) && (this._maritalStatus==a._maritalStatus)
                && (this._postCode==a._postCode) && (this._telephoneNumber==a._telephoneNumber));
        }

    }
}
