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
    public partial class ModifyPersonalInformation : System.Web.UI.Page
    {
        int empID = 10000001;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                if (!IsPostBack)
                {
                    List<Employee> emp = EmployeeFactory.RetrieveEmployeesByID(empID);

                    Session["lastTouched"] = emp[0].lastTouched;

                    txtCellPhone.Text = emp[0].CellPhoneNumber;
                    txtWorkPhone.Text = emp[0].WorkPhoneNumber;
                    txtHomeAddress.Text = emp[0].StreetAddress;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }

        }

        protected void btnUpdatePersonalInfo_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblSuccess.Text = "";
            Boolean IsValid = true;
            String errorMsg = "\n";
            if (!BusinessLayer.Validate.ValidatePhoneNumber(txtWorkPhone.Text))
            {
                errorMsg += "Invalid Work Number.\n";
                IsValid = false;
            }
            if (!BusinessLayer.Validate.ValidatePhoneNumber(txtCellPhone.Text))
            {
                errorMsg += "Invalid Cell Number.\n";
                IsValid = false;
            }
            if(txtHomeAddress.Text == String.Empty)
            {
                errorMsg += "Invalid Address.\n";
                IsValid = false;
            }

            if (IsValid)
            {
                byte[] lastChecked = (byte[]) Session["lastTouched"];

                Employee tmpEmp = EmployeeFactory.CreateEmployee();

                tmpEmp.EmpID = empID;
                tmpEmp.WorkPhoneNumber = txtWorkPhone.Text;
                tmpEmp.CellPhoneNumber = txtCellPhone.Text;
                tmpEmp.StreetAddress = txtHomeAddress.Text;
                tmpEmp.lastTouched = lastChecked;

                try
                {
                    CUDMethods.UpdateEmployeeEmp(tmpEmp);
                    lblSuccess.Text = "Information Updated!";

                    List<Employee> emp = EmployeeFactory.RetrieveEmployeesByID(empID);
                    Session["lastTouched"] = emp[0].lastTouched;

                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
            }
            else
            {
                lblError.Text = "Some fields were not valid: \n" + errorMsg;
            }
        }
    }
}