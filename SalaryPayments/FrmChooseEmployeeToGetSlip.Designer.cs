namespace EmployeeSalaryMGProj.SalaryPayments
{
    partial class FrmChooseEmployeeToGetSlip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.departmentsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vSalaryPaymentDetaildataGridView = new System.Windows.Forms.DataGridView();
            this.salaryPaymentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benefitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpty = new System.Windows.Forms.DataGridViewImageColumn();
            this.vSalaryPaymentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.salaryPaymentGrossTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.SalaryPaymentGrossTableAdapter();
            this.salaryPaymentsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.SalaryPaymentsTableAdapter();
            this.btnGenerateSlip = new System.Windows.Forms.Button();
            this.vSalaryPaymentDetailTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter();
            this.btnSetPaymentStatus = new System.Windows.Forms.Button();
            this.btnCancelPaymentStatus = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetaildataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Khmer M1", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1482, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "ជ្រើសរើសបុគ្គលិកដើម្បីចេញប័ណ្ណបើកប្រាក់ខែ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "ជ្រើសរើសផ្នែកឫដេប៉ាតឺម៉ង់៖";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DataSource = this.departmentsBindingSource;
            this.cbDepartment.DisplayMember = "Name";
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(216, 48);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(294, 39);
            this.cbDepartment.TabIndex = 2;
            this.cbDepartment.ValueMember = "DepartmentId";
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.vSalaryPaymentDetaildataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.employeesDataGridView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1458, 566);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // vSalaryPaymentDetaildataGridView
            // 
            this.vSalaryPaymentDetaildataGridView.AllowUserToAddRows = false;
            this.vSalaryPaymentDetaildataGridView.AllowUserToDeleteRows = false;
            this.vSalaryPaymentDetaildataGridView.AllowUserToResizeColumns = false;
            this.vSalaryPaymentDetaildataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.vSalaryPaymentDetaildataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vSalaryPaymentDetaildataGridView.AutoGenerateColumns = false;
            this.vSalaryPaymentDetaildataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vSalaryPaymentDetaildataGridView.BackgroundColor = System.Drawing.Color.White;
            this.vSalaryPaymentDetaildataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vSalaryPaymentDetaildataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vSalaryPaymentDetaildataGridView.ColumnHeadersHeight = 45;
            this.vSalaryPaymentDetaildataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vSalaryPaymentDetaildataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryPaymentIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.baseSalaryDataGridViewTextBoxColumn,
            this.benefitDataGridViewTextBoxColumn,
            this.deductionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.ColumnEmpty});
            this.vSalaryPaymentDetaildataGridView.DataSource = this.vSalaryPaymentDetailBindingSource;
            this.vSalaryPaymentDetaildataGridView.EnableHeadersVisualStyles = false;
            this.vSalaryPaymentDetaildataGridView.Location = new System.Drawing.Point(586, 3);
            this.vSalaryPaymentDetaildataGridView.Name = "vSalaryPaymentDetaildataGridView";
            this.vSalaryPaymentDetaildataGridView.ReadOnly = true;
            this.vSalaryPaymentDetaildataGridView.RowHeadersVisible = false;
            this.vSalaryPaymentDetaildataGridView.RowHeadersWidth = 51;
            this.vSalaryPaymentDetaildataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.vSalaryPaymentDetaildataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.vSalaryPaymentDetaildataGridView.RowTemplate.Height = 40;
            this.vSalaryPaymentDetaildataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vSalaryPaymentDetaildataGridView.Size = new System.Drawing.Size(869, 560);
            this.vSalaryPaymentDetaildataGridView.TabIndex = 1;
            this.vSalaryPaymentDetaildataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vSalaryPaymentDetaildataGridView_CellContentClick);
            this.vSalaryPaymentDetaildataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.vSalaryPaymentDetaildataGridView_Paint);
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
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះបុគ្គលិក";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "កាលបរិច្ឆេទចេញប័ណ្ណ";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseSalaryDataGridViewTextBoxColumn
            // 
            this.baseSalaryDataGridViewTextBoxColumn.DataPropertyName = "BaseSalary";
            this.baseSalaryDataGridViewTextBoxColumn.HeaderText = "BaseSalary";
            this.baseSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baseSalaryDataGridViewTextBoxColumn.Name = "baseSalaryDataGridViewTextBoxColumn";
            this.baseSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseSalaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // benefitDataGridViewTextBoxColumn
            // 
            this.benefitDataGridViewTextBoxColumn.DataPropertyName = "Benefit";
            this.benefitDataGridViewTextBoxColumn.HeaderText = "Benefit";
            this.benefitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.benefitDataGridViewTextBoxColumn.Name = "benefitDataGridViewTextBoxColumn";
            this.benefitDataGridViewTextBoxColumn.ReadOnly = true;
            this.benefitDataGridViewTextBoxColumn.Visible = false;
            // 
            // deductionDataGridViewTextBoxColumn
            // 
            this.deductionDataGridViewTextBoxColumn.DataPropertyName = "Deduction";
            this.deductionDataGridViewTextBoxColumn.HeaderText = "Deduction";
            this.deductionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deductionDataGridViewTextBoxColumn.Name = "deductionDataGridViewTextBoxColumn";
            this.deductionDataGridViewTextBoxColumn.ReadOnly = true;
            this.deductionDataGridViewTextBoxColumn.Visible = false;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            dataGridViewCellStyle3.Format = "C4";
            dataGridViewCellStyle3.NullValue = null;
            this.salaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "ប្រាក់បំណាច់ខែ";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "ស្ថានភាព";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "ក.បបង់";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColumnEmpty
            // 
            this.ColumnEmpty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnEmpty.HeaderText = "លុប";
            this.ColumnEmpty.Image = global::EmployeeSalaryMGProj.Properties.Resources.icons8_trash_can_16px;
            this.ColumnEmpty.MinimumWidth = 6;
            this.ColumnEmpty.Name = "ColumnEmpty";
            this.ColumnEmpty.ReadOnly = true;
            this.ColumnEmpty.Width = 49;
            // 
            // vSalaryPaymentDetailBindingSource
            // 
            this.vSalaryPaymentDetailBindingSource.DataMember = "VSalaryPaymentDetail";
            this.vSalaryPaymentDetailBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.AllowUserToResizeColumns = false;
            this.employeesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.employeesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.employeesDataGridView.ColumnHeadersHeight = 45;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.EnableHeadersVisualStyles = false;
            this.employeesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersVisible = false;
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employeesDataGridView.RowTemplate.Height = 40;
            this.employeesDataGridView.Size = new System.Drawing.Size(577, 560);
            this.employeesDataGridView.TabIndex = 0;
            this.employeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellClick);
            this.employeesDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.employeesDataGridView_Paint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "លេខកូដ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 101;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "នាមត្រកូល";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "នាមខ្លួន";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BaseSalary";
            dataGridViewCellStyle7.Format = "C4";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn6.HeaderText = "ប្រាក់ខែគោល";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DepartmentId";
            this.dataGridViewTextBoxColumn7.HeaderText = "DepartmentId";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
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
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.GrossSalariesTableAdapter = null;
            this.tableAdapterManager.GrossTypesTableAdapter = null;
            this.tableAdapterManager.MonthsTableAdapter = null;
            this.tableAdapterManager.PaymentStatesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentGrossTableAdapter = this.salaryPaymentGrossTableAdapter;
            this.tableAdapterManager.SalaryPaymentsTableAdapter = this.salaryPaymentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // salaryPaymentGrossTableAdapter
            // 
            this.salaryPaymentGrossTableAdapter.ClearBeforeFill = true;
            // 
            // salaryPaymentsTableAdapter
            // 
            this.salaryPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerateSlip
            // 
            this.btnGenerateSlip.BackColor = System.Drawing.Color.Navy;
            this.btnGenerateSlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateSlip.FlatAppearance.BorderSize = 0;
            this.btnGenerateSlip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateSlip.ForeColor = System.Drawing.Color.White;
            this.btnGenerateSlip.Location = new System.Drawing.Point(266, 120);
            this.btnGenerateSlip.Name = "btnGenerateSlip";
            this.btnGenerateSlip.Size = new System.Drawing.Size(174, 41);
            this.btnGenerateSlip.TabIndex = 0;
            this.btnGenerateSlip.Text = "ចេញប័ណ្ណបើកប្រាក់ខែ";
            this.btnGenerateSlip.UseVisualStyleBackColor = false;
            this.btnGenerateSlip.Click += new System.EventHandler(this.btnGenerateSlip_Click);
            // 
            // vSalaryPaymentDetailTableAdapter
            // 
            this.vSalaryPaymentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // btnSetPaymentStatus
            // 
            this.btnSetPaymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPaymentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSetPaymentStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetPaymentStatus.FlatAppearance.BorderSize = 0;
            this.btnSetPaymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetPaymentStatus.ForeColor = System.Drawing.Color.White;
            this.btnSetPaymentStatus.Location = new System.Drawing.Point(1171, 120);
            this.btnSetPaymentStatus.Name = "btnSetPaymentStatus";
            this.btnSetPaymentStatus.Size = new System.Drawing.Size(120, 41);
            this.btnSetPaymentStatus.TabIndex = 14;
            this.btnSetPaymentStatus.TabStop = false;
            this.btnSetPaymentStatus.Text = "បើកប្រាក់ខែ";
            this.btnSetPaymentStatus.UseVisualStyleBackColor = false;
            this.btnSetPaymentStatus.Click += new System.EventHandler(this.btnSetPaymentStatus_Click);
            // 
            // btnCancelPaymentStatus
            // 
            this.btnCancelPaymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelPaymentStatus.BackColor = System.Drawing.Color.Red;
            this.btnCancelPaymentStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelPaymentStatus.FlatAppearance.BorderSize = 0;
            this.btnCancelPaymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelPaymentStatus.ForeColor = System.Drawing.Color.White;
            this.btnCancelPaymentStatus.Location = new System.Drawing.Point(1045, 120);
            this.btnCancelPaymentStatus.Name = "btnCancelPaymentStatus";
            this.btnCancelPaymentStatus.Size = new System.Drawing.Size(120, 41);
            this.btnCancelPaymentStatus.TabIndex = 14;
            this.btnCancelPaymentStatus.TabStop = false;
            this.btnCancelPaymentStatus.Text = "ត្រឡប់";
            this.btnCancelPaymentStatus.UseVisualStyleBackColor = false;
            this.btnCancelPaymentStatus.Click += new System.EventHandler(this.btnCancelPaymentStatus_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Navy;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::EmployeeSalaryMGProj.Properties.Resources.icons8_print_24px_1;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1322, 120);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(148, 41);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "បោះពុម្ពប័ណ្ណ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmChooseEmployeeToGetSlip
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1482, 745);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancelPaymentStatus);
            this.Controls.Add(this.btnSetPaymentStatus);
            this.Controls.Add(this.btnGenerateSlip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChooseEmployeeToGetSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChooseEmployeeToGetSlip";
            this.Load += new System.EventHandler(this.FrmChooseEmployeeToGetSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetaildataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalaryPaymentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartment;
        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnGenerateSlip;
        private System.Windows.Forms.DataGridView vSalaryPaymentDetaildataGridView;
        private System.Windows.Forms.BindingSource vSalaryPaymentDetailBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.VSalaryPaymentDetailTableAdapter vSalaryPaymentDetailTableAdapter;
        private System.Windows.Forms.Button btnSetPaymentStatus;
        private System.Windows.Forms.Button btnCancelPaymentStatus;
        private EmployeeSalaryMGDataSetTableAdapters.SalaryPaymentsTableAdapter salaryPaymentsTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.SalaryPaymentGrossTableAdapter salaryPaymentGrossTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryPaymentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn benefitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEmpty;
        private System.Windows.Forms.Button btnPrint;
    }
}