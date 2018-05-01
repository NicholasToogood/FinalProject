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
        SearchRetrieveEmployeeHR searchEmp;
        CostOfLivingIncreaseHR costOfLiving;
        CalculatePayroll calculatePayroll;

        public Main()
        {
            InitializeComponent();

        }
        private void Main_Load(object sender, EventArgs e)
        {
            initiatePayroll();

            // REMOVE
            //if (calculatePayroll == null || calculatePayroll.IsDisposed)
            //{
            //    calculatePayroll = new CalculatePayroll();
            //    DisplayForm(calculatePayroll);
            //}
            //
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

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            if (searchEmp == null || searchEmp.IsDisposed)
            {
                searchEmp = new SearchRetrieveEmployeeHR();
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
                            DialogResult dialogResult = MessageBox.Show("Want to head to the CalculatePayroll section?", "Today is PayDay!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (calculatePayroll == null || calculatePayroll.IsDisposed)
                                {
                                    calculatePayroll = new CalculatePayroll();
                                    DisplayForm(calculatePayroll);
                                }
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }


            return false;
        }

    }
}
