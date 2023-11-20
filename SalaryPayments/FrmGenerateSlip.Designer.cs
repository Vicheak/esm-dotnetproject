namespace EmployeeSalaryMGProj.SalaryPayments
{
    partial class FrmGenerateSlip
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
            System.Windows.Forms.Label employeeIdLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label baseSalaryLabel;
            System.Windows.Forms.Label departmentIdLabel;
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.benefitflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBenefit = new System.Windows.Forms.Button();
            this.cbChooseBenefit = new System.Windows.Forms.ComboBox();
            this.vSalaryBenefitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deductionflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDeduction = new System.Windows.Forms.Button();
            this.cbChooseDeduction = new System.Windows.Forms.ComboBox();
            this.vSalaryDeductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSalaryBenefitTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VSalaryBenefitTableAdapter();
            this.vSalaryDeductionTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VSalaryDeductionTableAdapter();
            employeeIdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            baseSalaryLabel = new System.Windows.Forms.Label();
            departmentIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryBenefitBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryDeductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(20, 20);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(82, 31);
            employeeIdLabel.TabIndex = 1;
            employeeIdLabel.Text = "លេខកូដ៖";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(20, 65);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(117, 31);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "ឈ្មោះបុគ្គលិក៖";
            // 
            // baseSalaryLabel
            // 
            baseSalaryLabel.AutoSize = true;
            baseSalaryLabel.Location = new System.Drawing.Point(20, 115);
            baseSalaryLabel.Name = "baseSalaryLabel";
            baseSalaryLabel.Size = new System.Drawing.Size(114, 31);
            baseSalaryLabel.TabIndex = 11;
            baseSalaryLabel.Text = "ប្រាក់ខែគោល៖";
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.Location = new System.Drawing.Point(392, 115);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new System.Drawing.Size(94, 31);
            departmentIdLabel.TabIndex = 13;
            departmentIdLabel.Text = "ដេប៉ាតឺម៉ង់៖";
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseSalaryLogsTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.GrossSalariesTableAdapter = null;
            this.tableAdapterManager.GrossTypesTableAdapter = null;
            this.tableAdapterManager.PaymentStatesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentGrossTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeId", true));
            this.employeeIdTextBox.Location = new System.Drawing.Point(151, 17);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.ReadOnly = true;
            this.employeeIdTextBox.Size = new System.Drawing.Size(200, 39);
            this.employeeIdTextBox.TabIndex = 2;
            this.employeeIdTextBox.TabStop = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmployeeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.txtEmployeeName.Location = new System.Drawing.Point(151, 64);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(316, 39);
            this.txtEmployeeName.TabIndex = 4;
            this.txtEmployeeName.TabStop = false;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baseSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BaseSalary", true));
            this.baseSalaryTextBox.Location = new System.Drawing.Point(151, 111);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.ReadOnly = true;
            this.baseSalaryTextBox.Size = new System.Drawing.Size(200, 39);
            this.baseSalaryTextBox.TabIndex = 12;
            this.baseSalaryTextBox.TabStop = false;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDepartment.Location = new System.Drawing.Point(492, 112);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(200, 39);
            this.txtDepartment.TabIndex = 6;
            this.txtDepartment.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.benefitflowLayoutPanel);
            this.groupBox1.Controls.Add(this.btnAddBenefit);
            this.groupBox1.Controls.Add(this.cbChooseBenefit);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 431);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ជ្រើសរើសការបន្ថែមលើប្រាក់ខែ";
            // 
            // benefitflowLayoutPanel
            // 
            this.benefitflowLayoutPanel.Location = new System.Drawing.Point(6, 84);
            this.benefitflowLayoutPanel.Name = "benefitflowLayoutPanel";
            this.benefitflowLayoutPanel.Size = new System.Drawing.Size(443, 341);
            this.benefitflowLayoutPanel.TabIndex = 16;
            // 
            // btnAddBenefit
            // 
            this.btnAddBenefit.BackColor = System.Drawing.Color.Navy;
            this.btnAddBenefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBenefit.FlatAppearance.BorderSize = 0;
            this.btnAddBenefit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBenefit.ForeColor = System.Drawing.Color.White;
            this.btnAddBenefit.Location = new System.Drawing.Point(353, 39);
            this.btnAddBenefit.Name = "btnAddBenefit";
            this.btnAddBenefit.Size = new System.Drawing.Size(96, 39);
            this.btnAddBenefit.TabIndex = 15;
            this.btnAddBenefit.TabStop = false;
            this.btnAddBenefit.Text = "បន្ថែម";
            this.btnAddBenefit.UseVisualStyleBackColor = false;
            this.btnAddBenefit.Click += new System.EventHandler(this.btnAddBenefit_Click);
            // 
            // cbChooseBenefit
            // 
            this.cbChooseBenefit.DataSource = this.vSalaryBenefitBindingSource;
            this.cbChooseBenefit.DisplayMember = "Name";
            this.cbChooseBenefit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseBenefit.FormattingEnabled = true;
            this.cbChooseBenefit.Location = new System.Drawing.Point(7, 39);
            this.cbChooseBenefit.Name = "cbChooseBenefit";
            this.cbChooseBenefit.Size = new System.Drawing.Size(340, 39);
            this.cbChooseBenefit.TabIndex = 0;
            this.cbChooseBenefit.TabStop = false;
            this.cbChooseBenefit.ValueMember = "GrossSalaryId";
            // 
            // vSalaryBenefitBindingSource
            // 
            this.vSalaryBenefitBindingSource.DataMember = "VSalaryBenefit";
            this.vSalaryBenefitBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deductionflowLayoutPanel);
            this.groupBox2.Controls.Add(this.btnAddDeduction);
            this.groupBox2.Controls.Add(this.cbChooseDeduction);
            this.groupBox2.Location = new System.Drawing.Point(481, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 431);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ជ្រើសរើសការកាត់លើប្រាក់ខែ";
            // 
            // deductionflowLayoutPanel
            // 
            this.deductionflowLayoutPanel.Location = new System.Drawing.Point(6, 84);
            this.deductionflowLayoutPanel.Name = "deductionflowLayoutPanel";
            this.deductionflowLayoutPanel.Size = new System.Drawing.Size(443, 341);
            this.deductionflowLayoutPanel.TabIndex = 16;
            // 
            // btnAddDeduction
            // 
            this.btnAddDeduction.BackColor = System.Drawing.Color.Navy;
            this.btnAddDeduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDeduction.FlatAppearance.BorderSize = 0;
            this.btnAddDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDeduction.ForeColor = System.Drawing.Color.White;
            this.btnAddDeduction.Location = new System.Drawing.Point(353, 39);
            this.btnAddDeduction.Name = "btnAddDeduction";
            this.btnAddDeduction.Size = new System.Drawing.Size(96, 39);
            this.btnAddDeduction.TabIndex = 15;
            this.btnAddDeduction.TabStop = false;
            this.btnAddDeduction.Text = "បន្ថែម";
            this.btnAddDeduction.UseVisualStyleBackColor = false;
            this.btnAddDeduction.Click += new System.EventHandler(this.btnAddDeduction_Click);
            // 
            // cbChooseDeduction
            // 
            this.cbChooseDeduction.DataSource = this.vSalaryDeductionBindingSource;
            this.cbChooseDeduction.DisplayMember = "Name";
            this.cbChooseDeduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseDeduction.FormattingEnabled = true;
            this.cbChooseDeduction.Location = new System.Drawing.Point(7, 39);
            this.cbChooseDeduction.Name = "cbChooseDeduction";
            this.cbChooseDeduction.Size = new System.Drawing.Size(340, 39);
            this.cbChooseDeduction.TabIndex = 0;
            this.cbChooseDeduction.TabStop = false;
            this.cbChooseDeduction.ValueMember = "GrossSalaryId";
            // 
            // vSalaryDeductionBindingSource
            // 
            this.vSalaryDeductionBindingSource.DataMember = "VSalaryDeduction";
            this.vSalaryDeductionBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // vSalaryBenefitTableAdapter
            // 
            this.vSalaryBenefitTableAdapter.ClearBeforeFill = true;
            // 
            // vSalaryDeductionTableAdapter
            // 
            this.vSalaryDeductionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGenerateSlip
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(948, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(employeeIdLabel);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(baseSalaryLabel);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(departmentIdLabel);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerateSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGenerateSlip";
            this.Load += new System.EventHandler(this.FrmGenerateSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryBenefitBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryDeductionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChooseBenefit;
        private System.Windows.Forms.FlowLayoutPanel benefitflowLayoutPanel;
        private System.Windows.Forms.Button btnAddBenefit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel deductionflowLayoutPanel;
        private System.Windows.Forms.Button btnAddDeduction;
        private System.Windows.Forms.ComboBox cbChooseDeduction;
        private System.Windows.Forms.BindingSource vSalaryBenefitBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VSalaryBenefitTableAdapter vSalaryBenefitTableAdapter;
        private System.Windows.Forms.BindingSource vSalaryDeductionBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VSalaryDeductionTableAdapter vSalaryDeductionTableAdapter;
    }
}