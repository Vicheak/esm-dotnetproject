using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalaryMGProj.Utility;

namespace EmployeeSalaryMGProj.Users
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.employeeSalaryMGDataSet.Roles);

            this.usersTableAdapter.Fill(this.employeeSalaryMGDataSet.Users);

            passwordTextBox.PasswordChar = '\u25CF';
            passwordTextBox.Font = new Font("Khmer OS Siemreap", 5);
            passwordTextBox.AutoSize = false;
            passwordTextBox.Size = new Size(172, 33);

            usersDataGridView.Columns[2].DefaultCellStyle.Font = new Font("Khmer OS Siemreap", 5);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                //check if user is not yet saved into the database
                var currentRow = this.usersBindingSource.Current as DataRowView;

                if (currentRow != null || this.usersBindingSource.Count == 0)
                {
                    if (this.usersBindingSource.Count != 0)
                    {
                        var userRow = currentRow.Row as EmployeeSalaryMGDataSet.UsersRow;

                        if (userRow.UserId < 0)
                        {
                            MessageBox.Show("Please complete user information and save to the system!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    this.usersBindingSource.AddNew(); 

                    //set default role for combo box
                    roleIdComboBox.SelectedIndex = 0;
                }
            }catch(NoNullAllowedException ex)
            {
                MessageBox.Show("Please complete user information and save to the system!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void departmentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please complete user information and save to the system!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckUtil.CheckValidInput(usernameTextBox, "Username") &&
                CheckUtil.CheckValidInput(passwordTextBox, "Password"))
            {
                //check if password is less than 8
                if(passwordTextBox.Text.Length < 8)
                {
                    MessageBox.Show("Password must be more than 8 characters!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                this.usersBindingSource.EndEdit();

                try
                {
                    this.usersTableAdapter.Update(this.employeeSalaryMGDataSet.Users);
                }catch(SqlException ex) 
                {
                    MessageBox.Show("There might be due to some problem! try changing any value!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                //accept all changes into user data table
                this.employeeSalaryMGDataSet.Users.AcceptChanges(); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.CancelEdit();

            this.employeeSalaryMGDataSet.Users.RejectChanges(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.usersBindingSource.Count != 0)
            {
                var currentRow = this.usersBindingSource.Current as DataRowView;

                if (currentRow != null)
                {
                    var userRow = currentRow.Row as EmployeeSalaryMGDataSet.UsersRow;

                    var result = MessageBox.Show($"Are you sure to remove user with username {userRow.Username}?", "Confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        //validate two default users before delete from the database (admin, accountant)
                        if (userRow.Username.Equals("admin", StringComparison.OrdinalIgnoreCase) || 
                            userRow.Username.Equals("accountant", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("This user must not be allowed to remove! please consider another user!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }

                        this.usersBindingSource.RemoveCurrent(); 
                        this.usersBindingSource.EndEdit();

                        this.usersTableAdapter.Update(this.employeeSalaryMGDataSet.Users); 
                    }
                }
            }
        }

        private bool isShowPassword; 

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (isShowPassword)
            {
                passwordTextBox.PasswordChar = '\u25CF';
                passwordTextBox.Font = new Font("Khmer OS Siemreap", 5);
                passwordTextBox.AutoSize = false;
                passwordTextBox.Size = new Size(172, 33);
                isShowPassword = false;

                btnShowPassword.Image = Properties.Resources.icons8_hide_16px;
            }
            else
            {
                passwordTextBox.PasswordChar = '\0';
                passwordTextBox.Font = new Font("Khmer OS Siemreap", 11);
                passwordTextBox.AutoSize = false;
                passwordTextBox.Size = new Size(172, 33);
                isShowPassword = true;

                btnShowPassword.Image = Properties.Resources.icons8_eye_16px;
            }
        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }
    }
}
