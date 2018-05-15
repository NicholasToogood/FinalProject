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
    public partial class Main : Form
    {

        CreatePO createPO;
        ModifyPO modifyPO;
        CreateEmployeeHR createEmployee;
        AddSickDayHR searchEmp;
        CostOfLivingIncreaseHR costOfLiving;
        CalculatePayroll calculatePayroll;
        CalculatePension calculatePension;
        ProcessPO processPO;
        ModifyEmployeeHR modifyEmployeeHR;
        SalaryChangesHR salaryChangesHR;
        InquirePayroll inquirePayroll;

        public static int empID;

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Splash mySplash = new Splash();
            mySplash.ShowDialog();

            Login myLogin = new Login();
            myLogin.ShowDialog();
            if (myLogin.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                empID = myLogin.empID;
                // if employee JOB is HR
                Job empJob = JobFactory.JobByEmpID(myLogin.empID);
                if (empJob.JobID == 1)
                { // REGULAR EMPLOYEE
                    btnCreatePO.Visible = true;
                    btnModPO.Visible = true;
                }
                else if (empJob.JobID == 3)
                { // HR EMPLOYEE
                    btnCreatePO.Visible = true;
                    btnModPO.Visible = true;

                    btnAddEmp.Visible = true;
                    btnCostOfLiving.Visible = true;
                    btnCalculatePension.Visible = true;
                    btnInquirePayroll.Visible = true;

                    btnSickDays.Visible = true;
                    btnSalaryChanges.Visible = true;
                    btnModifyEmployee.Visible = true;
                }
                else if (empJob.JobID == 4)
                { // SUPERVISOR
                    btnCreatePO.Visible = true;
                    btnModPO.Visible = true;
                    btnProcessPO.Visible = true;
                }
                else if (empJob.JobID == 5)
                { // HR SUPERVISOR

                    initiatePayroll();

                    btnCreatePO.Visible = true;
                    btnModPO.Visible = true;
                    btnProcessPO.Visible = true;

                    btnAddEmp.Visible = true;
                    btnCostOfLiving.Visible = true;
                    btnCalculatePension.Visible = true;
                    btnInquirePayroll.Visible = true;

                    btnSickDays.Visible = true;
                    btnSalaryChanges.Visible = true;
                    btnModifyEmployee.Visible = true;
                }
            }
        }

        private void DisplayForm(Form form)
        {
            if (MainTab.Contains(form))
            {
                MainTab.TabPages[form].Select();
            }
            else
            {
                MainTab.TabPages.Add(form);
            }
        }

        private void btnCreatePO_Click(object sender, EventArgs e)
        {
            if (createPO == null || createPO.IsDisposed)
            {
                createPO = new CreatePO();
            }
            DisplayForm(createPO);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (createEmployee == null || createEmployee.IsDisposed)
            {
                createEmployee = new CreateEmployeeHR();
            }
            DisplayForm(createEmployee);
        }

        private void btnSickDays_Click(object sender, EventArgs e)
        {
            if (searchEmp == null || searchEmp.IsDisposed)
            {
                searchEmp = new AddSickDayHR();
            }
            DisplayForm(searchEmp);
        }

        private void btnCostOfLiving_Click(object sender, EventArgs e)
        {
            if (costOfLiving == null || costOfLiving.IsDisposed)
            {
                costOfLiving = new CostOfLivingIncreaseHR();
            }
            DisplayForm(costOfLiving);
        }

        private void btnModPO_Click(object sender, EventArgs e)
        {
            if (modifyPO == null || modifyPO.IsDisposed)
            {
                modifyPO = new ModifyPO();
            }
            DisplayForm(modifyPO);
        }

        private void btnCalculatePension_Click(object sender, EventArgs e)
        {
            if (calculatePension == null || calculatePension.IsDisposed)
            {
                calculatePension = new CalculatePension(empID);
            }
            DisplayForm(calculatePension);
        }
        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            if (modifyEmployeeHR == null || modifyEmployeeHR.IsDisposed)
            {
                modifyEmployeeHR = new ModifyEmployeeHR(empID);
            }
            DisplayForm(modifyEmployeeHR);
        }
        private void btnSalaryChanges_Click(object sender, EventArgs e)
        {
            if (salaryChangesHR == null || salaryChangesHR.IsDisposed)
            {
                salaryChangesHR = new SalaryChangesHR(empID);
            }
            DisplayForm(salaryChangesHR);
        }
        private void btnProcessPO_Click(object sender, EventArgs e)
        {
            if (processPO == null || processPO.IsDisposed)
            {
                processPO = new ProcessPO();
            }
            DisplayForm(processPO);
        }
        private void btnInquirePayroll_Click(object sender, EventArgs e)
        {
            if (inquirePayroll == null || inquirePayroll.IsDisposed)
            {
                inquirePayroll = new InquirePayroll();
            }
            DisplayForm(inquirePayroll);
        }
        
        


        private Boolean initiatePayroll()
        {
            DateTime today = DateTime.Today;

            DateTime myoriginalDate = DateTime.ParseExact("2018-04-13", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            
            if (today.DayOfWeek == DayOfWeek.Friday)
            {
                while (myoriginalDate < today)
                {
                    myoriginalDate = myoriginalDate.AddDays(14);
                    
                    if((today.Day == myoriginalDate.Day && today.Month == myoriginalDate.Month && today.Year == myoriginalDate.Year))
                    {
                        if (!CUDMethods.HasCalculatePayrollBeenRun())
                        {
                            ConfirmCalculaltePayroll confirmCalculaltePayroll = new ConfirmCalculaltePayroll();
                            confirmCalculaltePayroll.ShowDialog();

                            if (confirmCalculaltePayroll.DialogResult != System.Windows.Forms.DialogResult.OK)
                            {
                                this.Close();
                            }
                            else
                            {
                                
                                if (calculatePayroll == null || calculatePayroll.IsDisposed)
                                {
                                    calculatePayroll = new CalculatePayroll();
                                    DisplayForm(calculatePayroll);
                                }
                            }
                        }
                    }
                }
            }
            
            return false;
        }
    }
}
