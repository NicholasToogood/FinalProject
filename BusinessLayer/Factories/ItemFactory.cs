using SqlLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Factories
{
    public class ItemFactory
    {
        public static Item Create()
        {
            return new Item();
        }

        public static Item Create(int itemId)
        {
            DataTable tmpTable = POSQL.RetrieveItemById(itemId);
            return Repackage(tmpTable.Rows[0]);
        }

        private static Item Repackage(DataRow dr)
        {
            Item myItem = new Item();
            myItem.ItemId = Convert.ToInt32(dr["orderNumber"]);
            myItem.ItemName = dr["name"].ToString();
            myItem.Description = dr["description"].ToString();
            myItem.Quantity = Convert.ToInt32(dr["quantity"]);
            myItem.Price = Convert.ToDouble(dr["price"]);
            myItem.Location = dr["location"].ToString();
            myItem.Justification = dr["jusitification"].ToString();
            return myItem;
        }
    }
}
