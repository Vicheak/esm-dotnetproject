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
    public partial class FrmUpdateBaseSalary : Form
    {
        public string employeeName
        {
            set => txtEmployeeName.Text = value;
        }

        public decimal baseSalary
        {
            get => Convert.ToDecimal(txtBaseSalary.Text);
            set
            {
                txtBaseSalary.Text = value.ToString();
                amountTextBox.Text = value.ToString();
            }
        }

        public EmployeeSalaryMGDataSet.BaseSalaryLogsRow baseSalaryLogsRow { get; set; }

        public FrmUpdateBaseSalary()
        {
            InitializeComponent();
        }

        private void FrmUpdateBaseSalary_Load(object sender, EventArgs e)
        {
            this.TopMost = true; 

            baseSalaryLogsRow = this.employeeSalaryMGDataSet.BaseSalaryLogs.NewBaseSalaryLogsRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckUtil.CheckValidInput(amountTextBox, "Amount") &&
                CheckUtil.CheckValidInput(descriptionTextBox, "Description"))
            { 
                SetBaseSalaryLogsRow(baseSalaryLogsRow);
            }
        }

        private void SetBaseSalaryLogsRow(EmployeeSalaryMGDataSet.BaseSalaryLogsRow baseSalaryLogsRow)
        {
            if(baseSalaryLogsRow != null)
            {
                baseSalaryLogsRow.Date = dateDateTimePicker.Value;

                try
                {
                    baseSalaryLogsRow.Amount = Convert.ToDecimal(amountTextBox.Text);
                }catch(FormatException ex)
                {
                    MessageBox.Show("The input is not in correct format!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    amountTextBox.Text = baseSalary.ToString();
                    amountTextBox.Focus();
                    return; 
                }

                baseSalaryLogsRow.Description = descriptionTextBox.Text;

                //prevent null value adding to data set
                baseSalaryLogsRow.EmployeeId = -1;

                //add new row to data set
                this.employeeSalaryMGDataSet.BaseSalaryLogs.AddBaseSalaryLogsRow(baseSalaryLogsRow); 

                //close the form itself
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
