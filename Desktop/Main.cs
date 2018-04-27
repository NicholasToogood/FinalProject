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
        CreateEmployeeHR createEmployee;
        SearchRetrieveEmployeeHR searchEmp;
        CostOfLivingIncreaseHR costOfLiving;

        public Main()
        {
            InitializeComponent();
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
            createPO = new CreatePO();
            DisplayForm(createPO);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            createEmployee = new CreateEmployeeHR();
            DisplayForm(createEmployee);
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            searchEmp = new SearchRetrieveEmployeeHR();
            DisplayForm(searchEmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            costOfLiving = new CostOfLivingIncreaseHR();
            DisplayForm(costOfLiving);
        }
    }
}
