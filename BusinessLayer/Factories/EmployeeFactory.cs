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


    }
}
