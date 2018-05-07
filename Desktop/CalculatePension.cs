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
    public partial class CalculatePension : Form
    {
        public CalculatePension()
        {
            InitializeComponent();
        }

        private void CalculatePension_Load(object sender, EventArgs e)
        {
            int EmpID = 10000001;

            fillInformation(EmpID);
        }

        private void fillInformation(int EmpID)
        {
            List<Employee> emp = EmployeeFactory.RetrieveEmployeesByID(EmpID);

            txtEmployeeID.Text = emp[0].EmpID.ToString();
            txtFirstName.Text = emp[0].FirstName;
            txtMiddleInitial.Text = emp[0].MiddleInitial;
            txtLastName.Text = emp[0].LastName;
            dtpDateOfBirth.Value = emp[0].DateOfBirth;
            dtpSeniorityDate.Value = emp[0].HireDate;

            var today = DateTime.Today;
            var yearsOfWork = today.Year - emp[0].HireDate.Year;
            if (emp[0].HireDate > today.AddYears(-yearsOfWork)) yearsOfWork--;

            if(yearsOfWork < 5)
            {
                grpboxPension.Visible = false;
                grpBoxPensions.Visible = false;
                grpBoxWoops.Visible = true;
            }
            else
            {
                grpboxPension.Visible = true;
                grpBoxPensions.Visible = true;
                grpBoxWoops.Visible = false;

                fillEmployeePensions(emp[0]);
            }
        }
        
        private void fillEmployeePensions(Employee emp)
        {
            try
            {
                Double pensionAmt = EmployeeFactory.RetrieveEmployeePossiblePension(emp.EmpID);

                txtFullPension.Text = pensionAmt.ToString("c");
                dtpFullPensionDate.Value = emp.DateOfBirth.AddYears(60);
                
                var today = DateTime.Today;
                var age = today.Year - emp.DateOfBirth.Year;
                if (emp.DateOfBirth > today.AddYears(-age)) age--;

                if(age <= 55)
                {
                    txtPension55.Text = (pensionAmt * 0.97 * 0.97 * 0.97 * 0.97 * 0.97).ToString("c");
                    txtPension55.Visible = true;
                    lblPension55.Visible = true;
                }
                if(age <= 56)
                {
                    txtPension56.Text = (pensionAmt * 0.97 * 0.97 * 0.97 * 0.97).ToString("c");
                    txtPension56.Visible = true;
                    lblPension56.Visible = true;
                }
                if(age <= 57)
                {
                    txtPension57.Text = (pensionAmt * 0.97 * 0.97 * 0.97).ToString("c");
                    txtPension57.Visible = true;
                    lblPension57.Visible = true;
                }
                if(age <= 58)
                {
                    txtPension58.Text = (pensionAmt * 0.97 * 0.97).ToString("c");
                    txtPension58.Visible = true;
                    lblPension58.Visible = true;
                }
                if(age <= 59)
                {
                    txtPension59.Text = (pensionAmt * 0.97).ToString("c");
                    txtPension59.Visible = true;
                    lblPension59.Visible = true;
                }
                if (age <= 60)
                {
                    txtPension60.Text = pensionAmt.ToString("c");
                    txtPension60.Visible = true;
                    lblPension60.Visible = true;
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
