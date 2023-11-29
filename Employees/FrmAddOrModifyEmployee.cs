using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalaryMGProj.Utility;

namespace EmployeeSalaryMGProj
{
    public partial class FrmAddOrModifyEmployee : Form
    {
        public bool isAdded { get; set; }

        public EmployeeSalaryMGDataSet.EmployeesRow employeesRow { get; set; }

        public EmployeeSalaryMGDataSet.BaseSalaryLogsRow baseSalaryLogsRow { get; set; }

        public FrmAddOrModifyEmployee()
        {
            InitializeComponent();
        }

        private void FrmAddOrModifyEmployee_Load(object sender, EventArgs e)
        {
            this.TopMost = true; 

            this.departmentsTableAdapter.Fill(this.employeeSalaryMGDataSet.Departments);

            if (isAdded)
            {
                employeeIdTextBox.Text = "លេខកូដបង្កើតដោយស្វ័យប្រវត្តិ";

                genderComboBox.SelectedIndex = 0; 

                employeesRow = this.employeeSalaryMGDataSet.Employees.NewEmployeesRow();
            }
            else
            {
                lblTitle.Text = "កែប្រែព័ត៌មានបុគ្គលិក";

                this.employeeSalaryMGDataSet.Employees.ImportRow(employeesRow);

                //bind column id
                employeeIdTextBox.DataBindings.Add("Text", employeesBindingSource, "EmployeeId"); 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check all required data from user before save to the database
            if (CheckUtil.CheckValidInput(firstNameTextBox, "First name") &&
                CheckUtil.CheckValidInput(lastNameTextBox, "Last name") &&
                CheckUtil.CheckValidInput(baseSalaryTextBox, "Base salary"))
            {
                //set all data into new employee row
                SetEmployeesRow(employeesRow);

                if (isAdded)
                {
                    if (this.baseSalaryLogsRow != null)
                    {
                        //add one row to data set
                        this.employeeSalaryMGDataSet.Employees.AddEmployeesRow(employeesRow);

                        //Console.WriteLine(employeesRow.RowState);

                        //save data to the database 
                        employeesTableAdapter.Update(employeesRow);

                        //save base salary history (attach with employee id)
                        this.baseSalaryLogsRow.EmployeeId = employeesRow.EmployeeId;
                        this.baseSalaryLogsTableAdapter.Update(this.baseSalaryLogsRow);

                        //close the form itself
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Please define base salary for employee!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //update employee row 
                    //Console.WriteLine(employeesRow.RowState);

                    //save data to the database 
                    employeesTableAdapter.Update(employeesRow);

                    //check if the user does not update base salary while updating employee row
                    if (this.baseSalaryLogsRow != null)
                    {
                        //save base salary history (attach with employee id)
                        this.baseSalaryLogsRow.EmployeeId = employeesRow.EmployeeId;
                        this.baseSalaryLogsTableAdapter.Update(this.baseSalaryLogsRow);
                    }

                    //close the form itself
                    this.DialogResult = DialogResult.OK; 
                }
            }
        }

        private void SetEmployeesRow(EmployeeSalaryMGDataSet.EmployeesRow employeesRow)
        {
            if(employeesRow != null)
            {
                employeesRow.FirstName = firstNameTextBox.Text;
                employeesRow.LastName = lastNameTextBox.Text;
                employeesRow.Gender = genderComboBox.Text;
                employeesRow.BirthDate = birthDateDateTimePicker.Value;
                employeesRow.BaseSalary = decimal.Parse(baseSalaryTextBox.Text);
                employeesRow.DepartmentId = (int)departmentIdComboBox.SelectedValue;
                employeesRow.Active = activeCheckBox.Checked;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateBaseSalary_Click(object sender, EventArgs e)
        {
            if (CheckUtil.CheckValidInput(firstNameTextBox, "First name") &&
                CheckUtil.CheckValidInput(lastNameTextBox, "Last name") &&
                CheckUtil.CheckValidInput(baseSalaryTextBox, "Base salary"))
            {
                FrmUpdateBaseSalary frmUpdateBaseSalary = new FrmUpdateBaseSalary
                {
                    employeeName = $"{firstNameTextBox.Text} {lastNameTextBox.Text}",
                    baseSalary = Convert.ToDecimal(baseSalaryTextBox.Text)
                }; 

                frmUpdateBaseSalary.ShowDialog();

                if(frmUpdateBaseSalary.DialogResult == DialogResult.OK) 
                {
                    //copy reference from update base salary form
                    this.baseSalaryLogsRow = frmUpdateBaseSalary.baseSalaryLogsRow;
                    baseSalaryTextBox.Text = this.baseSalaryLogsRow.Amount.ToString(); 
                }
            }
        }
    }
}
