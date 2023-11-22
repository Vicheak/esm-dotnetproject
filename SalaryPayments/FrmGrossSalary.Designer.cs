namespace EmployeeSalaryMGProj.SalaryPayments
{
    partial class FrmGrossSalary
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label grossTypeIdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrossSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.employeeSalaryMGDataSet = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSet();
            this.grossSalariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grossSalariesTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.GrossSalariesTableAdapter();
            this.tableAdapterManager = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager();
            this.grossTypesTableAdapter = new EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.GrossTypesTableAdapter();
            this.grossSalariesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grossTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.grossTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.lblShowError = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            grossTypeIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSalariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSalariesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(24, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(127, 31);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "ឈ្មោះនៃប្រភេទ៖";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(24, 125);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(118, 31);
            amountLabel.TabIndex = 18;
            amountLabel.Text = "ចំនួនទឹកប្រាក់៖";
            // 
            // grossTypeIdLabel
            // 
            grossTypeIdLabel.AutoSize = true;
            grossTypeIdLabel.Location = new System.Drawing.Point(423, 66);
            grossTypeIdLabel.Name = "grossTypeIdLabel";
            grossTypeIdLabel.Size = new System.Drawing.Size(75, 31);
            grossTypeIdLabel.TabIndex = 20;
            grossTypeIdLabel.Text = "ជម្រើស៖";
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
            this.label1.TabIndex = 9;
            this.label1.Text = "គ្រប់គ្រងព័ត៌មានផ្សេងៗនៃប្រាក់ខែបុគ្គលិក";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employeeSalaryMGDataSet
            // 
            this.employeeSalaryMGDataSet.DataSetName = "EmployeeSalaryMGDataSet";
            this.employeeSalaryMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grossSalariesBindingSource
            // 
            this.grossSalariesBindingSource.DataMember = "GrossSalaries";
            this.grossSalariesBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // grossSalariesTableAdapter
            // 
            this.grossSalariesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseSalaryLogsTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.GrossSalariesTableAdapter = this.grossSalariesTableAdapter;
            this.tableAdapterManager.GrossTypesTableAdapter = this.grossTypesTableAdapter;
            this.tableAdapterManager.MonthsTableAdapter = null;
            this.tableAdapterManager.PaymentStatesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentGrossTableAdapter = null;
            this.tableAdapterManager.SalaryPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeSalaryMGProj.EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // grossTypesTableAdapter
            // 
            this.grossTypesTableAdapter.ClearBeforeFill = true;
            // 
            // grossSalariesDataGridView
            // 
            this.grossSalariesDataGridView.AllowUserToAddRows = false;
            this.grossSalariesDataGridView.AllowUserToDeleteRows = false;
            this.grossSalariesDataGridView.AllowUserToResizeColumns = false;
            this.grossSalariesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grossSalariesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grossSalariesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grossSalariesDataGridView.AutoGenerateColumns = false;
            this.grossSalariesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.grossSalariesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grossSalariesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grossSalariesDataGridView.ColumnHeadersHeight = 45;
            this.grossSalariesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grossSalariesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grossSalariesDataGridView.DataSource = this.grossSalariesBindingSource;
            this.grossSalariesDataGridView.EnableHeadersVisualStyles = false;
            this.grossSalariesDataGridView.Location = new System.Drawing.Point(12, 179);
            this.grossSalariesDataGridView.Name = "grossSalariesDataGridView";
            this.grossSalariesDataGridView.ReadOnly = true;
            this.grossSalariesDataGridView.RowHeadersVisible = false;
            this.grossSalariesDataGridView.RowHeadersWidth = 51;
            this.grossSalariesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grossSalariesDataGridView.RowTemplate.Height = 40;
            this.grossSalariesDataGridView.Size = new System.Drawing.Size(966, 360);
            this.grossSalariesDataGridView.TabIndex = 0;
            this.grossSalariesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grossSalariesDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GrossSalaryId";
            this.dataGridViewTextBoxColumn1.HeaderText = "លេខកូដ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 101;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ឈ្មោះប្រភេទ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "C4";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "ចំនួនទឹកប្រាក់";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GrossTypeId";
            this.dataGridViewTextBoxColumn4.DataSource = this.grossTypesBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "ជម្រើស";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "GrossTypeId";
            // 
            // grossTypesBindingSource
            // 
            this.grossTypesBindingSource.DataMember = "GrossTypes";
            this.grossTypesBindingSource.DataSource = this.employeeSalaryMGDataSet;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(777, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(858, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(858, 61);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(45, 45);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = global::EmployeeSalaryMGProj.Properties.Resources.icons8_undo_26px_1;
            this.btnCancel.Location = new System.Drawing.Point(777, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 45);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grossSalariesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(163, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(238, 39);
            this.nameTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grossSalariesBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(163, 122);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(238, 39);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // grossTypeIdComboBox
            // 
            this.grossTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.grossSalariesBindingSource, "GrossTypeId", true));
            this.grossTypeIdComboBox.DataSource = this.grossTypesBindingSource;
            this.grossTypeIdComboBox.DisplayMember = "Name";
            this.grossTypeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grossTypeIdComboBox.FormattingEnabled = true;
            this.grossTypeIdComboBox.Location = new System.Drawing.Point(520, 63);
            this.grossTypeIdComboBox.Name = "grossTypeIdComboBox";
            this.grossTypeIdComboBox.Size = new System.Drawing.Size(213, 39);
            this.grossTypeIdComboBox.TabIndex = 4;
            this.grossTypeIdComboBox.ValueMember = "GrossTypeId";
            // 
            // lblShowError
            // 
            this.lblShowError.AutoSize = true;
            this.lblShowError.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowError.ForeColor = System.Drawing.Color.Red;
            this.lblShowError.Location = new System.Drawing.Point(407, 130);
            this.lblShowError.Name = "lblShowError";
            this.lblShowError.Size = new System.Drawing.Size(192, 27);
            this.lblShowError.TabIndex = 21;
            this.lblShowError.Text = "សូមវាយបញ្ចូលជាតម្លៃទឹកប្រាក់";
            // 
            // FrmGrossSalary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(990, 561);
            this.Controls.Add(this.lblShowError);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(grossTypeIdLabel);
            this.Controls.Add(this.grossTypeIdComboBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grossSalariesDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGrossSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrossSalary";
            this.Load += new System.EventHandler(this.FrmGrossSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSalariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSalariesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private EmployeeSalaryMGDataSet employeeSalaryMGDataSet;
        private System.Windows.Forms.BindingSource grossSalariesBindingSource;
        private EmployeeSalaryMGDataSetTableAdapters.GrossSalariesTableAdapter grossSalariesTableAdapter;
        private EmployeeSalaryMGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView grossSalariesDataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private EmployeeSalaryMGDataSetTableAdapters.GrossTypesTableAdapter grossTypesTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox grossTypeIdComboBox;
        private System.Windows.Forms.BindingSource grossTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblShowError;
    }
}