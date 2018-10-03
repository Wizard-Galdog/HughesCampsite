namespace HughesCampsite
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.lblInvoiceStaffDetails = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerDetailsLastName = new System.Windows.Forms.Label();
            this.lblCustomerDetailsCustomerID = new System.Windows.Forms.Label();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblNumOfChildren = new System.Windows.Forms.Label();
            this.lblNumOfAdults = new System.Windows.Forms.Label();
            this.lblCabinNo = new System.Windows.Forms.Label();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnAboutUs = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLock = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExitProgram = new System.Windows.Forms.ToolStripButton();
            this.lblInvoicePage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCustomerDetails.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceStaffDetails
            // 
            this.lblInvoiceStaffDetails.AutoSize = true;
            this.lblInvoiceStaffDetails.Location = new System.Drawing.Point(12, 9);
            this.lblInvoiceStaffDetails.Name = "lblInvoiceStaffDetails";
            this.lblInvoiceStaffDetails.Size = new System.Drawing.Size(0, 13);
            this.lblInvoiceStaffDetails.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(278, 329);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.lblCustomerDetailsLastName);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerDetailsCustomerID);
            this.grpCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerDetails.Location = new System.Drawing.Point(12, 44);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(260, 72);
            this.grpCustomerDetails.TabIndex = 9;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // lblCustomerDetailsLastName
            // 
            this.lblCustomerDetailsLastName.AutoSize = true;
            this.lblCustomerDetailsLastName.Location = new System.Drawing.Point(6, 38);
            this.lblCustomerDetailsLastName.Name = "lblCustomerDetailsLastName";
            this.lblCustomerDetailsLastName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerDetailsLastName.TabIndex = 5;
            // 
            // lblCustomerDetailsCustomerID
            // 
            this.lblCustomerDetailsCustomerID.AutoSize = true;
            this.lblCustomerDetailsCustomerID.Location = new System.Drawing.Point(6, 16);
            this.lblCustomerDetailsCustomerID.Name = "lblCustomerDetailsCustomerID";
            this.lblCustomerDetailsCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerDetailsCustomerID.TabIndex = 4;
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.lblPrice);
            this.grpBookingDetails.Controls.Add(this.lblSeason);
            this.grpBookingDetails.Controls.Add(this.lblEndDate);
            this.grpBookingDetails.Controls.Add(this.lblStartDate);
            this.grpBookingDetails.Controls.Add(this.lblNumOfChildren);
            this.grpBookingDetails.Controls.Add(this.lblNumOfAdults);
            this.grpBookingDetails.Controls.Add(this.lblCabinNo);
            this.grpBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookingDetails.Location = new System.Drawing.Point(12, 122);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(260, 116);
            this.grpBookingDetails.TabIndex = 10;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 93);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "label1";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeason.Location = new System.Drawing.Point(6, 80);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(35, 13);
            this.lblSeason.TabIndex = 4;
            this.lblSeason.Text = "label1";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(6, 67);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(35, 13);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "label1";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(6, 54);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(35, 13);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "label1";
            // 
            // lblNumOfChildren
            // 
            this.lblNumOfChildren.AutoSize = true;
            this.lblNumOfChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfChildren.Location = new System.Drawing.Point(6, 41);
            this.lblNumOfChildren.Name = "lblNumOfChildren";
            this.lblNumOfChildren.Size = new System.Drawing.Size(35, 13);
            this.lblNumOfChildren.TabIndex = 4;
            this.lblNumOfChildren.Text = "label1";
            // 
            // lblNumOfAdults
            // 
            this.lblNumOfAdults.AutoSize = true;
            this.lblNumOfAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfAdults.Location = new System.Drawing.Point(6, 28);
            this.lblNumOfAdults.Name = "lblNumOfAdults";
            this.lblNumOfAdults.Size = new System.Drawing.Size(35, 13);
            this.lblNumOfAdults.TabIndex = 4;
            this.lblNumOfAdults.Text = "label1";
            // 
            // lblCabinNo
            // 
            this.lblCabinNo.AutoSize = true;
            this.lblCabinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinNo.Location = new System.Drawing.Point(6, 15);
            this.lblCabinNo.Name = "lblCabinNo";
            this.lblCabinNo.Size = new System.Drawing.Size(35, 13);
            this.lblCabinNo.TabIndex = 4;
            this.lblCabinNo.Text = "label1";
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.lblPaymentType);
            this.grpPaymentDetails.Controls.Add(this.lblAmountPaid);
            this.grpPaymentDetails.Controls.Add(this.lblExpiryDate);
            this.grpPaymentDetails.Controls.Add(this.lblSecurityCode);
            this.grpPaymentDetails.Controls.Add(this.lblCardNumber);
            this.grpPaymentDetails.Controls.Add(this.lblNameOnCard);
            this.grpPaymentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentDetails.Location = new System.Drawing.Point(12, 244);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(260, 108);
            this.grpPaymentDetails.TabIndex = 11;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(6, 16);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(35, 13);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "label1";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(6, 82);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(35, 13);
            this.lblAmountPaid.TabIndex = 1;
            this.lblAmountPaid.Text = "label1";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(6, 69);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(68, 13);
            this.lblExpiryDate.TabIndex = 0;
            this.lblExpiryDate.Text = "lblExpiryDate";
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityCode.Location = new System.Drawing.Point(6, 56);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(35, 13);
            this.lblSecurityCode.TabIndex = 0;
            this.lblSecurityCode.Text = "label1";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(6, 43);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(35, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "label1";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnCard.Location = new System.Drawing.Point(6, 30);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(35, 13);
            this.lblNameOnCard.TabIndex = 0;
            this.lblNameOnCard.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(197, 396);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnPrintInvoice.TabIndex = 12;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.printButton_Click);
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
            this.toolStripMain.Location = new System.Drawing.Point(614, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(87, 431);
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
            // lblInvoicePage
            // 
            this.lblInvoicePage.AutoSize = true;
            this.lblInvoicePage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoicePage.Location = new System.Drawing.Point(12, 9);
            this.lblInvoicePage.Name = "lblInvoicePage";
            this.lblInvoicePage.Size = new System.Drawing.Size(83, 19);
            this.lblInvoicePage.TabIndex = 28;
            this.lblInvoicePage.Tag = "P1";
            this.lblInvoicePage.Text = "INVOICE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::HughesCampsite.Properties.Resources.Hughes_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(344, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 119);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HughesCampsite.Properties.Resources.sils_logo_3;
            this.pictureBox1.Location = new System.Drawing.Point(409, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 91);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblInvoicePage);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpPaymentDetails);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblInvoiceStaffDetails);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceStaffDetails;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.Label lblCustomerDetailsCustomerID;
        private System.Windows.Forms.Label lblCustomerDetailsLastName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblNumOfChildren;
        private System.Windows.Forms.Label lblNumOfAdults;
        private System.Windows.Forms.Label lblCabinNo;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAboutUs;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripBtnSettings;
        private System.Windows.Forms.ToolStripButton toolStripBtnLock;
        private System.Windows.Forms.ToolStripButton toolStripBtnLogOut;
        private System.Windows.Forms.ToolStripButton toolStripBtnExitProgram;
        private System.Windows.Forms.Label lblInvoicePage;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}