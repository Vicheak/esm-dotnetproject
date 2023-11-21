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
    public partial class FrmChooseEmployeeToGetSlip : Form
    {
        public FrmChooseEmployeeToGetSlip()
        {
            InitializeComponent();
        }

        private void FrmChooseEmployeeToGetSlip_Load(object sender, EventArgs e)
        { 
            FillDepartment();

            //load all row from view salary payment detail
            this.vSalaryPaymentDetailTableAdapter.Fill(this.employeeSalaryMGDataSet.VSalaryPaymentDetail);
        }

        private void FillDepartment()
        {
            this.departmentsTableAdapter.Fill(this.employeeSalaryMGDataSet.Departments);

            //add one more row to department binding source
            var newDepartmentRow = this.employeeSalaryMGDataSet.Departments.NewDepartmentsRow(); 
            newDepartmentRow.Name = "All Departments";
            newDepartmentRow.DepartmentId = -1; //avoid unique constraint violation of the primary key
            newDepartmentRow.Description = "All Departments Description"; 

            //add to the first position of department data table
            this.employeeSalaryMGDataSet.Departments.Rows.InsertAt(newDepartmentRow, 0);

            //set default combo box of first selection
            cbDepartment.SelectedIndex = 0; 
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedValue == null) return;

            if (cbDepartment.SelectedIndex == 0)
            {
                //load all employees from data set
                this.employeesTableAdapter.Fill(this.employeeSalaryMGDataSet.Employees);
            }
            else
            { 
                //filter employee via department id
                this.employeesTableAdapter.FillByDepartmentId(this.employeeSalaryMGDataSet.Employees,
                    (int)cbDepartment.SelectedValue);
            }
        }

        private void employeesDataGridView_Paint(object sender, PaintEventArgs e)
        {
            if (employeesDataGridView.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "គ្មានទិន្នន័យ",
                    employeesDataGridView.Font,
                    employeesDataGridView.ClientRectangle,
                    employeesDataGridView.ForeColor,
                    employeesDataGridView.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnGenerateSlip_Click(object sender, EventArgs e)
        {
            FrmGenerateSlip frmGenerateSlip = new FrmGenerateSlip();
            frmGenerateSlip.employeesRow = GetCurrentEmployee();
            
            frmGenerateSlip.ShowDialog();

            //merge data row from form generate slip 
            if(frmGenerateSlip.DialogResult == DialogResult.OK)
            {
                var salaryPaymentDataTableToMerge = 
                    this.vSalaryPaymentDetailTableAdapter.GetDataBySalaryPaymentId(frmGenerateSlip.salaryPaymentRow.SalaryPaymentId);

                //merge from database into data set
                this.employeeSalaryMGDataSet.VSalaryPaymentDetail.Merge(salaryPaymentDataTableToMerge); 
            }
        }

        private EmployeeSalaryMGDataSet.EmployeesRow GetCurrentEmployee()
        {
            //access current data row from employee binding source
            try 
            { 
                var currentRow = this.employeesBindingSource.Current as DataRowView;
                if (currentRow == null) return null; 
                return currentRow.Row as EmployeeSalaryMGDataSet.EmployeesRow; 
            }catch(NullReferenceException ex)
            {
                return null; 
            }
        }
    }
}
