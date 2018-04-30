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

        public static PurchaseOrder Create(int orderNumber)
        {
            DataTable tmpTable = POSQL.RetrievePOById(orderNumber);
            return Repackage(tmpTable.Rows[0]);
        }

        private static PurchaseOrder Repackage(DataRow dr)
        {
            PurchaseOrder myPOLookup = new PurchaseOrder();
            myPOLookup.OrderNumber = Convert.ToInt32(dr["orderNumber"]);
            myPOLookup.OrderStatus = (OrderStatus)(Convert.ToInt32(dr["orderStatus"]));
            myPOLookup.OrderDate = Convert.ToDateTime(dr["orderDate"]);
            myPOLookup.Total = Convert.ToDouble(dr["total"]);
            myPOLookup.EmpId = Convert.ToInt32(dr["empId"]);
            myPOLookup.Items = ListsItemFactory.Create(myPOLookup.OrderNumber);
            return myPOLookup;
        }
    }
}
