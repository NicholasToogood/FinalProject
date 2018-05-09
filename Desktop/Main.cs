using BusinessLayer;
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

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            initiatePayroll();
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
                DisplayForm(createPO);
            } 
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (createEmployee == null || createEmployee.IsDisposed)
            {
                createEmployee = new CreateEmployeeHR();
                DisplayForm(createEmployee);
            }   
        }

        private void btnSickDays_Click(object sender, EventArgs e)
        {
            if (searchEmp == null || searchEmp.IsDisposed)
            {
                searchEmp = new AddSickDayHR();
                DisplayForm(searchEmp);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (costOfLiving == null || costOfLiving.IsDisposed)
            {
                costOfLiving = new CostOfLivingIncreaseHR();
                DisplayForm(costOfLiving);
            }
        }

        private void btnModPO_Click(object sender, EventArgs e)
        {
            if (modifyPO == null || modifyPO.IsDisposed)
            {
                modifyPO = new ModifyPO();
                DisplayForm(modifyPO);
            } 
        }

        private void btnCalculatePension_Click(object sender, EventArgs e)
        {
            if (calculatePension == null || calculatePension.IsDisposed)
            {
                calculatePension = new CalculatePension();
                DisplayForm(calculatePension);
            }
        }
        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            if (modifyEmployeeHR == null || modifyEmployeeHR.IsDisposed)
            {
                modifyEmployeeHR = new ModifyEmployeeHR();
                DisplayForm(modifyEmployeeHR);
            }
        }
        private void btnSalaryChanges_Click(object sender, EventArgs e)
        {
            if (salaryChangesHR == null || salaryChangesHR.IsDisposed)
            {
                salaryChangesHR = new SalaryChangesHR();
                DisplayForm(salaryChangesHR);
            }
        }


        private Boolean initiatePayroll()
        {
            DateTime today = DateTime.Today;

            DateTime myoriginalDate = DateTime.ParseExact("2018-04-13", "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);

            

            


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

        private void btnProcessPO_Click(object sender, EventArgs e)
        {
            if (processPO == null || processPO.IsDisposed)
            {
                processPO = new ProcessPO();
                DisplayForm(processPO);
            }
        }

    }
}
