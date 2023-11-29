using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMGProj.SalaryPayments
{
    public partial class FrmGenerateSlip : Form
    {
        public EmployeeSalaryMGDataSet.EmployeesRow employeesRow { get; set; }

        //create temporary data table for Salary Gross Table
        public EmployeeSalaryMGDataSet.GrossSalariesDataTable tempBenefitGrossSalaryDataTable =
            new EmployeeSalaryMGDataSet.GrossSalariesDataTable();

        public EmployeeSalaryMGDataSet.GrossSalariesDataTable tempDeductionGrossSalaryDataTable =
            new EmployeeSalaryMGDataSet.GrossSalariesDataTable();

        //create salary payment row for filter in form choose employee to get slip 
        public EmployeeSalaryMGDataSet.SalaryPaymentsRow salaryPaymentRow; 

        public FrmGenerateSlip()
        {
            InitializeComponent();
        }

        private void FrmGenerateSlip_Load(object sender, EventArgs e)
        {
            this.TopMost = true; 

            this.monthsTableAdapter.Fill(this.employeeSalaryMGDataSet.Months);
            if (employeesRow == null)
            {
                MessageBox.Show("Employee is empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //close form and try again
                this.DialogResult = DialogResult.Retry;
                return; 
            }

            this.employeeSalaryMGDataSet.Employees.ImportRow(employeesRow);

            //show data from the current row -> employee row
            txtEmployeeName.Text = $"{employeesRow.FirstName} {employeesRow.LastName}";
            //format base salary
            decimal baseSalary = decimal.Parse(baseSalaryTextBox.Text);
            baseSalaryTextBox.Text = baseSalary.ToString("C4");
            txtDepartment.Text = employeesRow.DepartmentsRow.Name;

            //fill all view to combo box
            this.vSalaryDeductionTableAdapter.Fill(this.employeeSalaryMGDataSet.VSalaryDeduction);

            this.vSalaryBenefitTableAdapter.Fill(this.employeeSalaryMGDataSet.VSalaryBenefit);

            //set default value for combo box (month and year)
            var now = DateTime.Now;
            var lastMonthDate = now.AddMonths(-1);

            cbMonth.SelectedValue = lastMonthDate.Month;
            cbYear.Text = lastMonthDate.Year.ToString(); 
        }

        private void btnAddBenefit_Click(object sender, EventArgs e)
        {
            if (cbChooseBenefit.Items.Count > 0)
            {
                var benefitItem = cbChooseBenefit.SelectedItem as DataRowView;
                //Console.WriteLine(benefitItem);
                var vSalaryBenefit = benefitItem.Row as EmployeeSalaryMGDataSet.VSalaryBenefitRow;

                var grossSalaryRow = tempBenefitGrossSalaryDataTable.NewGrossSalariesRow();

                //copy signature from view to table object
                grossSalaryRow.ItemArray = vSalaryBenefit.ItemArray;

                //add gross salary row to temporary data table
                tempBenefitGrossSalaryDataTable.AddGrossSalariesRow(grossSalaryRow);

                UserControlSalaryGross userControlSalaryGross = new UserControlSalaryGross(grossSalaryRow);
                userControlSalaryGross.btnClose.Click += btnRemoveBenefit;

                //add user control to flow layout panel
                benefitflowLayoutPanel.Controls.Add(userControlSalaryGross);

                //remove benefit item from vSalaryBenefit binding source
                benefitItem.Delete();

                //Console.WriteLine(tempGrossSalaryDataTable.Rows); 
            }
        }

        private void btnRemoveBenefit(object sender, EventArgs e)
        {
            //access to the parent of button control
            Button control = (Button)sender;
            UserControlSalaryGross userControl = control.Parent as UserControlSalaryGross;

            //reverse data back to combo box of view object
            var vSalaryBenefitRow = this.employeeSalaryMGDataSet.VSalaryBenefit.NewVSalaryBenefitRow(); 

            var grossSalaryRow = userControl.grossSalariesRow;
            vSalaryBenefitRow.ItemArray = grossSalaryRow.ItemArray;

            this.employeeSalaryMGDataSet.VSalaryBenefit.AddVSalaryBenefitRow(vSalaryBenefitRow);

            //set focus to combo box
            cbChooseBenefit.SelectedValue = vSalaryBenefitRow.GrossSalaryId;
            cbChooseBenefit.Focus(); 

            //remove gross salary from temporary data table
            userControl.grossSalariesRow.Delete(); 

            //remove user control from flow layout panel
            benefitflowLayoutPanel.Controls.Remove(userControl); 
        }

        private void btnAddDeduction_Click(object sender, EventArgs e)
        {
            if (cbChooseDeduction.Items.Count > 0)
            {
                var deductionItem = cbChooseDeduction.SelectedItem as DataRowView;
                var vSalaryDeduction = deductionItem.Row as EmployeeSalaryMGDataSet.VSalaryDeductionRow; 

                var grossSalaryRow = tempDeductionGrossSalaryDataTable.NewGrossSalariesRow();

                //copy signature from view to table object
                grossSalaryRow.ItemArray = vSalaryDeduction.ItemArray;

                //add gross salary row to temporary data table
                tempDeductionGrossSalaryDataTable.AddGrossSalariesRow(grossSalaryRow);

                UserControlSalaryGross userControlSalaryGross = new UserControlSalaryGross(grossSalaryRow);
                userControlSalaryGross.btnClose.Click += btnRemoveDeduction; 

                //add user control to flow layout panel
                deductionflowLayoutPanel.Controls.Add(userControlSalaryGross);

                //remove deduction item from vSalaryDeduction binding source
                deductionItem.Delete();
            }
        }

        private void btnRemoveDeduction(object sender, EventArgs e)
        {
            //access to the parent of button control
            Button control = (Button)sender;
            UserControlSalaryGross userControl = control.Parent as UserControlSalaryGross;

            //reverse data back to combo box of view object
            var vSalaryDeductionRow = this.employeeSalaryMGDataSet.VSalaryDeduction.NewVSalaryDeductionRow(); 

            var grossSalaryRow = userControl.grossSalariesRow;
            vSalaryDeductionRow.ItemArray = grossSalaryRow.ItemArray;

            this.employeeSalaryMGDataSet.VSalaryDeduction.AddVSalaryDeductionRow(vSalaryDeductionRow); 

            //set focus to combo box
            cbChooseDeduction.SelectedValue = vSalaryDeductionRow.GrossSalaryId;
            cbChooseDeduction.Focus();

            //remove gross salary from temporary data table
            userControl.grossSalariesRow.Delete();

            //remove user control from flow layout panel
            deductionflowLayoutPanel.Controls.Remove(userControl);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //create new row for salary payment and assign value to required fields
            salaryPaymentRow = this.employeeSalaryMGDataSet.SalaryPayments.NewSalaryPaymentsRow();
            salaryPaymentRow.ItemArray = new object[]
            {
                -1, 
               dateTimePickerGeneratedSlip.Value, 
               employeesRow.BaseSalary,
               (int)cbMonth.SelectedValue,
               Convert.ToInt32(cbYear.Text),
               1, //Unpaid
               DBNull.Value,
               employeesRow.EmployeeId
            };

            //add one salary payment row to data set
            this.employeeSalaryMGDataSet.SalaryPayments.AddSalaryPaymentsRow(salaryPaymentRow);

            //update salary payment row into the database
            this.salaryPaymentsTableAdapter.Update(salaryPaymentRow); 

            //loop via temporary data table
            foreach(var benefit in tempBenefitGrossSalaryDataTable)
            {
                var salaryPaymentGrossRow = this.employeeSalaryMGDataSet.SalaryPaymentGross.NewSalaryPaymentGrossRow();
                salaryPaymentGrossRow.ItemArray = new object[]
                {
                    salaryPaymentRow.SalaryPaymentId,
                    benefit.GrossSalaryId, 
                    benefit.Amount
                };

                this.employeeSalaryMGDataSet.SalaryPaymentGross.AddSalaryPaymentGrossRow(salaryPaymentGrossRow); 
            }

            foreach (var deduction in tempDeductionGrossSalaryDataTable)
            {
                var salaryPaymentGrossRow = this.employeeSalaryMGDataSet.SalaryPaymentGross.NewSalaryPaymentGrossRow();
                salaryPaymentGrossRow.ItemArray = new object[]
                {
                    salaryPaymentRow.SalaryPaymentId,
                    deduction.GrossSalaryId,
                    deduction.Amount
                };

                this.employeeSalaryMGDataSet.SalaryPaymentGross.AddSalaryPaymentGrossRow(salaryPaymentGrossRow);
            }

            //update all salary payment gross rows into the database 
            this.salaryPaymentGrossTableAdapter.Update(this.employeeSalaryMGDataSet.SalaryPaymentGross); 

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
