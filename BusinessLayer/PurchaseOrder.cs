using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class PurchaseOrder
    {
        internal PurchaseOrder() { }

        internal int _orderNumber;
        internal byte _orderStatus;
        internal DateTime _orderDate;
        internal double _total;
        internal double _tax;
        internal double _grandTotal;
    }
}
