using BusinessLayer;
using BusinessLayer.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class ProcessPO : Form
    {

        List<PurchaseOrder> pos;
        PurchaseOrder po;
        bool askToClose = true;
        byte orderStatus = 1;

        public ProcessPO()
        {
            InitializeComponent();
        }

        private void ProcessPO_Load(object sender, EventArgs e)
        {
            pos = ListsPOFactory.CreatePending();

            lstOrders.DataSource = ListsPOFactory.CreatePending();
            lstOrders.DisplayMember = "orderNumber";
            lstOrders.ValueMember = "orderNumber";
            lstOrders.SelectedIndex = -1;
            lstOrders.Enabled = true;
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedIndex >= 0 && lstOrders.Enabled == true)
            {
                po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                LoadItems();
                lblOrderNumber.Text = po.OrderNumber.ToString();
                lblName.Text = po.EmpId.ToString();
                lblDate.Text = po.OrderDate.ToShortDateString();
                lblTotal.Text = "$" + po.Total.ToString();
                lblOrderStatus.Text = po.OrderStatus.ToString();

                grpTop.Visible = true;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            askToClose = true;

            CUDMethods.ProcessItem(Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value), Convert.ToByte(2));
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

            if (askToClose == true)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to close the order?", "Purchase Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CUDMethods.ProcessOrder(po.OrderNumber, Convert.ToByte(3));
                    po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                    LoadItems();
                    lblOrderNumber.Text = po.OrderNumber.ToString();
                    lblName.Text = po.EmpId.ToString();
                    lblDate.Text = po.OrderDate.ToShortDateString();
                    lblTotal.Text = "$" + po.Total.ToString();
                    lblOrderStatus.Text = po.OrderStatus.ToString();

                    sendEmail();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void LoadItems()
        {
            dgvItems.DataSource = ListsItemFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            askToClose = true;

            CUDMethods.ProcessItem(Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value), Convert.ToByte(3));
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

            if (askToClose == true)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to close the order?", "Purchase Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CUDMethods.ProcessOrder(po.OrderNumber, Convert.ToByte(3));
                    po = POFactory.Create(Convert.ToInt32(lstOrders.SelectedValue));
                    LoadItems();
                    lblOrderNumber.Text = po.OrderNumber.ToString();
                    lblName.Text = po.EmpId.ToString();
                    lblDate.Text = po.OrderDate.ToShortDateString();
                    lblTotal.Text = "$" + po.Total.ToString();
                    lblOrderStatus.Text = po.OrderStatus.ToString();

                    sendEmail();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void rdoPending_CheckedChanged(object sender, EventArgs e)
        {
            pos = ListsPOFactory.CreatePending();

            lstOrders.DataSource = ListsPOFactory.CreatePending();
            lstOrders.DisplayMember = "orderNumber";
            lstOrders.ValueMember = "orderNumber";
            lstOrders.SelectedIndex = -1;

            orderStatus = 1;
        }

        private void rdoClosed_CheckedChanged(object sender, EventArgs e)
        {
            pos = ListsPOFactory.CreateClosed();

            lstOrders.DataSource = ListsPOFactory.CreateClosed();
            lstOrders.DisplayMember = "orderNumber";
            lstOrders.ValueMember = "orderNumber";
            lstOrders.SelectedIndex = -1;

            orderStatus = 3;
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            pos = ListsPOFactory.Create();

            lstOrders.DataSource = ListsPOFactory.Create();
            lstOrders.DisplayMember = "orderNumber";
            lstOrders.ValueMember = "orderNumber";
            lstOrders.SelectedIndex = -1;
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            dgvItems.DataSource = null;

            if (rdoAll.Checked)
            {
                pos = ListsPOFactory.Create(dtpStart.Value, dtpEnd.Value);

                lstOrders.DataSource = ListsPOFactory.Create(dtpStart.Value, dtpEnd.Value);
                lstOrders.DisplayMember = "orderNumber";
                lstOrders.ValueMember = "orderNumber";
                lstOrders.SelectedIndex = -1;
            }
            else
            {
                pos = ListsPOFactory.CreateDate(orderStatus, dtpStart.Value, dtpEnd.Value);

                lstOrders.DataSource = ListsPOFactory.CreateDate(orderStatus, dtpStart.Value, dtpEnd.Value);
                lstOrders.DisplayMember = "orderNumber";
                lstOrders.ValueMember = "orderNumber";
                lstOrders.SelectedIndex = -1;
            }
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
                message.Body = "<h3>Pruchase Order #" + po.OrderNumber + " has been processed!</h3>";
                SmtpClient smtpClient = new SmtpClient("localhost");
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
