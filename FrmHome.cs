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
        public Users.FrmUser frmUser;
        public Users.FrmLogin frmLogin = new Users.FrmLogin(); 

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Login(); 
        }

        private void Login()
        {
            //open login windows before main view
            frmLogin.ShowDialog();

            if (frmLogin.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
            else if (frmLogin.DialogResult == DialogResult.OK)
            {
                if (frmLogin.userRow.RoleId == 1) //admin
                {
                    btnShowFrmAddNewEmployee.Visible = true;
                    btnShowFrmUser.Visible = true; 
                }
                else if (frmLogin.userRow.RoleId == 2) //accountant
                {
                    btnShowFrmAddNewEmployee.Visible = false;
                    btnShowFrmUser.Visible = false;
                }

                //load the control screen buttons
                if (this.TopMost == false)
                {
                    btnGoFullScreen.Visible = true;
                    btnGoNormalScreen.Visible = false;
                    btnCloseScreen.Visible = false; 
                }

                //open the main form by auto clicked button
                //btnShowFrmEmployee.PerformClick();
                PopUpForm(new FrmEmployee() { usersRow = frmLogin.userRow });
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            //hide home form
            this.Visible = false;

            //clear all login fields after logout 
            frmLogin.usernameTextBox.Clear(); 
            frmLogin.passwordTextBox.Clear();

            Login();

            //show home form back after a successfull login
            if(!this.IsDisposed)
                this.Visible = true; 
        }

        private void btnShowFrmEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee = new FrmEmployee() { usersRow = frmLogin.userRow };

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
            frmDepartment = new FrmDepartment() { usersRow = frmLogin.userRow };

            PopUpForm(frmDepartment); 
        }

        private void btnShowFrmGrossSalary_Click(object sender, EventArgs e)
        {
            frmGrossSalary = new FrmGrossSalary() { userRow = frmLogin.userRow };

            PopUpForm(frmGrossSalary);
        }

        private void btnShowFrmUser_Click(object sender, EventArgs e)
        {
            frmUser = new Users.FrmUser();

            PopUpForm(frmUser);
        }

        private void btnCloseScreen_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnGoNormalScreen_Click(object sender, EventArgs e)
        {
            //go normal screen 
            this.TopMost = false; //no overlaping
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;

            //control the visibility
            btnGoFullScreen.Visible = true;
            btnGoNormalScreen.Visible = false;
            btnCloseScreen.Visible = false;
        }

        private void btnGoFullScreen_Click(object sender, EventArgs e)
        {
            //go full screen
            this.TopMost = true; //overlap all forms
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //control the visibility
            btnGoFullScreen.Visible = false;
            btnGoNormalScreen.Visible = true;
            btnCloseScreen.Visible = true;
        }

        private void lblAppHome_Click(object sender, EventArgs e)
        {
            btnShowFrmEmployee.PerformClick();    
        }
    }
}
