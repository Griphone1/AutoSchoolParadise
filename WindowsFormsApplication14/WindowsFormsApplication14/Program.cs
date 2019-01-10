using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication14
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
            //Application.Run(new Form4());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            Thread Test1 = new Thread(() => Application.Run(new MainMenuForm()));
            Thread Test2 = new Thread(() => Application.Run(new RegistrationForm()));
            Thread Test3 = new Thread(() => Application.Run(new PersonalAccountForm()));
            Thread Test4 = new Thread(() => Application.Run(new ScheduleForm()));
            Thread Test5 = new Thread(() => Application.Run(new InfoForm()));
            Test1.Start();
            
            Console.WriteLine();

        }
    }
}
