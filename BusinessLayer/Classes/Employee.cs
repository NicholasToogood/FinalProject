﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class Employee : IEmployee
    {
        internal Employee() { }

        internal int _EmpID;
        internal string _FirstName;
        internal string _MiddleInitial;
        internal string _LastName;
        internal DateTime _DateOfBirth;
        internal string _StreetAddress;
        internal string _City;
        internal string _PostalCode;
        internal int _SIN;
        internal string _CellPhoneNumber;
        internal string _EmailAddress;
        internal DateTime _HireDate;
        internal DateTime _JobStartDate;
        internal string _WorkPhoneNumber;
        internal Boolean _EmailNotification;
        internal int _JobID;
        internal int _DepartmentID;
        internal int _EmpStatus;
        internal DateTime _DateOfDeparture;
        internal Double _BiWeeklyRate;
        internal byte[] _lastTouched;

        public int EmpID
        {
            get { return _EmpID; }
            set { _EmpID = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string MiddleInitial
        {
            get { return _MiddleInitial; }
            set { _MiddleInitial = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public string StreetAddress
        {
            get { return _StreetAddress; }
            set { _StreetAddress = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string PostalCode
        {
            get { return _PostalCode; }
            set { _PostalCode = value; }
        }
        public int SIN
        {
            get { return _SIN; }
            set { _SIN = value; }
        }
        public string CellPhoneNumber
        {
            get { return _CellPhoneNumber; }
            set { _CellPhoneNumber = value; }
        }
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }
        public DateTime HireDate
        {
            get { return _HireDate; }
            set { _HireDate = value; }
        }
        public DateTime JobStartDate
        {
            get { return _JobStartDate; }
            set { _JobStartDate = value; }
        }
        public string WorkPhoneNumber
        {
            get { return _WorkPhoneNumber; }
            set { _WorkPhoneNumber = value; }
        }
        public Boolean EmailNotification
        {
            get { return _EmailNotification; }
            set { _EmailNotification = value; }
        }
        public int JobID
        {
            get { return _JobID; }
            set { _JobID = value; }
        }
        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }
        public int EmpStatus
        {
            get { return _EmpStatus; }
            set { _EmpStatus = value; }
        }
        public DateTime DateOfDeparture
        {
            get { return _DateOfDeparture; }
            set { _DateOfDeparture = value; }
        }
        public Double BiWeeklyRate
        {
            get { return _BiWeeklyRate; }
            set { _BiWeeklyRate = value; }
        }
        public byte[] lastTouched
        {
            get { return _lastTouched; }
            set { _lastTouched = value; }
        }


        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        

    }

}
