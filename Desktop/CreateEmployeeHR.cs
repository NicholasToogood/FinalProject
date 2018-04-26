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
            List<Department> dept = DepartmentFactory.DepartmentCreateList();
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.ValueMember = "id";
            cmbDepartment.DataSource = dept;

            List<Job> job = JobFactory.JobsCreateList();

            cmbDepartment.DisplayMember = "jobTitle";
            cmbDepartment.ValueMember = "jobId";
            cmbDepartment.DataSource = job;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
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
                //emp.JobID = cmbJobAssignment.SelectedItem;
                //emp.DepartmentID = cmbDepartment.SelectedValue;
                emp.BiWeeklyRate = Convert.ToDouble(txtBiWeeklyPayRate.Text);


                CUDMethods.CreateEmp(emp);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
