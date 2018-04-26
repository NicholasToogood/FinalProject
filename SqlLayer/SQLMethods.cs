using DataAccessLayer;
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
        public static DataTable RetrievePOById(int orderNumber)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@orderNumber", orderNumber, SqlDbType.Int, ParameterDirection.Input, 8));
            return DAL.GetData("GetOrderById", parms);
        }

        public static DataTable RetrievePOByDAte(DateTime startDate, DateTime endDate)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@startDate", startDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@endDate", endDate, SqlDbType.Date, ParameterDirection.Input));
            return DAL.GetData("GetOrderByDate", parms);
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
            int orderNumber = 0;

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
                orderNumber = DAL.SendData("CreatePO", parms);
            }
            return orderNumber;
        }
    }
    public class HRSQL
    {
        public static int CreateNewEmployee(IEmployee emp)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@firstName", emp.FirstName, SqlDbType.VarChar, ParameterDirection.Input, 20));
            parms.Add(new parameters("@middleInitial", emp.MiddleInitial, SqlDbType.Char, ParameterDirection.Input, 1));
            parms.Add(new parameters("@lastName", emp.LastName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@dob", emp.DateOfBirth, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@address", emp.StreetAddress, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@city", emp.City, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@pCode", emp.DateOfBirth, SqlDbType.VarChar, ParameterDirection.Input, 7));
            parms.Add(new parameters("@sin", emp.SIN, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@cellPNumber", emp.CellPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@workPNumber", emp.WorkPhoneNumber, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new parameters("@email", emp.EmailAddress, SqlDbType.VarChar, ParameterDirection.Input, 40));
            parms.Add(new parameters("@hireDate", emp.HireDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@jobStartDate", emp.JobStartDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@payrollEmail", emp.EmailNotification, SqlDbType.Bit, ParameterDirection.Input));
            parms.Add(new parameters("@biWeeklyRate", emp.BiWeeklyRate, SqlDbType.Float, ParameterDirection.Input));
            parms.Add(new parameters("@jobID", emp.JobID, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@departmentID", emp.JobID, SqlDbType.Int, ParameterDirection.Input));
            
            DAL.SendData("CreateEmployee", parms);

            emp.EmpID = Convert.ToInt32(parms[18].value);

            return emp.EmpID;
        }
    }
}
