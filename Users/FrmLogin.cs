using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalaryMGProj.Utility; 

namespace EmployeeSalaryMGProj.Users
{
    public partial class FrmLogin : Form
    {
        public EmployeeSalaryMGDataSet.UsersRow userRow { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();

            passwordTextBox.PasswordChar = '\u25CF';
            passwordTextBox.Font = new Font("Khmer OS Siemreap", 7);
            passwordTextBox.AutoSize = false;
            passwordTextBox.Size = new Size(293, 33);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //authenticate valid username and password 
            if(CheckUtil.CheckValidInput(usernameTextBox, "Username") &&
                CheckUtil.CheckValidInput(passwordTextBox, "Password"))
            {
                string username = usernameTextBox.Text.Trim(); 
                string password = passwordTextBox.Text.Trim();

                var userDataTable = this.usersTableAdapter.GetDataByUsernamePassword(username, password); 

                if(userDataTable.Count > 0)
                {
                    userRow = userDataTable[0]; 

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Not a valid account! try again!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    userRow = null; 
                }
            }
        }

        private bool isShowPassword;

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (isShowPassword)
            {
                passwordTextBox.PasswordChar = '\u25CF';
                passwordTextBox.Font = new Font("Khmer OS Siemreap", 7);
                passwordTextBox.AutoSize = false;
                passwordTextBox.Size = new Size(293, 33);
                isShowPassword = false;

                btnShowPassword.Image = Properties.Resources.icons8_hide_16px;
            }
            else
            {
                passwordTextBox.PasswordChar = '\0';
                passwordTextBox.Font = new Font("Khmer OS Siemreap", 11);
                passwordTextBox.AutoSize = false;
                passwordTextBox.Size = new Size(293, 33);
                isShowPassword = true;

                btnShowPassword.Image = Properties.Resources.icons8_eye_16px;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
