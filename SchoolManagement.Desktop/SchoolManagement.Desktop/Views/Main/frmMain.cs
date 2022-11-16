using SchoolManagement.Desktop.Constants;
using SchoolManagement.Desktop.Controllers;
using SchoolManagement.Desktop.Views.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lblSystemVersion.Text = CustomString.SYS_VER;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            var form = new frmStudentInformation()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            pnlContent.Controls.Add(form);
            form.Show();
        }

        private void LabelMouseEnter(object sender, EventArgs e)
        {
            UtilityController.LabelMouseEnter(sender);
        }

        private void LabelMouseLeave(object sender, EventArgs e)
        {
            UtilityController.LabelMouseLeave(sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
