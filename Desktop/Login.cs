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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public int empID { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool fields = true;
                errorProvider1.Clear();
                if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    errorProvider1.SetError(txtPassword, "Please enter your password.");
                    fields = false;
                }
                if (String.IsNullOrEmpty(txtEmpID.Text.Trim()))
                {
                    errorProvider1.SetError(txtEmpID, "Please enter your username.");
                    fields = false;
                }
                else if (!BusinessLayer.Validate.IsValidEmployeeID(txtEmpID.Text))
                {
                    errorProvider1.SetError(txtEmpID, "Incorrect Username.");
                    fields = false;
                }
                if (fields)
                {
                    if (EmployeeFactory.AuthenticateEmployee(Convert.ToInt32(txtEmpID.Text), txtPassword.Text))
                    {
                        //AuthenticationLvl = Convert.ToInt32(txtUserName.Text);
                        empID = Convert.ToInt32(txtEmpID.Text);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee ID or Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
