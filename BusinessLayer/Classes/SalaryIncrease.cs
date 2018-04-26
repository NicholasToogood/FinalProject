using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class SalaryIncrease : ISalaryIncrease
    {
        internal SalaryIncrease() { }

        internal int _SalaryIncreaseID;
        internal Double _PercentageIncrease;
        internal DateTime _DateOfIncrease;
        internal Byte _ReasonForIncrease;
        internal int _EmpID;
        internal Boolean _HasBeenApplied;

        public int SalaryIncreaseID
        {
            get { return _SalaryIncreaseID; }
            set { _SalaryIncreaseID = value; }
        }
        public Double PercentageIncrease
        {
            get { return _PercentageIncrease; }
            set { _PercentageIncrease = value; }
        }
        public DateTime DateOfIncrease
        {
            get { return _DateOfIncrease; }
            set { _DateOfIncrease = value; }
        }
        public Byte ReasonForIncrease
        {
            get { return _ReasonForIncrease; }
            set { _ReasonForIncrease = value; }
        }
        public int EmpID
        {
            get { return _EmpID; }
            set { _EmpID = value; }
        }
        public Boolean HasBeenApplied
        {
            get { return _HasBeenApplied; }
            set { _HasBeenApplied = value; }
        }
    }
}
