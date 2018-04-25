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

                item.ItemName = txtName.Text;
                item.Description = txtDesc.Text;
                item.Quantity = Convert.ToInt32(txtQty.Text);
                item.Price = Convert.ToDouble(txtPrice.Text);
                item.Location = txtLocation.Text;
                item.Justification = txtJustification.Text;

                po.Items = new List<Types.IItem>();
                po.Items.Add(item);

                CUDMethods.CreatPO(po);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CreatePO_Load(object sender, EventArgs e)
        {

        }
    }
}
