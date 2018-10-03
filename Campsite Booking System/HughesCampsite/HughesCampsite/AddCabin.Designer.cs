namespace HughesCampsite
{
    partial class AddCabin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCabin));
            this.lblAddCabinStaffDetails = new System.Windows.Forms.Label();
            this.btnAddCabin = new System.Windows.Forms.Button();
            this.txtCabinDesc = new System.Windows.Forms.TextBox();
            this.txtCabinCapacity = new System.Windows.Forms.TextBox();
            this.comboCabinType = new System.Windows.Forms.ComboBox();
            this.lblCabinDesc = new System.Windows.Forms.Label();
            this.lblCabinCapacity = new System.Windows.Forms.Label();
            this.lblCabinType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnAboutUs = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLock = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExitProgram = new System.Windows.Forms.ToolStripButton();
            this.lblAddCabinPage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCabinStaffDetails
            // 
            this.lblAddCabinStaffDetails.AutoSize = true;
            this.lblAddCabinStaffDetails.Location = new System.Drawing.Point(12, 9);
            this.lblAddCabinStaffDetails.Name = "lblAddCabinStaffDetails";
            this.lblAddCabinStaffDetails.Size = new System.Drawing.Size(0, 13);
            this.lblAddCabinStaffDetails.TabIndex = 0;
            // 
            // btnAddCabin
            // 
            this.btnAddCabin.Location = new System.Drawing.Point(203, 233);
            this.btnAddCabin.Name = "btnAddCabin";
            this.btnAddCabin.Size = new System.Drawing.Size(75, 23);
            this.btnAddCabin.TabIndex = 3;
            this.btnAddCabin.Text = "Add Cabin";
            this.btnAddCabin.UseVisualStyleBackColor = true;
            this.btnAddCabin.Click += new System.EventHandler(this.btnAddCabin_Click);
            // 
            // txtCabinDesc
            // 
            this.txtCabinDesc.Location = new System.Drawing.Point(157, 128);
            this.txtCabinDesc.Name = "txtCabinDesc";
            this.txtCabinDesc.Size = new System.Drawing.Size(121, 20);
            this.txtCabinDesc.TabIndex = 0;
            // 
            // txtCabinCapacity
            // 
            this.txtCabinCapacity.Location = new System.Drawing.Point(157, 154);
            this.txtCabinCapacity.Name = "txtCabinCapacity";
            this.txtCabinCapacity.Size = new System.Drawing.Size(121, 20);
            this.txtCabinCapacity.TabIndex = 1;
            // 
            // comboCabinType
            // 
            this.comboCabinType.FormattingEnabled = true;
            this.comboCabinType.Items.AddRange(new object[] {
            "Platinum",
            "Master",
            "Gold",
            "Silver",
            "Bronze"});
            this.comboCabinType.Location = new System.Drawing.Point(157, 180);
            this.comboCabinType.Name = "comboCabinType";
            this.comboCabinType.Size = new System.Drawing.Size(121, 21);
            this.comboCabinType.TabIndex = 2;
            // 
            // lblCabinDesc
            // 
            this.lblCabinDesc.AutoSize = true;
            this.lblCabinDesc.Location = new System.Drawing.Point(13, 128);
            this.lblCabinDesc.Name = "lblCabinDesc";
            this.lblCabinDesc.Size = new System.Drawing.Size(136, 13);
            this.lblCabinDesc.TabIndex = 4;
            this.lblCabinDesc.Text = "Cabin Description(optional):";
            // 
            // lblCabinCapacity
            // 
            this.lblCabinCapacity.AutoSize = true;
            this.lblCabinCapacity.Location = new System.Drawing.Point(13, 154);
            this.lblCabinCapacity.Name = "lblCabinCapacity";
            this.lblCabinCapacity.Size = new System.Drawing.Size(81, 13);
            this.lblCabinCapacity.TabIndex = 4;
            this.lblCabinCapacity.Text = "Cabin Capacity:";
            // 
            // lblCabinType
            // 
            this.lblCabinType.AutoSize = true;
            this.lblCabinType.Location = new System.Drawing.Point(13, 180);
            this.lblCabinType.Name = "lblCabinType";
            this.lblCabinType.Size = new System.Drawing.Size(64, 13);
            this.lblCabinType.TabIndex = 4;
            this.lblCabinType.Text = "Cabin Type:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(41, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.toolStripMain.Location = new System.Drawing.Point(359, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(87, 279);
            this.toolStripMain.TabIndex = 17;
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
            // lblAddCabinPage
            // 
            this.lblAddCabinPage.AutoSize = true;
            this.lblAddCabinPage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCabinPage.Location = new System.Drawing.Point(12, 9);
            this.lblAddCabinPage.Name = "lblAddCabinPage";
            this.lblAddCabinPage.Size = new System.Drawing.Size(104, 19);
            this.lblAddCabinPage.TabIndex = 29;
            this.lblAddCabinPage.Tag = "P1";
            this.lblAddCabinPage.Text = "ADD CABIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HughesCampsite.Properties.Resources.Hughes_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(16, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // AddCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 279);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAddCabinPage);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCabinType);
            this.Controls.Add(this.lblCabinCapacity);
            this.Controls.Add(this.lblCabinDesc);
            this.Controls.Add(this.comboCabinType);
            this.Controls.Add(this.txtCabinCapacity);
            this.Controls.Add(this.txtCabinDesc);
            this.Controls.Add(this.btnAddCabin);
            this.Controls.Add(this.lblAddCabinStaffDetails);
            this.Name = "AddCabin";
            this.Text = "Add Cabin";
            this.Load += new System.EventHandler(this.AddCabin_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCabinStaffDetails;
        private System.Windows.Forms.Button btnAddCabin;
        private System.Windows.Forms.TextBox txtCabinDesc;
        private System.Windows.Forms.TextBox txtCabinCapacity;
        private System.Windows.Forms.ComboBox comboCabinType;
        private System.Windows.Forms.Label lblCabinDesc;
        private System.Windows.Forms.Label lblCabinCapacity;
        private System.Windows.Forms.Label lblCabinType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAboutUs;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripBtnSettings;
        private System.Windows.Forms.ToolStripButton toolStripBtnLock;
        private System.Windows.Forms.ToolStripButton toolStripBtnLogOut;
        private System.Windows.Forms.ToolStripButton toolStripBtnExitProgram;
        private System.Windows.Forms.Label lblAddCabinPage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}