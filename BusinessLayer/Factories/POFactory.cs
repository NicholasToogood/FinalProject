using SqlLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer.Factories
{
    public class POFactory
    {
        public static PurchaseOrder Create()
        {
            return new PurchaseOrder();
        }

        //public static PurchaseOrder Create(int orderNumber)
        //{
        //    DataTable tmpTable = POSQL.RetrievePOById(orderNumber);
        //    return Repackage(tmpTable.Rows[0]);
        //}

        //private static PurchaseOrder Repackage(DataRow myRow)
        //{
        //    PurchaseOrder po = new PurchaseOrder();
        //    po.OrderNumber = Convert.ToInt32(myRow["orderNumber"]);
        //    po.OrderStatus = (OrderStatus) Enum.Parse(typeof(OrderStatus), myRow["orderNumber"].ToString());
        //    po.OrderNumber = Convert.ToInt32(myRow["orderNumber"]);
        //    po.OrderNumber = Convert.ToInt32(myRow["orderNumber"]);
        //}
    }
}
