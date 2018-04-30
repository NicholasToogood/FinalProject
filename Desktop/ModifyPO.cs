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
    public partial class ModifyPO : Form
    {
        PurchaseOrder po;

        public ModifyPO()
        {
            InitializeComponent();
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text == "")
            {
                return;
            }

            try
            {
                lstOrders.DataSource = ListsPOFactory.Create(Convert.ToInt32(txtOrderNumber.Text));
                lstOrders.DisplayMember = "orderNumber";
                lstOrders.ValueMember = "orderNumber";
                lstOrders.SelectedIndex = -1;
                lstOrders.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Purchase Order Exists with that Order Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedIndex >= 0 && lstOrders.Enabled == true)
            {
                po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                dgvItems.DataSource = ListsItemFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                lblSubNum.Text = "$ " + po.Total.ToString("F");
                lblTaxNum.Text = "$ " + (po.Total * 0.15).ToString("F");
                lblTotalNum.Text = "$ " + (po.Total * 1.15).ToString("F");
            }  
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            lstOrders.DataSource = ListsPOFactory.Create(dtpStart.Value, dtpEnd.Value);
            lstOrders.DisplayMember = "orderNumber";
            lstOrders.ValueMember = "orderNumber";
            lstOrders.SelectedIndex = -1;
            lstOrders.Enabled = true;
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ItemId = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells[0].Value);

                Item item = ItemFactory.Create();
                item.ItemId = ItemId;
                item.ItemName = dgvItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                item.Description = dgvItems.Rows[e.RowIndex].Cells[2].Value.ToString();
                item.Quantity = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells[3].Value);
                item.Price = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells[4].Value);
                item.Location = dgvItems.Rows[e.RowIndex].Cells[5].Value.ToString();
                item.Justification = dgvItems.Rows[e.RowIndex].Cells[6].Value.ToString();

                CUDMethods.UpdateItem(item);

                po = POFactory.Create(Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells[8].Value));
                lblSubNum.Text = "$ " + po.Total.ToString("F");
                lblTaxNum.Text = "$ " + (po.Total * 0.15).ToString("F");
                lblTotalNum.Text = "$ " + (po.Total * 1.15).ToString("F");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
