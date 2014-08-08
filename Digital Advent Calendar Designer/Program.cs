using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace Digital_Advent_Calendar_Designer
{

    /// <summary>
    /// The main class of the application. 
    /// </summary>
    static class Program
    {

        public const int NUM_DOORS = 25;

        public const double SCALE_FACTOR = 0.25;

        /// <summary>
        /// The application reference variable from Main.dll. 
        /// </summary>
        public static App App = new App("Digital Advent Calendar Designer");

        /// <summary>
        /// The application's executable directory. 
        /// </summary>
        public static String ExecutableDirectory
        {
            get
            {
                return Utils.QualifyDirectory(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\") + 1));
            }
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // The following two commands are required from the system. 
            // Enable visual stypes for the application. 
            Application.EnableVisualStyles();
            // Set the text rendering default. 
            Application.SetCompatibleTextRenderingDefault(false);

            // Open the main window. 
            Application.Run(new FormMain());
        }
    }
}
