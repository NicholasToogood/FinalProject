using BusinessLayer;
using BusinessLayer.Classes;
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
using Types;

namespace Desktop
{
    public partial class AddSickDayHR : Form
    {
        private List<Department> dept;
        private List<Employee> emp;

        Boolean searchByID;
        String searchText;

        private void SearchRetrieveEmployeeHR_Load(object sender, EventArgs e)
        {
            rdoSearchByID.Checked = true;
            loadList();
        }
        private void loadList()
        {
            try
            {
                cmbLenthOfDay.DataSource = Enum.GetValues(typeof(SickDayLength));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public AddSickDayHR()
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
                searchByID = rdoSearchByID.Checked;
                searchText = txtSearch.Text;
                searchEmployee();
            }
            catch(Exception ex)
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
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

        private void btnReturnToSearch_Click(object sender, EventArgs e)
        {
            try
            {
                grpBoxSearchEmp.Visible = true;
                grpBoxRecordSickDays.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnSickDays_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxResults.Items.Count > 0)
                {
                    grpBoxSearchEmp.Visible = false;
                    grpBoxRecordSickDays.Visible = true;
                    RetrieveSickDays(emp[listBoxResults.SelectedIndex].EmpID);
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
        

        // SICK DAYS 
        private void RetrieveSickDays(int ID)
        {
            List<SickDays> sickDays = SickDaysFactory.RetrieveSickDaysByID(ID);

            dataGridviewSickDays.DataSource = sickDays;

            txtTotalSickDays.Text = SickDaysFactory.RetrieveNumberOfSickDays(ID).ToString();
        }

        private void btnAddSickDay_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSickDayDescription.Text == "")
                {
                    MessageBox.Show("Error Missing Sick Day Description.");
                }
                else if (dtpSickDayDate.Value.Date > DateTime.Now.Date || dtpSickDayEndDate.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Error sick date cannot be in the future.");
                }
                else if (dtpSickDayDate.Value.Date > dtpSickDayEndDate.Value.Date)
                {
                    MessageBox.Show("Error sick start date must be before sick end date.");
                }
                else
                {
                    List<SickDays> sickDays = new List<SickDays>();

                    if (chkRangeOfSickDates.Checked)
                    {
                        //TimeSpan difference = (dtpSickDayEndDate.Value.Date - dtpSickDayDate.Value.Date);

                        DateTime tmpDate = dtpSickDayDate.Value.Date;

                        while (tmpDate.Date <= dtpSickDayEndDate.Value.Date)
                        {

                            SickDays tmpSickDay = SickDaysFactory.SickDaysCreate();
                            tmpSickDay.empId = emp[listBoxResults.SelectedIndex].EmpID;
                            tmpSickDay.SickDayDate = tmpDate;
                            tmpSickDay.SickDayDescription = txtSickDayDescription.Text;
                            if (cmbLenthOfDay.SelectedValue.ToString() == "Full")
                            {
                                tmpSickDay.SickDayLength = 1;
                            }
                            else
                            {
                                tmpSickDay.SickDayLength = 0.5;
                            }

                            sickDays.Add(tmpSickDay);

                            tmpDate = tmpDate.AddDays(1);
                        }
                    }
                    else
                    {
                        SickDays tmpSickDaySingular = SickDaysFactory.SickDaysCreate();
                        tmpSickDaySingular.empId = emp[listBoxResults.SelectedIndex].EmpID;
                        tmpSickDaySingular.SickDayDate = dtpSickDayDate.Value;
                        tmpSickDaySingular.SickDayDescription = txtSickDayDescription.Text;
                        if (cmbLenthOfDay.SelectedValue.ToString() == "Full")
                        {
                            tmpSickDaySingular.SickDayLength = 1;
                        }
                        else
                        {
                            tmpSickDaySingular.SickDayLength = 0.5;
                        }

                        sickDays.Add(tmpSickDaySingular);
                    }

                    foreach (SickDays tmpAddSickDay in sickDays)
                    {
                        CUDMethods.CreateNewSickDay(tmpAddSickDay);
                    }

                    MessageBox.Show("Sick Day Added.");
                    RetrieveSickDays(emp[listBoxResults.SelectedIndex].EmpID);
                    clearSickDayInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void clearSickDayInfo()
        {
            txtSickDayDescription.Text = "";
            chkRangeOfSickDates.Checked = false;
            cmbLenthOfDay.SelectedIndex = 0;
            dtpSickDayDate.Value = DateTime.Now;
            dtpSickDayEndDate.Value = DateTime.Now;
        }

        private void btnClearSickDay_Click(object sender, EventArgs e)
        {
            clearSickDayInfo();
        }

        private void chkRangeOfSickDates_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRangeOfSickDates.Checked)
            {
                dtpSickDayEndDate.Visible = true;
                lblSickDayEndDate.Visible = true;
            }
            else
            {
                dtpSickDayEndDate.Visible = false;
                lblSickDayEndDate.Visible = false;
            }
        }
        

        // SICK DAYS ^^
    }
}
