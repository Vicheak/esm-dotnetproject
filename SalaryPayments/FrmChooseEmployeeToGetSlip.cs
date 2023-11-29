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
            //this.vSalaryPaymentDetailTableAdapter.Fill(this.employeeSalaryMGDataSet.VSalaryPaymentDetail);

            //load top five record from view object
            this.vSalaryPaymentDetailTableAdapter.FillByTopFiveRecord(this.employeeSalaryMGDataSet.VSalaryPaymentDetail);
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

        private void btnSetPaymentStatus_Click(object sender, EventArgs e)
        {
            //set payment status
            var salaryPaymentDetailRow = GetCurrentVSalaryPaymentDetailRow(); 

            if (salaryPaymentDetailRow == null)
            {
                MessageBox.Show("Salary payment detail is empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string message = $"Are you sure to pay for employee {salaryPaymentDetailRow.EmployeeName}?";

            var resultDialog = MessageBox.Show(message, "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 

            if(resultDialog == DialogResult.OK)
            {
                //filter for data table
                var salaryPaymentsDataTableTemp = 
                    this.salaryPaymentsTableAdapter.GetDataBySalaryPaymentId(salaryPaymentDetailRow.SalaryPaymentId);

                //access the first row of data table 
                var salaryPaymentRow = salaryPaymentsDataTableTemp[0];

                //update salary payment row
                salaryPaymentRow.PaymentStateId = 2; //Paid
                salaryPaymentRow.PaymentDate = DateTime.Now;

                //update view object row
                salaryPaymentDetailRow.Status = "Paid";
                salaryPaymentDetailRow.PaymentDate = salaryPaymentRow.PaymentDate; 

                //update into the database
                this.salaryPaymentsTableAdapter.Update(salaryPaymentRow);
            }
        }

        private void btnCancelPaymentStatus_Click(object sender, EventArgs e)
        {
            //set payment 
            var salaryPaymentDetailRow = GetCurrentVSalaryPaymentDetailRow();

            if (salaryPaymentDetailRow == null)
            {
                MessageBox.Show("Salary payment detail is empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = $"Are you sure to cancel payment for employee {salaryPaymentDetailRow.EmployeeName}?";

            var resultDialog = MessageBox.Show(message, "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.OK)
            {
                //filter for data table
                var salaryPaymentsDataTableTemp =
                    this.salaryPaymentsTableAdapter.GetDataBySalaryPaymentId(salaryPaymentDetailRow.SalaryPaymentId);

                //access the first row of data table 
                var salaryPaymentRow = salaryPaymentsDataTableTemp[0];

                //update salary payment row
                salaryPaymentRow.PaymentStateId = 1; //Unpaid

                //update view object row
                salaryPaymentDetailRow.Status = "Unpaid";

                //update into the database
                this.salaryPaymentsTableAdapter.Update(salaryPaymentRow);
            }
        }
        
        private EmployeeSalaryMGDataSet.VSalaryPaymentDetailRow GetCurrentVSalaryPaymentDetailRow()
        {
            //access current data row from employee binding source
            try
            { 
                var currentSalaryPaymentDetailRow = this.vSalaryPaymentDetailBindingSource.Current as DataRowView;
                if (currentSalaryPaymentDetailRow == null) return null; 
                return currentSalaryPaymentDetailRow.Row as EmployeeSalaryMGDataSet.VSalaryPaymentDetailRow;
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
        }

        private void vSalaryPaymentDetaildataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Column Index = 12 (for any row index except row index = -1)
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 12)
            {
                var salaryPaymentDetailRow = GetCurrentVSalaryPaymentDetailRow();

                string message = $"Are you sure to remove payment record from employee {salaryPaymentDetailRow.EmployeeName}?";

                var resultDialog = MessageBox.Show(message, "Confirmation",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultDialog == DialogResult.OK)
                {
                    //delete from bridge entity
                    this.salaryPaymentGrossTableAdapter.DeleteBySalaryPaymentId(salaryPaymentDetailRow.SalaryPaymentId);

                    //delete selected row from salary payment table (selected view row)
                    this.salaryPaymentsTableAdapter.DeleteBySalaryPaymentId(salaryPaymentDetailRow.SalaryPaymentId);

                    //refresh the view
                    //this.vSalaryPaymentDetailTableAdapter.Fill(this.employeeSalaryMGDataSet.VSalaryPaymentDetail);

                    //refresh the view by employee id 
                    this.vSalaryPaymentDetailTableAdapter.FillByEmployeeId(this.employeeSalaryMGDataSet.VSalaryPaymentDetail,
                        salaryPaymentDetailRow.EmployeeId);
                }
            }
        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentEmployeeRow = GetCurrentEmployee(); 

            if(currentEmployeeRow == null)
            {
                MessageBox.Show("Employee record is empty!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //filter view salary payment detail by employee id
            this.vSalaryPaymentDetailTableAdapter.FillByEmployeeId(this.employeeSalaryMGDataSet.VSalaryPaymentDetail,
                currentEmployeeRow.EmployeeId); 
        }

        private void vSalaryPaymentDetaildataGridView_Paint(object sender, PaintEventArgs e)
        {
            if (vSalaryPaymentDetaildataGridView.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "គ្មានប្រវត្តិបើកប្រាក់ខែ",
                    vSalaryPaymentDetaildataGridView.Font,
                    vSalaryPaymentDetaildataGridView.ClientRectangle,
                    vSalaryPaymentDetaildataGridView.ForeColor,
                    vSalaryPaymentDetaildataGridView.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var currentSalaryPaymentDetailRow = this.vSalaryPaymentDetailBindingSource.Current as DataRowView;
            if (currentSalaryPaymentDetailRow == null) return; 
            var vSalaryPaymentDetailRow = currentSalaryPaymentDetailRow.Row as EmployeeSalaryMGDataSet.VSalaryPaymentDetailRow;

            FrmPreviewSalarySlip frmPreviewSalarySlip = new FrmPreviewSalarySlip();
            frmPreviewSalarySlip.vSalaryPaymentDetailRow = vSalaryPaymentDetailRow; 

            frmPreviewSalarySlip.ShowDialog();
        }
    }
}
