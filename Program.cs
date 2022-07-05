using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MKS_SERVO42C_CONTROL
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern void SetProcessDPIAware();


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // support High DPI
            SetProcessDPIAware();

            //
            Application.Run(new FrmMain());
        }
    }
}
