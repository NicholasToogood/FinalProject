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
            txtSupervisor.Text = "";
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
    }
}
