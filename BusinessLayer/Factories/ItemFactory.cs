using System;
using System.Collections.Generic;
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
            //DataTable tmpTable = 
        }
    }
}
