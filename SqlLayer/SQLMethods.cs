﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace SqlLayer
{
    public class POSQL
    {
        public static DataTable RetrieveAllPOs()
        {
            List<parameters> parms = new List<parameters>();
            return DAL.GetData("GetAllOrders", parms);
        }

        public static DataTable RetrieveDepartment(int id)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empId", id, SqlDbType.Int, ParameterDirection.Input));
            return DAL.GetData("GetDepartment", parms);
        }

        public static DataTable RetrieveAllPendingPOs()
        {
            List<parameters> parms = new List<parameters>();
            return DAL.GetData("GetAllPendingOrders", parms);
        }

        public static DataTable RetrieveAllClosedPOs()
        {
            List<parameters> parms = new List<parameters>();
            return DAL.GetData("GetAllClosedOrders", parms);
        }

        public static DataTable RetrieveAllPOsByDate(byte orderStatus, DateTime startDate, DateTime endDate)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@orderStatus", orderStatus, SqlDbType.SmallInt, ParameterDirection.Input));
            parms.Add(new parameters("@startDate", startDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@endDate", endDate, SqlDbType.Date, ParameterDirection.Input));
            return DAL.GetData("GetOrdersByDateProcess", parms);
        }

        public static DataTable RetrieveAllPOsByName(byte orderStatus, string name)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@orderStatus", orderStatus, SqlDbType.SmallInt, ParameterDirection.Input));
            parms.Add(new parameters("@name", name, SqlDbType.VarChar, ParameterDirection.Input));
            return DAL.GetData("GetOrdersByNameProcess", parms);
        }

        public static DataTable RetrievePOById(int orderNumber)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@orderNumber", orderNumber, SqlDbType.Int, ParameterDirection.Input, 8));
            return DAL.GetData("GetOrderById", parms);
        }

        public static DataTable RetrievePOByName(string name)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@name", name, SqlDbType.VarChar, ParameterDirection.Input));
            return DAL.GetData("GetOrderByName", parms);
        }

        public static DataTable RetrievePOByDate(DateTime startDate, DateTime endDate)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@startDate", startDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@endDate", endDate, SqlDbType.Date, ParameterDirection.Input));
            return DAL.GetData("GetOrderByDate", parms);
        }

        public static DataTable RetrieveItemById(int orderNumber)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@orderNumber", orderNumber, SqlDbType.Int, ParameterDirection.Input, 8));
            return DAL.GetData("GetItemsById", parms);
        }

        public static bool ModItem(IItem item)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@id", item.ItemId, SqlDbType.Int, ParameterDirection.Input, 8));
            parms.Add(new parameters("@qty", item.Quantity, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@price", item.Price, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new parameters("@location", item.Location, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new parameters("@reason", item.ReasonForMod, SqlDbType.VarChar, ParameterDirection.Input, 255));
            DAL.SendData("ModItem", parms);
            return true;
        }

        public static bool UpdatePO(IItem item)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@itemId", item.ItemId, SqlDbType.Int, ParameterDirection.Input, 8));
            parms.Add(new parameters("@name", item.ItemName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@description", item.Description, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new parameters("@qty", item.Quantity, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@price", item.Price, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new parameters("@location", item.Location, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new parameters("@jusitification", item.Justification, SqlDbType.VarChar, ParameterDirection.Input, 255));
            DAL.SendData("ModifyPO", parms);
            return true;
        }

        public static bool ProcessItem(int itemId, byte itemStatus)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@itemId", itemId, SqlDbType.Int, ParameterDirection.Input, 8));
            parms.Add(new parameters("@itemStatus", itemStatus, SqlDbType.TinyInt, ParameterDirection.Input, 1));
            DAL.SendData("ProcessItem", parms);
            return true;
        }

        public static bool ProcessOrder(int orderNumber, byte orderStatus)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@orderNumber", orderNumber, SqlDbType.Int, ParameterDirection.Input, 8));
            parms.Add(new parameters("@orderStatus", orderStatus, SqlDbType.TinyInt, ParameterDirection.Input, 1));
            DAL.SendData("ProcessPO", parms);
            return true;
        }

        public static DataTable CreatePO(IItem item, int empId)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@name", item.ItemName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@description", item.Description, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new parameters("@qty", item.Quantity, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@price", item.Price, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new parameters("@location", item.Location, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new parameters("@justification", item.Justification, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new parameters("@total", item.Price, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new parameters("@empId", empId, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@orderNumberIn", null, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@orderNumberOut", 0, SqlDbType.Int, ParameterDirection.Output));
            return DAL.GetData("CreatePO", parms);
        }

        public static int CreatePO(IPurchaseOrder po)
        {
            List<parameters> parms = new List<parameters>();

            foreach (var item in po.Items)
            {
                parms.Add(new parameters("@name", item.ItemName, SqlDbType.VarChar, ParameterDirection.Input, 30));
                parms.Add(new parameters("@description", item.Description, SqlDbType.VarChar, ParameterDirection.Input, 255));
                parms.Add(new parameters("@qty", item.Quantity, SqlDbType.Int, ParameterDirection.Input));
                parms.Add(new parameters("@price", item.Price, SqlDbType.Money, ParameterDirection.Input));
                parms.Add(new parameters("@location", item.Location, SqlDbType.VarChar, ParameterDirection.Input, 50));
                parms.Add(new parameters("@justification", item.Justification, SqlDbType.VarChar, ParameterDirection.Input, 255));
                parms.Add(new parameters("@total", item.Price, SqlDbType.Money, ParameterDirection.Input));
                parms.Add(new parameters("@empId", po.EmpId, SqlDbType.Int, ParameterDirection.Input));
                parms.Add(new parameters("@orderNumberIn", po.OrderNumber, SqlDbType.Int, ParameterDirection.Input));
                parms.Add(new parameters("@orderNumberOut", 0, SqlDbType.Int, ParameterDirection.Output));
                DAL.SendData("CreatePO", parms);
            }

            parameters myParms = parms[9];
            int orderNumber = Convert.ToInt32(myParms.value);

            return orderNumber;
        }
    }
    public class HRSQL
    {

        // INSERTS NEW EMPLOYEE RECORD THEN RETURNS THE ID.
        public static int CreateNewEmployee(IEmployee emp)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@firstName", emp.FirstName, SqlDbType.VarChar, ParameterDirection.Input, 20));
            parms.Add(new parameters("@middleInitial", emp.MiddleInitial, SqlDbType.Char, ParameterDirection.Input, 1));
            parms.Add(new parameters("@lastName", emp.LastName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@dob", emp.DateOfBirth, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@address", emp.StreetAddress, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@city", emp.City, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@pCode", emp.PostalCode, SqlDbType.VarChar, ParameterDirection.Input, 7));
            parms.Add(new parameters("@sin", emp.SIN, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@cellPNumber", emp.CellPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@workPNumber", emp.WorkPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@email", emp.EmailAddress, SqlDbType.VarChar, ParameterDirection.Input, 40));
            parms.Add(new parameters("@hireDate", emp.HireDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@jobStartDate", emp.JobStartDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@payrollEmail", emp.EmailNotification, SqlDbType.Bit, ParameterDirection.Input));
            parms.Add(new parameters("@biWeeklyRate", emp.BiWeeklyRate, SqlDbType.Float, ParameterDirection.Input));
            parms.Add(new parameters("@jobID", emp.JobID, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@departmentID", emp.DepartmentID, SqlDbType.Int, ParameterDirection.Input));

            parms.Add(new parameters("@empID", emp.EmpID, SqlDbType.Int, ParameterDirection.Output));

            DAL.SendData("CreateEmployee", parms);

            emp.EmpID = Convert.ToInt32(parms[17].value);

            return emp.EmpID;
        }

        //RETRIEVES EMPLOYEE BY NAME
        public static DataTable RetrieveEmployeeByName(String name)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empName", name, SqlDbType.VarChar, ParameterDirection.Input, 30));
            return DAL.GetData("SearchForEmployeesByName", parms);
        }
        //RETRIEVES EMPLOYEE BY ID
        public static DataTable RetrieveEmployeeByID(Int32 ID)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", ID, SqlDbType.Int, ParameterDirection.Input));
            return DAL.GetData("SearchForEmployeesByID", parms);
        }

        // RETRIEVES ALL DATA FROM DEPARTMENT.
        public static DataTable RetrieveDepartments()
        {
            return DAL.GetData("GetAllDepartments");
        }

        // RETRIEVES ALL DATA FROM JOB.
        public static DataTable RetrieveJobs()
        {
            return DAL.GetData("GetAllJobs");
        }

        //RETRIEVES JOB BY EMPID
        public static DataTable RetrieveJobByEmpID(int empID)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", empID, SqlDbType.Int, ParameterDirection.Input));
            
            return DAL.GetData("getJobByEmpID", parms);
        }


        public static Boolean CreatePerformanceIncrease(int EmpID, Double percentage, DateTime dateOfIncrease)
        {
            List<parameters> parms = new List<parameters>();

            parms.Add(new parameters("@empID", EmpID, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@percentageIncrease", percentage, SqlDbType.VarChar, ParameterDirection.Input, 20));
            parms.Add(new parameters("@dateOfIncrease", dateOfIncrease, SqlDbType.DateTime, ParameterDirection.Input));
            
            DAL.SendData("EmployeePerformanceIncrease", parms);
            
            return true;
        }
        public static Boolean CreateCostOfLivingIncrease(Double percentage, DateTime dateOfIncrease)
        {
            List<parameters> parms = new List<parameters>();
            
            parms.Add(new parameters("@percentageIncrease", percentage, SqlDbType.VarChar, ParameterDirection.Input, 20));
            parms.Add(new parameters("@dateOfIncrease", dateOfIncrease, SqlDbType.DateTime, ParameterDirection.Input));

            DAL.SendData("EmployeeCostOfLivingIncrease", parms);

            return true;
        }
       public static Boolean HasCalculatePayrollBeenRun()
        {

            DataTable tmpDataTable = DAL.GetData("HasCalculatePayrollBeenRun");

            if(tmpDataTable.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        // CALCULATES PAYROLL AND GENERATES PAYSTUBS
        public static Boolean CalculatePayroll()
        {
            DAL.GetData("CalculatePayroll");

            return true;
        }

        //GETS TODAYS PAYSTUBS
        public static DataTable RetrieveTodaysPayStubs()
        {
            DataTable tmpDataTable = DAL.GetData("GetAllPaystubsForToday");
            
            return tmpDataTable;
        }

        //GETS TODAYS PAYSTUBS EMAIL
        public static DataTable RetrieveTodaysPayStubsEmail()
        {
            DataTable tmpDataTable = DAL.GetData("GetAllPaystubsForTodayEMAIL");

            return tmpDataTable;
        }

        //GETS PAYSTUBS BY EMPLOYEE ID / DATE
        public static DataTable RetrievePaystubsForEmpBetweenDates(int empid, DateTime startDate, DateTime endDate)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", empid, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@startDate", startDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@endDate", endDate, SqlDbType.Date, ParameterDirection.Input));

            DataTable tmpDataTable = DAL.GetData("GetPaystubsForEmpBetweenDates", parms);

            return tmpDataTable;
        }

        //GETS Employees who want their paystubs sent to them.
        public static DataTable RetrieveEmployeesForEmailPaystubs()
        {
            DataTable tmpDataTable = DAL.GetData("GetAllEmployeesEMAIL");

            return tmpDataTable;
        }
        // GETS TODAYS PAYSTUB BY ID
        public static DataTable RetrieveTodaysPaystubByID(int ID)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", ID, SqlDbType.Int, ParameterDirection.Input));
            DataTable tmpDataTable = DAL.GetData("GetPaystubForTodayByID", parms);

            return tmpDataTable;
        }

        public static Boolean ValidatePayrollCode(string entryCode)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@entryText", entryCode, SqlDbType.VarChar, ParameterDirection.Input, 8));

            DataTable tmpDataTable = DAL.GetData("[ValidatePaystub]", parms);
            
            Boolean tmpBool = Convert.ToBoolean(tmpDataTable.Rows[0]["result"]);
            return tmpBool;
        }
        
        public static Boolean ModifyEmployee(IEmployee emp)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", emp.EmpID, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@firstName", emp.FirstName, SqlDbType.VarChar, ParameterDirection.Input, 20));
            parms.Add(new parameters("@middleInitial", emp.MiddleInitial, SqlDbType.Char, ParameterDirection.Input, 1));
            parms.Add(new parameters("@lastName", emp.LastName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@dob", emp.DateOfBirth, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@address", emp.StreetAddress, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@city", emp.City, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@pCode", emp.PostalCode, SqlDbType.VarChar, ParameterDirection.Input, 7));
            parms.Add(new parameters("@sin", emp.SIN, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@cellPNumber", emp.CellPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@workPNumber", emp.WorkPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@email", emp.EmailAddress, SqlDbType.VarChar, ParameterDirection.Input, 40));
            parms.Add(new parameters("@hireDate", emp.HireDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@jobStartDate", emp.JobStartDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@payrollEmail", emp.EmailNotification, SqlDbType.Bit, ParameterDirection.Input));
            parms.Add(new parameters("@jobID", emp.JobID, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@departmentID", emp.DepartmentID, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@empStatus", emp.EmpStatus, SqlDbType.SmallInt, ParameterDirection.Input));
            parms.Add(new parameters("@dateOfDeparture", emp.DateOfDeparture, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@biWeeklyRate", emp.BiWeeklyRate, SqlDbType.Float, ParameterDirection.Input));

            //long longVar = BitConverter.ToInt64(emp.lastTouched, 0);
            //DateTime dateTime = new DateTime(1980, 1, 1).AddMilliseconds(longVar);

            parms.Add(new parameters("@timeStamp", emp.lastTouched, SqlDbType.Timestamp, ParameterDirection.Input));
            
            DAL.SendData("ModifyEmployee", parms);
            
            return true;
        }

        // RETRIEVE 
        public static DataTable RetrieveSickDaysByempID(int ID)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", ID, SqlDbType.Int, ParameterDirection.Input));
            DataTable tmpDataTable = DAL.GetData("GetSickDaysByID", parms);

            return tmpDataTable;
        }
        public static Boolean CreateNewSickDay(ISickDays sickDay)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@sickDayDate", sickDay.SickDayDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@sickDayLength", sickDay.SickDayLength, SqlDbType.Float, ParameterDirection.Input));
            parms.Add(new parameters("@sickDayDescription", sickDay.SickDayDescription, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new parameters("@empId", sickDay.empId, SqlDbType.Int, ParameterDirection.Input));
            
            DAL.SendData("CreateSickDay", parms);

            return true;
        }

        public static DataTable RetrieveNumberOfSickDays(int empID)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", empID, SqlDbType.Int, ParameterDirection.Input));

            return DAL.GetData("GetSumOfSickDays", parms);
        }

        // GET FULL PENSION AMOUNT
        public static DataTable RetrieveEmployeePension(int empID)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", empID, SqlDbType.Int, ParameterDirection.Input));

            return DAL.GetData("CalculatePension", parms);
        }

        // EMPLOYEE UPDATE INFO
        public static Boolean UpdateEmployeeEmp(IEmployee emp)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", emp.EmpID, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@workPhoneNumber", emp.WorkPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@cellPhoneNumber", emp.CellPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@address", emp.StreetAddress, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@city", emp.City, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@postalCode", emp.PostalCode, SqlDbType.VarChar, ParameterDirection.Input, 7));
            parms.Add(new parameters("@timeStamp", emp.lastTouched, SqlDbType.Timestamp, ParameterDirection.Input));

            DAL.SendData("EmployeeModifyEmployee", parms);
            return true;
        }

        // AUTHENTICATE LOGIN
        public static DataTable AuthenticateEmployee(int empId, string password)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@empID", empId, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@password", password, SqlDbType.VarChar, ParameterDirection.Input, 30));
            
            return DAL.GetData("AuthenticateUser", parms);
        }
    }
}
