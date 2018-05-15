using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Factories
{
    public class PaystubFactory
    {
        public static PayStub RetrievePayStubByID(int ID)
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveTodaysPaystubByID(ID);
            PayStub employeeList = RetrievePayStubByIDRepackage(tmpTable);
            return employeeList;
        }
        private static PayStub RetrievePayStubByIDRepackage(DataTable myTable)
        {
            PayStub tmpPayStub = new PayStub();

            tmpPayStub.PayStubID = Convert.ToInt32(myTable.Rows[0]["empId"]);
            tmpPayStub.GrossPay = Convert.ToDouble(myTable.Rows[0]["grossPay"]);
            tmpPayStub.Deductions = Convert.ToDouble(myTable.Rows[0]["deductions"]);
            tmpPayStub.CPP = Convert.ToDouble(myTable.Rows[0]["cPP"]);
            tmpPayStub.EI = Convert.ToDouble(myTable.Rows[0]["eI"]);
            tmpPayStub.CompanyPensionDeduction = Convert.ToDouble(myTable.Rows[0]["companyPensionDeduction"]);
            tmpPayStub.Netpay = Convert.ToDouble(myTable.Rows[0]["netPay"]);
            tmpPayStub.EmpID = Convert.ToInt32(myTable.Rows[0]["empID"]);
            tmpPayStub.CreationDate = Convert.ToDateTime(myTable.Rows[0]["creationDate"]);
            tmpPayStub.YTDGrossPay = Convert.ToDouble(myTable.Rows[0]["ytdGrossPay"]);
            tmpPayStub.YTDDeductions = Convert.ToDouble(myTable.Rows[0]["ytdDeductions"]);
            tmpPayStub.YTDCPP = Convert.ToDouble(myTable.Rows[0]["ytdCPP"]);
            tmpPayStub.YTDEI = Convert.ToDouble(myTable.Rows[0]["ytdEI"]);
            tmpPayStub.YTDCompanyPensionDeduction = Convert.ToDouble(myTable.Rows[0]["ytdCompanyPensionDeductions"]);
            tmpPayStub.YTDNetpay = Convert.ToDouble(myTable.Rows[0]["ytdNetPay"]);

            return tmpPayStub;
        }


        public static List<PayStub> RetrievePayStubsToday()
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveTodaysPayStubs();
            List<PayStub> employeeList = RetrievePayStubsTodayRepackage(tmpTable);
            return employeeList;
        }
        private static List<PayStub> RetrievePayStubsTodayRepackage(DataTable myTable)
        {
            List<PayStub> paystubs = new List<PayStub>();
            foreach (DataRow tempRow in myTable.Rows)
            {
                PayStub tmpPayStub = new PayStub();

                tmpPayStub.PayStubID = Convert.ToInt32(tempRow["empId"]);
                tmpPayStub.GrossPay = Convert.ToDouble(tempRow["grossPay"]);
                tmpPayStub.Deductions = Convert.ToDouble(tempRow["deductions"]);
                tmpPayStub.CPP = Convert.ToDouble(tempRow["cPP"]);
                tmpPayStub.EI = Convert.ToDouble(tempRow["eI"]);
                tmpPayStub.CompanyPensionDeduction = Convert.ToDouble(tempRow["companyPensionDeduction"]);
                tmpPayStub.Netpay = Convert.ToDouble(tempRow["netPay"]);
                tmpPayStub.EmpID = Convert.ToInt32(tempRow["empID"]);
                tmpPayStub.CreationDate = Convert.ToDateTime(tempRow["creationDate"]);
                tmpPayStub.YTDGrossPay = Convert.ToDouble(tempRow["ytdGrossPay"]);
                tmpPayStub.YTDDeductions = Convert.ToDouble(tempRow["ytdDeductions"]);
                tmpPayStub.YTDCPP = Convert.ToDouble(tempRow["ytdCPP"]);
                tmpPayStub.YTDEI = Convert.ToDouble(tempRow["ytdEI"]);
                tmpPayStub.YTDCompanyPensionDeduction = Convert.ToDouble(tempRow["ytdCompanyPensionDeductions"]);
                tmpPayStub.YTDNetpay = Convert.ToDouble(tempRow["ytdNetPay"]);
                tmpPayStub.BiWeeklyRate = Math.Round(Convert.ToDouble(tempRow["biWeeklyRate"]), 2);

                paystubs.Add(tmpPayStub);
            }
            return paystubs;
        }
        

        public static List<PayStub> RetrievePaystubsForEmpBetweenDates(int empId, DateTime startdate, DateTime enddate)
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrievePaystubsForEmpBetweenDates(empId, startdate, enddate);
            List<PayStub> employeeList = RetrievePayStubsTodayRepackage(tmpTable);
            return employeeList;
        }




    }
}
