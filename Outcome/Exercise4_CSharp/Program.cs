#region Using Directives
using System;
using System.Windows.Forms;
#endregion Using Directives

namespace Exercise4_CSharp
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
            Application.Run(new FrmFileExtensions());
        } // end main
    } // end static class Program
} // end namespace Exercise4_CSharp