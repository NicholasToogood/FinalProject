using BusinessLayer;
using BusinessLayer.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class ProcessPO : System.Web.UI.Page
    {

        List<PurchaseOrder> pos;
        PurchaseOrder po;
        bool askToClose = true;
        byte orderStatus = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            pos = ListsPOFactory.CreatePending();

            lstOrders.DataSource = ListsPOFactory.CreatePending();
            lstOrders.DataTextField = "orderNumber";
            lstOrders.DataValueField = "orderNumber";
            lstOrders.DataBind();
            lstOrders.SelectedIndex = -1;
            lstOrders.Enabled = true;
        }

        protected void rdoPending_CheckedChanged(object sender, EventArgs e)
        {
            pos = ListsPOFactory.CreatePending();

            lstOrders.DataSource = ListsPOFactory.CreatePending();
            lstOrders.DataTextField = "orderNumber";
            lstOrders.DataValueField = "orderNumber";
            lstOrders.DataBind();
            lstOrders.SelectedIndex = -1;

            orderStatus = 1;
        }

        protected void rdoClosed_CheckedChanged(object sender, EventArgs e)
        {
            pos = ListsPOFactory.CreateClosed();

            lstOrders.DataSource = ListsPOFactory.CreateClosed();
            lstOrders.DataTextField = "orderNumber";
            lstOrders.DataValueField = "orderNumber";
            lstOrders.DataBind();
            lstOrders.SelectedIndex = -1;

            orderStatus = 3;
        }

        protected void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            pos = ListsPOFactory.Create();

            lstOrders.DataSource = ListsPOFactory.Create();
            lstOrders.DataTextField = "orderNumber";
            lstOrders.DataValueField = "orderNumber";
            lstOrders.DataBind();
            lstOrders.SelectedIndex = -1;
        }
    }
}