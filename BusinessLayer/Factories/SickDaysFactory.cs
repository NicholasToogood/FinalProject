using BusinessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Factories
{
    public class SickDaysFactory
    {
        public static SickDays SickDaysCreate()
        {
            return new SickDays();
        }

        public static List<SickDays> RetrieveSickDaysByID(Int32 ID)
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveSickDaysByempID(ID);
            List<SickDays> employeeList = RetrieveSickDaysByIDRepackage(tmpTable);
            return employeeList;
        }
        private static List<SickDays> RetrieveSickDaysByIDRepackage(DataTable myTable)
        {
            List<SickDays> sickDayList = new List<SickDays>();
            foreach (DataRow tempRow in myTable.Rows)
            {
                SickDays tmpSickDays = new SickDays();
                
                tmpSickDays.SickDayID = Convert.ToInt32(tempRow["sickDayId"]);
                tmpSickDays.SickDayDate = Convert.ToDateTime(tempRow["sickDayDate"]);
                tmpSickDays.SickDayLength = Convert.ToDouble(tempRow["sickDayLength"]); 
                tmpSickDays.SickDayDescription = Convert.ToString(tempRow["sickDayDescription"]);
                tmpSickDays.empId = Convert.ToInt32(tempRow["empId"]);

                sickDayList.Add(tmpSickDays);
            }
            return sickDayList;
        }

        public static Double RetrieveNumberOfSickDays(Int32 ID)
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveNumberOfSickDays(ID);
            Double numOfSickDays = RetrieveNumberOfSickDaysRepackage(tmpTable);
            return numOfSickDays;
        }
        private static Double RetrieveNumberOfSickDaysRepackage(DataTable myTable)
        {
            Double numOfSickDays = 0;
            try
            {
                numOfSickDays = Convert.ToDouble(myTable.Rows[0][0]);
            }
            catch
            {
                numOfSickDays = 0;
            }
            
            return numOfSickDays;
        }
    }
}
