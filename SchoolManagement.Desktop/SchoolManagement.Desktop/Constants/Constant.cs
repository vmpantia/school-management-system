using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.Constants
{
    public class ConstantString
    {
        public const string TITLE_NEW_STUDENT = "New Student Information";
        public const string DESCRIPTION_NEW_STUDENT = "This page you can insert all the information of the Student that's needed for the system";
        public const string TITLE_EDIT_STUDENT = "Edit Student Information";
        public const string DESCRIPTION_EDIT_STUDENT = "This page you can edit/update all the information of the Student";
    }

    public static class CustomString
    {
        public static string SYS_VER { get { return string.Concat("ver. ", DateTime.Now.ToString("yyyy.MM.dd")); } }
    }

    public static class CustomColor
    {
        public static Color COLOR_EDIT { get { return Color.FromArgb(241, 196, 15); } }
        public static Color COLOR_NEW { get { return Color.FromArgb(52, 152, 219); } }
        public static Color BACKCOLOR_LABEL_MOUSE_ENTER { get { return Color.FromArgb(60, 60, 60); } }
        public static Color FORECOLOR_LABEL_MOUSE_LEAVE { get { return Color.FromArgb(40, 40, 40); } }

    }
}
