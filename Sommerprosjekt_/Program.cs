using System;
using System.Windows.Forms;

namespace Sommerprosjekt_
{
    internal static class Program
    {
        
        public class Foo
        {
            //global variables to display the correct header and section from form 1 in form 2
            public static string header = "";
            public static string section = ""; 
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
