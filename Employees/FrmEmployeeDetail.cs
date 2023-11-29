using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMGProj.Employees
{
    public partial class FrmEmployeeDetail : Form
    {
        public EmployeeSalaryMGDataSet.EmployeesRow employeesRow { get; set; }

        public FrmEmployeeDetail()
        {
            InitializeComponent();
        }

        private void FrmEmployeeDetail_Load(object sender, EventArgs e)
        {
            this.TopMost = true; 

            this.monthsTableAdapter.Fill(this.employeeSalaryMGDataSet.Months);
            this.employeeSalaryMGDataSet.Employees.ImportRow(employeesRow);

            double baseSalary = double.Parse(baseSalaryTextBox.Text);
            baseSalaryTextBox.Text = baseSalary.ToString("C");

            //access row from table department
            var departmentRow = this.departmentsTableAdapter.GetDataByDepartmentId(employeesRow.DepartmentId)[0];
            departmentTextBox.Text = departmentRow["Name"].ToString();

            activeTextBox.Text = employeesRow.Active ? "សកម្ម" : "មិនសកម្ម";

            //fill base salary log DGV
            this.baseSalaryLogsTableAdapter.FillByEmployeeId(this.employeeSalaryMGDataSet.BaseSalaryLogs,
                employeesRow.EmployeeId); 

            //fill salary payment detail DGV
            this.vSalaryPaymentDetailTableAdapter.FillByEmployeeId(this.employeeSalaryMGDataSet.VSalaryPaymentDetail,
                employeesRow.EmployeeId);
        }

        private void baseSalaryLogDataGridView_Paint(object sender, PaintEventArgs e)
        {
            if (baseSalaryLogDataGridView.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "គ្មានទិន្នន័យ",
                    baseSalaryLogDataGridView.Font,
                    baseSalaryLogDataGridView.ClientRectangle,
                    baseSalaryLogDataGridView.ForeColor,
                    baseSalaryLogDataGridView.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void vSalaryPaymentDetailDataGridView_Paint(object sender, PaintEventArgs e)
        {
            if (vSalaryPaymentDetailDataGridView.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "គ្មានទិន្នន័យ",
                    vSalaryPaymentDetailDataGridView.Font,
                    vSalaryPaymentDetailDataGridView.ClientRectangle,
                    vSalaryPaymentDetailDataGridView.ForeColor,
                    vSalaryPaymentDetailDataGridView.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmPreviewIndividualEmployee frmPreviewIndividualEmployee = new FrmPreviewIndividualEmployee();
            frmPreviewIndividualEmployee.employeesRow = employeesRow; 
            frmPreviewIndividualEmployee.baseSalaryLogsDataTable = this.employeeSalaryMGDataSet.BaseSalaryLogs;
            frmPreviewIndividualEmployee.vSalaryPaymentDetailsDataTable = this.employeeSalaryMGDataSet.VSalaryPaymentDetail;

            frmPreviewIndividualEmployee.ShowDialog();
        }
    }
}
