using EmployeeSalaryMGProj.Employees;
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
    public partial class FrmEmployee : Form
    {
        public EmployeeSalaryMGDataSet.UsersRow usersRow { get; set; }

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        { 
            this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees);

            if(usersRow.RoleId == 2) //accountant
            {
                btnAddNew.Visible = false;
                employeesDataGridView.Columns[8].Visible = false; 
                employeesDataGridView.Columns[10].Visible = false; 
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyEmployee frmAddOrModify = new FrmAddOrModifyEmployee();
            frmAddOrModify.isAdded = true; 

            frmAddOrModify.ShowDialog(); 

            if (frmAddOrModify.DialogResult == DialogResult.OK) 
            {
                //import row from different data set
                this.employeeSalaryMGDataSet.Employees.ImportRow(frmAddOrModify.employeesRow); 
            }
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Column Index = 8
            //Any Row except Row Index = -1 (header)
            if (e.RowIndex == -1) return; 
            if (e.ColumnIndex == 8)
            {
                FrmAddOrModifyEmployee frmAddOrModifyEmployee = new FrmAddOrModifyEmployee();
                frmAddOrModifyEmployee.isAdded = false;

                //access employee current row
                var currentEmployeeRow = this.employeesBindingSource.Current as DataRowView; 
                if (currentEmployeeRow != null)
                {
                    var employeesRow = currentEmployeeRow.Row as EmployeeSalaryMGDataSet.EmployeesRow;
                    frmAddOrModifyEmployee.employeesRow = employeesRow; 
                }

                frmAddOrModifyEmployee.ShowDialog(); 
            }

            if (e.ColumnIndex == 9)
            {
                FrmEmployeeDetail frmEmployeeDetail = new FrmEmployeeDetail();

                //access employee current row
                var currentEmployeeRow = this.employeesBindingSource.Current as DataRowView;
                if (currentEmployeeRow != null)
                {
                    var employeesRow = currentEmployeeRow.Row as EmployeeSalaryMGDataSet.EmployeesRow;
                    frmEmployeeDetail.employeesRow = employeesRow;
                }

                frmEmployeeDetail.ShowDialog(); 
            }

            if (e.ColumnIndex == 10)
            {
                //access employee current row
                var currentEmployeeRow = this.employeesBindingSource.Current as DataRowView;
                if (currentEmployeeRow != null)
                {
                    var employeesRow = currentEmployeeRow.Row as EmployeeSalaryMGDataSet.EmployeesRow;

                    var result = MessageBox.Show($"Are you sure you want to remove employee with name {employeesRow.FirstName} {employeesRow.LastName}," +
                        $" this record will effect all records in the system?", 
                        "Confirmation", 
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question); 

                    if(result == DialogResult.OK)
                    {
                        //remove records from base salary log
                        this.baseSalaryLogsTableAdapter.DeleteByEmployeeId(employeesRow.EmployeeId);

                        //access rows from table salary payment
                        var salaryPaymentDataTable = this.salaryPaymentsTableAdapter.GetDataByEmployeeId(employeesRow.EmployeeId);

                        //remove records from salary payment gross 
                        foreach (var salaryPaymentRow in salaryPaymentDataTable)
                        {
                            this.salaryPaymentGrossTableAdapter.DeleteBySalaryPaymentId(salaryPaymentRow.SalaryPaymentId); 
                        }

                        //remove records from salary payment
                        this.salaryPaymentsTableAdapter.DeleteByEmployeeId(employeesRow.EmployeeId);

                        //remove employee record from binding source
                        employeesRow.Delete();

                        //update into the database
                        this.employeesTableAdapter.Update(this.employeeSalaryMGDataSet.Employees); 
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim())) return;

            this.employeesTableAdapter.SearchEmployees(this.employeeSalaryMGDataSet.Employees, txtSearch.Text);

            //clear text after search
            txtSearch.Clear(); 
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick(); 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees); 
        }

        private void employeesDataGridView_Paint(object sender, PaintEventArgs e)
        {
            if (employeesDataGridView.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "រកមិនឃើញទិន្នន័យ",
                    employeesDataGridView.Font,
                    employeesDataGridView.ClientRectangle,
                    employeesDataGridView.ForeColor,
                    employeesDataGridView.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmPreviewEmployeeList frmPreviewEmployeeList = new FrmPreviewEmployeeList(); 
            
            frmPreviewEmployeeList.ShowDialog(); 
        }
    }
}
