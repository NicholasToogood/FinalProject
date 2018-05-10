using BusinessLayer.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["empID"] != null)
            {
                // lblSuccess.Text = "Welcome! " + Session["empID"].ToString();
                lblCurrentLoginID.Text = Session["empID"].ToString();
                loginDiv.Visible = false;
                logoutDiv.Visible = true;
            }
            else
            {
                loginDiv.Visible = true;
                logoutDiv.Visible = false;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                lblSuccess.Text = "";
                bool fields = true;

                String errorMsg = "";

                if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    errorMsg += "Please enter your password. <br/>";
                    fields = false;
                }
                if (String.IsNullOrEmpty(txtEmployeeID.Text.Trim()))
                {
                    errorMsg += "Please enter your username. <br/>";
                    fields = false;
                }
                else if (!BusinessLayer.Validate.IsValidEmployeeID(txtEmployeeID.Text))
                {
                    errorMsg += "Incorrect Username. <br/>";
                    fields = false;
                }
                if (fields)
                {
                    if (EmployeeFactory.AuthenticateEmployee(Convert.ToInt32(txtEmployeeID.Text), txtPassword.Text))
                    {
                        //AuthenticationLvl = Convert.ToInt32(txtUserName.Text);
                        Session["empID"] = Convert.ToInt32(txtEmployeeID.Text);

                        Response.Redirect(Request.RawUrl);

                    }
                    else
                    {
                        lblError.Text = "Invalid Employee ID or Password.";
                    }
                }
                else
                {
                    lblError.Text = errorMsg;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["empID"] = null;
            Response.Redirect(Request.RawUrl);
        }
    }
}