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
        private RequestModel requestModel;
        private DonationModel donationModel;

        public View View { get => view; set => view = value; }
        internal RequestModel RequestModel { get => requestModel; set => requestModel = value; }
        internal DonationModel DonationModel { get => donationModel; set => donationModel = value; }

        #endregion


        public Controller() //Controller class constructor
        {
            View = new View(); //Initialize MainView to view passed from Program.cs
            RequestModel = new RequestModel(); //Initialize RequestModel
            DonationModel = new DonationModel(); //Initialize DonationModel
            View.AddListener(this, RequestModel, DonationModel); //Pass this Controller and Request to View
        }

        public void OnSubmitClick()
        {
            RequestModel.StoreRequest();
            RequestModel.ClearRequestModel();
        }

        public void OnLookUpClick()
        {
            RequestModel.PullStudentInfo();
               
        }
    }
}
