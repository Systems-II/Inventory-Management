using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    static class Program
    {

        //this is the bestest test comment

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller controller = new Controller(); //Declare and initialize the Controller
            Application.Run(controller.View); //Run the application/Show the view by passing Run function the View from controller 
        }
    }
}
