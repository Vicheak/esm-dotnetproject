namespace EmployeeSalaryMGProj
{
    partial class FrmAddOrModifyEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrModifyEmployee));
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.baseSalaryLogsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter();
            this.departmentsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.departmentIdComboBox = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateBaseSalary = new System.Windows.Forms.Button();
            employeeIdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            baseSalaryLabel = new System.Windows.Forms.Label();
            departmentIdLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(16, 84);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(85, 33);
            employeeIdLabel.TabIndex = 1;
            employeeIdLabel.Text = "លេខកូដ៖";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(16, 130);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(103, 33);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "នាមត្រគូល៖";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(16, 176);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(79, 33);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "នាមខ្លួន៖";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(16, 222);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(55, 33);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "ភេទ៖";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(16, 270);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(133, 33);
            birthDateLabel.TabIndex = 9;
            birthDateLabel.Text = "ថ្ងៃខែឆ្នាំកំណើត៖";
            // 
            // baseSalaryLabel
            // 
            baseSalaryLabel.AutoSize = true;
            baseSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            baseSalaryLabel.Location = new System.Drawing.Point(16, 315);
            baseSalaryLabel.Name = "baseSalaryLabel";
            baseSalaryLabel.Size = new System.Drawing.Size(121, 33);
            baseSalaryLabel.TabIndex = 11;
            baseSalaryLabel.Text = "ប្រាក់ខែគោល៖";
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.Location = new System.Drawing.Point(16, 361);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new System.Drawing.Size(97, 33);
            departmentIdLabel.TabIndex = 13;
            departmentIdLabel.Text = "ដេប៉ាតឺម៉ង់៖";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(16, 410);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(97, 33);
            activeLabel.TabIndex = 15;
            activeLabel.Text = "ភាពសកម្ម៖";
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
            this.tableAdapterManager.BaseSalaryLogsTableAdapter = this.baseSalaryLogsTableAdapter;
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
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
            // baseSalaryLogsTableAdapter
            // 
            this.baseSalaryLogsTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeeIdTextBox.ForeColor = System.Drawing.Color.Red;
            this.employeeIdTextBox.Location = new System.Drawing.Point(156, 81);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.ReadOnly = true;
            this.employeeIdTextBox.Size = new System.Drawing.Size(252, 40);
            this.employeeIdTextBox.TabIndex = 2;
            this.employeeIdTextBox.TabStop = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(156, 127);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(252, 40);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(156, 173);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(252, 40);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "ប្រុស",
            "ស្រី"});
            this.genderComboBox.Location = new System.Drawing.Point(156, 219);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(252, 41);
            this.genderComboBox.TabIndex = 2;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(156, 266);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(252, 40);
            this.birthDateDateTimePicker.TabIndex = 3;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BaseSalary", true));
            this.baseSalaryTextBox.Location = new System.Drawing.Point(156, 312);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.ReadOnly = true;
            this.baseSalaryTextBox.Size = new System.Drawing.Size(200, 40);
            this.baseSalaryTextBox.TabIndex = 12;
            this.baseSalaryTextBox.TabStop = false;
            this.baseSalaryTextBox.Text = "0.00";
            // 
            // departmentIdComboBox
            // 
            this.departmentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "DepartmentId", true));
            this.departmentIdComboBox.DataSource = this.departmentsBindingSource;
            this.departmentIdComboBox.DisplayMember = "Name";
            this.departmentIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentIdComboBox.FormattingEnabled = true;
            this.departmentIdComboBox.Location = new System.Drawing.Point(156, 358);
            this.departmentIdComboBox.Name = "departmentIdComboBox";
            this.departmentIdComboBox.Size = new System.Drawing.Size(252, 41);
            this.departmentIdComboBox.TabIndex = 5;
            this.departmentIdComboBox.ValueMember = "DepartmentId";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource, "Active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(156, 405);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(200, 38);
            this.activeCheckBox.TabIndex = 6;
            this.activeCheckBox.Text = "សកម្ម";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Khmer M1", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Image = global::EmployeeSalaryMGProj.Properties.Resources.icons8_add_user_male_30px_1;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(432, 43);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "បន្ថែមព័ត៌មានបុគ្គលិក";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(363, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = global::EmployeeSalaryMGProj.Properties.Resources.icons8_undo_26px_1;
            this.btnCancel.Location = new System.Drawing.Point(296, 476);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateBaseSalary
            // 
            this.btnUpdateBaseSalary.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateBaseSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBaseSalary.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBaseSalary.Location = new System.Drawing.Point(368, 311);
            this.btnUpdateBaseSalary.Name = "btnUpdateBaseSalary";
            this.btnUpdateBaseSalary.Size = new System.Drawing.Size(40, 40);
            this.btnUpdateBaseSalary.TabIndex = 4;
            this.btnUpdateBaseSalary.Text = "...";
            this.btnUpdateBaseSalary.UseVisualStyleBackColor = false;
            this.btnUpdateBaseSalary.Click += new System.EventHandler(this.btnUpdateBaseSalary_Click);
            // 
            // FrmAddOrModifyEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.btnUpdateBaseSalary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(employeeIdLabel);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(baseSalaryLabel);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(departmentIdLabel);
            this.Controls.Add(this.departmentIdComboBox);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeCheckBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddOrModifyEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រងប្រាក់ខែបុគ្គលិក";
            this.Load += new System.EventHandler(this.FrmAddOrModifyEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.ComboBox departmentIdComboBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Label lblTitle;
        private EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateBaseSalary;
        private EmployeeSalaryMGDataSetTableAdapters.BaseSalaryLogsTableAdapter baseSalaryLogsTableAdapter;
    }
}