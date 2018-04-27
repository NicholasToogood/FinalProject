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
    public partial class SearchRetrieveEmployeeHR : Form
    {
        private List<Department> dept;
        private List<Employee> emp;

        private void SearchRetrieveEmployeeHR_Load(object sender, EventArgs e)
        {
            rdoSearchByID.Checked = true;
            loadList();
        }
        private void loadList()
        {
            try
            {
                dept = DepartmentFactory.DepartmentCreateList();
                cmbSCDepartment.DataSource = dept;
                cmbSCDepartment.DisplayMember = "DepartmentName";
                cmbSCDepartment.ValueMember = "DepartmentID";

                List<Job> job = JobFactory.JobsCreateList();

                cmbSCJobAssignment.DataSource = job;
                cmbSCJobAssignment.DisplayMember = "jobTitle";
                cmbSCJobAssignment.ValueMember = "jobId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public SearchRetrieveEmployeeHR()
        {
            InitializeComponent();
        }

        private void rdoSearchByID_CheckedChanged(object sender, EventArgs e)
        {
            lblSearch.Text = "Enter Employee ID:";
        }

        private void rdoSearchByName_CheckedChanged(object sender, EventArgs e)
        {
            lblSearch.Text = "Enter Employee Name:";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String search = txtSearch.Text;

                emp = new List<Employee>();

                Boolean isValid = true;

                if (rdoSearchByID.Checked)
                {
                    if (BusinessLayer.Validate.IsValidEmployeeID(search))
                    {
                        emp = EmployeeFactory.RetrieveEmployeesByID(Convert.ToInt32(search));
                    }
                    else
                    {
                        isValid = false;
                        MessageBox.Show("Employee ID was not valid.");
                    }
                }
                else if (rdoSearchByName.Checked)
                {
                    if (BusinessLayer.Validate.ValidateName(search))
                    {
                        emp = EmployeeFactory.RetrieveEmployeesByName(search);
                    }
                    else
                    {
                        isValid = false;
                        MessageBox.Show("Employee Name was not valid.");
                    }
                }

                if (emp.Count() < 1 && isValid == true)
                {
                    MessageBox.Show("Requested employee/s not found.");
                }
                listBoxResults.DataSource = emp;
                listBoxResults.DisplayMember = "FullName";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Search
            txtFirstName.Text = emp[listBoxResults.SelectedIndex].FirstName.ToString();
            txtMiddleInitial.Text = emp[listBoxResults.SelectedIndex].MiddleInitial.ToString();
            txtLastName.Text = emp[listBoxResults.SelectedIndex].LastName.ToString();
            txtStreetAddress.Text = emp[listBoxResults.SelectedIndex].StreetAddress.ToString();
            txtWorkPhoneNumber.Text = emp[listBoxResults.SelectedIndex].WorkPhoneNumber.ToString();
            txtCellPhoneNumber.Text = emp[listBoxResults.SelectedIndex].CellPhoneNumber.ToString();
            txtEmailAddress.Text = emp[listBoxResults.SelectedIndex].EmailAddress.ToString();
            chkPayrollEmailNotification.Checked = emp[listBoxResults.SelectedIndex].EmailNotification;

            // Apply Salary Changes
            // Employment Information
            txtSCSIN.Text = emp[listBoxResults.SelectedIndex].SIN.ToString();
            dtpSCSeniorityDate.Value = emp[listBoxResults.SelectedIndex].HireDate;
            dtpSCJobStartDate.Value = emp[listBoxResults.SelectedIndex].JobStartDate;
            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].DepartmentID == emp[listBoxResults.SelectedIndex].JobID)
                {
                    txtSCSupervisor.Text = dept[i].Supervisor;
                }
            }
            txtSCBiWeeklyPayRate.Text = emp[listBoxResults.SelectedIndex].BiWeeklyRate.ToString();
            txtSCCellPhoneNumber.Text = emp[listBoxResults.SelectedIndex].CellPhoneNumber;
            txtSCWorkPhoneNumber.Text = emp[listBoxResults.SelectedIndex].WorkPhoneNumber;
            txtSCEmailAddress.Text = emp[listBoxResults.SelectedIndex].EmailAddress;
            chkSCPayrollNotification.Checked = emp[listBoxResults.SelectedIndex].EmailNotification;

            // Personal Information
            txtSCFirstName.Text = emp[listBoxResults.SelectedIndex].FirstName.ToString();
            txtSCMiddleInitial.Text = emp[listBoxResults.SelectedIndex].MiddleInitial.ToString();
            txtSCRealLastName.Text = emp[listBoxResults.SelectedIndex].LastName.ToString();
            dtpSCDateOfBirth.Value = emp[listBoxResults.SelectedIndex].DateOfBirth;
            txtSCStreetAddress.Text = emp[listBoxResults.SelectedIndex].StreetAddress.ToString();
            txtSCCity.Text = emp[listBoxResults.SelectedIndex].City.ToString();
            txtSCPostalCode.Text = emp[listBoxResults.SelectedIndex].PostalCode.ToString();
        }

        private void btnSalaryChanges_Click(object sender, EventArgs e)
        {
            grpBoxApplySalaryChanges.Visible = true;
            grpBoxSearchEmp.Visible = false;
            
        }

        private void btnReturnToSearch_Click(object sender, EventArgs e)
        {
            grpBoxApplySalaryChanges.Visible = false;
            grpBoxSearchEmp.Visible = true;

        }

        private void btnRequestIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                if(!BusinessLayer.Validate.IsValidPercentageIncreaseRequest(txtPercentageIncreaseRequest.Text))
                {
                    MessageBox.Show("Invalid Percentage. Percentage must be a numeric value above 0.");
                }
                else
                {

                    Double perfIncreaseVal = Convert.ToDouble(txtPercentageIncreaseRequest.Text) / 100;

                    if (CUDMethods.CreatePerformanceIncrease(emp[listBoxResults.SelectedIndex].EmpID, perfIncreaseVal, dtpDateOfIncrease.Value))
                    {
                        MessageBox.Show("Performance Increase Successful!");
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
