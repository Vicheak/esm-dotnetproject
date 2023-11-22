using EmployeeSalaryMGProj.SalaryPayments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMGProj
{
    public partial class FrmHome : Form
    {
        public FrmEmployee frmEmployee;
        public FrmAddOrModifyEmployee frmAddOrModifyEmployee;
        public FrmChooseEmployeeToGetSlip frmChooseEmployeeToGetSlip;
        public FrmDepartment frmDepartment;
        public FrmGrossSalary frmGrossSalary;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            btnShowFrmEmployee.PerformClick(); 
        }

        private void btnShowFrmEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee = new FrmEmployee();

            PopUpForm(frmEmployee);
        }

        private void PopUpForm(Form form)
        {
            form.TopLevel = false; 
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;    

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(form);

            form.Show(); 
        }

        private void btnShowFrmAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddOrModifyEmployee = new FrmAddOrModifyEmployee() { isAdded = true };

            frmAddOrModifyEmployee.ShowDialog(); 
        }

        private void btnShowFrmSalaryPayment_Click(object sender, EventArgs e)
        {
            frmChooseEmployeeToGetSlip = new FrmChooseEmployeeToGetSlip();

            PopUpForm(frmChooseEmployeeToGetSlip); 
        }

        private void btnShowFrmDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment = new FrmDepartment();

            PopUpForm(frmDepartment); 
        }

        private void btnShowFrmGrossSalary_Click(object sender, EventArgs e)
        {
            frmGrossSalary = new FrmGrossSalary();

            PopUpForm(frmGrossSalary);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
