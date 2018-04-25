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

        public static DataTable CreatePO(IItem item, int empId)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@name", item.ItemName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new parameters("@description", item.Description, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new parameters("@qty", item.Quantity, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@price", item.Price, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new parameters("@location", item.Location, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new parameters("@justification", item.Justification, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new parameters("@total", item.Price, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new parameters("@empId", empId, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@orderNumberIn", null, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@orderNumberOut", 0, SqlDbType.Int, ParameterDirection.Output));
            return DAL.GetData("CreatePO", parms);
        }

        public static int CreatePO(IPurchaseOrder po)
        {
            int orderNumber = 0;

            List<parameters> parms = new List<parameters>();

            foreach (var item in po.Items)
            {
                parms.Add(new parameters("@name", item.ItemName, SqlDbType.VarChar, ParameterDirection.Input, 30));
                parms.Add(new parameters("@description", item.Description, SqlDbType.VarChar, ParameterDirection.Input, 255));
                parms.Add(new parameters("@qty", item.Quantity, SqlDbType.Int, ParameterDirection.Input));
                parms.Add(new parameters("@price", item.Price, SqlDbType.Money, ParameterDirection.Input));
                parms.Add(new parameters("@location", item.Location, SqlDbType.VarChar, ParameterDirection.Input, 50));
                parms.Add(new parameters("@justification", item.Justification, SqlDbType.VarChar, ParameterDirection.Input, 255));
                parms.Add(new parameters("@total", item.Price, SqlDbType.Money, ParameterDirection.Input));
                parms.Add(new parameters("@empId", po.EmpId, SqlDbType.Int, ParameterDirection.Input));
                parms.Add(new parameters("@orderNumberIn", po.OrderNumber, SqlDbType.Int, ParameterDirection.Input));
                parms.Add(new parameters("@orderNumberOut", 0, SqlDbType.Int, ParameterDirection.Output));
                orderNumber = DAL.SendData("CreatePO", parms);
            }
            return orderNumber;
        }
    }
}
