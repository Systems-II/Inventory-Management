using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public class Controller
    {
        View mainView;

        public Controller()
        {
            MainView = new View(this);
        }

        public Form showView()
        {
            MainView.Show();
            return MainView;
        }

        public View MainView { get => mainView; set => mainView = value; }
    }
}
