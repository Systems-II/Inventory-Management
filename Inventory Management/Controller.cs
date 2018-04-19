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


        #region VARIABLES AND PROPERTIES

        private View view;
        private RequestModel request;

        public View View { get => view; set => view = value; }
        internal RequestModel Request { get => request; set => request = value; }

        #endregion


        public Controller() //Controller class constructor
        {
            View = new View(); //Initialize MainView to view passed from Program.cs
            Request = new RequestModel(); //Initialize Request
            View.AddListener(this, Request); //Pass this Controller and Request to View
        }

        public void OnSubmitClick()
        {
            Request.StoreRequest();
            Request.ClearRequestModel();
        }

        public void OnLookUpClick()
        {
            Request.PullStudentInfo();
               
        }
    }
}
