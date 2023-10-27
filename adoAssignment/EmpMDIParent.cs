using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoAssignment
{
    public partial class EmpMDIParent : Form
    {
        public EmpMDIParent()
        {
            InitializeComponent();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new EmployeeDetails();
            form.Show();
        }

        private void manageDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ManageDept();
            form.Show();
        }
    }
}
