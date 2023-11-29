namespace EmployeeSalaryMGProj.Employees
{
    partial class FrmPreviewIndividualEmployee
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreviewIndividualEmployee));
            this.vEmployeeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.baseSalaryLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSalaryPaymentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vEmployeeDetailTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VEmployeeDetailTableAdapter();
            this.baseSalaryLogsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter();
            this.vSalaryPaymentDetailTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter();
            this.departmentsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogsBindingSource)).BeginInit();
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
            // baseSalaryLogsBindingSource
            // 
            this.baseSalaryLogsBindingSource.DataMember = "BaseSalaryLogs";
            this.baseSalaryLogsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // vSalaryPaymentDetailBindingSource
            // 
            this.vSalaryPaymentDetailBindingSource.DataMember = "VSalaryPaymentDetail";
            this.vSalaryPaymentDetailBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVEmployeeDetail";
            reportDataSource1.Value = this.vEmployeeDetailBindingSource;
            reportDataSource2.Name = "DataSetBaseSalaryLogs";
            reportDataSource2.Value = this.baseSalaryLogsBindingSource;
            reportDataSource3.Name = "DataSetVSalaryPaymentDetail";
            reportDataSource3.Value = this.vSalaryPaymentDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmployeeSalaryMGProj.ReportIndividualEmployee.rdlc";
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
            // baseSalaryLogsTableAdapter
            // 
            this.baseSalaryLogsTableAdapter.ClearBeforeFill = true;
            // 
            // vSalaryPaymentDetailTableAdapter
            // 
            this.vSalaryPaymentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPreviewIndividualEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPreviewIndividualEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រងប្រាក់ខែបុគ្គលិក";
            this.Load += new System.EventHandler(this.FrmPreviewIndividualEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource vEmployeeDetailBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VEmployeeDetailTableAdapter vEmployeeDetailTableAdapter;
        private System.Windows.Forms.BindingSource baseSalaryLogsBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter baseSalaryLogsTableAdapter;
        private System.Windows.Forms.BindingSource vSalaryPaymentDetailBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter vSalaryPaymentDetailTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
    }
}