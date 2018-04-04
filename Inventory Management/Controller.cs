﻿using System;
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
            View.AddListener(this); //Pass this Controller to View
            Request = new RequestModel(); //Initialize Request
        }

        public void OnSubmitClick()
        {
            request.GetDBConnection();
        }


    }
}
