using BusinessLayer;
using BusinessLayer.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

                lblModLocation.Visible = false;
                lblModPrice.Visible = false;
                lblModQty.Visible = false;
                lblModReason.Visible = false;
                txtModLocation.Visible = false;
                txtModPrice.Visible = false;
                txtModQty.Visible = false;
                txtModReason.Visible = false;
                btnModApprove.Visible = false;
                btnApprove.Visible = false;
                btnDeny.Visible = false;
                btnMod.Visible = false;
                btnClose.Visible = false;
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

            if (po.OrderStatus == Types.OrderStatus.Closed)
            {
                btnApprove.Visible = false;
                btnDeny.Visible = false;
                btnMod.Visible = false;
                btnModApprove.Visible = false;
                btnClose.Visible = false;
            }
            else
            {
                btnApprove.Visible = true;
                btnDeny.Visible = true;
                btnMod.Visible = true;
            }

            lblModLocation.Visible = false;
            lblModPrice.Visible = false;
            lblModQty.Visible = false;
            lblModReason.Visible = false;
            txtModLocation.Visible = false;
            txtModPrice.Visible = false;
            txtModQty.Visible = false;
            txtModReason.Visible = false;
            btnModApprove.Visible = false;
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
            po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
            CUDMethods.ProcessOrder(po.OrderNumber, Convert.ToByte(3));
            LoadItems();
            lblOrderNumber.Text = po.OrderNumber.ToString();
            lblDate.Text = po.OrderDate.ToShortDateString();
            lblTotal.Text = "$" + po.Total.ToString();
            lblOrderStatus.Text = po.OrderStatus.ToString();

            btnApprove.Visible = false;
            btnDeny.Visible = false;
            btnMod.Visible = false;
            btnModApprove.Visible = false;
            btnClose.Visible = false;

            LoadItems();
            sendEmail();
        }

        private void sendEmail()
        {
            try
            {
                var date = DateTime.Now.ToShortDateString();
                List<Employee> emp = EmployeeFactory.RetrieveEmployeesByID(po.EmpId);

                MailMessage message = new MailMessage();
                message.To.Add(emp[0].EmailAddress);
                message.From = new MailAddress("purchaseorders@newroads.com");
                message.Subject = "Pruchase Order Closed";
                message.IsBodyHtml = true;
                message.Body += "<h2>" + date + "</h2>";
                message.Body += "<h3>Pruchase Order #" + po.OrderNumber + " has been processed!</h3><br />";

                foreach (Item item in po.Items)
                {
                    message.Body += "<p>" + item.ItemName + " - " + item.ItemStatus + "</p>";
                }

                message.Body += "<p>Total Order Cost - $" + po.Total + "</p>";

                SmtpClient smtpClient = new SmtpClient("localhost");
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnMod_Click(object sender, EventArgs e)
        {
            txtModQty.Text = grvItems.SelectedRow.Cells[4].Text;
            txtModLocation.Text = grvItems.SelectedRow.Cells[6].Text;
            txtModPrice.Text = grvItems.SelectedRow.Cells[5].Text;

            lblModLocation.Visible = true;
            lblModPrice.Visible = true;
            lblModQty.Visible = true;
            lblModReason.Visible = true;
            txtModLocation.Visible = true;
            txtModPrice.Visible = true;
            txtModQty.Visible = true;
            txtModReason.Visible = true;
            btnModApprove.Visible = true;
        }

        protected void btnModApprove_Click(object sender, EventArgs e)
        {
            askToClose = true;
            Item i = ItemFactory.Create();

            i.ItemId = Convert.ToInt32(grvItems.SelectedRow.Cells[1].Text);
            i.ItemName = grvItems.SelectedRow.Cells[2].Text;
            i.Description = grvItems.SelectedRow.Cells[3].Text;
            i.Price = Convert.ToDouble(txtModPrice.Text);
            i.Quantity = Convert.ToInt32(txtModQty.Text);
            i.Location = txtModLocation.Text;
            i.Justification = grvItems.SelectedRow.Cells[7].Text;
            i.OrderNumber = Convert.ToInt32(grvItems.SelectedRow.Cells[9].Text);
            i.ReasonForMod = txtModReason.Text;

            if (grvItems.SelectedRow.Cells[8].Text == "Approved")
            {
                i.ItemStatus = Types.ItemStatus.Approved;
            }
            else if (grvItems.SelectedRow.Cells[8].Text == "Denied")
            {
                i.ItemStatus = Types.ItemStatus.Denied;
            }
            else if (grvItems.SelectedRow.Cells[8].Text == "Pending")
            {
                i.ItemStatus = Types.ItemStatus.Pending;
            }

            CUDMethods.ProcessItem(Convert.ToInt32(Session["itemId"].ToString()), Convert.ToByte(2));
            CUDMethods.ModItem(i);
            LoadItems();

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

            lblModLocation.Visible = false;
            lblModPrice.Visible = false;
            lblModQty.Visible = false;
            lblModReason.Visible = false;
            txtModLocation.Visible = false;
            txtModPrice.Visible = false;
            txtModQty.Visible = false;
            txtModReason.Visible = false;
            btnModApprove.Visible = false;
        }
    }
}