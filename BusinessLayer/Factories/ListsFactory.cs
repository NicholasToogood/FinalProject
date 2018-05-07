using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Classes;
using SqlLayer;
using Types;

namespace BusinessLayer.Factories
{
    public class ListsPOFactory
    {
        public static List<PurchaseOrder> Create()
        {
            DataTable dt = POSQL.RetrieveAllPOs();
            List<PurchaseOrder> lstPurchaseOrderLookup = Repackage(dt);
            return lstPurchaseOrderLookup;
        }

        public static List<PurchaseOrder> Create(int orderNumber)
        {
            DataTable dt = POSQL.RetrievePOById(orderNumber);
            List<PurchaseOrder> lstPurchaseOrderLookup = Repackage(dt);
            return lstPurchaseOrderLookup;
        }

        public static List<PurchaseOrder> Create(DateTime startDate, DateTime endDate)
        {
            DataTable dt = POSQL.RetrievePOByDate(startDate, endDate);
            List<PurchaseOrder> lstPurchaseOrderLookup = Repackage(dt);
            return lstPurchaseOrderLookup;
        }

        private static List<PurchaseOrder> Repackage(DataTable dt)
        {
            List<PurchaseOrder> list = new List<PurchaseOrder>();

            foreach (DataRow dr in dt.Rows)
            {
                PurchaseOrder myPOLookup = new PurchaseOrder();
                myPOLookup.OrderNumber = Convert.ToInt32(dr["orderNumber"]);
                myPOLookup.OrderStatus = (OrderStatus)(Convert.ToInt32(dr["orderStatus"]));
                myPOLookup.OrderDate = Convert.ToDateTime(dr["orderDate"]);
                myPOLookup.Total = Convert.ToDouble(dr["total"]);
                myPOLookup.EmpId = Convert.ToInt32(dr["empId"]);
                myPOLookup.Items = ListsItemFactory.Create(myPOLookup.OrderNumber);
                list.Add(myPOLookup);
            }
            return list;
        }
    }

    public class ListsItemFactory
    {
        public static List<IItem> Create(int orderNumber)
        {
            DataTable dt = POSQL.RetrieveItemById(orderNumber);
            List<IItem> lstItemLookup = Repackage(dt);
            return lstItemLookup;
        }

        private static List<IItem> Repackage(DataTable dt)
        {
            List<IItem> list = new List<IItem>();

            foreach (DataRow dr in dt.Rows)
            {
                Item myItemLookup = new Item();
                myItemLookup.ItemId = Convert.ToInt32(dr["itemId"]);
                myItemLookup.ItemName = dr["name"].ToString();
                myItemLookup.Description = dr["description"].ToString();
                myItemLookup.Quantity = Convert.ToInt32(dr["quantity"]);
                myItemLookup.Price = Convert.ToDouble(dr["price"]);
                myItemLookup.Location = dr["location"].ToString();
                myItemLookup.Justification = dr["jusitification"].ToString();
                myItemLookup.OrderNumber = Convert.ToInt32(dr["orderNumber"]);
                myItemLookup.ItemStatus = (ItemStatus)Convert.ToInt32(dr["itemStatus"]);
                myItemLookup.ReasonForMod = dr["reasonForMod"].ToString();
                list.Add(myItemLookup);
            }
            return list;
        }
    }
}
