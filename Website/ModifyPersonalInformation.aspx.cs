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
            List<Employee> emp = EmployeeFactory.RetrieveEmployeesByID(empID);

            txtCellPhone.Text = emp[0].CellPhoneNumber;
            txtWorkPhone.Text = emp[0].WorkPhoneNumber;
            txtHomeAddress.Text = emp[0].StreetAddress;

        }

        protected void btnUpdatePersonalInfo_Click(object sender, EventArgs e)
        {
            Boolean IsValid = true;

            if (BusinessLayer.Validate.ValidatePhoneNumber(txtWorkPhone.Text))
            {

                IsValid = false;
            }
            if (BusinessLayer.Validate.ValidatePhoneNumber(txtCellPhone.Text))
            {

                IsValid = false;
            }

            if (IsValid)
            {

            }

            Employee tmpEmp = EmployeeFactory.CreateEmployee();

            tmpEmp.EmpID = empID;
            tmpEmp.WorkPhoneNumber = txtWorkPhone.Text;
            tmpEmp.CellPhoneNumber = txtCellPhone.Text;
            tmpEmp.StreetAddress = txtHomeAddress.Text;

            try
            {
                CUDMethods.UpdateEmployeeEmp(tmpEmp);
            }
            catch(Exception ex)
            {
                
            }
            
        }
    }
}