using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class Department : IDepartment
    {
        internal Department() { }

        internal int _DepartmentID;
        internal string _DepartmentName;
        internal string _Supervisor;

        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        public string Supervisor
        {
            get { return _Supervisor; }
            set { _Supervisor = value; }
        }

    }
}
