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
        int JobID { get; set; }
        int DepartmentID { get; set; }
        int EmpStatus { get; set; } // REPLACE WITH ENUM or some variation
        DateTime DateOfDeparture { get; set; }
        Double BiWeeklyRate { get; set; }

    }

    public enum empStatus
    {
        Active,
        Retired,
        Terminated
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
        int EmpID { get; set; }
        Boolean HasBeenApplied { get; set; }
    }
    
    public interface IPayStub
    {
        int PayStubID { get; set; }
        Double GrossPay { get; set; }
        Double Deductions { get; set; }
        Double CPP { get; set; }
        Double EI { get; set; }
        Double CompanyPensionDeduction { get; set; }
        int EmpID { get; set; }
        DateTime CreationDate { get; set; }
        Double YTDGrossPay { get; set; }
        Double YTDDeductions { get; set; }
        Double YTDCPP { get; set; }
        Double YTDEI { get; set; }
        Double YTDCompanyPensionDeduction { get; set; }

    }

    public interface IItem
    {
        int ItemId { get; set; }
        string ItemName { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }
        string Location { get; set; }
        string Justification { get; set; }
        ItemStatus ItemStatus { get; set; }
        int OrderNumber { get; set; }
    }


    public interface IPurchaseOrder
    {
        int OrderNumber { get; set; }
        OrderStatus OrderStatus { get; set; }
        DateTime OrderDate { get; set; }
        double Total { get; set; }
        double Tax { get; set; }
        double GrandTotal { get; set; }
        int EmpId { get; set; }
        List<IItem> Items { get; set; }
    }

    public enum ItemStatus
    {
        Pending,
        Approved,
        Denied
    }

    public enum OrderStatus
    {
        Pending,
        UnderReview,
        Closed
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
