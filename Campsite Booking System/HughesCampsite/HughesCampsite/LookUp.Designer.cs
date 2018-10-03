namespace HughesCampsite
{
    partial class LookUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUp));
            this.lblStaffDetails = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.radioCustomer = new System.Windows.Forms.RadioButton();
            this.dtpCustomerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerDOB = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBooking = new System.Windows.Forms.RadioButton();
            this.lblBookingEndDate = new System.Windows.Forms.Label();
            this.lblBookingStartDate = new System.Windows.Forms.Label();
            this.dtpBookingEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingStartDate = new System.Windows.Forms.DateTimePicker();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.radioPayments = new System.Windows.Forms.RadioButton();
            this.lblPaymentCardNumber = new System.Windows.Forms.Label();
            this.lblPaymentNameOnCard = new System.Windows.Forms.Label();
            this.txtPaymentCardNumber = new System.Windows.Forms.TextBox();
            this.txtPaymentNameOnCard = new System.Windows.Forms.TextBox();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.radioStaff = new System.Windows.Forms.RadioButton();
            this.lblStaffDOB = new System.Windows.Forms.Label();
            this.lblStaffLastName = new System.Windows.Forms.Label();
            this.dtpStaffDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtStaffLastName = new System.Windows.Forms.TextBox();
            this.grpCabin = new System.Windows.Forms.GroupBox();
            this.radioCabin = new System.Windows.Forms.RadioButton();
            this.lblCabinType = new System.Windows.Forms.Label();
            this.comboCabinType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearchs = new System.Windows.Forms.DataGridView();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.btnShowBooking = new System.Windows.Forms.Button();
            this.btnShowPayment = new System.Windows.Forms.Button();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.btnShowCabin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnableEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEditingIsEnabled = new System.Windows.Forms.Label();
            this.lblChangesSaved = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnAboutUs = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLock = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExitProgram = new System.Windows.Forms.ToolStripButton();
            this.lblLookUpPage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDownRecord = new System.Windows.Forms.Button();
            this.btnUpRecord = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpStaff.SuspendLayout();
            this.grpCabin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchs)).BeginInit();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffDetails
            // 
            this.lblStaffDetails.AutoSize = true;
            this.lblStaffDetails.Location = new System.Drawing.Point(12, 9);
            this.lblStaffDetails.Name = "lblStaffDetails";
            this.lblStaffDetails.Size = new System.Drawing.Size(0, 13);
            this.lblStaffDetails.TabIndex = 0;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.radioCustomer);
            this.grpCustomer.Controls.Add(this.dtpCustomerDOB);
            this.grpCustomer.Controls.Add(this.txtCustomerLastName);
            this.grpCustomer.Controls.Add(this.lblCustomerDOB);
            this.grpCustomer.Controls.Add(this.lblCustomerLastName);
            this.grpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(12, 67);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(200, 145);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Table";
            // 
            // radioCustomer
            // 
            this.radioCustomer.AutoCheck = false;
            this.radioCustomer.AutoSize = true;
            this.radioCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCustomer.Location = new System.Drawing.Point(109, 122);
            this.radioCustomer.Name = "radioCustomer";
            this.radioCustomer.Size = new System.Drawing.Size(55, 17);
            this.radioCustomer.TabIndex = 2;
            this.radioCustomer.Text = "Select";
            this.radioCustomer.UseVisualStyleBackColor = true;
            this.radioCustomer.Click += new System.EventHandler(this.radioButtons);
            // 
            // dtpCustomerDOB
            // 
            this.dtpCustomerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustomerDOB.Location = new System.Drawing.Point(75, 43);
            this.dtpCustomerDOB.Name = "dtpCustomerDOB";
            this.dtpCustomerDOB.Size = new System.Drawing.Size(119, 20);
            this.dtpCustomerDOB.TabIndex = 1;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLastName.Location = new System.Drawing.Point(75, 16);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(119, 20);
            this.txtCustomerLastName.TabIndex = 0;
            // 
            // lblCustomerDOB
            // 
            this.lblCustomerDOB.AutoSize = true;
            this.lblCustomerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDOB.Location = new System.Drawing.Point(6, 49);
            this.lblCustomerDOB.Name = "lblCustomerDOB";
            this.lblCustomerDOB.Size = new System.Drawing.Size(71, 13);
            this.lblCustomerDOB.TabIndex = 4;
            this.lblCustomerDOB.Text = "Date Of Birth:";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLastName.Location = new System.Drawing.Point(6, 23);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(61, 13);
            this.lblCustomerLastName.TabIndex = 4;
            this.lblCustomerLastName.Text = "Last Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBooking);
            this.groupBox2.Controls.Add(this.lblBookingEndDate);
            this.groupBox2.Controls.Add(this.lblBookingStartDate);
            this.groupBox2.Controls.Add(this.dtpBookingEndDate);
            this.groupBox2.Controls.Add(this.dtpBookingStartDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(218, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Table";
            // 
            // radioBooking
            // 
            this.radioBooking.AutoCheck = false;
            this.radioBooking.AutoSize = true;
            this.radioBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBooking.Location = new System.Drawing.Point(109, 122);
            this.radioBooking.Name = "radioBooking";
            this.radioBooking.Size = new System.Drawing.Size(55, 17);
            this.radioBooking.TabIndex = 5;
            this.radioBooking.Text = "Select";
            this.radioBooking.UseVisualStyleBackColor = true;
            this.radioBooking.Click += new System.EventHandler(this.radioButtons);
            // 
            // lblBookingEndDate
            // 
            this.lblBookingEndDate.AutoSize = true;
            this.lblBookingEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingEndDate.Location = new System.Drawing.Point(6, 50);
            this.lblBookingEndDate.Name = "lblBookingEndDate";
            this.lblBookingEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblBookingEndDate.TabIndex = 8;
            this.lblBookingEndDate.Text = "End Date:";
            // 
            // lblBookingStartDate
            // 
            this.lblBookingStartDate.AutoSize = true;
            this.lblBookingStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingStartDate.Location = new System.Drawing.Point(6, 26);
            this.lblBookingStartDate.Name = "lblBookingStartDate";
            this.lblBookingStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblBookingStartDate.TabIndex = 8;
            this.lblBookingStartDate.Text = "Start Date:";
            // 
            // dtpBookingEndDate
            // 
            this.dtpBookingEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingEndDate.Location = new System.Drawing.Point(77, 42);
            this.dtpBookingEndDate.Name = "dtpBookingEndDate";
            this.dtpBookingEndDate.Size = new System.Drawing.Size(117, 20);
            this.dtpBookingEndDate.TabIndex = 4;
            // 
            // dtpBookingStartDate
            // 
            this.dtpBookingStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingStartDate.Location = new System.Drawing.Point(77, 19);
            this.dtpBookingStartDate.Name = "dtpBookingStartDate";
            this.dtpBookingStartDate.Size = new System.Drawing.Size(117, 20);
            this.dtpBookingStartDate.TabIndex = 3;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.radioPayments);
            this.grpPayment.Controls.Add(this.lblPaymentCardNumber);
            this.grpPayment.Controls.Add(this.lblPaymentNameOnCard);
            this.grpPayment.Controls.Add(this.txtPaymentCardNumber);
            this.grpPayment.Controls.Add(this.txtPaymentNameOnCard);
            this.grpPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.Location = new System.Drawing.Point(424, 67);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(200, 145);
            this.grpPayment.TabIndex = 6;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payments Table";
            // 
            // radioPayments
            // 
            this.radioPayments.AutoCheck = false;
            this.radioPayments.AutoSize = true;
            this.radioPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPayments.Location = new System.Drawing.Point(109, 122);
            this.radioPayments.Name = "radioPayments";
            this.radioPayments.Size = new System.Drawing.Size(55, 17);
            this.radioPayments.TabIndex = 8;
            this.radioPayments.Text = "Select";
            this.radioPayments.UseVisualStyleBackColor = true;
            this.radioPayments.Click += new System.EventHandler(this.radioButtons);
            // 
            // lblPaymentCardNumber
            // 
            this.lblPaymentCardNumber.AutoSize = true;
            this.lblPaymentCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentCardNumber.Location = new System.Drawing.Point(6, 50);
            this.lblPaymentCardNumber.Name = "lblPaymentCardNumber";
            this.lblPaymentCardNumber.Size = new System.Drawing.Size(72, 13);
            this.lblPaymentCardNumber.TabIndex = 8;
            this.lblPaymentCardNumber.Text = "Card Number:";
            // 
            // lblPaymentNameOnCard
            // 
            this.lblPaymentNameOnCard.AutoSize = true;
            this.lblPaymentNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentNameOnCard.Location = new System.Drawing.Point(6, 26);
            this.lblPaymentNameOnCard.Name = "lblPaymentNameOnCard";
            this.lblPaymentNameOnCard.Size = new System.Drawing.Size(80, 13);
            this.lblPaymentNameOnCard.TabIndex = 8;
            this.lblPaymentNameOnCard.Text = "Name On Card:";
            // 
            // txtPaymentCardNumber
            // 
            this.txtPaymentCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentCardNumber.Location = new System.Drawing.Point(94, 42);
            this.txtPaymentCardNumber.Name = "txtPaymentCardNumber";
            this.txtPaymentCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentCardNumber.TabIndex = 7;
            // 
            // txtPaymentNameOnCard
            // 
            this.txtPaymentNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentNameOnCard.Location = new System.Drawing.Point(94, 19);
            this.txtPaymentNameOnCard.Name = "txtPaymentNameOnCard";
            this.txtPaymentNameOnCard.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentNameOnCard.TabIndex = 6;
            // 
            // grpStaff
            // 
            this.grpStaff.Controls.Add(this.radioStaff);
            this.grpStaff.Controls.Add(this.lblStaffDOB);
            this.grpStaff.Controls.Add(this.lblStaffLastName);
            this.grpStaff.Controls.Add(this.dtpStaffDateOfBirth);
            this.grpStaff.Controls.Add(this.txtStaffLastName);
            this.grpStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaff.Location = new System.Drawing.Point(630, 67);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Size = new System.Drawing.Size(200, 145);
            this.grpStaff.TabIndex = 9;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Staff Table";
            // 
            // radioStaff
            // 
            this.radioStaff.AutoCheck = false;
            this.radioStaff.AutoSize = true;
            this.radioStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStaff.Location = new System.Drawing.Point(109, 122);
            this.radioStaff.Name = "radioStaff";
            this.radioStaff.Size = new System.Drawing.Size(55, 17);
            this.radioStaff.TabIndex = 11;
            this.radioStaff.Text = "Select";
            this.radioStaff.UseVisualStyleBackColor = true;
            this.radioStaff.Click += new System.EventHandler(this.radioButtons);
            // 
            // lblStaffDOB
            // 
            this.lblStaffDOB.AutoSize = true;
            this.lblStaffDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffDOB.Location = new System.Drawing.Point(6, 50);
            this.lblStaffDOB.Name = "lblStaffDOB";
            this.lblStaffDOB.Size = new System.Drawing.Size(71, 13);
            this.lblStaffDOB.TabIndex = 8;
            this.lblStaffDOB.Text = "Date Of Birth:";
            // 
            // lblStaffLastName
            // 
            this.lblStaffLastName.AutoSize = true;
            this.lblStaffLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLastName.Location = new System.Drawing.Point(6, 26);
            this.lblStaffLastName.Name = "lblStaffLastName";
            this.lblStaffLastName.Size = new System.Drawing.Size(61, 13);
            this.lblStaffLastName.TabIndex = 10;
            this.lblStaffLastName.Text = "Last Name:";
            // 
            // dtpStaffDateOfBirth
            // 
            this.dtpStaffDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStaffDateOfBirth.Location = new System.Drawing.Point(77, 43);
            this.dtpStaffDateOfBirth.Name = "dtpStaffDateOfBirth";
            this.dtpStaffDateOfBirth.Size = new System.Drawing.Size(117, 20);
            this.dtpStaffDateOfBirth.TabIndex = 10;
            // 
            // txtStaffLastName
            // 
            this.txtStaffLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffLastName.Location = new System.Drawing.Point(77, 19);
            this.txtStaffLastName.Name = "txtStaffLastName";
            this.txtStaffLastName.Size = new System.Drawing.Size(117, 20);
            this.txtStaffLastName.TabIndex = 9;
            // 
            // grpCabin
            // 
            this.grpCabin.Controls.Add(this.radioCabin);
            this.grpCabin.Controls.Add(this.lblCabinType);
            this.grpCabin.Controls.Add(this.comboCabinType);
            this.grpCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCabin.Location = new System.Drawing.Point(836, 67);
            this.grpCabin.Name = "grpCabin";
            this.grpCabin.Size = new System.Drawing.Size(200, 145);
            this.grpCabin.TabIndex = 12;
            this.grpCabin.TabStop = false;
            this.grpCabin.Text = "Cabin Table";
            // 
            // radioCabin
            // 
            this.radioCabin.AutoCheck = false;
            this.radioCabin.AutoSize = true;
            this.radioCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCabin.Location = new System.Drawing.Point(109, 122);
            this.radioCabin.Name = "radioCabin";
            this.radioCabin.Size = new System.Drawing.Size(55, 17);
            this.radioCabin.TabIndex = 13;
            this.radioCabin.Text = "Select";
            this.radioCabin.UseVisualStyleBackColor = true;
            this.radioCabin.Click += new System.EventHandler(this.radioButtons);
            // 
            // lblCabinType
            // 
            this.lblCabinType.AutoSize = true;
            this.lblCabinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinType.Location = new System.Drawing.Point(6, 25);
            this.lblCabinType.Name = "lblCabinType";
            this.lblCabinType.Size = new System.Drawing.Size(34, 13);
            this.lblCabinType.TabIndex = 8;
            this.lblCabinType.Text = "Type:";
            // 
            // comboCabinType
            // 
            this.comboCabinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCabinType.FormattingEnabled = true;
            this.comboCabinType.Items.AddRange(new object[] {
            "Master",
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.comboCabinType.Location = new System.Drawing.Point(73, 23);
            this.comboCabinType.Name = "comboCabinType";
            this.comboCabinType.Size = new System.Drawing.Size(121, 21);
            this.comboCabinType.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(961, 218);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearchs
            // 
            this.dgvSearchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchs.Location = new System.Drawing.Point(12, 257);
            this.dgvSearchs.Name = "dgvSearchs";
            this.dgvSearchs.ReadOnly = true;
            this.dgvSearchs.Size = new System.Drawing.Size(1312, 165);
            this.dgvSearchs.TabIndex = 8;
            this.dgvSearchs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchs_CellValueChanged);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.Location = new System.Drawing.Point(412, 428);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(120, 23);
            this.btnShowCustomer.TabIndex = 15;
            this.btnShowCustomer.Text = "Show Customer";
            this.btnShowCustomer.UseVisualStyleBackColor = true;
            this.btnShowCustomer.Click += new System.EventHandler(this.showButtons);
            // 
            // btnShowBooking
            // 
            this.btnShowBooking.Location = new System.Drawing.Point(538, 428);
            this.btnShowBooking.Name = "btnShowBooking";
            this.btnShowBooking.Size = new System.Drawing.Size(120, 23);
            this.btnShowBooking.TabIndex = 16;
            this.btnShowBooking.Text = "Show Booking";
            this.btnShowBooking.UseVisualStyleBackColor = true;
            this.btnShowBooking.Click += new System.EventHandler(this.showButtons);
            // 
            // btnShowPayment
            // 
            this.btnShowPayment.Location = new System.Drawing.Point(664, 428);
            this.btnShowPayment.Name = "btnShowPayment";
            this.btnShowPayment.Size = new System.Drawing.Size(120, 23);
            this.btnShowPayment.TabIndex = 17;
            this.btnShowPayment.Text = "Show Payment";
            this.btnShowPayment.UseVisualStyleBackColor = true;
            this.btnShowPayment.Click += new System.EventHandler(this.showButtons);
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Location = new System.Drawing.Point(790, 428);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(120, 23);
            this.btnShowStaff.TabIndex = 18;
            this.btnShowStaff.Text = "Show Staff";
            this.btnShowStaff.UseVisualStyleBackColor = true;
            this.btnShowStaff.Click += new System.EventHandler(this.showButtons);
            // 
            // btnShowCabin
            // 
            this.btnShowCabin.Location = new System.Drawing.Point(916, 428);
            this.btnShowCabin.Name = "btnShowCabin";
            this.btnShowCabin.Size = new System.Drawing.Size(120, 23);
            this.btnShowCabin.TabIndex = 19;
            this.btnShowCabin.Text = "Show Cabin";
            this.btnShowCabin.UseVisualStyleBackColor = true;
            this.btnShowCabin.Click += new System.EventHandler(this.showButtons);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(916, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnableEdit
            // 
            this.btnEnableEdit.Location = new System.Drawing.Point(790, 457);
            this.btnEnableEdit.Name = "btnEnableEdit";
            this.btnEnableEdit.Size = new System.Drawing.Size(120, 23);
            this.btnEnableEdit.TabIndex = 20;
            this.btnEnableEdit.Text = "Enable Editing";
            this.btnEnableEdit.UseVisualStyleBackColor = true;
            this.btnEnableEdit.Click += new System.EventHandler(this.btnEnableEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1042, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // lblEditingIsEnabled
            // 
            this.lblEditingIsEnabled.AutoSize = true;
            this.lblEditingIsEnabled.Location = new System.Drawing.Point(1330, 258);
            this.lblEditingIsEnabled.Name = "lblEditingIsEnabled";
            this.lblEditingIsEnabled.Size = new System.Drawing.Size(104, 13);
            this.lblEditingIsEnabled.TabIndex = 18;
            this.lblEditingIsEnabled.Text = "EDITING ENABLED";
            this.lblEditingIsEnabled.Visible = false;
            // 
            // lblChangesSaved
            // 
            this.lblChangesSaved.AutoSize = true;
            this.lblChangesSaved.Location = new System.Drawing.Point(1330, 271);
            this.lblChangesSaved.Name = "lblChangesSaved";
            this.lblChangesSaved.Size = new System.Drawing.Size(84, 13);
            this.lblChangesSaved.TabIndex = 19;
            this.lblChangesSaved.Text = "Changes saved:";
            this.lblChangesSaved.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 609);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1330, 287);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.toolStripMain.Location = new System.Drawing.Point(1440, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(87, 644);
            this.toolStripMain.TabIndex = 24;
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
            // lblLookUpPage
            // 
            this.lblLookUpPage.AutoSize = true;
            this.lblLookUpPage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookUpPage.Location = new System.Drawing.Point(12, 9);
            this.lblLookUpPage.Name = "lblLookUpPage";
            this.lblLookUpPage.Size = new System.Drawing.Size(77, 19);
            this.lblLookUpPage.TabIndex = 28;
            this.lblLookUpPage.Tag = "P1";
            this.lblLookUpPage.Text = "SEARCH";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::HughesCampsite.Properties.Resources.Hughes_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(1169, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 119);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnDownRecord
            // 
            this.btnDownRecord.Location = new System.Drawing.Point(12, 457);
            this.btnDownRecord.Name = "btnDownRecord";
            this.btnDownRecord.Size = new System.Drawing.Size(101, 23);
            this.btnDownRecord.TabIndex = 30;
            this.btnDownRecord.Text = "Down record";
            this.btnDownRecord.UseVisualStyleBackColor = true;
            this.btnDownRecord.Click += new System.EventHandler(this.btnDownRecord_Click);
            // 
            // btnUpRecord
            // 
            this.btnUpRecord.Location = new System.Drawing.Point(12, 428);
            this.btnUpRecord.Name = "btnUpRecord";
            this.btnUpRecord.Size = new System.Drawing.Size(101, 23);
            this.btnUpRecord.TabIndex = 31;
            this.btnUpRecord.Text = "Up record";
            this.btnUpRecord.UseVisualStyleBackColor = true;
            this.btnUpRecord.Click += new System.EventHandler(this.btnUpRecord_Click);
            // 
            // LookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 644);
            this.Controls.Add(this.btnUpRecord);
            this.Controls.Add(this.btnDownRecord);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblLookUpPage);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblChangesSaved);
            this.Controls.Add(this.lblEditingIsEnabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnableEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowCabin);
            this.Controls.Add(this.btnShowStaff);
            this.Controls.Add(this.btnShowPayment);
            this.Controls.Add(this.btnShowBooking);
            this.Controls.Add(this.btnShowCustomer);
            this.Controls.Add(this.dgvSearchs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpCabin);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.lblStaffDetails);
            this.Name = "LookUp";
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LookUp_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            this.grpCabin.ResumeLayout(false);
            this.grpCabin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchs)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffDetails;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.GroupBox grpCabin;
        private System.Windows.Forms.DateTimePicker dtpCustomerDOB;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblCustomerDOB;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBookingEndDate;
        private System.Windows.Forms.Label lblBookingStartDate;
        private System.Windows.Forms.DateTimePicker dtpBookingEndDate;
        private System.Windows.Forms.DateTimePicker dtpBookingStartDate;
        private System.Windows.Forms.TextBox txtPaymentCardNumber;
        private System.Windows.Forms.TextBox txtPaymentNameOnCard;
        private System.Windows.Forms.Label lblPaymentCardNumber;
        private System.Windows.Forms.Label lblPaymentNameOnCard;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.Label lblStaffLastName;
        private System.Windows.Forms.DateTimePicker dtpStaffDateOfBirth;
        private System.Windows.Forms.Label lblStaffDOB;
        private System.Windows.Forms.ComboBox comboCabinType;
        private System.Windows.Forms.Label lblCabinType;
        private System.Windows.Forms.RadioButton radioCustomer;
        private System.Windows.Forms.RadioButton radioBooking;
        private System.Windows.Forms.RadioButton radioPayments;
        private System.Windows.Forms.RadioButton radioStaff;
        private System.Windows.Forms.RadioButton radioCabin;
        private System.Windows.Forms.DataGridView dgvSearchs;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.Button btnShowBooking;
        private System.Windows.Forms.Button btnShowPayment;
        private System.Windows.Forms.Button btnShowStaff;
        private System.Windows.Forms.Button btnShowCabin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnableEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEditingIsEnabled;
        private System.Windows.Forms.Label lblChangesSaved;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAboutUs;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripBtnSettings;
        private System.Windows.Forms.ToolStripButton toolStripBtnLock;
        private System.Windows.Forms.ToolStripButton toolStripBtnLogOut;
        private System.Windows.Forms.ToolStripButton toolStripBtnExitProgram;
        private System.Windows.Forms.Label lblLookUpPage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDownRecord;
        private System.Windows.Forms.Button btnUpRecord;
    }
}