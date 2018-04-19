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

        private RequestModel request;

        internal RequestModel Request { get => request; set => request = value; }

        public void AddListener(Controller controller, RequestModel request)
        {
            this.controller = controller;
            Request = request;
            requestModelBindingSource.DataSource = request;
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

        private void UpdateTNumber()
        {
            txtTNumber.Text = Request.TNumber;
        }

        private void UpdateFamilySize()
        {
            nudFamilySize.Value = Request.FamilySize;
        }

        private void UpdateNotes()
        {
            rtxtNotes.Text = Request.Notes;
        }

        private void UpdateDates()
        {
            dtpDateReceived.Value = Request.DateRequested;
            dtpDateFilled.Value = Request.DateFilled;
            dtpDatePickedUp.Value = Request.DatePickedUp;
        }
    }
}
