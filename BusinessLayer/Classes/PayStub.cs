using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class PayStub : IPayStub
    {
        internal PayStub() { }

        internal int _PayStubID;
        internal Double _GrossPay;
        internal Double _Deductions;
        internal Double _CPP;
        internal Double _EI;
        internal Double _CompanyPensionDeduction;
        internal Double _Netpay;
        internal DateTime _CreationDate;
        internal int _EmpID;

        internal Double _YTDGrossPay;
        internal Double _YTDDeductions;
        internal Double _YTDCPP;
        internal Double _YTDEI;
        internal Double _YTDCompanyPensionDeduction;
        internal Double _YTDNetpay;

        internal Double _biWeeklyRate;


        public int PayStubID
        {
            get { return _PayStubID; }
            set { _PayStubID = value; }
        }
        public Double GrossPay
        {
            get { return _GrossPay; }
            set { _GrossPay = value; }
        }
        public Double Deductions
        {
            get { return _Deductions; }
            set { _Deductions = value; }
        }
        public Double CPP
        {
            get { return _CPP; }
            set { _CPP = value; }
        }
        public Double EI
        {
            get { return _EI; }
            set { _EI = value; }
        }
        public Double CompanyPensionDeduction
        {
            get { return _CompanyPensionDeduction; }
            set { _CompanyPensionDeduction = value; }
        }
        public Double Netpay
        {
            get { return _Netpay; }
            set { _Netpay = value; }
        }
        public DateTime CreationDate
        {
            get { return _CreationDate; }
            set { _CreationDate = value; }
        }
        public int EmpID
        {
            get { return _EmpID; }
            set { _EmpID = value; }
        }

        // YTD
        public Double YTDGrossPay
        {
            get { return _YTDGrossPay; }
            set { _YTDGrossPay = value; }
        }
        public Double YTDDeductions
        {
            get { return _YTDDeductions; }
            set { _YTDDeductions = value; }
        }
        public Double YTDCPP
        {
            get { return _YTDCPP; }
            set { _YTDCPP = value; }
        }
        public Double YTDEI
        {
            get { return _YTDEI; }
            set { _YTDEI = value; }
        }
        public Double YTDCompanyPensionDeduction
        {
            get { return _YTDCompanyPensionDeduction; }
            set { _YTDCompanyPensionDeduction = value; }
        }
        public Double YTDNetpay
        {
            get { return _YTDNetpay; }
            set { _YTDNetpay = value; }
        }
        public Double BiWeeklyRate
        {
            get { return _biWeeklyRate; }
            set { _biWeeklyRate = value; }
        }
        
    }
}
