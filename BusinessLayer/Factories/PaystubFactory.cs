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
            tmpPayStub.GrossPay = Convert.ToInt64(myTable.Rows[0]["grossPay"]);
            tmpPayStub.Deductions = Convert.ToInt64(myTable.Rows[0]["deductions"]);
            tmpPayStub.CPP = Convert.ToInt64(myTable.Rows[0]["cPP"]);
            tmpPayStub.EI = Convert.ToInt64(myTable.Rows[0]["eI"]);
            tmpPayStub.CompanyPensionDeduction = Convert.ToInt64(myTable.Rows[0]["companyPensionDeduction"]);
            tmpPayStub.Netpay = Convert.ToInt64(myTable.Rows[0]["netPay"]);
            tmpPayStub.EmpID = Convert.ToInt32(myTable.Rows[0]["empID"]);
            tmpPayStub.CreationDate = Convert.ToDateTime(myTable.Rows[0]["creationDate"]);
            tmpPayStub.YTDGrossPay = Convert.ToInt64(myTable.Rows[0]["ytdGrossPay"]);
            tmpPayStub.YTDDeductions = Convert.ToInt64(myTable.Rows[0]["ytdDeductions"]);
            tmpPayStub.YTDCPP = Convert.ToInt64(myTable.Rows[0]["ytdCPP"]);
            tmpPayStub.YTDEI = Convert.ToInt64(myTable.Rows[0]["ytdEI"]);
            tmpPayStub.YTDCompanyPensionDeduction = Convert.ToInt64(myTable.Rows[0]["ytdCompanyPensionDeductions"]);
            tmpPayStub.YTDNetpay = Convert.ToInt64(myTable.Rows[0]["ytdNetPay"]);

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
                tmpPayStub.GrossPay = Convert.ToInt64(tempRow["grossPay"]);
                tmpPayStub.Deductions = Convert.ToInt64(tempRow["deductions"]);
                tmpPayStub.CPP = Convert.ToInt64(tempRow["cPP"]);
                tmpPayStub.EI = Convert.ToInt64(tempRow["eI"]);
                tmpPayStub.CompanyPensionDeduction = Convert.ToInt64(tempRow["companyPensionDeduction"]);
                tmpPayStub.Netpay = Convert.ToInt64(myTable.Rows[0]["netPay"]);
                tmpPayStub.EmpID = Convert.ToInt32(tempRow["empID"]);
                tmpPayStub.CreationDate = Convert.ToDateTime(tempRow["creationDate"]);
                tmpPayStub.YTDGrossPay = Convert.ToInt64(tempRow["ytdGrossPay"]);
                tmpPayStub.YTDDeductions = Convert.ToInt64(tempRow["ytdDeductions"]);
                tmpPayStub.YTDCPP = Convert.ToInt64(tempRow["ytdCPP"]);
                tmpPayStub.YTDEI = Convert.ToInt64(tempRow["ytdEI"]);
                tmpPayStub.YTDCompanyPensionDeduction = Convert.ToInt64(tempRow["ytdCompanyPensionDeductions"]);
                tmpPayStub.YTDNetpay = Convert.ToInt64(tempRow["ytdNetPay"]);

                paystubs.Add(tmpPayStub);
            }
            return paystubs;
        }
    }
}
