using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuShiX
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmLogin());
            //Application.Run(new FrmEmployee("NV0020"));

            //Application.Run(new FrmManager("NV0000"));
            //Application.Run(new FrmCreateAndReissueCard());
            //Application.Run(new FrmPromotionManagement("NV0000"));

        }
    }
}