﻿using BusinessLayer;
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
    public partial class ProcessPO : Form
    {

        List<PurchaseOrder> pos;
        PurchaseOrder po;
        bool askToClose = true;

        public ProcessPO()
        {
            InitializeComponent();
        }

        private void ProcessPO_Load(object sender, EventArgs e)
        {
            pos = ListsPOFactory.Create();

            lstOrders.DataSource = ListsPOFactory.Create();
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
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            askToClose = true;

            CUDMethods.ProcessItem(Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value), Convert.ToByte(2));
            LoadItems();;

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
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}