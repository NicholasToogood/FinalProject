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

            if (!IsPostBack)
            {
                lstOrders.DataSource = ListsPOFactory.CreatePending();
                lstOrders.DataTextField = "orderNumber";
                lstOrders.DataValueField = "orderNumber";
                lstOrders.DataBind();
                lstOrders.SelectedIndex = -1;
            }
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

        protected void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedIndex >= 0)
            {
                po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                LoadItems();
                lblOrderNumber.Text = po.OrderNumber.ToString();
                lblDate.Text = po.OrderDate.ToShortDateString();
                lblTotal.Text = "$" + po.Total.ToString();
                lblOrderStatus.Text = po.OrderStatus.ToString();
            }
        }

        private void LoadItems()
        {
            grvItems.DataSource = ListsItemFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
            grvItems.DataBind();
        }

        protected void grvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvItems.BackColor = System.Drawing.Color.White;
            grvItems.SelectedRow.BackColor = System.Drawing.Color.LightCyan;

            Session["itemId"] = Convert.ToInt32(grvItems.SelectedRow.Cells[1].Text);

            btnApprove.Visible = true;
            btnDeny.Visible = true;
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            askToClose = true;

            CUDMethods.ProcessItem(Convert.ToInt32(Session["itemId"].ToString()), Convert.ToByte(2));
            LoadItems(); ;

            po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));

            foreach (Item item in po.Items)
            {
                if (item.ItemStatus == Types.ItemStatus.Pending)
                {
                    askToClose = false;
                }
                else
                {
                    CUDMethods.ProcessOrder(po.OrderNumber, Convert.ToByte(2));
                }
            }

            po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
            lblOrderStatus.Text = po.OrderStatus.ToString();

            if (askToClose == true)
            {
                btnClose.Visible = true;
            }
        }

        protected void btnDeny_Click(object sender, EventArgs e)
        {
            askToClose = true;

            CUDMethods.ProcessItem(Convert.ToInt32(Session["itemId"].ToString()), Convert.ToByte(3));
            LoadItems(); ;

            po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));

            foreach (Item item in po.Items)
            {
                if (item.ItemStatus == Types.ItemStatus.Pending)
                {
                    askToClose = false;
                }
                else
                {
                    CUDMethods.ProcessOrder(po.OrderNumber, Convert.ToByte(2));
                }
            }

            po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
            lblOrderStatus.Text = po.OrderStatus.ToString();

            if (askToClose == true)
            {
                btnClose.Visible = true;
            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            CUDMethods.ProcessOrder(po.OrderNumber, Convert.ToByte(3));
            po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
            LoadItems();
            lblOrderNumber.Text = po.OrderNumber.ToString();
            lblDate.Text = po.OrderDate.ToShortDateString();
            lblTotal.Text = "$" + po.Total.ToString();
            lblOrderStatus.Text = po.OrderStatus.ToString();

            sendEmail();
        }

        private void sendEmail()
        {

        }
    }
}