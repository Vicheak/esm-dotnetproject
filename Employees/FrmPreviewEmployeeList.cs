using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryMGProj.Employees
{
    public partial class FrmPreviewEmployeeList : Form
    {
        public FrmPreviewEmployeeList()
        {
            InitializeComponent();
        }

        private void FrmPreviewEmployeeList_Load(object sender, EventArgs e)
        {
            this.TopMost = true; 

            this.vEmployeeDetailTableAdapter.Fill(this.employeeSalaryMGDataSet.VEmployeeDetail);

            this.reportViewer1.RefreshReport();
        }
    }
}
