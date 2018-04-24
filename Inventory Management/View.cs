using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    partial class View : Form
    {
        private Controller controller;

        public View()
        {
            InitializeComponent();
        }

        private RequestModel requestModel;
        private DonationModel donationModel;

        internal RequestModel RequestModel { get => requestModel; set => requestModel = value; }
        internal DonationModel DonationModel { get => donationModel; set => donationModel = value; }

        public void AddListener(Controller controller, RequestModel requestModel, DonationModel donationModel)
        {
            this.controller = controller;
            RequestModel = requestModel;
            DonationModel = donationModel;
            requestModelBindingSource.DataSource = requestModel;
            donationsBindingSource.DataSource = donationModel.Donations;
            donationBindingSource.DataSource = donationModel.Donation;
            cbxCategory.DataSource = donationModel.Categories;
            dgvDonations.DataSource = donationModel.Donations;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        #region REQUEST HANDLERS AND FUNCTIONS

        #region HANDLERS
        private void btnSubmitClick(object sender, EventArgs e)
        {
            controller.OnSubmitClick();
            UpdateTNumber();
            UpdateFamilySize();
            UpdateNotes();
        }

        private void btnLookUpStudentClick(object sender, EventArgs e)
        {
            controller.OnLookUpClick();
            UpdateFamilySize();
            UpdateNotes();
        }

        #endregion

        #region FUNCTIONS
        private void UpdateTNumber()
        {
            txtTNumber.Text = RequestModel.TNumber;
        }

        private void UpdateFamilySize()
        {
            nudFamilySize.Value = RequestModel.FamilySize;
        }

        private void UpdateNotes()
        {
            rtxtNotes.Text = RequestModel.Notes;
        }

        private void UpdateDates()
        {
            dtpDateReceived.Value = RequestModel.DateRequested;
            dtpDateFilled.Value = RequestModel.DateFilled;
            dtpDatePickedUp.Value = RequestModel.DatePickedUp;
        }

        #endregion

        #endregion

        #region DONATION HANDLERS AND FUNCTIONS

        #region HANDLERS    

        private void btnSubmitItem_Click(object sender, EventArgs e)
        {
            DonationModel.StoreDonations();
        }
        private void btnAddToBatch_Click(object sender, EventArgs e)
        {
            DonationModel.AddDonationToDonations();
            dgvDonations.DataSource = DonationModel.Donations;
            dgvDonations.Refresh();
        }

        #endregion

        #region FUNCTIONS



        #endregion

        #endregion

    }
}
