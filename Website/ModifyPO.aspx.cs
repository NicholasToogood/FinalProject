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
    public partial class ModifyPO : System.Web.UI.Page
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

        protected void dgvItems_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvItems.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void dgvItems_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvItems.EditIndex = -1;
            BindGridView();
        }

        protected void dgvItems_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = dgvItems.Rows[e.RowIndex];

                Item item = ItemFactory.Create();
                TextBox textId = (TextBox)row.Cells[1].Controls[0];
                TextBox textName = (TextBox)row.Cells[2].Controls[0];
                TextBox textDesc = (TextBox)row.Cells[3].Controls[0];
                TextBox textQty = (TextBox)row.Cells[4].Controls[0];
                TextBox textPrice = (TextBox)row.Cells[5].Controls[0];
                TextBox textLocation = (TextBox)row.Cells[6].Controls[0];
                TextBox textJust = (TextBox)row.Cells[7].Controls[0];
                TextBox textOrder = (TextBox)row.Cells[9].Controls[0];

                item.ItemId = Convert.ToInt32(textId.Text);
                item.ItemName = textName.Text;
                item.Description = textDesc.Text;
                item.Quantity = Convert.ToInt32(textQty.Text);
                item.Price = Convert.ToDouble(textPrice.Text);
                item.Location = textLocation.Text;
                item.Justification = textJust.Text;

                CUDMethods.UpdateItem(item);

                po = POFactory.Create(Convert.ToInt32(textOrder.Text));
                lblSub.Text = "$ " + po.Total.ToString("F");
                lblTax.Text = "$ " + (po.Total * 0.15).ToString("F");
                lblTotal.Text = "$ " + (po.Total * 1.15).ToString("F");

                dgvItems.EditIndex = -1;
                BindGridView();
                lblError.InnerText = "";
            }
            catch (Exception ex)
            {
                lblError.InnerText = ex.Message;
            }

        }
    }
}