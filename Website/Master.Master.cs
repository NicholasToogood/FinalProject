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
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["empID"] == null)
            {
                navContent.Visible = false;
                if (Request.RawUrl != "/login.aspx")
                {
                    Response.Redirect("~/login.aspx");
                }
            }
            else
            {
                try
                {
                    navContent.Visible = true;

                    Job empJob = JobFactory.JobByEmpID(Convert.ToInt32(Session["empID"]));
                    if (empJob.JobID == 1)
                    { // REGULAR EMPLOYEE
                        createPO.Visible = true;
                        modifyPO.Visible = true;

                        modifyPersonalInformation.Visible = true;
                    }
                    else if (empJob.JobID == 3)
                    { // HR EMPLOYEE
                        createPO.Visible = true;
                        modifyPO.Visible = true;

                        modifyPersonalInformation.Visible = true;
                    }
                    else if (empJob.JobID == 4)
                    { // SUPERVISOR
                        createPO.Visible = true;
                        modifyPO.Visible = true;
                        processPO.Visible = true;

                        modifyPersonalInformation.Visible = true;
                    }
                    else if (empJob.JobID == 5)
                    { // HR SUPERVISOR
                        createPO.Visible = true;
                        modifyPO.Visible = true;
                        processPO.Visible = true;

                        modifyPersonalInformation.Visible = true;
                    }

                    if(Request.RawUrl == "/ProcessPO.aspx" && (empJob.JobID != 5 || empJob.JobID != 4))
                    {
                        Response.Redirect("~/login.aspx");
                    }
                }
                catch(Exception ex)
                {
                    navContent.Visible = false;

                    lblErrMessage.InnerText = ex.Message;
                }
                



            }
        }
    }
}