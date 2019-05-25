using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsDemo
{
    public static class WinformsUtil
    {
        public static void MessageBoxShow(string text)
        {
            MessageBox.Show(text);
        }
        public static void MessageBoxShow(string format, params object[] args)
        {
            MessageBox.Show(string.Format(format, args));
        }
    }
}