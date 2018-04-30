using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer.Classes
{
    public class POLookup
    {
        internal POLookup() { }

        public int OrderNumber { get; internal set; }
        public OrderStatus OrderStatus { get; internal set; }
        public DateTime OrderDate { get; internal set; }
        public double Total { get; internal set; }
        public int EmpId { get; internal set; }
        public List<IItem> Items { get; internal set; }
    }
}
