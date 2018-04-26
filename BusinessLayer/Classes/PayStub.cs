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
        internal DateTime _CreationDate;
        internal int _EmpID;

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


    }
}
