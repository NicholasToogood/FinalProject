using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class Job : IJob
    {
        internal Job() { }

        internal int _JobID;
        internal Double _MaxPay;
        internal String _JobTitle;
        
        public int JobID
        {
            get { return _JobID; }
            set { _JobID = value; }
        }
        public Double MaxPay
        {
            get { return _MaxPay; }
            set { _MaxPay = value; }
        }
        public String JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }
    }
}
