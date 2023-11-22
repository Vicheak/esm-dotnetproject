using EmployeeSalaryMGProj.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMGProj.SalaryPayments
{
    public partial class FrmGrossSalary : Form
    {
        private bool isValidAmount = false;

        public EmployeeSalaryMGDataSet.UsersRow userRow { get; set; }

        public FrmGrossSalary()
        {
            InitializeComponent();
        }

        private void FrmGrossSalary_Load(object sender, EventArgs e)
        { 
            this.grossTypesTableAdapter.Fill(this.employeeSalaryMGDataSet.GrossTypes);
            this.grossSalariesTableAdapter.Fill(this.employeeSalaryMGDataSet.GrossSalaries);

            lblShowError.Text = string.Empty; 

            if (userRow.RoleId == 2) //accountant
            {
                btnAddNew.Visible = false;
                btnSave.Visible = false; 
                btnCancel.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountTextBox.Text.Trim()) || isValidAmount)
            {
                try
                {
                    //access the current row 
                    var currentRow = this.grossSalariesBindingSource.Current as DataRowView;
                    if (currentRow != null)
                    {
                        //validate if the user does not save the data
                        var grossSalaryRow = currentRow.Row as EmployeeSalaryMGDataSet.GrossSalariesRow;
                        if (grossSalaryRow.GrossSalaryId < 0) //generated marked value is always negative
                        {
                            MessageBox.Show("Please fill in the gross salary information and save into the system!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    this.grossSalariesBindingSource.AddNew();

                    //set default value for combo box
                    grossTypeIdComboBox.SelectedValue = 1;
                }
                catch (NoNullAllowedException ex)
                {
                    MessageBox.Show("Please fill in the important information!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidAmount)
            {
                if (CheckUtil.CheckValidInput(nameTextBox, "gross salary name"))
                {
                    //save to data set
                    this.grossSalariesBindingSource.EndEdit();

                    try
                    {
                        //save to data source
                        this.grossSalariesTableAdapter.Update(this.employeeSalaryMGDataSet.GrossSalaries);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("There might be some problems due to the input! try changing...", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void grossSalariesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please fill in the gross salary information!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountTextBox.Text.Trim()) || isValidAmount)
            {
                //reject all changes
                this.grossSalariesBindingSource.CancelEdit();

                this.employeeSalaryMGDataSet.GrossSalaries.RejectChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountTextBox.Text.Trim()) || isValidAmount)
            {
                try
                {
                    //access the current row 
                    var currentRow = this.grossSalariesBindingSource.Current as DataRowView;
                    if (currentRow != null)
                    {
                        //check confirmation from user to delete specific row 
                        var grossSalaryRow = currentRow.Row as EmployeeSalaryMGDataSet.GrossSalariesRow;

                        DialogResult result = MessageBox.Show($"Are you sure to remove gross salary {grossSalaryRow.Name}?", "Confirmation",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            //remove row from binding source
                            this.grossSalariesBindingSource.RemoveCurrent();

                            //update to the database
                            this.grossSalariesTableAdapter.Update(this.employeeSalaryMGDataSet.GrossSalaries);
                        }
                    }
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Please fill in the gross salary information and save into the system before you remove any!", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(amountTextBox.Text, out decimal validAmount) == false)
            {
                lblShowError.Text = "សូមវាយបញ្ចូលជាតម្លៃទឹកប្រាក់";
                isValidAmount = false; 
            }
            else
            {
                lblShowError.Text = string.Empty;
                isValidAmount = true; 
            }
        }
    }
}
