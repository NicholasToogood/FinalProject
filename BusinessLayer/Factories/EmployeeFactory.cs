using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlLayer;
using Types;

namespace BusinessLayer.Factories
{
    public class EmployeeFactory
    {
        public static Employee CreateEmployee()
        {
            return new Employee();
        }

        public static List<Employee> RetrieveEmployeesByName(String name)
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveEmployeeByName(name);
            List<Employee> employeeList = RetrieveEmployeesRepackage(tmpTable);
            return employeeList;
        }
        public static List<Employee> RetrieveEmployeesByID(Int32 ID)
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveEmployeeByID(ID);
            List<Employee> employeeList = RetrieveEmployeesRepackage(tmpTable);
            return employeeList;
        }
        private static List<Employee> RetrieveEmployeesRepackage(DataTable myTable)
        {
            List<Employee> empList = new List<Employee>();
            foreach (DataRow tempRow in myTable.Rows)
            {
                Employee tmpEmp = new Employee();

                tmpEmp.EmpID = Convert.ToInt32(tempRow["empId"]);
                tmpEmp.SIN = Convert.ToInt32(tempRow["SIN"]);
                tmpEmp.HireDate = Convert.ToDateTime(tempRow["hireDate"]);
                tmpEmp.JobStartDate = Convert.ToDateTime(tempRow["jobStartDate"]);
                tmpEmp.JobID = Convert.ToInt32(tempRow["jobId"]);
                tmpEmp.DepartmentID = Convert.ToInt32(tempRow["departmentID"]);
                tmpEmp.BiWeeklyRate = Convert.ToInt32(tempRow["biWeeklyRate"]);
                tmpEmp.CellPhoneNumber = tempRow["cellPNumber"].ToString();
                tmpEmp.WorkPhoneNumber = tempRow["workPNumber"].ToString();
                tmpEmp.EmailAddress = tempRow["email"].ToString();
                tmpEmp.EmailNotification = Convert.ToBoolean(tempRow["payrollEmail"]);
                tmpEmp.FirstName = (tempRow["firstName"]).ToString();
                tmpEmp.MiddleInitial = (tempRow["middleInitial"]).ToString();
                tmpEmp.LastName = tempRow["lastName"].ToString();
                tmpEmp.DateOfBirth = Convert.ToDateTime(tempRow["dob"]);
                tmpEmp.StreetAddress = tempRow["address"].ToString();
                tmpEmp.City = tempRow["city"].ToString();
                tmpEmp.PostalCode = tempRow["pCode"].ToString();

                
                empList.Add(tmpEmp);
            }
            return empList;
        }

    }
}
