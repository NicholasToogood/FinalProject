﻿using BusinessLayer;
using BusinessLayer.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class InquireEmploymentInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblSuccess.Text = "";
            if (dtpStart.SelectedDate > dtpEnd.SelectedDate)
            {
                lblError.Text = "Start Date must be before end date.";
            }
            else
            {
                try
                {
                    if(Session["empID"] != null)
                    {
                        Calendar date = new Calendar();
                        //date.TodaysDate.AddYears(-1000)

                        if(dtpStart.SelectedDate < date.TodaysDate.AddYears(-1000) || dtpEnd.SelectedDate < date.TodaysDate.AddYears(-1000))
                        {
                            lblError.Text = "Must select a start and a end date.";
                        }
                        else
                        {
                            List<PayStub> paystubs = PaystubFactory.RetrievePaystubsForEmpBetweenDates(Convert.ToInt32(Session["empID"]), dtpStart.SelectedDate, dtpEnd.SelectedDate);

                            dgvItems.DataSource = paystubs;
                            dgvItems.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
            }
        }
    }
}