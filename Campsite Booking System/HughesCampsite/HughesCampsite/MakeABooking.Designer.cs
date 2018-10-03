namespace HughesCampsite
{
    partial class MakeABooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeABooking));
            this.lblMakeABookingStaffDetails = new System.Windows.Forms.Label();
            this.grpCheckAvailability = new System.Windows.Forms.GroupBox();
            this.lblMakeABookingCapacity = new System.Windows.Forms.Label();
            this.comboCapacity = new System.Windows.Forms.ComboBox();
            this.btnMakeABookingCA = new System.Windows.Forms.Button();
            this.comboMakeABookingType = new System.Windows.Forms.ComboBox();
            this.lblMainABookingCAEndDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMakeABookingCAstartDate = new System.Windows.Forms.Label();
            this.dtpMakeABookingCAEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMakeABookingCAStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblCabinNo = new System.Windows.Forms.Label();
            this.grpMakeABooking = new System.Windows.Forms.GroupBox();
            this.btnMakeABookingGetAQuote = new System.Windows.Forms.Button();
            this.comboMakeABookingCabinNo = new System.Windows.Forms.ComboBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.txtMakeABookingChildren = new System.Windows.Forms.TextBox();
            this.txtMakeABookingAdults = new System.Windows.Forms.TextBox();
            this.lblMakeABookingAdults = new System.Windows.Forms.Label();
            this.lblQuotePrice = new System.Windows.Forms.Label();
            this.btnMakeABookingBook = new System.Windows.Forms.Button();
            this.grpMakeABookingSelectCustomer = new System.Windows.Forms.GroupBox();
            this.btnMakeABookingAddCustomer = new System.Windows.Forms.Button();
            this.lblMakeABookingDOB = new System.Windows.Forms.Label();
            this.lblMakeABookingLastName = new System.Windows.Forms.Label();
            this.txtMakeABookingLastName = new System.Windows.Forms.TextBox();
            this.dtpMakeABookingDOB = new System.Windows.Forms.DateTimePicker();
            this.dgvMakeABookingCustomerAccount = new System.Windows.Forms.DataGridView();
            this.btnMakeABookingPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMakeABookingCustIDSelected = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnAboutUs = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLock = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExitProgram = new System.Windows.Forms.ToolStripButton();
            this.lblMakeABookingPage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpCheckAvailability.SuspendLayout();
            this.grpMakeABooking.SuspendLayout();
            this.grpMakeABookingSelectCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakeABookingCustomerAccount)).BeginInit();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMakeABookingStaffDetails
            // 
            this.lblMakeABookingStaffDetails.AutoSize = true;
            this.lblMakeABookingStaffDetails.Location = new System.Drawing.Point(12, 9);
            this.lblMakeABookingStaffDetails.Name = "lblMakeABookingStaffDetails";
            this.lblMakeABookingStaffDetails.Size = new System.Drawing.Size(0, 13);
            this.lblMakeABookingStaffDetails.TabIndex = 0;
            // 
            // grpCheckAvailability
            // 
            this.grpCheckAvailability.Controls.Add(this.lblMakeABookingCapacity);
            this.grpCheckAvailability.Controls.Add(this.comboCapacity);
            this.grpCheckAvailability.Controls.Add(this.btnMakeABookingCA);
            this.grpCheckAvailability.Controls.Add(this.comboMakeABookingType);
            this.grpCheckAvailability.Controls.Add(this.lblMainABookingCAEndDate);
            this.grpCheckAvailability.Controls.Add(this.lblType);
            this.grpCheckAvailability.Controls.Add(this.lblMakeABookingCAstartDate);
            this.grpCheckAvailability.Controls.Add(this.dtpMakeABookingCAEndDate);
            this.grpCheckAvailability.Controls.Add(this.dtpMakeABookingCAStartDate);
            this.grpCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheckAvailability.Location = new System.Drawing.Point(12, 38);
            this.grpCheckAvailability.Name = "grpCheckAvailability";
            this.grpCheckAvailability.Size = new System.Drawing.Size(301, 189);
            this.grpCheckAvailability.TabIndex = 1;
            this.grpCheckAvailability.TabStop = false;
            this.grpCheckAvailability.Text = "Step 1: Select a Cabin Type and Dates";
            // 
            // lblMakeABookingCapacity
            // 
            this.lblMakeABookingCapacity.AutoSize = true;
            this.lblMakeABookingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeABookingCapacity.Location = new System.Drawing.Point(9, 46);
            this.lblMakeABookingCapacity.Name = "lblMakeABookingCapacity";
            this.lblMakeABookingCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblMakeABookingCapacity.TabIndex = 11;
            this.lblMakeABookingCapacity.Text = "Capacity:";
            // 
            // comboCapacity
            // 
            this.comboCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCapacity.FormattingEnabled = true;
            this.comboCapacity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboCapacity.Location = new System.Drawing.Point(113, 46);
            this.comboCapacity.Name = "comboCapacity";
            this.comboCapacity.Size = new System.Drawing.Size(98, 21);
            this.comboCapacity.TabIndex = 2;
            this.comboCapacity.SelectedIndexChanged += new System.EventHandler(this.stepOneComboUpdates);
            // 
            // btnMakeABookingCA
            // 
            this.btnMakeABookingCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeABookingCA.Location = new System.Drawing.Point(187, 149);
            this.btnMakeABookingCA.Name = "btnMakeABookingCA";
            this.btnMakeABookingCA.Size = new System.Drawing.Size(108, 23);
            this.btnMakeABookingCA.TabIndex = 5;
            this.btnMakeABookingCA.Text = "Check Availability";
            this.btnMakeABookingCA.UseVisualStyleBackColor = true;
            this.btnMakeABookingCA.Click += new System.EventHandler(this.btnMakeABookingCA_Click);
            // 
            // comboMakeABookingType
            // 
            this.comboMakeABookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMakeABookingType.FormattingEnabled = true;
            this.comboMakeABookingType.Items.AddRange(new object[] {
            "Master",
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.comboMakeABookingType.Location = new System.Drawing.Point(113, 19);
            this.comboMakeABookingType.Name = "comboMakeABookingType";
            this.comboMakeABookingType.Size = new System.Drawing.Size(100, 21);
            this.comboMakeABookingType.TabIndex = 1;
            this.comboMakeABookingType.SelectedIndexChanged += new System.EventHandler(this.stepOneComboUpdates);
            // 
            // lblMainABookingCAEndDate
            // 
            this.lblMainABookingCAEndDate.AutoSize = true;
            this.lblMainABookingCAEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainABookingCAEndDate.Location = new System.Drawing.Point(6, 123);
            this.lblMainABookingCAEndDate.Name = "lblMainABookingCAEndDate";
            this.lblMainABookingCAEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblMainABookingCAEndDate.TabIndex = 3;
            this.lblMainABookingCAEndDate.Text = "End Date:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(9, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type:";
            // 
            // lblMakeABookingCAstartDate
            // 
            this.lblMakeABookingCAstartDate.AutoSize = true;
            this.lblMakeABookingCAstartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeABookingCAstartDate.Location = new System.Drawing.Point(6, 77);
            this.lblMakeABookingCAstartDate.Name = "lblMakeABookingCAstartDate";
            this.lblMakeABookingCAstartDate.Size = new System.Drawing.Size(58, 13);
            this.lblMakeABookingCAstartDate.TabIndex = 2;
            this.lblMakeABookingCAstartDate.Text = "Start Date:";
            // 
            // dtpMakeABookingCAEndDate
            // 
            this.dtpMakeABookingCAEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMakeABookingCAEndDate.Location = new System.Drawing.Point(113, 123);
            this.dtpMakeABookingCAEndDate.Name = "dtpMakeABookingCAEndDate";
            this.dtpMakeABookingCAEndDate.Size = new System.Drawing.Size(182, 20);
            this.dtpMakeABookingCAEndDate.TabIndex = 4;
            this.dtpMakeABookingCAEndDate.ValueChanged += new System.EventHandler(this.stepOneComboUpdates);
            // 
            // dtpMakeABookingCAStartDate
            // 
            this.dtpMakeABookingCAStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMakeABookingCAStartDate.Location = new System.Drawing.Point(113, 77);
            this.dtpMakeABookingCAStartDate.Name = "dtpMakeABookingCAStartDate";
            this.dtpMakeABookingCAStartDate.Size = new System.Drawing.Size(182, 20);
            this.dtpMakeABookingCAStartDate.TabIndex = 3;
            this.dtpMakeABookingCAStartDate.ValueChanged += new System.EventHandler(this.stepOneComboUpdates);
            // 
            // lblCabinNo
            // 
            this.lblCabinNo.AutoSize = true;
            this.lblCabinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinNo.Location = new System.Drawing.Point(32, 43);
            this.lblCabinNo.Name = "lblCabinNo";
            this.lblCabinNo.Size = new System.Drawing.Size(51, 13);
            this.lblCabinNo.TabIndex = 3;
            this.lblCabinNo.Text = "CabinNo:";
            // 
            // grpMakeABooking
            // 
            this.grpMakeABooking.Controls.Add(this.btnMakeABookingGetAQuote);
            this.grpMakeABooking.Controls.Add(this.comboMakeABookingCabinNo);
            this.grpMakeABooking.Controls.Add(this.lblChildren);
            this.grpMakeABooking.Controls.Add(this.txtMakeABookingChildren);
            this.grpMakeABooking.Controls.Add(this.txtMakeABookingAdults);
            this.grpMakeABooking.Controls.Add(this.lblMakeABookingAdults);
            this.grpMakeABooking.Controls.Add(this.lblCabinNo);
            this.grpMakeABooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMakeABooking.Location = new System.Drawing.Point(12, 233);
            this.grpMakeABooking.Name = "grpMakeABooking";
            this.grpMakeABooking.Size = new System.Drawing.Size(301, 194);
            this.grpMakeABooking.TabIndex = 2;
            this.grpMakeABooking.TabStop = false;
            this.grpMakeABooking.Text = "Step 2: Input Group Details";
            this.grpMakeABooking.Visible = false;
            this.grpMakeABooking.Leave += new System.EventHandler(this.stepTwoComboUpdates);
            // 
            // btnMakeABookingGetAQuote
            // 
            this.btnMakeABookingGetAQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeABookingGetAQuote.Location = new System.Drawing.Point(208, 158);
            this.btnMakeABookingGetAQuote.Name = "btnMakeABookingGetAQuote";
            this.btnMakeABookingGetAQuote.Size = new System.Drawing.Size(75, 23);
            this.btnMakeABookingGetAQuote.TabIndex = 4;
            this.btnMakeABookingGetAQuote.Text = "Get Quote";
            this.btnMakeABookingGetAQuote.UseVisualStyleBackColor = true;
            this.btnMakeABookingGetAQuote.Click += new System.EventHandler(this.btnMakeABookingGetAQuote_Click);
            // 
            // comboMakeABookingCabinNo
            // 
            this.comboMakeABookingCabinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMakeABookingCabinNo.FormattingEnabled = true;
            this.comboMakeABookingCabinNo.Location = new System.Drawing.Point(136, 43);
            this.comboMakeABookingCabinNo.Name = "comboMakeABookingCabinNo";
            this.comboMakeABookingCabinNo.Size = new System.Drawing.Size(100, 21);
            this.comboMakeABookingCabinNo.TabIndex = 1;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(31, 123);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(48, 13);
            this.lblChildren.TabIndex = 7;
            this.lblChildren.Text = "Children:";
            // 
            // txtMakeABookingChildren
            // 
            this.txtMakeABookingChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakeABookingChildren.Location = new System.Drawing.Point(136, 123);
            this.txtMakeABookingChildren.Name = "txtMakeABookingChildren";
            this.txtMakeABookingChildren.Size = new System.Drawing.Size(100, 20);
            this.txtMakeABookingChildren.TabIndex = 3;
            // 
            // txtMakeABookingAdults
            // 
            this.txtMakeABookingAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakeABookingAdults.Location = new System.Drawing.Point(136, 97);
            this.txtMakeABookingAdults.Name = "txtMakeABookingAdults";
            this.txtMakeABookingAdults.Size = new System.Drawing.Size(100, 20);
            this.txtMakeABookingAdults.TabIndex = 2;
            // 
            // lblMakeABookingAdults
            // 
            this.lblMakeABookingAdults.AutoSize = true;
            this.lblMakeABookingAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeABookingAdults.Location = new System.Drawing.Point(32, 97);
            this.lblMakeABookingAdults.Name = "lblMakeABookingAdults";
            this.lblMakeABookingAdults.Size = new System.Drawing.Size(39, 13);
            this.lblMakeABookingAdults.TabIndex = 4;
            this.lblMakeABookingAdults.Text = "Adults:";
            // 
            // lblQuotePrice
            // 
            this.lblQuotePrice.AutoSize = true;
            this.lblQuotePrice.Location = new System.Drawing.Point(232, 430);
            this.lblQuotePrice.Name = "lblQuotePrice";
            this.lblQuotePrice.Size = new System.Drawing.Size(0, 13);
            this.lblQuotePrice.TabIndex = 5;
            // 
            // btnMakeABookingBook
            // 
            this.btnMakeABookingBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeABookingBook.Location = new System.Drawing.Point(145, 71);
            this.btnMakeABookingBook.Name = "btnMakeABookingBook";
            this.btnMakeABookingBook.Size = new System.Drawing.Size(138, 23);
            this.btnMakeABookingBook.TabIndex = 3;
            this.btnMakeABookingBook.Text = "Find Customer";
            this.btnMakeABookingBook.UseVisualStyleBackColor = true;
            this.btnMakeABookingBook.Click += new System.EventHandler(this.btnMakeABookingBook_Click);
            // 
            // grpMakeABookingSelectCustomer
            // 
            this.grpMakeABookingSelectCustomer.Controls.Add(this.btnMakeABookingAddCustomer);
            this.grpMakeABookingSelectCustomer.Controls.Add(this.lblMakeABookingDOB);
            this.grpMakeABookingSelectCustomer.Controls.Add(this.lblMakeABookingLastName);
            this.grpMakeABookingSelectCustomer.Controls.Add(this.txtMakeABookingLastName);
            this.grpMakeABookingSelectCustomer.Controls.Add(this.dtpMakeABookingDOB);
            this.grpMakeABookingSelectCustomer.Controls.Add(this.btnMakeABookingBook);
            this.grpMakeABookingSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMakeABookingSelectCustomer.Location = new System.Drawing.Point(12, 449);
            this.grpMakeABookingSelectCustomer.Name = "grpMakeABookingSelectCustomer";
            this.grpMakeABookingSelectCustomer.Size = new System.Drawing.Size(301, 138);
            this.grpMakeABookingSelectCustomer.TabIndex = 3;
            this.grpMakeABookingSelectCustomer.TabStop = false;
            this.grpMakeABookingSelectCustomer.Text = "Step 3:  Select Customer Details";
            this.grpMakeABookingSelectCustomer.Visible = false;
            // 
            // btnMakeABookingAddCustomer
            // 
            this.btnMakeABookingAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeABookingAddCustomer.Location = new System.Drawing.Point(145, 100);
            this.btnMakeABookingAddCustomer.Name = "btnMakeABookingAddCustomer";
            this.btnMakeABookingAddCustomer.Size = new System.Drawing.Size(138, 23);
            this.btnMakeABookingAddCustomer.TabIndex = 4;
            this.btnMakeABookingAddCustomer.Text = "New Customer";
            this.btnMakeABookingAddCustomer.UseVisualStyleBackColor = true;
            this.btnMakeABookingAddCustomer.Click += new System.EventHandler(this.btnMakeABookingAddCustomer_Click);
            // 
            // lblMakeABookingDOB
            // 
            this.lblMakeABookingDOB.AutoSize = true;
            this.lblMakeABookingDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeABookingDOB.Location = new System.Drawing.Point(25, 45);
            this.lblMakeABookingDOB.Name = "lblMakeABookingDOB";
            this.lblMakeABookingDOB.Size = new System.Drawing.Size(71, 13);
            this.lblMakeABookingDOB.TabIndex = 11;
            this.lblMakeABookingDOB.Text = "Date Of Birth:";
            // 
            // lblMakeABookingLastName
            // 
            this.lblMakeABookingLastName.AutoSize = true;
            this.lblMakeABookingLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeABookingLastName.Location = new System.Drawing.Point(25, 19);
            this.lblMakeABookingLastName.Name = "lblMakeABookingLastName";
            this.lblMakeABookingLastName.Size = new System.Drawing.Size(61, 13);
            this.lblMakeABookingLastName.TabIndex = 10;
            this.lblMakeABookingLastName.Text = "Last Name:";
            // 
            // txtMakeABookingLastName
            // 
            this.txtMakeABookingLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakeABookingLastName.Location = new System.Drawing.Point(136, 19);
            this.txtMakeABookingLastName.Name = "txtMakeABookingLastName";
            this.txtMakeABookingLastName.Size = new System.Drawing.Size(100, 20);
            this.txtMakeABookingLastName.TabIndex = 1;
            // 
            // dtpMakeABookingDOB
            // 
            this.dtpMakeABookingDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMakeABookingDOB.Location = new System.Drawing.Point(136, 45);
            this.dtpMakeABookingDOB.Name = "dtpMakeABookingDOB";
            this.dtpMakeABookingDOB.Size = new System.Drawing.Size(159, 20);
            this.dtpMakeABookingDOB.TabIndex = 2;
            // 
            // dgvMakeABookingCustomerAccount
            // 
            this.dgvMakeABookingCustomerAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMakeABookingCustomerAccount.Location = new System.Drawing.Point(357, 449);
            this.dgvMakeABookingCustomerAccount.Name = "dgvMakeABookingCustomerAccount";
            this.dgvMakeABookingCustomerAccount.Size = new System.Drawing.Size(561, 123);
            this.dgvMakeABookingCustomerAccount.TabIndex = 8;
            this.dgvMakeABookingCustomerAccount.TabStop = false;
            this.dgvMakeABookingCustomerAccount.Visible = false;
            this.dgvMakeABookingCustomerAccount.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMakeABookingCustomerAccount_RowHeaderMouseClick);
            // 
            // btnMakeABookingPay
            // 
            this.btnMakeABookingPay.Location = new System.Drawing.Point(247, 619);
            this.btnMakeABookingPay.Name = "btnMakeABookingPay";
            this.btnMakeABookingPay.Size = new System.Drawing.Size(75, 23);
            this.btnMakeABookingPay.TabIndex = 4;
            this.btnMakeABookingPay.Text = "Pay";
            this.btnMakeABookingPay.UseVisualStyleBackColor = true;
            this.btnMakeABookingPay.Visible = false;
            this.btnMakeABookingPay.Click += new System.EventHandler(this.btnMakeABookingPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.txtBack_Click);
            // 
            // lblMakeABookingCustIDSelected
            // 
            this.lblMakeABookingCustIDSelected.AutoSize = true;
            this.lblMakeABookingCustIDSelected.Location = new System.Drawing.Point(163, 590);
            this.lblMakeABookingCustIDSelected.Name = "lblMakeABookingCustIDSelected";
            this.lblMakeABookingCustIDSelected.Size = new System.Drawing.Size(0, 13);
            this.lblMakeABookingCustIDSelected.TabIndex = 12;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripBtnAboutUs,
            this.toolStripBtnHelp,
            this.toolStripBtnSettings,
            this.toolStripBtnLock,
            this.toolStripBtnLogOut,
            this.toolStripBtnExitProgram});
            this.toolStripMain.Location = new System.Drawing.Point(989, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(87, 654);
            this.toolStripMain.TabIndex = 22;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 15);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripBtnAboutUs
            // 
            this.toolStripBtnAboutUs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAboutUs.Image")));
            this.toolStripBtnAboutUs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAboutUs.Name = "toolStripBtnAboutUs";
            this.toolStripBtnAboutUs.Size = new System.Drawing.Size(84, 19);
            this.toolStripBtnAboutUs.Text = "About Us";
            // 
            // toolStripBtnHelp
            // 
            this.toolStripBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHelp.Image")));
            this.toolStripBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHelp.Name = "toolStripBtnHelp";
            this.toolStripBtnHelp.Size = new System.Drawing.Size(84, 19);
            this.toolStripBtnHelp.Text = "Help";
            // 
            // toolStripBtnSettings
            // 
            this.toolStripBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSettings.Image")));
            this.toolStripBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSettings.Name = "toolStripBtnSettings";
            this.toolStripBtnSettings.Size = new System.Drawing.Size(84, 19);
            this.toolStripBtnSettings.Text = "Settings";
            // 
            // toolStripBtnLock
            // 
            this.toolStripBtnLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnLock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLock.Image")));
            this.toolStripBtnLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLock.Name = "toolStripBtnLock";
            this.toolStripBtnLock.Size = new System.Drawing.Size(84, 19);
            this.toolStripBtnLock.Text = "Lock";
            // 
            // toolStripBtnLogOut
            // 
            this.toolStripBtnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLogOut.Image")));
            this.toolStripBtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLogOut.Name = "toolStripBtnLogOut";
            this.toolStripBtnLogOut.Size = new System.Drawing.Size(84, 19);
            this.toolStripBtnLogOut.Text = "Log Out";
            // 
            // toolStripBtnExitProgram
            // 
            this.toolStripBtnExitProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnExitProgram.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExitProgram.Image")));
            this.toolStripBtnExitProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExitProgram.Name = "toolStripBtnExitProgram";
            this.toolStripBtnExitProgram.Size = new System.Drawing.Size(84, 19);
            this.toolStripBtnExitProgram.Text = "Exit Program";
            // 
            // lblMakeABookingPage
            // 
            this.lblMakeABookingPage.AutoSize = true;
            this.lblMakeABookingPage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeABookingPage.Location = new System.Drawing.Point(12, 9);
            this.lblMakeABookingPage.Name = "lblMakeABookingPage";
            this.lblMakeABookingPage.Size = new System.Drawing.Size(138, 19);
            this.lblMakeABookingPage.TabIndex = 28;
            this.lblMakeABookingPage.Tag = "P1";
            this.lblMakeABookingPage.Text = "NEW BOOKING";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HughesCampsite.Properties.Resources.Hughes_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(725, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 119);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // MakeABooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 654);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblMakeABookingPage);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.lblMakeABookingCustIDSelected);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMakeABookingPay);
            this.Controls.Add(this.dgvMakeABookingCustomerAccount);
            this.Controls.Add(this.grpMakeABookingSelectCustomer);
            this.Controls.Add(this.lblQuotePrice);
            this.Controls.Add(this.grpMakeABooking);
            this.Controls.Add(this.grpCheckAvailability);
            this.Controls.Add(this.lblMakeABookingStaffDetails);
            this.Name = "MakeABooking";
            this.Text = "Make A Booking";
            this.Load += new System.EventHandler(this.MakeABooking_Load);
            this.grpCheckAvailability.ResumeLayout(false);
            this.grpCheckAvailability.PerformLayout();
            this.grpMakeABooking.ResumeLayout(false);
            this.grpMakeABooking.PerformLayout();
            this.grpMakeABookingSelectCustomer.ResumeLayout(false);
            this.grpMakeABookingSelectCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakeABookingCustomerAccount)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakeABookingStaffDetails;
        private System.Windows.Forms.GroupBox grpCheckAvailability;
        private System.Windows.Forms.Button btnMakeABookingCA;
        private System.Windows.Forms.Label lblMainABookingCAEndDate;
        private System.Windows.Forms.Label lblMakeABookingCAstartDate;
        private System.Windows.Forms.DateTimePicker dtpMakeABookingCAEndDate;
        private System.Windows.Forms.DateTimePicker dtpMakeABookingCAStartDate;
        private System.Windows.Forms.Label lblCabinNo;
        private System.Windows.Forms.GroupBox grpMakeABooking;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.TextBox txtMakeABookingChildren;
        private System.Windows.Forms.TextBox txtMakeABookingAdults;
        private System.Windows.Forms.Label lblMakeABookingAdults;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboMakeABookingType;
        private System.Windows.Forms.ComboBox comboMakeABookingCabinNo;
        private System.Windows.Forms.Button btnMakeABookingGetAQuote;
        private System.Windows.Forms.Label lblMakeABookingCapacity;
        private System.Windows.Forms.ComboBox comboCapacity;
        private System.Windows.Forms.Label lblQuotePrice;
        private System.Windows.Forms.Button btnMakeABookingBook;
        private System.Windows.Forms.GroupBox grpMakeABookingSelectCustomer;
        private System.Windows.Forms.Label lblMakeABookingDOB;
        private System.Windows.Forms.Label lblMakeABookingLastName;
        private System.Windows.Forms.TextBox txtMakeABookingLastName;
        private System.Windows.Forms.DateTimePicker dtpMakeABookingDOB;
        private System.Windows.Forms.DataGridView dgvMakeABookingCustomerAccount;
        private System.Windows.Forms.Button btnMakeABookingAddCustomer;
        private System.Windows.Forms.Button btnMakeABookingPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMakeABookingCustIDSelected;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAboutUs;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripBtnSettings;
        private System.Windows.Forms.ToolStripButton toolStripBtnLock;
        private System.Windows.Forms.ToolStripButton toolStripBtnLogOut;
        private System.Windows.Forms.ToolStripButton toolStripBtnExitProgram;
        private System.Windows.Forms.Label lblMakeABookingPage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}