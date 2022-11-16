using SchoolManagement.Desktop.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Desktop.Views.Student
{
    public partial class frmStudentInformation : Form
    {
        public frmStudentInformation(bool IsNew = true)
        {
            InitializeComponent();

            lblTitle.Text = IsNew ? ConstantString.TITLE_NEW_STUDENT : ConstantString.TITLE_EDIT_STUDENT;
            lblTitleDescription.Text = IsNew ? ConstantString.DESCRIPTION_NEW_STUDENT : ConstantString.DESCRIPTION_EDIT_STUDENT;
        }
    }
}
