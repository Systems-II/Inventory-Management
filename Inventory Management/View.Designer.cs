namespace Inventory_Management
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.process1 = new System.Diagnostics.Process();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.lblDateFilled = new System.Windows.Forms.Label();
            this.lblDatePickedUp = new System.Windows.Forms.Label();
            this.dtpDateReceived = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFilled = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePickedUp = new System.Windows.Forms.DateTimePicker();
            this.txtTNumber = new System.Windows.Forms.TextBox();
            this.requestModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTNumber = new System.Windows.Forms.Label();
            this.lblFamilySize = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.btnLookUpStudent = new System.Windows.Forms.Button();
            this.nudFamilySize = new System.Windows.Forms.NumericUpDown();
            this.tabDonationRequest = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.donationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddToBatch = new System.Windows.Forms.Button();
            this.nudWeightDonated = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitItem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateDonationReceived = new System.Windows.Forms.Label();
            this.lblWeightDonated = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvDonations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requestModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFamilySize)).BeginInit();
            this.tabDonationRequest.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightDonated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).BeginInit();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Location = new System.Drawing.Point(292, 212);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(147, 13);
            this.lblDateReceived.TabIndex = 6;
            this.lblDateReceived.Text = "Date Request Was Received";
            // 
            // lblDateFilled
            // 
            this.lblDateFilled.AutoSize = true;
            this.lblDateFilled.Location = new System.Drawing.Point(292, 260);
            this.lblDateFilled.Name = "lblDateFilled";
            this.lblDateFilled.Size = new System.Drawing.Size(125, 13);
            this.lblDateFilled.TabIndex = 15;
            this.lblDateFilled.Text = "Date Request Was Filled";
            // 
            // lblDatePickedUp
            // 
            this.lblDatePickedUp.AutoSize = true;
            this.lblDatePickedUp.Location = new System.Drawing.Point(292, 308);
            this.lblDatePickedUp.Name = "lblDatePickedUp";
            this.lblDatePickedUp.Size = new System.Drawing.Size(151, 13);
            this.lblDatePickedUp.TabIndex = 18;
            this.lblDatePickedUp.Text = "Date Request Was Picked Up";
            // 
            // dtpDateReceived
            // 
            this.dtpDateReceived.Location = new System.Drawing.Point(296, 228);
            this.dtpDateReceived.Name = "dtpDateReceived";
            this.dtpDateReceived.Size = new System.Drawing.Size(200, 20);
            this.dtpDateReceived.TabIndex = 20;
            // 
            // dtpDateFilled
            // 
            this.dtpDateFilled.Location = new System.Drawing.Point(296, 275);
            this.dtpDateFilled.Name = "dtpDateFilled";
            this.dtpDateFilled.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFilled.TabIndex = 21;
            // 
            // dtpDatePickedUp
            // 
            this.dtpDatePickedUp.Location = new System.Drawing.Point(296, 323);
            this.dtpDatePickedUp.Name = "dtpDatePickedUp";
            this.dtpDatePickedUp.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePickedUp.TabIndex = 22;
            // 
            // txtTNumber
            // 
            this.txtTNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestModelBindingSource, "TNumber", true));
            this.txtTNumber.Location = new System.Drawing.Point(12, 33);
            this.txtTNumber.Name = "txtTNumber";
            this.txtTNumber.Size = new System.Drawing.Size(121, 20);
            this.txtTNumber.TabIndex = 23;
            // 
            // requestModelBindingSource
            // 
            this.requestModelBindingSource.DataSource = typeof(Inventory_Management.RequestModel);
            // 
            // lblTNumber
            // 
            this.lblTNumber.AutoSize = true;
            this.lblTNumber.Location = new System.Drawing.Point(10, 16);
            this.lblTNumber.Name = "lblTNumber";
            this.lblTNumber.Size = new System.Drawing.Size(101, 13);
            this.lblTNumber.TabIndex = 24;
            this.lblTNumber.Text = "Student\'s T-Number";
            // 
            // lblFamilySize
            // 
            this.lblFamilySize.AutoSize = true;
            this.lblFamilySize.Location = new System.Drawing.Point(293, 136);
            this.lblFamilySize.Name = "lblFamilySize";
            this.lblFamilySize.Size = new System.Drawing.Size(104, 13);
            this.lblFamilySize.TabIndex = 25;
            this.lblFamilySize.Text = "Family Size Provided";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(10, 154);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(271, 189);
            this.rtxtNotes.TabIndex = 32;
            this.rtxtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(10, 136);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 33;
            this.lblNotes.Text = "Notes";
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Location = new System.Drawing.Point(198, 349);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(97, 23);
            this.btnSubmitRequest.TabIndex = 34;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitClick);
            // 
            // btnLookUpStudent
            // 
            this.btnLookUpStudent.Location = new System.Drawing.Point(12, 58);
            this.btnLookUpStudent.Name = "btnLookUpStudent";
            this.btnLookUpStudent.Size = new System.Drawing.Size(97, 23);
            this.btnLookUpStudent.TabIndex = 38;
            this.btnLookUpStudent.Text = "Look Up Student";
            this.btnLookUpStudent.UseVisualStyleBackColor = true;
            this.btnLookUpStudent.Click += new System.EventHandler(this.btnLookUpStudentClick);
            // 
            // nudFamilySize
            // 
            this.nudFamilySize.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestModelBindingSource, "FamilySize", true));
            this.nudFamilySize.Location = new System.Drawing.Point(296, 153);
            this.nudFamilySize.Margin = new System.Windows.Forms.Padding(2);
            this.nudFamilySize.Name = "nudFamilySize";
            this.nudFamilySize.Size = new System.Drawing.Size(90, 20);
            this.nudFamilySize.TabIndex = 39;
            // 
            // tabDonationRequest
            // 
            this.tabDonationRequest.Controls.Add(this.tabPage1);
            this.tabDonationRequest.Controls.Add(this.tabPage2);
            this.tabDonationRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDonationRequest.Location = new System.Drawing.Point(0, 0);
            this.tabDonationRequest.Margin = new System.Windows.Forms.Padding(2);
            this.tabDonationRequest.Name = "tabDonationRequest";
            this.tabDonationRequest.SelectedIndex = 0;
            this.tabDonationRequest.Size = new System.Drawing.Size(507, 412);
            this.tabDonationRequest.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.lblTNumber);
            this.tabPage1.Controls.Add(this.txtTNumber);
            this.tabPage1.Controls.Add(this.btnLookUpStudent);
            this.tabPage1.Controls.Add(this.lblFamilySize);
            this.tabPage1.Controls.Add(this.nudFamilySize);
            this.tabPage1.Controls.Add(this.lblNotes);
            this.tabPage1.Controls.Add(this.rtxtNotes);
            this.tabPage1.Controls.Add(this.lblDateReceived);
            this.tabPage1.Controls.Add(this.dtpDateReceived);
            this.tabPage1.Controls.Add(this.lblDateFilled);
            this.tabPage1.Controls.Add(this.dtpDateFilled);
            this.tabPage1.Controls.Add(this.lblDatePickedUp);
            this.tabPage1.Controls.Add(this.dtpDatePickedUp);
            this.tabPage1.Controls.Add(this.btnSubmitRequest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(499, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.dgvDonations);
            this.tabPage2.Controls.Add(this.cbxCategory);
            this.tabPage2.Controls.Add(this.btnAddToBatch);
            this.tabPage2.Controls.Add(this.nudWeightDonated);
            this.tabPage2.Controls.Add(this.btnSubmitItem);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.lblDateDonationReceived);
            this.tabPage2.Controls.Add(this.lblWeightDonated);
            this.tabPage2.Controls.Add(this.lblCategory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(499, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // donationsBindingSource
            // 
            this.donationsBindingSource.DataSource = typeof(Inventory_Management.Donation);
            // 
            // cbxCategory
            // 
            this.cbxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.donationBindingSource, "Category", true));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(136, 8);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(196, 21);
            this.cbxCategory.TabIndex = 13;
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataSource = typeof(Inventory_Management.Donation);
            // 
            // btnAddToBatch
            // 
            this.btnAddToBatch.Location = new System.Drawing.Point(136, 83);
            this.btnAddToBatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToBatch.Name = "btnAddToBatch";
            this.btnAddToBatch.Size = new System.Drawing.Size(79, 19);
            this.btnAddToBatch.TabIndex = 12;
            this.btnAddToBatch.Text = "Add to Batch";
            this.btnAddToBatch.UseVisualStyleBackColor = true;
            this.btnAddToBatch.Click += new System.EventHandler(this.btnAddToBatch_Click);
            // 
            // nudWeightDonated
            // 
            this.nudWeightDonated.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donationBindingSource, "Weight", true));
            this.nudWeightDonated.Location = new System.Drawing.Point(136, 35);
            this.nudWeightDonated.Margin = new System.Windows.Forms.Padding(2);
            this.nudWeightDonated.Name = "nudWeightDonated";
            this.nudWeightDonated.Size = new System.Drawing.Size(79, 20);
            this.nudWeightDonated.TabIndex = 11;
            // 
            // btnSubmitItem
            // 
            this.btnSubmitItem.Location = new System.Drawing.Point(212, 363);
            this.btnSubmitItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitItem.Name = "btnSubmitItem";
            this.btnSubmitItem.Size = new System.Drawing.Size(79, 19);
            this.btnSubmitItem.TabIndex = 8;
            this.btnSubmitItem.Text = "Submit Batch";
            this.btnSubmitItem.UseVisualStyleBackColor = true;
            this.btnSubmitItem.Click += new System.EventHandler(this.btnSubmitItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donationBindingSource, "DateDonationReceived", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 59);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblDateDonationReceived
            // 
            this.lblDateDonationReceived.AutoSize = true;
            this.lblDateDonationReceived.Location = new System.Drawing.Point(7, 65);
            this.lblDateDonationReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDonationReceived.Name = "lblDateDonationReceived";
            this.lblDateDonationReceived.Size = new System.Drawing.Size(79, 13);
            this.lblDateDonationReceived.TabIndex = 6;
            this.lblDateDonationReceived.Text = "Date Received";
            // 
            // lblWeightDonated
            // 
            this.lblWeightDonated.AutoSize = true;
            this.lblWeightDonated.Location = new System.Drawing.Point(7, 38);
            this.lblWeightDonated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeightDonated.Name = "lblWeightDonated";
            this.lblWeightDonated.Size = new System.Drawing.Size(107, 13);
            this.lblWeightDonated.TabIndex = 4;
            this.lblWeightDonated.Text = "Weight Donated (lbs)";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 11);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // dgvDonations
            // 
            this.dgvDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonations.Location = new System.Drawing.Point(114, 163);
            this.dgvDonations.Name = "dgvDonations";
            this.dgvDonations.Size = new System.Drawing.Size(240, 150);
            this.dgvDonations.TabIndex = 14;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 412);
            this.Controls.Add(this.tabDonationRequest);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFamilySize)).EndInit();
            this.tabDonationRequest.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightDonated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.DateTimePicker dtpDateReceived;
        private System.Windows.Forms.Label lblDatePickedUp;
        private System.Windows.Forms.Label lblDateFilled;
        private System.Windows.Forms.Label lblTNumber;
        private System.Windows.Forms.TextBox txtTNumber;
        private System.Windows.Forms.DateTimePicker dtpDatePickedUp;
        private System.Windows.Forms.DateTimePicker dtpDateFilled;
        private System.Windows.Forms.Label lblFamilySize;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Button btnLookUpStudent;
        private System.Windows.Forms.BindingSource requestModelBindingSource;
        private System.Windows.Forms.NumericUpDown nudFamilySize;
        private System.Windows.Forms.TabControl tabDonationRequest;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblWeightDonated;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateDonationReceived;
        private System.Windows.Forms.Button btnSubmitItem;
        private System.Windows.Forms.NumericUpDown nudWeightDonated;
        private System.Windows.Forms.Button btnAddToBatch;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.BindingSource donationsBindingSource;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private System.Windows.Forms.DataGridView dgvDonations;
    }
}

