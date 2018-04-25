using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class Salary : ISalary
    {
        internal Salary() { }

        internal int _SalaryID;
        internal Double _BiWeeklyRate;
        internal Double _YearToDateGrossPay;
        internal Double _YearToDateDeductions;
        internal Double _YearToDateCPP;
        internal Double _YearToDateEI;
        internal Double _YearToDateCompanyPensionDeduction;
        
        public int SalaryID
        {
            get { return _SalaryID; }
            set { _SalaryID = value; }
        }
        public Double BiWeeklyRate
        {
            get { return _BiWeeklyRate; }
            set { _BiWeeklyRate = value; }
        }
        public Double YearToDateGrossPay
        {
            get { return _YearToDateGrossPay; }
            set { _YearToDateGrossPay = value; }
        }
        public Double YearToDateDeductions
        {
            get { return _YearToDateDeductions; }
            set { _YearToDateDeductions = value; }
        }
        public Double YearToDateCPP
        {
            get { return _YearToDateCPP; }
            set { _YearToDateCPP = value; }
        }
        public Double YearToDateEI
        {
            get { return _YearToDateEI; }
            set { _YearToDateEI = value; }
        }
        public Double YearToDateCompanyPensionDeduction
        {
            get { return _YearToDateCompanyPensionDeduction; }
            set { _YearToDateCompanyPensionDeduction = value; }
        }
    }
}
