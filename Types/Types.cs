using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployee
    {
        int EmpID { get; set; }
        string FirstName { get; set; }
        string MiddleInitial { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string StreetAddress { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        int SIN { get; set; }
        string CellPhoneNumber { get; set; }
        string EmailAddress { get; set; }
        DateTime HireDate { get; set; }
        DateTime JobStartDate { get; set; }
        string WorkPhoneNumber { get; set; }
        Boolean EmailNotification { get; set; }
    }

    public interface IDepartment
    {
        int DepartmentID { get; set; }
        string DepartmentName { get; set; }
        string Supervisor { get; set; }
    }

    public interface IJob
    {
        int JobID { get; set; }
        Double MaxPay { get; set; }
        String JobTitle { get; set; }
    }

    public interface ISalaryIncrease
    {
        int SalaryIncreaseID { get; set; }
        Double PercentageIncrease { get; set; }
        DateTime DateOfIncrease { get; set; }
        Byte ReasonForIncrease { get; set; }
    }
    
    public interface ISalary
    {
        int SalaryID { get; set; }
        Double BiWeeklyRate { get; set; }
        Double YearToDateGrossPay { get; set; }
        Double YearToDateDeductions { get; set; }
        Double YearToDateCPP { get; set; }
        Double YearToDateEI { get; set; }
        Double YearToDateCompanyPensionDeduction { get; set; }
    }

    public interface IPurchaseOrder
    {

    }

    public struct parameters
    {
        public string name;
        public object value;
        public SqlDbType type;
        public ParameterDirection parmDirect;
        public short size;

        public parameters(string name, object value, SqlDbType type, ParameterDirection parmDirect, short size = 0)
        {
            this.name = name;
            this.value = value;
            this.type = type;
            this.parmDirect = parmDirect;
            this.size = size;
        }
    }
}
