using BusinessLayer.Classes;
using SqlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CUDMethods
    {
        public static int CreatPO(PurchaseOrder po)
        {
            return POSQL.CreatePO(po);
        }

        public static int CreateEmp(Employee emp)
        {
            return HRSQL.CreateNewEmployee(emp);
        }

        public static bool UpdateItem(Item item)
        {
            return POSQL.UpdatePO(item);
        }

        public static bool ProcessItem(int itemId, byte itemStatus)
        {
            return POSQL.ProcessItem(itemId, itemStatus);
        }

        public static bool ProcessOrder(int orderNumber, byte orderStatus)
        {
            return POSQL.ProcessOrder(orderNumber, orderStatus);
        }

        public static Boolean CreatePerformanceIncrease(int empID, Double percentage, DateTime dateOfIncrease)
        {
            return HRSQL.CreatePerformanceIncrease(empID, percentage, dateOfIncrease);
        }

        public static Boolean CreateCostOfLivingIncrease(Double percentage, DateTime dateOfIncrease)
        {
            return HRSQL.CreateCostOfLivingIncrease(percentage, dateOfIncrease);
        }

        public static Boolean HasCalculatePayrollBeenRun()
        {
            return HRSQL.HasCalculatePayrollBeenRun();
        }
        public static Boolean CalculatePayroll()
        {
            return HRSQL.CalculatePayroll();
        }

        public static Boolean ValidatePayrollCode(string entryCode)
        {
            return HRSQL.ValidatePayrollCode(entryCode);
        }

        public static Boolean ModifyEmployee(Employee emp)
        {
            return HRSQL.ModifyEmployee(emp);
        }

        public static Boolean CreateNewSickDay(SickDays sickDays)
        {
            return HRSQL.CreateNewSickDay(sickDays);
        }

        public static Boolean UpdateEmployeeEmp(Employee emp)
        {
            return HRSQL.UpdateEmployeeEmp(emp);
        }

    }
}
