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
    public partial class FrmPreviewSalarySlip : Form
    {
        public EmployeeSalaryMGDataSet.VSalaryPaymentDetailRow vSalaryPaymentDetailRow { get; set; }

        public FrmPreviewSalarySlip()
        {
            InitializeComponent();
        }

        private void FrmPreviewSalarySlip_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            //fill view salary payment detail
            this.employeeSalaryMGDataSet.VSalaryPaymentDetail.ImportRow(vSalaryPaymentDetailRow); 

            //fill view employee detail
            this.vEmployeeDetailTableAdapter.FillByEmployeeId(this.employeeSalaryMGDataSet.VEmployeeDetail,
                this.vSalaryPaymentDetailRow.EmployeeId);

            //fill view payment benefit
            this.vPaymentBenefitTableAdapter.FillBySalaryPaymentId(this.employeeSalaryMGDataSet.VPaymentBenefit,
                this.vSalaryPaymentDetailRow.SalaryPaymentId);

            //fill view payment deduction
            this.vPaymentDeductionTableAdapter.FillBySalaryPaymentId(this.employeeSalaryMGDataSet.VPaymentDeduction,
                this.vSalaryPaymentDetailRow.SalaryPaymentId);

            this.reportViewer1.RefreshReport();
        }
    }
}
