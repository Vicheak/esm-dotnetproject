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
using EmployeeSalaryMGProj.Utility; 

namespace EmployeeSalaryMGProj
{
    public partial class FrmDepartment : Form
    {
        public EmployeeSalaryMGDataSet.UsersRow usersRow { get; set; }

        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            this.departmentsTableAdapter.Fill(this.employeeSalaryMGDataSet.Departments);

            lblGeneratedString.Text = string.Empty; 

            if(usersRow.RoleId == 2) //accountant
            {
                btnAddNew.Visible = false; 
                btnSave.Visible = false;
                btnCancel.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                //access the current row 
                var currentDepartmentRow = this.departmentsBindingSource.Current as DataRowView; 
                if(currentDepartmentRow != null)
                {
                    //validate if the user does not save the data
                    var departmentRow = currentDepartmentRow.Row as EmployeeSalaryMGDataSet.DepartmentsRow; 
                    if (departmentRow.DepartmentId < 0) //generated marked value is always negative
                    {
                        MessageBox.Show("Please fill in the department information and save into the system!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                }

                this.departmentsBindingSource.AddNew();

                lblGeneratedString.Text = "លេខកូដបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            catch(NoNullAllowedException ex)
            { 
                MessageBox.Show("Please fill in the important information!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckUtil.CheckValidInput(nameTextBox, "department name") &&
               CheckUtil.CheckValidInput(descriptionTextBox, "department description"))
            {
                //save to data set
                this.departmentsBindingSource.EndEdit();

                try
                {
                    //save to data source
                    this.tableAdapterManager.UpdateAll(this.employeeSalaryMGDataSet);

                    lblGeneratedString.Text = string.Empty;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("There might be some problems due to the input! try changing...", "Warning",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //reject change from binding source
            this.departmentsBindingSource.CancelEdit();

            //reject change from data set
            this.employeeSalaryMGDataSet.Departments.RejectChanges();

            lblGeneratedString.Text = string.Empty;
        }

        private void departmentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please fill in the department information!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);

            lblGeneratedString.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //access the current row 
                var currentDepartmentRow = this.departmentsBindingSource.Current as DataRowView;
                if (currentDepartmentRow != null)
                {
                    //check confirmation from user to delete specific row 
                    var departmentRow = currentDepartmentRow.Row as EmployeeSalaryMGDataSet.DepartmentsRow;

                    DialogResult result = MessageBox.Show($"Are you sure to remove department {departmentRow.Name}?", "Confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        //remove row from binding source
                        this.departmentsBindingSource.RemoveCurrent();

                        //update to the database
                        this.tableAdapterManager.UpdateAll(this.employeeSalaryMGDataSet); 

                        lblGeneratedString.Text = string.Empty;
                    }
                }
            }catch(InvalidCastException ex)
            {
                MessageBox.Show("Please fill in the department information and save into the system before you remove any!", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
