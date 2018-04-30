using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class PurchaseOrder : IPurchaseOrder
    {
        internal PurchaseOrder() { }

        internal int _orderNumber;
        internal OrderStatus _orderStatus;
        internal DateTime _orderDate;
        internal double _total;
        internal int _empId;
        internal List<IItem> _items;

        public int OrderNumber
        {
            get
            {
                return _orderNumber;
            }
            set
            {
                if (_orderNumber == value)
                {
                    return;
                }
                _orderNumber = value;
            }
        }

        public OrderStatus OrderStatus
        {
            get
            {
                return _orderStatus;
            }
            set
            {
                if (_orderStatus == value)
                {
                    return;
                }
                _orderStatus = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                if (_orderDate == value)
                {
                    return;
                }
                _orderDate = value;
            }
        }

        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (_total == value)
                {
                    return;
                }
                _total = value;
            }
        }

        public int EmpId
        {
            get
            {
                return _empId;
            }
            set
            {
                if (_empId == value)
                {
                    return;
                }
                _empId = value;
            }
        }

        public List<IItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items == value)
                {
                    return;
                }
                _items = value;
            }
        }
    }
}
