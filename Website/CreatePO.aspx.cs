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
    public partial class CreatePO : System.Web.UI.Page
    {
        Item item;
        PurchaseOrder po;
        double orderPrice;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblDate.InnerText = DateTime.Now.ToLongDateString();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                item = ItemFactory.Create();
                po = POFactory.Create();

                double itemPrice = Convert.ToDouble(txtPrice.Text);
                orderPrice += itemPrice;

                item.ItemName = txtName.Text;
                item.Description = txtDesc.Text;
                item.Quantity = Convert.ToInt32(txtQty.Text);
                item.Price = itemPrice;
                item.Location = txtLocation.Text;
                item.Justification = txtJustification.Text;

                po.Items = new List<Types.IItem>();
                po.Items.Add(item);
                po.OrderNumber = Convert.ToInt32(lblOrderNum.Text);
                po.EmpId = 10000004;

                int orderNumber = CUDMethods.CreatPO(po);

                lblSubNum.Text = "$" + (orderPrice).ToString("F");
                lblTaxNum.Text = "$" + (orderPrice * 0.15).ToString("F");
                lblTotalNum.Text = "$" + (orderPrice * 1.15).ToString("F");

                lblOrderNum.Text = orderNumber.ToString();
                lblOrderNum.Visible = true;
                lblOrder.Visible = true;

                btnCreate.Text = "Add";
                lstItems.Items.Add(item.ItemName);

                clear();
            }
            catch (Exception ex)
            {

            }
        }

        private void clear()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtLocation.Text = "";
            txtJustification.Text = "";
        }
    }
}