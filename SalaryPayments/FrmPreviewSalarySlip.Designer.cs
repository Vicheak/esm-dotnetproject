namespace EmployeeSalaryMGProj.SalaryPayments
{
    partial class FrmPreviewSalarySlip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreviewSalarySlip));
            this.vEmployeeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.vPaymentBenefitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPaymentDeductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSalaryPaymentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vEmployeeDetailTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VEmployeeDetailTableAdapter();
            this.vPaymentBenefitTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VPaymentBenefitTableAdapter();
            this.vPaymentDeductionTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VPaymentDeductionTableAdapter();
            this.vSalaryPaymentDetailTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPaymentBenefitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPaymentDeductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vEmployeeDetailBindingSource
            // 
            this.vEmployeeDetailBindingSource.DataMember = "VEmployeeDetail";
            this.vEmployeeDetailBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPaymentBenefitBindingSource
            // 
            this.vPaymentBenefitBindingSource.DataMember = "VPaymentBenefit";
            this.vPaymentBenefitBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // vPaymentDeductionBindingSource
            // 
            this.vPaymentDeductionBindingSource.DataMember = "VPaymentDeduction";
            this.vPaymentDeductionBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // vSalaryPaymentDetailBindingSource
            // 
            this.vSalaryPaymentDetailBindingSource.DataMember = "VSalaryPaymentDetail";
            this.vSalaryPaymentDetailBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSetVEmployeeDetail";
            reportDataSource5.Value = this.vEmployeeDetailBindingSource;
            reportDataSource6.Name = "DataSetVPaymentBenefit";
            reportDataSource6.Value = this.vPaymentBenefitBindingSource;
            reportDataSource7.Name = "DataSetVPaymentDeduction";
            reportDataSource7.Value = this.vPaymentDeductionBindingSource;
            reportDataSource8.Name = "DataSetVSalaryPaymentDetail";
            reportDataSource8.Value = this.vSalaryPaymentDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmployeeSalaryMGProj.ReportSalarySlip.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(982, 753);
            this.reportViewer1.TabIndex = 0;
            // 
            // vEmployeeDetailTableAdapter
            // 
            this.vEmployeeDetailTableAdapter.ClearBeforeFill = true;
            // 
            // vPaymentBenefitTableAdapter
            // 
            this.vPaymentBenefitTableAdapter.ClearBeforeFill = true;
            // 
            // vPaymentDeductionTableAdapter
            // 
            this.vPaymentDeductionTableAdapter.ClearBeforeFill = true;
            // 
            // vSalaryPaymentDetailTableAdapter
            // 
            this.vSalaryPaymentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPreviewSalarySlip
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPreviewSalarySlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រងប្រាក់ខែបុគ្គលិក";
            this.Load += new System.EventHandler(this.FrmPreviewSalarySlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPaymentBenefitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPaymentDeductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource vEmployeeDetailBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VEmployeeDetailTableAdapter vEmployeeDetailTableAdapter;
        private System.Windows.Forms.BindingSource vPaymentBenefitBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VPaymentBenefitTableAdapter vPaymentBenefitTableAdapter;
        private System.Windows.Forms.BindingSource vPaymentDeductionBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VPaymentDeductionTableAdapter vPaymentDeductionTableAdapter;
        private System.Windows.Forms.BindingSource vSalaryPaymentDetailBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter vSalaryPaymentDetailTableAdapter;
    }
}