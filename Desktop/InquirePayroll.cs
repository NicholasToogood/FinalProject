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
    public partial class InquirePayroll : Form
    {
        private List<Department> dept;
        private List<Employee> emp;

        //int currentEmployeeID;

        Boolean searchByID;
        String searchText;

        public InquirePayroll()
        {
            InitializeComponent();
        }

        #region search
        private void InquirePayroll_Load(object sender, EventArgs e)
        {
            rdoSearchByID.Checked = true;
            //loadList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                searchByID = rdoSearchByID.Checked;
                searchText = txtSearch.Text;
                searchEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdoSearchByID_CheckedChanged(object sender, EventArgs e)
        {
            lblSearch.Text = "Enter Employee ID:";
        }

        private void rdoSearchByName_CheckedChanged(object sender, EventArgs e)
        {
            lblSearch.Text = "Enter Employee Name:";
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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

                //displaySCSigns();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void searchEmployee()
        {

            try
            {
                String search = searchText;

                emp = new List<Employee>();

                Boolean isValid = true;

                if (searchByID)
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
                else if (!searchByID)
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

        private void btnInquirePayroll_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxResults.Items.Count > 0)
                {
                    grpBoxInquirePayroll.Visible = true;
                    grpBoxSearchEmp.Visible = false;
                }
                else
                {
                    MessageBox.Show("Must select an employee before entering this section.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Inquire Payroll Information

        private void btnReturnToSearch_Click(object sender, EventArgs e)
        {
            try
            {
                grpBoxInquirePayroll.Visible = false;
                grpBoxSearchEmp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        private void btnSearchPaystubs_Click(object sender, EventArgs e)
        {
            if(dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date must be before end date.");
            }
            else
            {
                try
                {

                    List<PayStub> paystubs = PaystubFactory.RetrievePaystubsForEmpBetweenDates(emp[listBoxResults.SelectedIndex].EmpID, dtpStartDate.Value, dtpEndDate.Value);

                    dataGridViewPaystubs.DataSource = paystubs;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
