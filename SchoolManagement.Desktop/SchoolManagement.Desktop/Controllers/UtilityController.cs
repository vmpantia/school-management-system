using SchoolManagement.Desktop.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Desktop.Controllers
{
    public static class UtilityController
    {
        public static void LabelMouseEnter(object input)
        {
            ((Label)input).BackColor = CustomColor.BACKCOLOR_LABEL_MOUSE_ENTER;
            ((Label)input).ForeColor = Color.White;
        }

        public static void LabelMouseLeave(object input)
        {
            ((Label)input).BackColor = Color.WhiteSmoke; 
            ((Label)input).ForeColor = CustomColor.FORECOLOR_LABEL_MOUSE_LEAVE;
        }
    }
}
