using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Factories
{
    public class DepartmentFactory
    {
        public static List<Department> DepartmentCreateList()
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveDepartments();
            List<Department> retrievedDepartments = new List<Department>();
            retrievedDepartments = DepartmentRepackager(tmpTable);
            return retrievedDepartments;
        }

        private static List<Department> DepartmentRepackager(DataTable myTable)
        {
            List<Department> departments = new List<Department>();
            foreach (DataRow tempRow in myTable.Rows)
            {
                Department tmpDepartments = new Department();
                tmpDepartments.DepartmentID = Convert.ToInt32(tempRow["id"]);
                tmpDepartments.DepartmentName = tempRow["name"].ToString();
                tmpDepartments.Supervisor = tempRow["supervisor"].ToString();
                
                departments.Add(tmpDepartments);
            }
            return departments;
        }
    }
}
