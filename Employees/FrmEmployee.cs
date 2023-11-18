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
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        { 
            this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees);
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
            if(e.ColumnIndex == 8)
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
    }
}
