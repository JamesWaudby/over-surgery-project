using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    // Enum for track different Absence Types
    public enum AbsenceType
    {
        Holiday = 0, Illness, InSugery, Offsite
    }

    public class Absence
    {
        private int _staffID;
        private AbsenceType _absenceType;
        private DateTime _startDate;
        private DateTime _endDate;

        // Unique Staff identifier
        public int StaffID
        {
            get { return _staffID; }
            set { _staffID = value; }
        }

        // Which type of absence it is
        public AbsenceType AbsenceType
        {
            get { return _absenceType; }
            set { _absenceType = value; }
        }

        // When the absence began / will begin
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        // When it ended / will end
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        // Overriden Equals method for Unit Testing
        public override bool Equals(object obj)
        {
            if ((obj == null || !this.GetType().Equals(obj.GetType())))
            {
                return false;
            }

            Absence a = (Absence)obj;

            return (this._absenceType==a._absenceType)
                && (this._endDate==a._endDate) 
                && (this._staffID==a._staffID) 
                && (this._startDate==a._startDate);

        }
    }
}
