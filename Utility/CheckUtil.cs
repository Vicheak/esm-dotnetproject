using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMGProj.Utility
{
    internal class CheckUtil
    {

        public static bool CheckValidInput(TextBox textBox, string sourceInput)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                MessageBox.Show($"Please fill in {sourceInput}!", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox.Focus(); 
                return false; 
            }
            return true; 
        }

    }
}
