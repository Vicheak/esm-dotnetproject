using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMGProj.SalaryPayments
{
    public partial class UserControlSalaryGross : UserControl
    {
        public EmployeeSalaryMGDataSet.GrossSalariesRow grossSalariesRow { get; }

        public UserControlSalaryGross(EmployeeSalaryMGDataSet.GrossSalariesRow grossSalariesRow)
        {
            InitializeComponent();
            this.grossSalariesRow = grossSalariesRow; 
        }

        private void UserControlSalaryGross_Load(object sender, EventArgs e)
        { 
            if(grossSalariesRow == null)
            {
                MessageBox.Show("Gross Salary is empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            lblGrossSalaryName.Text = grossSalariesRow.Name;
            lblAmount.Text = grossSalariesRow.Amount.ToString("C4"); 
        }
    }
}
