using Fastfood_Kiosk_V0.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Views.AddingCategoryView());
            Application.Run(new Views.LoginView());
        }
    }
}
