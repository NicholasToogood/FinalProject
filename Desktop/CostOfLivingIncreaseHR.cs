using BusinessLayer;
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
    public partial class CostOfLivingIncreaseHR : Form
    {
        public CostOfLivingIncreaseHR()
        {
            InitializeComponent();
        }

        private void btnRequestIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BusinessLayer.Validate.IsValidPercentageIncreaseRequest(txtPercentageIncreaseRequest.Text))
                {
                    MessageBox.Show("Invalid Percentage. Percentage must be a numeric value above 0.");
                }
                else
                {

                    Double perfIncreaseVal = Convert.ToDouble(txtPercentageIncreaseRequest.Text) / 100;

                    if (CUDMethods.CreateCostOfLivingIncrease(perfIncreaseVal, dtpDateOfIncrease.Value))
                    {
                        MessageBox.Show("Cost-of-living Increase Successful!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
