namespace EmployeeSalaryMGProj.Employees
{
    partial class FrmEmployeeDetail
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label baseSalaryLabel;
            System.Windows.Forms.Label departmentIdLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.activeTextBox = new System.Windows.Forms.TextBox();
            this.employeesTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.baseSalaryLogDataGridView = new System.Windows.Forms.DataGridView();
            this.baseSalaryLogIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalaryLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseSalaryLogsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vSalaryPaymentDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.salaryPaymentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benefitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.monthsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSalaryPaymentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vSalaryPaymentDetailTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter();
            this.departmentsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter();
            this.monthsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.MonthsTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            employeeIdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            baseSalaryLabel = new System.Windows.Forms.Label();
            departmentIdLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(18, 51);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(82, 31);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "លេខកូដ៖";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(18, 96);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(99, 31);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "នាមត្រកូល៖";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(18, 141);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(77, 31);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "នាមខ្លួន៖";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(18, 186);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(53, 31);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "ភេទ៖";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(325, 51);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(127, 31);
            birthDateLabel.TabIndex = 8;
            birthDateLabel.Text = "ថ្ងៃខែឆ្នាំកំណើត៖";
            // 
            // baseSalaryLabel
            // 
            baseSalaryLabel.AutoSize = true;
            baseSalaryLabel.Location = new System.Drawing.Point(325, 96);
            baseSalaryLabel.Name = "baseSalaryLabel";
            baseSalaryLabel.Size = new System.Drawing.Size(114, 31);
            baseSalaryLabel.TabIndex = 10;
            baseSalaryLabel.Text = "ប្រាក់ខែគោល៖";
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.Location = new System.Drawing.Point(325, 141);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new System.Drawing.Size(94, 31);
            departmentIdLabel.TabIndex = 12;
            departmentIdLabel.Text = "ដេប៉ាតឺម៉ង់៖";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(325, 186);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(65, 31);
            activeLabel.TabIndex = 14;
            activeLabel.Text = "សកម្ម៖";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(employeeIdLabel);
            this.groupBox1.Controls.Add(this.employeeIdTextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(this.genderTextBox);
            this.groupBox1.Controls.Add(birthDateLabel);
            this.groupBox1.Controls.Add(this.birthDateTextBox);
            this.groupBox1.Controls.Add(baseSalaryLabel);
            this.groupBox1.Controls.Add(this.baseSalaryTextBox);
            this.groupBox1.Controls.Add(departmentIdLabel);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Controls.Add(activeLabel);
            this.groupBox1.Controls.Add(this.activeTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ព័ត៌មានបឋមរបស់បុគ្គលិក";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeId", true));
            this.employeeIdTextBox.Location = new System.Drawing.Point(116, 48);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.ReadOnly = true;
            this.employeeIdTextBox.Size = new System.Drawing.Size(204, 39);
            this.employeeIdTextBox.TabIndex = 1;
            this.employeeIdTextBox.TabStop = false;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(116, 93);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(204, 39);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TabStop = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(116, 138);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(204, 39);
            this.lastNameTextBox.TabIndex = 5;
            this.lastNameTextBox.TabStop = false;
            // 
            // genderTextBox
            // 
            this.genderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(116, 183);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(204, 39);
            this.genderTextBox.TabIndex = 7;
            this.genderTextBox.TabStop = false;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BirthDate", true));
            this.birthDateTextBox.Location = new System.Drawing.Point(456, 48);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.ReadOnly = true;
            this.birthDateTextBox.Size = new System.Drawing.Size(204, 39);
            this.birthDateTextBox.TabIndex = 9;
            this.birthDateTextBox.TabStop = false;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baseSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BaseSalary", true));
            this.baseSalaryTextBox.Location = new System.Drawing.Point(456, 93);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.ReadOnly = true;
            this.baseSalaryTextBox.Size = new System.Drawing.Size(204, 39);
            this.baseSalaryTextBox.TabIndex = 11;
            this.baseSalaryTextBox.TabStop = false;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "DepartmentId", true));
            this.departmentTextBox.Location = new System.Drawing.Point(456, 138);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(204, 39);
            this.departmentTextBox.TabIndex = 13;
            this.departmentTextBox.TabStop = false;
            // 
            // activeTextBox
            // 
            this.activeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.activeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Active", true));
            this.activeTextBox.Location = new System.Drawing.Point(456, 183);
            this.activeTextBox.Name = "activeTextBox";
            this.activeTextBox.ReadOnly = true;
            this.activeTextBox.Size = new System.Drawing.Size(204, 39);
            this.activeTextBox.TabIndex = 15;
            this.activeTextBox.TabStop = false;
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
            this.tableAdapterManager.MonthsTableAdapter = null;
            this.tableAdapterManager.PaymentStatesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentGrossTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // baseSalaryLogDataGridView
            // 
            this.baseSalaryLogDataGridView.AllowUserToAddRows = false;
            this.baseSalaryLogDataGridView.AllowUserToDeleteRows = false;
            this.baseSalaryLogDataGridView.AllowUserToResizeColumns = false;
            this.baseSalaryLogDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.baseSalaryLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.baseSalaryLogDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseSalaryLogDataGridView.AutoGenerateColumns = false;
            this.baseSalaryLogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.baseSalaryLogDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.baseSalaryLogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.baseSalaryLogDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.baseSalaryLogDataGridView.ColumnHeadersHeight = 45;
            this.baseSalaryLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.baseSalaryLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baseSalaryLogIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn});
            this.baseSalaryLogDataGridView.DataSource = this.baseSalaryLogsBindingSource;
            this.baseSalaryLogDataGridView.EnableHeadersVisualStyles = false;
            this.baseSalaryLogDataGridView.Location = new System.Drawing.Point(9, 38);
            this.baseSalaryLogDataGridView.Name = "baseSalaryLogDataGridView";
            this.baseSalaryLogDataGridView.ReadOnly = true;
            this.baseSalaryLogDataGridView.RowHeadersVisible = false;
            this.baseSalaryLogDataGridView.RowHeadersWidth = 51;
            this.baseSalaryLogDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.baseSalaryLogDataGridView.RowTemplate.Height = 40;
            this.baseSalaryLogDataGridView.Size = new System.Drawing.Size(549, 212);
            this.baseSalaryLogDataGridView.TabIndex = 1;
            this.baseSalaryLogDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.baseSalaryLogDataGridView_Paint);
            // 
            // baseSalaryLogIdDataGridViewTextBoxColumn
            // 
            this.baseSalaryLogIdDataGridViewTextBoxColumn.DataPropertyName = "BaseSalaryLogId";
            this.baseSalaryLogIdDataGridViewTextBoxColumn.HeaderText = "BaseSalaryLogId";
            this.baseSalaryLogIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baseSalaryLogIdDataGridViewTextBoxColumn.Name = "baseSalaryLogIdDataGridViewTextBoxColumn";
            this.baseSalaryLogIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseSalaryLogIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "ក.បនៃប្រវត្តិ";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle12.Format = "C4";
            dataGridViewCellStyle12.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.amountDataGridViewTextBoxColumn.HeaderText = "ចំនួនទឹកប្រាក់";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "អធិប្បាយ";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // baseSalaryLogsBindingSource
            // 
            this.baseSalaryLogsBindingSource.DataMember = "BaseSalaryLogs";
            this.baseSalaryLogsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // baseSalaryLogsTableAdapter
            // 
            this.baseSalaryLogsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baseSalaryLogDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(698, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "តាមដានប្រវត្តិនៃការប្រែប្រួលប្រាក់ខែ";
            // 
            // vSalaryPaymentDetailDataGridView
            // 
            this.vSalaryPaymentDetailDataGridView.AllowUserToAddRows = false;
            this.vSalaryPaymentDetailDataGridView.AllowUserToDeleteRows = false;
            this.vSalaryPaymentDetailDataGridView.AllowUserToResizeColumns = false;
            this.vSalaryPaymentDetailDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.vSalaryPaymentDetailDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.vSalaryPaymentDetailDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vSalaryPaymentDetailDataGridView.AutoGenerateColumns = false;
            this.vSalaryPaymentDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vSalaryPaymentDetailDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.vSalaryPaymentDetailDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vSalaryPaymentDetailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.vSalaryPaymentDetailDataGridView.ColumnHeadersHeight = 45;
            this.vSalaryPaymentDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vSalaryPaymentDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryPaymentIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn1,
            this.employeeNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.baseSalaryDataGridViewTextBoxColumn,
            this.benefitDataGridViewTextBoxColumn,
            this.deductionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn});
            this.vSalaryPaymentDetailDataGridView.DataSource = this.vSalaryPaymentDetailBindingSource;
            this.vSalaryPaymentDetailDataGridView.EnableHeadersVisualStyles = false;
            this.vSalaryPaymentDetailDataGridView.Location = new System.Drawing.Point(6, 38);
            this.vSalaryPaymentDetailDataGridView.Name = "vSalaryPaymentDetailDataGridView";
            this.vSalaryPaymentDetailDataGridView.ReadOnly = true;
            this.vSalaryPaymentDetailDataGridView.RowHeadersVisible = false;
            this.vSalaryPaymentDetailDataGridView.RowHeadersWidth = 51;
            this.vSalaryPaymentDetailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.vSalaryPaymentDetailDataGridView.RowTemplate.Height = 40;
            this.vSalaryPaymentDetailDataGridView.Size = new System.Drawing.Size(1247, 282);
            this.vSalaryPaymentDetailDataGridView.TabIndex = 2;
            this.vSalaryPaymentDetailDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.vSalaryPaymentDetailDataGridView_Paint);
            // 
            // salaryPaymentIdDataGridViewTextBoxColumn
            // 
            this.salaryPaymentIdDataGridViewTextBoxColumn.DataPropertyName = "SalaryPaymentId";
            this.salaryPaymentIdDataGridViewTextBoxColumn.HeaderText = "SalaryPaymentId";
            this.salaryPaymentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryPaymentIdDataGridViewTextBoxColumn.Name = "salaryPaymentIdDataGridViewTextBoxColumn";
            this.salaryPaymentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryPaymentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeIdDataGridViewTextBoxColumn1
            // 
            this.employeeIdDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn1.Name = "employeeIdDataGridViewTextBoxColumn1";
            this.employeeIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "ក.បបង្កើតប័ណ្ណ";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // baseSalaryDataGridViewTextBoxColumn
            // 
            this.baseSalaryDataGridViewTextBoxColumn.DataPropertyName = "BaseSalary";
            dataGridViewCellStyle15.Format = "C4";
            dataGridViewCellStyle15.NullValue = null;
            this.baseSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.baseSalaryDataGridViewTextBoxColumn.HeaderText = "ប្រាក់ខែគោល";
            this.baseSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baseSalaryDataGridViewTextBoxColumn.Name = "baseSalaryDataGridViewTextBoxColumn";
            this.baseSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // benefitDataGridViewTextBoxColumn
            // 
            this.benefitDataGridViewTextBoxColumn.DataPropertyName = "Benefit";
            dataGridViewCellStyle16.Format = "C4";
            dataGridViewCellStyle16.NullValue = null;
            this.benefitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.benefitDataGridViewTextBoxColumn.HeaderText = "ផលប្រយោជន៏";
            this.benefitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.benefitDataGridViewTextBoxColumn.Name = "benefitDataGridViewTextBoxColumn";
            this.benefitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionDataGridViewTextBoxColumn
            // 
            this.deductionDataGridViewTextBoxColumn.DataPropertyName = "Deduction";
            dataGridViewCellStyle17.Format = "C4";
            dataGridViewCellStyle17.NullValue = null;
            this.deductionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.deductionDataGridViewTextBoxColumn.HeaderText = "កាត់ប្រាក់ខែ";
            this.deductionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deductionDataGridViewTextBoxColumn.Name = "deductionDataGridViewTextBoxColumn";
            this.deductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            dataGridViewCellStyle18.Format = "C4";
            dataGridViewCellStyle18.NullValue = null;
            this.salaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "ប្រាក់ដំណាច់ខែ";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.DataSource = this.monthsBindingSource;
            this.monthDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.monthDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.monthDataGridViewTextBoxColumn.HeaderText = "ខែ";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.monthDataGridViewTextBoxColumn.ValueMember = "MonthId";
            // 
            // monthsBindingSource
            // 
            this.monthsBindingSource.DataMember = "Months";
            this.monthsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "ឆ្នាំ";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "ស្ថានភាពបង់";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "ក.បបើកប្រាក់ខែ";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vSalaryPaymentDetailBindingSource
            // 
            this.vSalaryPaymentDetailBindingSource.DataMember = "VSalaryPaymentDetail";
            this.vSalaryPaymentDetailBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.vSalaryPaymentDetailDataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1259, 326);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "តាមដានប្រវត្តិនៃការបើកប្រាក់ខែ";
            // 
            // vSalaryPaymentDetailTableAdapter
            // 
            this.vSalaryPaymentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // monthsTableAdapter
            // 
            this.monthsTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1265, 598);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Navy;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::EmployeeSalaryMGProj.Properties.Resources.icons8_print_24px_1;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1170, 620);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(107, 41);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "បោះពុម្ព";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmEmployeeDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1289, 674);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmployeeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រងប្រាក់ខែបុគ្គលិក";
            this.Load += new System.EventHandler(this.FrmEmployeeDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseSalaryLogsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox activeTextBox;
        private System.Windows.Forms.DataGridView baseSalaryLogDataGridView;
        private System.Windows.Forms.BindingSource baseSalaryLogsBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter baseSalaryLogsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView vSalaryPaymentDetailDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource vSalaryPaymentDetailBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter vSalaryPaymentDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalaryLogIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource monthsBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.MonthsTableAdapter monthsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryPaymentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn benefitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrint;
    }
}