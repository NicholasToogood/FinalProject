using BusinessLayer;
using BusinessLayer.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class CreatePO : Form
    {
        Item item;
        PurchaseOrder po;
        double orderPrice;

        public CreatePO()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
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
                po.OrderNumber = 0;
                po.EmpId = 10000004;

                int orderNumber = CUDMethods.CreatPO(po);

                lblSubNum.Text = "$" + (orderPrice).ToString("F");
                lblTaxNum.Text = "$" + (orderPrice * 0.15).ToString("F");
                lblTotalNum.Text = "$" + (orderPrice * 1.15).ToString("F");

                lblOrderNumber.Text = orderNumber.ToString();
                lblOrderNumber.Visible = true;
                lblOrderNumberLabel.Visible = true;

                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void CreatePO_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
