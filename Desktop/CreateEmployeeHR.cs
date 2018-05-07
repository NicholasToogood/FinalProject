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
    public partial class CreateEmployeeHR : Form
    {
        private List<Department> dept;

        public CreateEmployeeHR()
        {
            InitializeComponent();
        }

        private void CreateEmployeeHR_Load(object sender, EventArgs e)
        {
            loadList();

            txtCellPhoneNumber.Text = "XXX-XXX-XXXX";
            txtCellPhoneNumber.ForeColor = Color.Gray;
            txtWorkPhoneNumber.Text = "XXX-XXX-XXXX";
            txtWorkPhoneNumber.ForeColor = Color.Gray;
            txtSIN.Text = "XXXXXXXXX";
            txtSIN.ForeColor = Color.Gray;
        }

        private void loadList()
        {
            dept = DepartmentFactory.DepartmentCreateList();
            cmbDepartment.DataSource = dept;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";

            List<Job> job = JobFactory.JobsCreateList();

            cmbJobAssignment.DataSource = job;
            cmbJobAssignment.DisplayMember = "jobTitle";
            cmbJobAssignment.ValueMember = "jobId";
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            try{
                String errorMsg = "";
                Boolean isValid = true;
                if(txtSIN.Text.Length <= 0 || txtBiWeeklyPayRate.Text.Length <= 0 || txtCellPhoneNumber.Text.Length <= 0 || txtWorkPhoneNumber.Text.Length <= 0 || txtEmailAddress.Text.Length <= 0 || txtFirstName.Text.Length <= 0 || txtLastName.Text.Length <= 0 || txtStreetAddress.Text.Length <= 0 || txtCity.Text.Length <= 0 || txtPostalCode.Text.Length <= 0)
                {
                    isValid = false;
                    errorMsg = "Error Missing fields.";
                }
                else
                {
                    if (!BusinessLayer.Validate.IsValidSIN(txtSIN.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid SIN. \n";
                    }
                    if (dtpSeniorityDate.Value.Date > dtpJobStartDate.Value.Date)
                    {
                        isValid = false;
                        errorMsg += "Seniority Date must be sooner than or equal to Job Start Date. \n";
                    }
                    if (!BusinessLayer.Validate.IsValidBiweeklyPay(txtBiWeeklyPayRate.Text))
                    {
                        isValid = false;
                        errorMsg += "Bi-Weekly Payrate must be a numeric value greater than 0. \n";
                    }
                    if (!BusinessLayer.Validate.ValidatePhoneNumber(txtCellPhoneNumber.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Cell Phone Number. \n";
                    }
                    if (!BusinessLayer.Validate.ValidatePhoneNumber(txtWorkPhoneNumber.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Work Phone Number. \n";
                    }
                    if (!BusinessLayer.Validate.ValidateEmail(txtEmailAddress.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Email Address. \n";
                    }
                    if (!BusinessLayer.Validate.ValidateLength(txtFirstName.Text, 20))
                    {
                        isValid = false;
                        errorMsg += "First Name cannot be longer than 20 characters. \n";
                    }

                    if (!BusinessLayer.Validate.ValidateLength(txtMiddleInitial.Text, 1))
                    {
                        isValid = false;
                        errorMsg += "Middle Initial cannot be longer than 1 character. \n";
                    }

                    if (!BusinessLayer.Validate.ValidateLength(txtLastName.Text, 30))
                    {
                        isValid = false;
                        errorMsg += "Last Name cannot be longer than 30 characters. \n";
                    }
                    if (!BusinessLayer.Validate.IsValidPostalCode(txtPostalCode.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Postal Code \n";
                    }
                }
                
                if (isValid)
                {
                    Employee emp = EmployeeFactory.CreateEmployee();
                    emp.FirstName = txtFirstName.Text;
                    emp.MiddleInitial = txtMiddleInitial.Text;
                    emp.LastName = txtLastName.Text;
                    emp.DateOfBirth = dtpDateOfBirth.Value;
                    emp.StreetAddress = txtStreetAddress.Text;
                    emp.City = txtCity.Text;
                    emp.PostalCode = txtPostalCode.Text;
                    emp.SIN = Convert.ToInt32(txtSIN.Text);
                    emp.CellPhoneNumber = txtCellPhoneNumber.Text;
                    emp.WorkPhoneNumber = txtWorkPhoneNumber.Text;
                    emp.EmailAddress = txtEmailAddress.Text;
                    emp.HireDate = dtpSeniorityDate.Value;
                    emp.JobStartDate = dtpJobStartDate.Value;
                    emp.EmailNotification = chkPayrollEmailNotification.Checked;
                    emp.JobID = Convert.ToInt32(cmbJobAssignment.SelectedValue);
                    emp.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    emp.BiWeeklyRate = Convert.ToDouble(txtBiWeeklyPayRate.Text);


                    int newEmpID = CUDMethods.CreateEmp(emp);

                    MessageBox.Show("New Employee Created With ID of: " + newEmpID);

                    //MessageBox.Show("Worked");
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSIN.Text = "";
            cmbJobAssignment.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            txtBiWeeklyPayRate.Text = "";
            txtCellPhoneNumber.Text = "";
            txtWorkPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            chkPayrollEmailNotification.Checked = false;
            txtFirstName.Text = "";
            txtMiddleInitial.Text = "";
            txtLastName.Text = "";
            txtStreetAddress.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";

            dtpSeniorityDate.Value = DateTime.Today;
            dtpJobStartDate.Value = DateTime.Today;
            dtpDateOfBirth.Value = DateTime.Today;

            txtCellPhoneNumber.Text = "XXX-XXX-XXXX";
            txtCellPhoneNumber.ForeColor = Color.Gray;
            txtWorkPhoneNumber.Text = "XXX-XXX-XXXX";
            txtWorkPhoneNumber.ForeColor = Color.Gray;
            txtSIN.Text = "XXXXXXXXX";
            txtSIN.ForeColor = Color.Gray;
        }

        private void cmbJobAssignment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDept;
            String supervisorName = "";

            if (int.TryParse(cmbDepartment.SelectedValue.ToString(), out selectedDept))
            {
                for (int i = 0; i < dept.Count; i++)
                {
                    if (dept[i].DepartmentID == selectedDept)
                    {
                        supervisorName = dept[i].Supervisor;
                    }
                }
            }
            else
            {
                if(dept.Count > 0)
                {
                    supervisorName = dept[0].Supervisor;
                }
            }
            
            txtSupervisor.Text = supervisorName;
        }

        private void txtCellPhoneNumber_Enter(object sender, EventArgs e)
        {
            if(txtCellPhoneNumber.Text == "XXX-XXX-XXXX")
            {
                txtCellPhoneNumber.Text = "";
                txtCellPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void txtCellPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtCellPhoneNumber.Text == "")
            {
                txtCellPhoneNumber.Text = "XXX-XXX-XXXX";
                txtCellPhoneNumber.ForeColor = Color.Gray;
            }
        }

        private void txtWorkPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtWorkPhoneNumber.Text == "XXX-XXX-XXXX")
            {
                txtWorkPhoneNumber.Text = "";
                txtWorkPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void txtWorkPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtWorkPhoneNumber.Text == "")
            {
                txtWorkPhoneNumber.Text = "XXX-XXX-XXXX";
                txtWorkPhoneNumber.ForeColor = Color.Gray;
            }
        }

        private void txtSIN_Enter(object sender, EventArgs e)
        {
            if (txtSIN.Text == "XXXXXXXXX")
            {
                txtSIN.Text = "";
                txtSIN.ForeColor = Color.Black;
            }
        }

        private void txtSIN_Leave(object sender, EventArgs e)
        {
            if (txtSIN.Text == "")
            {
                txtSIN.Text = "XXXXXXXXX";
                txtSIN.ForeColor = Color.Gray;
            }
        }
    }
}
