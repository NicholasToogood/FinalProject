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
    public partial class CreateEmployeeHR : Form
    {
        public CreateEmployeeHR()
        {
            InitializeComponent();
        }

        private void CreateEmployeeHR_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String errorMsg = "";
            Boolean isValid = true;


            if (isValid)
            {

                //CUDMethods.CreateEmp(emp);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
