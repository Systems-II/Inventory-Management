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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblWeightDonated = new System.Windows.Forms.Label();
            this.lblDateDonationReceived = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitItem = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxItemName = new System.Windows.Forms.ComboBox();
            this.nudWeightDonated = new System.Windows.Forms.NumericUpDown();
            this.requestModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToBatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFamilySize)).BeginInit();
            this.tabDonationRequest.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightDonated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).BeginInit();
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
            this.lblDateReceived.Location = new System.Drawing.Point(390, 261);
            this.lblDateReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(190, 17);
            this.lblDateReceived.TabIndex = 6;
            this.lblDateReceived.Text = "Date Request Was Received";
            // 
            // lblDateFilled
            // 
            this.lblDateFilled.AutoSize = true;
            this.lblDateFilled.Location = new System.Drawing.Point(390, 320);
            this.lblDateFilled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFilled.Name = "lblDateFilled";
            this.lblDateFilled.Size = new System.Drawing.Size(164, 17);
            this.lblDateFilled.TabIndex = 15;
            this.lblDateFilled.Text = "Date Request Was Filled";
            // 
            // lblDatePickedUp
            // 
            this.lblDatePickedUp.AutoSize = true;
            this.lblDatePickedUp.Location = new System.Drawing.Point(390, 379);
            this.lblDatePickedUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatePickedUp.Name = "lblDatePickedUp";
            this.lblDatePickedUp.Size = new System.Drawing.Size(195, 17);
            this.lblDatePickedUp.TabIndex = 18;
            this.lblDatePickedUp.Text = "Date Request Was Picked Up";
            // 
            // dtpDateReceived
            // 
            this.dtpDateReceived.Location = new System.Drawing.Point(394, 280);
            this.dtpDateReceived.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateReceived.Name = "dtpDateReceived";
            this.dtpDateReceived.Size = new System.Drawing.Size(265, 22);
            this.dtpDateReceived.TabIndex = 20;
            // 
            // dtpDateFilled
            // 
            this.dtpDateFilled.Location = new System.Drawing.Point(394, 339);
            this.dtpDateFilled.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateFilled.Name = "dtpDateFilled";
            this.dtpDateFilled.Size = new System.Drawing.Size(265, 22);
            this.dtpDateFilled.TabIndex = 21;
            // 
            // dtpDatePickedUp
            // 
            this.dtpDatePickedUp.Location = new System.Drawing.Point(394, 398);
            this.dtpDatePickedUp.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatePickedUp.Name = "dtpDatePickedUp";
            this.dtpDatePickedUp.Size = new System.Drawing.Size(265, 22);
            this.dtpDatePickedUp.TabIndex = 22;
            // 
            // txtTNumber
            // 
            this.txtTNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestModelBindingSource, "TNumber", true));
            this.txtTNumber.Location = new System.Drawing.Point(16, 41);
            this.txtTNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtTNumber.Name = "txtTNumber";
            this.txtTNumber.Size = new System.Drawing.Size(160, 22);
            this.txtTNumber.TabIndex = 23;
            // 
            // lblTNumber
            // 
            this.lblTNumber.AutoSize = true;
            this.lblTNumber.Location = new System.Drawing.Point(13, 20);
            this.lblTNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTNumber.Name = "lblTNumber";
            this.lblTNumber.Size = new System.Drawing.Size(135, 17);
            this.lblTNumber.TabIndex = 24;
            this.lblTNumber.Text = "Student\'s T-Number";
            // 
            // lblFamilySize
            // 
            this.lblFamilySize.AutoSize = true;
            this.lblFamilySize.Location = new System.Drawing.Point(391, 168);
            this.lblFamilySize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFamilySize.Name = "lblFamilySize";
            this.lblFamilySize.Size = new System.Drawing.Size(139, 17);
            this.lblFamilySize.TabIndex = 25;
            this.lblFamilySize.Text = "Family Size Provided";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestModelBindingSource, "Notes", true));
            this.rtxtNotes.Location = new System.Drawing.Point(13, 189);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(360, 232);
            this.rtxtNotes.TabIndex = 32;
            this.rtxtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(13, 168);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(45, 17);
            this.lblNotes.TabIndex = 33;
            this.lblNotes.Text = "Notes";
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Location = new System.Drawing.Point(264, 429);
            this.btnSubmitRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(129, 28);
            this.btnSubmitRequest.TabIndex = 34;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitClick);
            // 
            // btnLookUpStudent
            // 
            this.btnLookUpStudent.Location = new System.Drawing.Point(16, 71);
            this.btnLookUpStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnLookUpStudent.Name = "btnLookUpStudent";
            this.btnLookUpStudent.Size = new System.Drawing.Size(129, 28);
            this.btnLookUpStudent.TabIndex = 38;
            this.btnLookUpStudent.Text = "Look Up Student";
            this.btnLookUpStudent.UseVisualStyleBackColor = true;
            this.btnLookUpStudent.Click += new System.EventHandler(this.btnLookUpStudentClick);
            // 
            // nudFamilySize
            // 
            this.nudFamilySize.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestModelBindingSource, "FamilySize", true));
            this.nudFamilySize.Location = new System.Drawing.Point(394, 188);
            this.nudFamilySize.Name = "nudFamilySize";
            this.nudFamilySize.Size = new System.Drawing.Size(120, 22);
            this.nudFamilySize.TabIndex = 39;
            // 
            // tabDonationRequest
            // 
            this.tabDonationRequest.Controls.Add(this.tabPage1);
            this.tabDonationRequest.Controls.Add(this.tabPage2);
            this.tabDonationRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDonationRequest.Location = new System.Drawing.Point(0, 0);
            this.tabDonationRequest.Name = "tabDonationRequest";
            this.tabDonationRequest.SelectedIndex = 0;
            this.tabDonationRequest.Size = new System.Drawing.Size(676, 507);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.btnAddToBatch);
            this.tabPage2.Controls.Add(this.donationDataGridView);
            this.tabPage2.Controls.Add(this.nudWeightDonated);
            this.tabPage2.Controls.Add(this.cbxItemName);
            this.tabPage2.Controls.Add(this.cbxCategory);
            this.tabPage2.Controls.Add(this.btnSubmitItem);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.lblDateDonationReceived);
            this.tabPage2.Controls.Add(this.lblWeightDonated);
            this.tabPage2.Controls.Add(this.lblItemName);
            this.tabPage2.Controls.Add(this.lblCategory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(8, 14);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(8, 47);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(75, 17);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            // 
            // lblWeightDonated
            // 
            this.lblWeightDonated.AutoSize = true;
            this.lblWeightDonated.Location = new System.Drawing.Point(8, 80);
            this.lblWeightDonated.Name = "lblWeightDonated";
            this.lblWeightDonated.Size = new System.Drawing.Size(142, 17);
            this.lblWeightDonated.TabIndex = 4;
            this.lblWeightDonated.Text = "Weight Donated (lbs)";
            // 
            // lblDateDonationReceived
            // 
            this.lblDateDonationReceived.AutoSize = true;
            this.lblDateDonationReceived.Location = new System.Drawing.Point(8, 113);
            this.lblDateDonationReceived.Name = "lblDateDonationReceived";
            this.lblDateDonationReceived.Size = new System.Drawing.Size(101, 17);
            this.lblDateDonationReceived.TabIndex = 6;
            this.lblDateDonationReceived.Text = "Date Received";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnSubmitItem
            // 
            this.btnSubmitItem.Location = new System.Drawing.Point(282, 447);
            this.btnSubmitItem.Name = "btnSubmitItem";
            this.btnSubmitItem.Size = new System.Drawing.Size(105, 23);
            this.btnSubmitItem.TabIndex = 8;
            this.btnSubmitItem.Text = "Submit Batch";
            this.btnSubmitItem.UseVisualStyleBackColor = true;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(180, 11);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(201, 24);
            this.cbxCategory.TabIndex = 9;
            // 
            // cbxItemName
            // 
            this.cbxItemName.FormattingEnabled = true;
            this.cbxItemName.Location = new System.Drawing.Point(180, 44);
            this.cbxItemName.Name = "cbxItemName";
            this.cbxItemName.Size = new System.Drawing.Size(201, 24);
            this.cbxItemName.TabIndex = 10;
            // 
            // nudWeightDonated
            // 
            this.nudWeightDonated.Location = new System.Drawing.Point(180, 78);
            this.nudWeightDonated.Name = "nudWeightDonated";
            this.nudWeightDonated.Size = new System.Drawing.Size(77, 22);
            this.nudWeightDonated.TabIndex = 11;
            // 
            // requestModelBindingSource
            // 
            this.requestModelBindingSource.DataSource = typeof(Inventory_Management.RequestModel);
            // 
            // donationModelBindingSource
            // 
            this.donationModelBindingSource.DataSource = typeof(Inventory_Management.DonationModel);
            // 
            // donationsBindingSource
            // 
            this.donationsBindingSource.DataMember = "Donations";
            this.donationsBindingSource.DataSource = this.donationModelBindingSource;
            // 
            // donationDataGridView
            // 
            this.donationDataGridView.AutoGenerateColumns = false;
            this.donationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.donationDataGridView.DataSource = this.donationsBindingSource;
            this.donationDataGridView.Location = new System.Drawing.Point(11, 175);
            this.donationDataGridView.Name = "donationDataGridView";
            this.donationDataGridView.RowTemplate.Height = 24;
            this.donationDataGridView.Size = new System.Drawing.Size(642, 264);
            this.donationDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn1.HeaderText = "Category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateDonationReceived1";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateDonationReceived1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnAddToBatch
            // 
            this.btnAddToBatch.Location = new System.Drawing.Point(180, 146);
            this.btnAddToBatch.Name = "btnAddToBatch";
            this.btnAddToBatch.Size = new System.Drawing.Size(105, 23);
            this.btnAddToBatch.TabIndex = 12;
            this.btnAddToBatch.Text = "Add to Batch";
            this.btnAddToBatch.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 507);
            this.Controls.Add(this.tabDonationRequest);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFamilySize)).EndInit();
            this.tabDonationRequest.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightDonated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).EndInit();
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
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateDonationReceived;
        private System.Windows.Forms.Button btnSubmitItem;
        private System.Windows.Forms.NumericUpDown nudWeightDonated;
        private System.Windows.Forms.ComboBox cbxItemName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.BindingSource donationModelBindingSource;
        private System.Windows.Forms.DataGridView donationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource donationsBindingSource;
        private System.Windows.Forms.Button btnAddToBatch;
    }
}

