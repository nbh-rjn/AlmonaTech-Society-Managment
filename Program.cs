using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmonaTech_Society_Managment
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
            //Application.Run(new LoginSignup());

            System.Drawing.Icon appIcon = AlmonaTech_Society_Managment.Properties.Resources.logo_ico; // Replace "YourIconName" with the name of your icon resource

            // Run the main form with the default icon
            Application.Run(new LoginSignup() { Icon = appIcon });

          
        }
    }
}
