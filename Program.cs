using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Teleavtomatika_Form_Validation
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var frm = new frmMain2())
            {
                frm.ShowDialog();
            }
        }
    }
}
