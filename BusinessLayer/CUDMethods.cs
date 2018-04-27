﻿using SqlLayer;
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
        
        public static Boolean CreatePerformanceIncrease(int empID, Double percentage, DateTime dateOfIncrease)
        {
            return HRSQL.CreatePerformanceIncrease(empID, percentage, dateOfIncrease);
        }

        public static Boolean CreateCostOfLivingIncrease(Double percentage, DateTime dateOfIncrease)
        {
            return HRSQL.CreateCostOfLivingIncrease(percentage, dateOfIncrease);
        }
    }
}
