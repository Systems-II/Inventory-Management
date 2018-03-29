using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    class Controller
    {
        View mainView;
        RequestModel request;

        public Controller(View view)
        {
            MainView = view;
            Request = new RequestModel();
        }

        public View MainView { get => mainView; set => mainView = value; }
        internal RequestModel Request { get => request; set => request = value; }

    }
}
