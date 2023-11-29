using EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters;
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
    public partial class FrmPreviewIndividualEmployee : Form
    {
        public EmployeeSalaryMGDataSet.EmployeesRow employeesRow { get; set; }
        public EmployeeSalaryMGDataSet.BaseSalaryLogsDataTable baseSalaryLogsDataTable { get; set; }
        public EmployeeSalaryMGDataSet.VSalaryPaymentDetailDataTable vSalaryPaymentDetailsDataTable { get; set; }

        public FrmPreviewIndividualEmployee()
        {
            InitializeComponent();
        }

        private void FrmPreviewIndividualEmployee_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            //create one row from VEmployeeDetail
            EmployeeSalaryMGDataSet.VEmployeeDetailRow vEmployeeDetailRow =
                this.employeeSalaryMGDataSet.VEmployeeDetail.NewVEmployeeDetailRow();
            EmployeeSalaryMGDataSet.DepartmentsRow deparment =
                departmentsTableAdapter.GetDataByDepartmentId(this.employeesRow.DepartmentId)[0];

            vEmployeeDetailRow.ItemArray = new object[]
            {
                this.employeesRow.EmployeeId,
                this.employeesRow.FirstName,
                this.employeesRow.LastName,
                this.employeesRow.Gender,
                this.employeesRow.BirthDate,
                this.employeesRow.BaseSalary,
                this.employeesRow.DepartmentId,
                deparment.Name,
                this.employeesRow.Active
            };

            this.employeeSalaryMGDataSet.VEmployeeDetail.AddVEmployeeDetailRow(vEmployeeDetailRow);

            //Merge BaseSalaryLogs data table
            this.employeeSalaryMGDataSet.BaseSalaryLogs.Merge(this.baseSalaryLogsDataTable);

            //Merge VSalaryPaymentDetail data table 
            this.employeeSalaryMGDataSet.VSalaryPaymentDetail.Merge(this.vSalaryPaymentDetailsDataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
