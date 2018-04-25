using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace SqlLayer
{
    //public class ItemSQL
    //{
    //    public static DataTable RetrieveItem(int itemId)
    //    {
    //        List<parameters> parms = new List<parameters>();
    //        parms.Add(new parameters(""))
    //    }
    //}

    public class POSQL
    {
        public static DataTable RetrievePOById(int orderNumber)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@orderNumber", orderNumber, SqlDbType.Int, ParameterDirection.Input, 8));
            return DAL.GetData("GetOrderById", parms);
        }

        public static DataTable RetrievePOByDAte(DateTime startDate, DateTime endDate)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@startDate", startDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new parameters("@endDate", endDate, SqlDbType.Date, ParameterDirection.Input));
            return DAL.GetData("GetOrderByDate", parms);
        }

        public static DataTable CreatePO()
    }
}
