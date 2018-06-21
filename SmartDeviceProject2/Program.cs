using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Tsmt
{
    static class Program
    {

        [DllImport("coredll.Dll")]
        public static extern IntPtr FindWindow(String classname, String title);
        [DllImport("coredll.Dll")]
        public static extern void SetForegroundWindow(IntPtr hwnd);

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            IntPtr hDlg = IntPtr.Zero;
            hDlg = FindWindow(null, "仓库管理系统");//ThisWindows:应用程序主窗体  
            if (hDlg != IntPtr.Zero)
            {
                SetForegroundWindow(hDlg);
            }
            else
            {
                Application.Run(new Login());

            }           
        }

    }
}