using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    class LookupLists
    {
        
    }
    // EMPLOYEE LOOKUPLIST
    public class EmployeeLookupList
    {
        internal EmployeeLookupList() { }
        public int EmpID { get; internal set; }
        public string FirstName { get; internal set; }
        public string MiddleInitial { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string StreetAddress { get; internal set; }
        public string City { get; internal set; }
        public string PostalCode { get; internal set; }
        public int SIN { get; internal set; }
        public string CellPhoneNumber { get; internal set; }
        public string EmailAddress { get; internal set; }
        public DateTime HireDate { get; internal set; }
        public DateTime JobStartDate { get; internal set; }
        public string WorkPhoneNumber { get; internal set; }
        public Boolean EmailNotification { get; internal set; }
        public int JobID { get; internal set; }
        public int SalaryID { get; internal set; }
    }
    // DEPARTMENT LOOKUP LIST
    public class DepartmentLookupList
    {
        internal DepartmentLookupList() { }
        public int DepartmentID { get; internal set; }
        public string DepartmentName { get; internal set; }
        public string Supervisor { get; internal set; }
    }
    // JOB LOOKUP LIST
    public class JobLookupList
    {
        internal JobLookupList() { }
        public int JobID { get; internal set; }
        public Double MaxPay { get; internal set; }
        public String JobTitle { get; internal set; }
        public int DepartmentID { get; set; }
    }
    // SALARY INCREASE LOOKUP LIST
    public class SalaryIncreaseLookupList
    {
        internal SalaryIncreaseLookupList() { }
        public int SalaryIncreaseID { get; internal set; }
        public Double PercentageIncrease { get; internal set; }
        public DateTime DateOfIncrease { get; internal set; }
        public Byte ReasonForIncrease { get; internal set; }
        public int _EmpID { get; internal set; }
    }
    // SALARY LOOKUP LIST
    public class SalaryLookupList
    {
        internal SalaryLookupList() { }

        internal int _SalaryID;
        public Double _BiWeeklyRate { get; internal set; }
        public Double _YearToDateGrossPay { get; internal set; }
        public Double _YearToDateDeductions { get; internal set; }
        public Double _YearToDateCPP { get; internal set; }
        public Double _YearToDateEI { get; internal set; }
        public Double _YearToDateCompanyPensionDeduction { get; internal set; }
    }
}
