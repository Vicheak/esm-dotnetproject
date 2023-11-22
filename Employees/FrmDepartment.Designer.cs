namespace EmployeeSalaryMGProj
{
    partial class FrmDepartment
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
            System.Windows.Forms.Label departmentIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.departmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGeneratedString = new System.Windows.Forms.Label();
            departmentIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.Location = new System.Drawing.Point(12, 101);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new System.Drawing.Size(157, 33);
            departmentIdLabel.TabIndex = 2;
            departmentIdLabel.Text = "លេខកូដដេប៉ាតឺម៉ង់​៖";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 164);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(140, 33);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "ឈ្មោះដេប៉ាតឺម៉ង់៖";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(419, 56);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(186, 33);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "អធិប្បាយអំពីដេប៉ាតឺម៉ង់៖";
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseSalaryLogsTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
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
            // departmentsDataGridView
            // 
            this.departmentsDataGridView.AllowUserToAddRows = false;
            this.departmentsDataGridView.AllowUserToDeleteRows = false;
            this.departmentsDataGridView.AllowUserToResizeColumns = false;
            this.departmentsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.departmentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.departmentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentsDataGridView.AutoGenerateColumns = false;
            this.departmentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.departmentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.departmentsDataGridView.ColumnHeadersHeight = 45;
            this.departmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.departmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.departmentsDataGridView.DataSource = this.departmentsBindingSource;
            this.departmentsDataGridView.EnableHeadersVisualStyles = false;
            this.departmentsDataGridView.Location = new System.Drawing.Point(12, 232);
            this.departmentsDataGridView.Name = "departmentsDataGridView";
            this.departmentsDataGridView.ReadOnly = true;
            this.departmentsDataGridView.RowHeadersVisible = false;
            this.departmentsDataGridView.RowHeadersWidth = 51;
            this.departmentsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.departmentsDataGridView.RowTemplate.Height = 40;
            this.departmentsDataGridView.Size = new System.Drawing.Size(958, 309);
            this.departmentsDataGridView.TabIndex = 0;
            this.departmentsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.departmentsDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DepartmentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "លេខកូដ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ឈ្មោះដេប៉ាតឺម៉ង់​";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "អធិប្បាយដេប៉ាតឺម៉ង់​";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // departmentIdTextBox
            // 
            this.departmentIdTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.departmentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "DepartmentId", true));
            this.departmentIdTextBox.Location = new System.Drawing.Point(170, 94);
            this.departmentIdTextBox.Name = "departmentIdTextBox";
            this.departmentIdTextBox.ReadOnly = true;
            this.departmentIdTextBox.Size = new System.Drawing.Size(232, 40);
            this.departmentIdTextBox.TabIndex = 3;
            this.departmentIdTextBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(170, 157);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 40);
            this.nameTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(425, 93);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(320, 103);
            this.descriptionTextBox.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(990, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "គ្រប់គ្រងព័ត៌មាននៃដេប៉ាតឺម៉ង់";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = global::EmployeeSalaryMGProj.Properties.Resources.icons8_undo_26px_1;
            this.btnCancel.Location = new System.Drawing.Point(779, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(860, 94);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(45, 45);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(860, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(779, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGeneratedString
            // 
            this.lblGeneratedString.AutoSize = true;
            this.lblGeneratedString.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblGeneratedString.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratedString.ForeColor = System.Drawing.Color.Red;
            this.lblGeneratedString.Location = new System.Drawing.Point(174, 101);
            this.lblGeneratedString.Name = "lblGeneratedString";
            this.lblGeneratedString.Size = new System.Drawing.Size(192, 27);
            this.lblGeneratedString.TabIndex = 10;
            this.lblGeneratedString.Text = "លេខកូដបង្កើតដោយស្វ័យប្រវត្តិ";
            this.lblGeneratedString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(990, 561);
            this.Controls.Add(this.lblGeneratedString);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(departmentIdLabel);
            this.Controls.Add(this.departmentIdTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.departmentsDataGridView);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDepartment";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView departmentsDataGridView;
        private System.Windows.Forms.TextBox departmentIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblGeneratedString;
    }
}