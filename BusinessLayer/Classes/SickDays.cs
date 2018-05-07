using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer.Classes
{
    public class SickDays : ISickDays
    {
        internal SickDays() { }

        internal int _SickDayID;
        internal DateTime _SickDayDate;
        internal Double _SickDayLength;
        internal String _SickDayDescription;
        internal int _empId;

        public int SickDayID
        {
            get { return _SickDayID; }
            set { _SickDayID = value; }
        }
        public DateTime SickDayDate
        {
            get { return _SickDayDate; }
            set { _SickDayDate = value; }
        }
        public Double SickDayLength
        {
            get { return _SickDayLength; }
            set { _SickDayLength = value; }
        }
        public String SickDayDescription
        {
            get { return _SickDayDescription; }
            set { _SickDayDescription = value; }
        }
        public int empId
        {
            get { return _empId; }
            set { _empId = value; }
        }
    }
}
