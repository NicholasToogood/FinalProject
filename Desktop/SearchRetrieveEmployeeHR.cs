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
    public partial class SearchRetrieveEmployeeHR : Form
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
                dept = DepartmentFactory.DepartmentCreateList();
                cmbSCDepartment.DataSource = dept;
                cmbSCDepartment.DisplayMember = "DepartmentName";
                cmbSCDepartment.ValueMember = "DepartmentID";

                cmbDepartmentModify.DataSource = dept;
                cmbDepartmentModify.DisplayMember = "DepartmentName";
                cmbDepartmentModify.ValueMember = "DepartmentID";

                List<Job> job = JobFactory.JobsCreateList();

                cmbSCJobAssignment.DataSource = job;
                cmbSCJobAssignment.DisplayMember = "jobTitle";
                cmbSCJobAssignment.ValueMember = "jobId";

                cmbJobAssignmentModify.DataSource = job;
                cmbJobAssignmentModify.DisplayMember = "jobTitle";
                cmbJobAssignmentModify.ValueMember = "jobId";



                cmbEmpStatusModify.DataSource = Enum.GetValues(typeof(EmpStatus));
                cmbLenthOfDay.DataSource = Enum.GetValues(typeof(SickDayLength));
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
            searchByID = rdoSearchByID.Checked;
            searchText = txtSearch.Text;
            searchEmployee();
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

            // Search
            txtFirstName.Text = emp[listBoxResults.SelectedIndex].FirstName.ToString();
            txtMiddleInitial.Text = emp[listBoxResults.SelectedIndex].MiddleInitial.ToString();
            txtLastName.Text = emp[listBoxResults.SelectedIndex].LastName.ToString();
            txtStreetAddress.Text = emp[listBoxResults.SelectedIndex].StreetAddress.ToString();
            txtWorkPhoneNumber.Text = emp[listBoxResults.SelectedIndex].WorkPhoneNumber.ToString();
            txtCellPhoneNumber.Text = emp[listBoxResults.SelectedIndex].CellPhoneNumber.ToString();
            txtEmailAddress.Text = emp[listBoxResults.SelectedIndex].EmailAddress.ToString();
            chkPayrollEmailNotification.Checked = emp[listBoxResults.SelectedIndex].EmailNotification;

            displaySCSigns();
            displaySignsModify();
        }
        private void displaySCSigns()
        {
            // Apply Salary Changes
            // Employment Information
            txtSCSIN.Text = emp[listBoxResults.SelectedIndex].SIN.ToString();
            dtpSCSeniorityDate.Value = emp[listBoxResults.SelectedIndex].HireDate;
            dtpSCJobStartDate.Value = emp[listBoxResults.SelectedIndex].JobStartDate;
            cmbSCDepartment.SelectedValue = emp[listBoxResults.SelectedIndex].DepartmentID;
            cmbSCJobAssignment.SelectedValue = emp[listBoxResults.SelectedIndex].JobID;
            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].DepartmentID == emp[listBoxResults.SelectedIndex].DepartmentID)
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
        private void displaySignsModify()
        {
            // Apply Salary Changes
            // Employment Information
            txtSINModify.Text = emp[listBoxResults.SelectedIndex].SIN.ToString();
            dtpSeniorityDateModify.Value = emp[listBoxResults.SelectedIndex].HireDate;
            dtpJobStartDateModify.Value = emp[listBoxResults.SelectedIndex].JobStartDate;
            cmbDepartmentModify.SelectedValue = emp[listBoxResults.SelectedIndex].DepartmentID;
            cmbJobAssignmentModify.SelectedValue = emp[listBoxResults.SelectedIndex].JobID;
            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].DepartmentID == emp[listBoxResults.SelectedIndex].DepartmentID)
                {
                    txtSupervisorModify.Text = dept[i].Supervisor;
                }
            }
            txtBiWeeklyRateModify.Text = emp[listBoxResults.SelectedIndex].BiWeeklyRate.ToString();
            txtCellPhoneNumberModify.Text = emp[listBoxResults.SelectedIndex].CellPhoneNumber;
            txtWorkPhoneNumberModify.Text = emp[listBoxResults.SelectedIndex].WorkPhoneNumber;
            txtEmailAddressModify.Text = emp[listBoxResults.SelectedIndex].EmailAddress;
            chkPayrollEmailModify.Checked = emp[listBoxResults.SelectedIndex].EmailNotification;

            // Personal Information
            txtFirstNameModify.Text = emp[listBoxResults.SelectedIndex].FirstName.ToString();
            txtMiddleInitialModify.Text = emp[listBoxResults.SelectedIndex].MiddleInitial.ToString();
            txtLastNameModify.Text = emp[listBoxResults.SelectedIndex].LastName.ToString();
            dtpDateOfBirthModify.Value = emp[listBoxResults.SelectedIndex].DateOfBirth;
            txtStreetAddressModify.Text = emp[listBoxResults.SelectedIndex].StreetAddress.ToString();
            txtCityModify.Text = emp[listBoxResults.SelectedIndex].City.ToString();
            txtPostalCodeModify.Text = emp[listBoxResults.SelectedIndex].PostalCode.ToString();

            cmbEmpStatusModify.SelectedIndex = emp[listBoxResults.SelectedIndex].EmpStatus - 1;
            if (emp[listBoxResults.SelectedIndex].EmpStatus != 1)
            {
                dtpEmpEndModify.Value = emp[listBoxResults.SelectedIndex].DateOfDeparture;
            }
        }

        private void cmbSCDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDept;
            String supervisorName = "";

            if (int.TryParse(cmbSCDepartment.SelectedValue.ToString(), out selectedDept))
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
                if (dept.Count > 0)
                {
                    supervisorName = dept[0].Supervisor;
                }
            }

            txtSCSupervisor.Text = supervisorName;
        }

        private void btnSalaryChanges_Click(object sender, EventArgs e)
        {
            if(listBoxResults.Items.Count > 0)
            {
                grpBoxApplySalaryChanges.Visible = true;
                grpBoxSearchEmp.Visible = false;
                grpBoxModify.Visible = false;
                grpBoxRecordSickDays.Visible = false;
            }
            else
            {
                MessageBox.Show("Must select an employee before entering this section.");
            }
        }

        private void btnReturnToSearch_Click(object sender, EventArgs e)
        {
            grpBoxApplySalaryChanges.Visible = false;
            grpBoxSearchEmp.Visible = true;
            grpBoxModify.Visible = false;
            grpBoxRecordSickDays.Visible = false;
            cancelButton();
        }

        private void btnModifyEmp_Click(object sender, EventArgs e)
        {
            if (listBoxResults.Items.Count > 0)
            {
                grpBoxApplySalaryChanges.Visible = false;
                grpBoxSearchEmp.Visible = false;
                grpBoxModify.Visible = true;
                grpBoxRecordSickDays.Visible = false;
            }
            else
            {
                MessageBox.Show("Must select an employee before entering this section.");
            }
        }

        private void btnSickDays_Click(object sender, EventArgs e)
        {
            if (listBoxResults.Items.Count > 0)
            {
                grpBoxApplySalaryChanges.Visible = false;
                grpBoxSearchEmp.Visible = false;
                grpBoxModify.Visible = false;
                grpBoxRecordSickDays.Visible = true;
                RetrieveSickDays(emp[listBoxResults.SelectedIndex].EmpID);
            }
            else
            {
                MessageBox.Show("Must select an employee before entering this section.");
            }
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

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnModifyEmployee.Visible = false;

            txtSINModify.ReadOnly = false;
            dtpJobStartDateModify.Enabled = true;
            dtpSeniorityDateModify.Enabled = true;
            txtBiWeeklyRateModify.ReadOnly = false;
            txtCellPhoneNumberModify.ReadOnly = false;
            txtWorkPhoneNumberModify.ReadOnly = false;
            txtEmailAddressModify.ReadOnly = false;
            chkPayrollEmailModify.Enabled = true;
            txtFirstNameModify.ReadOnly = false;
            txtMiddleInitialModify.ReadOnly = false;
            txtLastNameModify.ReadOnly = false;
            dtpDateOfBirthModify.Enabled = true;
            txtStreetAddressModify.ReadOnly = false;
            txtCityModify.ReadOnly = false;
            txtPostalCodeModify.ReadOnly = false;
            
            if(emp[listBoxResults.SelectedIndex].EmpStatus == 2)
            {
                dtpEmpEndModify.Enabled = false;
            }
            else
            {
                dtpEmpEndModify.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelButton();
        }
        private void cancelButton()
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnModifyEmployee.Visible = true;

            txtSINModify.ReadOnly = true;
            dtpJobStartDateModify.Enabled = false;
            dtpSeniorityDateModify.Enabled = false;
            txtBiWeeklyRateModify.ReadOnly = true;
            txtCellPhoneNumberModify.ReadOnly = true;
            txtWorkPhoneNumberModify.ReadOnly = true;
            txtEmailAddressModify.ReadOnly = true;
            chkPayrollEmailModify.Enabled = false;
            txtFirstNameModify.ReadOnly = true;
            txtMiddleInitialModify.ReadOnly = true;
            txtLastNameModify.ReadOnly = true;
            dtpDateOfBirthModify.Enabled = false;
            txtStreetAddressModify.ReadOnly = true;
            txtCityModify.ReadOnly = true;
            txtPostalCodeModify.ReadOnly = true;
            
            displaySignsModify();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String errorMsg = "";
                Boolean isValid = true;
                DateTime now = DateTime.Today;
                int listIndex = listBoxResults.SelectedIndex;

                if (txtSINModify.Text.Length <= 0 || txtBiWeeklyRateModify.Text.Length <= 0 || txtCellPhoneNumberModify.Text.Length <= 0 || txtWorkPhoneNumberModify.Text.Length <= 0 || txtEmailAddressModify.Text.Length <= 0 || txtFirstNameModify.Text.Length <= 0 || txtLastNameModify.Text.Length <= 0 || txtStreetAddressModify.Text.Length <= 0 || txtCityModify.Text.Length <= 0 || txtPostalCodeModify.Text.Length <= 0)
                {
                    isValid = false;
                    errorMsg = "Error Missing fields.";
                }
                else if((cmbEmpStatusModify.SelectedValue.ToString() == "Retired") && ((now.Year - emp[listBoxResults.SelectedIndex].DateOfBirth.Year) < 55))
                {
                    isValid = false;
                    errorMsg = "Cannot retire if you're less than 55. \n";
                }
                else if(emp[listBoxResults.SelectedIndex].EmpStatus == 2 && cmbEmpStatusModify.SelectedValue.ToString() != "Retired"){
                    isValid = false;
                    errorMsg = "Once an employee retires they cannot be reinstated. \n";
                }
                else
                {
                    if (!BusinessLayer.Validate.IsValidSIN(txtSINModify.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid SIN. \n";
                    }
                    if (dtpSeniorityDateModify.Value.Date > dtpJobStartDateModify.Value.Date)
                    {
                        isValid = false;
                        errorMsg += "Seniority Date must be sooner than or equal to Job Start Date. \n";
                    }
                    if (!BusinessLayer.Validate.IsValidBiweeklyPay(txtBiWeeklyRateModify.Text))
                    {
                        isValid = false;
                        errorMsg += "Bi-Weekly Payrate must be a numeric value greater than 0. \n";
                    }
                    if (!BusinessLayer.Validate.ValidatePhoneNumber(txtCellPhoneNumberModify.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Cell Phone Number. \n";
                    }
                    if (!BusinessLayer.Validate.ValidatePhoneNumber(txtWorkPhoneNumberModify.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Work Phone Number. \n";
                    }
                    if (!BusinessLayer.Validate.ValidateEmail(txtEmailAddressModify.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Email Address. \n";
                    }
                    if (!BusinessLayer.Validate.ValidateLength(txtFirstNameModify.Text, 20))
                    {
                        isValid = false;
                        errorMsg += "First Name cannot be longer than 20 characters. \n";
                    }

                    if (!BusinessLayer.Validate.ValidateLength(txtMiddleInitialModify.Text, 1))
                    {
                        isValid = false;
                        errorMsg += "Middle Initial cannot be longer than 1 character. \n";
                    }

                    if (!BusinessLayer.Validate.ValidateLength(txtLastNameModify.Text, 30))
                    {
                        isValid = false;
                        errorMsg += "Last Name cannot be longer than 30 characters. \n";
                    }
                    if (!BusinessLayer.Validate.IsValidPostalCode(txtPostalCodeModify.Text))
                    {
                        isValid = false;
                        errorMsg += "Invalid Postal Code \n";
                    }
                    
                }

                if (isValid)
                {
                    Employee modifiedEmp = EmployeeFactory.CreateEmployee();

                    modifiedEmp.EmpID = emp[listBoxResults.SelectedIndex].EmpID;

                    modifiedEmp.FirstName = txtFirstNameModify.Text;
                    modifiedEmp.MiddleInitial = txtMiddleInitialModify.Text;
                    modifiedEmp.LastName = txtLastNameModify.Text;
                    modifiedEmp.DateOfBirth = dtpDateOfBirthModify.Value;
                    modifiedEmp.StreetAddress = txtStreetAddressModify.Text;
                    modifiedEmp.City = txtCityModify.Text;
                    modifiedEmp.PostalCode = txtPostalCodeModify.Text;
                    modifiedEmp.SIN = Convert.ToInt32(txtSINModify.Text);
                    modifiedEmp.CellPhoneNumber = txtCellPhoneNumberModify.Text;
                    modifiedEmp.WorkPhoneNumber = txtWorkPhoneNumberModify.Text;
                    modifiedEmp.EmailAddress = txtEmailAddressModify.Text;
                    modifiedEmp.HireDate = dtpSeniorityDateModify.Value;
                    modifiedEmp.JobStartDate = dtpJobStartDateModify.Value;
                    modifiedEmp.EmailNotification = chkPayrollEmailModify.Checked;
                    modifiedEmp.JobID = Convert.ToInt32(cmbJobAssignmentModify.SelectedValue);
                    modifiedEmp.DepartmentID = Convert.ToInt32(cmbDepartmentModify.SelectedValue);
                    modifiedEmp.BiWeeklyRate = Convert.ToDouble(txtBiWeeklyRateModify.Text);
                    
                    modifiedEmp.EmpStatus = Convert.ToInt32(cmbEmpStatusModify.SelectedValue);
                    modifiedEmp.DateOfDeparture = dtpEmpEndModify.Value;

                    if (CUDMethods.ModifyEmployee(modifiedEmp))
                    {
                        MessageBox.Show("Employee Succesfully Modified!");
                        emp[listBoxResults.SelectedIndex] = modifiedEmp;
                        cancelButton();
                        searchEmployee();
                        listBoxResults.SelectedIndex = listIndex;
                    }
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
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

            if(txtSickDayDescription.Text == "")
            {
                MessageBox.Show("Error Missing Sick Day Description.");
            }
            else if(dtpSickDayDate.Value.Date > DateTime.Now.Date || dtpSickDayEndDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Error sick date cannot be in the future.");
            }
            else if(dtpSickDayDate.Value.Date > dtpSickDayEndDate.Value.Date)
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
                
                foreach(SickDays tmpAddSickDay in sickDays)
                {
                    CUDMethods.CreateNewSickDay(tmpAddSickDay);
                }
                
                MessageBox.Show("Sick Day Added.");
                RetrieveSickDays(emp[listBoxResults.SelectedIndex].EmpID);
                clearSickDayInfo();
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
