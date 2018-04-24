using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.Account;
using MyApp.Authorization;
using MyApp.Labs;
using MyApp.Tests;
using MyApp.Theory;

namespace MyApp
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
            Application.Run(new AuthorizationForm());
            //Application.Run(new TheoryForm());
            //Application.Run(new LabsForm());


        }
    }
}
