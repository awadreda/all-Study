using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemwidowsForm.Main;
using BankbusinessLayer;
//using BankSystemwidowsForm.

namespace BankSystemwidowsForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            if(UserBussinees.IsLoggedIn())
            {
                Global.CurrentUser = UserBussinees.FillUserLogedIN();
                Application.Run(new MainScreen());
            }
            else
            {
            Application.Run(new LoginScreen());

            }
            

            
        }
    }
}
