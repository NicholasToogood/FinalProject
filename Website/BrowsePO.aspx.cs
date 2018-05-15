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
    public partial class BrowsePO : System.Web.UI.Page
    {
        PurchaseOrder po;
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtStartDate.Text = DateTime.Today.ToShortDateString();
            //txtEndDate.Text = DateTime.Today.ToShortDateString();
            lblDate.InnerText = DateTime.Now.ToLongDateString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtStartDate.Text = dtpStart.SelectedDate.ToShortDateString();
        }

        protected void dtpEnd_SelectionChanged(object sender, EventArgs e)
        {
            txtEndDate.Text = dtpEnd.SelectedDate.ToShortDateString();
        }

        protected void btnId_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text == "")
            {
                return;
            }

            try
            {
                lstOrders.DataSource = ListsPOFactory.Create(Convert.ToInt32(txtOrderNumber.Text));
                lstOrders.DataTextField = "orderNumber";
                lstOrders.DataValueField = "orderNumber";
                lstOrders.DataBind();
                lstOrders.SelectedIndex = -1;
                lstOrders.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnDat_Click(object sender, EventArgs e)
        {
            try
            {
                lstOrders.DataSource = ListsPOFactory.Create(Convert.ToDateTime(txtStartDate.Text), Convert.ToDateTime(txtEndDate.Text));
                lstOrders.DataTextField = "orderNumber";
                lstOrders.DataValueField = "orderNumber";
                lstOrders.DataBind();
                lstOrders.SelectedIndex = -1;
                lstOrders.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }



        protected void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            if (lstOrders.SelectedIndex >= 0 && lstOrders.Enabled == true)
            {
                po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                dgvItems.DataSource = ListsItemFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                dgvItems.DataBind();
                lblSub.Text = "Sub Total: $ " + po.Total.ToString("F");
                lblTax.Text = "Tax: $ " + (po.Total * 0.15).ToString("F");
                lblTotal.Text = "Total: $ " + (po.Total * 1.15).ToString("F");
            }
        }
    }
}