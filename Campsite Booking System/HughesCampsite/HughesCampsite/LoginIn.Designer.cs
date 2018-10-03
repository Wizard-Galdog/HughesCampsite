namespace HughesCampsite
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnMainMenuLogIn = new System.Windows.Forms.Button();
            this.lblMainMenuPassword = new System.Windows.Forms.Label();
            this.lblMainMenuSignIn = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAboutUs = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExitProgram = new System.Windows.Forms.ToolStripButton();
            this.lblLoginPage = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(109, 166);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(109, 192);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(100, 20);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // btnMainMenuLogIn
            // 
            this.btnMainMenuLogIn.Location = new System.Drawing.Point(134, 250);
            this.btnMainMenuLogIn.Name = "btnMainMenuLogIn";
            this.btnMainMenuLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenuLogIn.TabIndex = 2;
            this.btnMainMenuLogIn.Text = "Log In";
            this.btnMainMenuLogIn.UseVisualStyleBackColor = true;
            this.btnMainMenuLogIn.Click += new System.EventHandler(this.btnMainMenuLogIn_Click);
            // 
            // lblMainMenuPassword
            // 
            this.lblMainMenuPassword.AutoSize = true;
            this.lblMainMenuPassword.Location = new System.Drawing.Point(13, 195);
            this.lblMainMenuPassword.Name = "lblMainMenuPassword";
            this.lblMainMenuPassword.Size = new System.Drawing.Size(56, 13);
            this.lblMainMenuPassword.TabIndex = 9;
            this.lblMainMenuPassword.Text = "Password:";
            // 
            // lblMainMenuSignIn
            // 
            this.lblMainMenuSignIn.AutoSize = true;
            this.lblMainMenuSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMainMenuSignIn.Location = new System.Drawing.Point(13, 166);
            this.lblMainMenuSignIn.Name = "lblMainMenuSignIn";
            this.lblMainMenuSignIn.Size = new System.Drawing.Size(60, 13);
            this.lblMainMenuSignIn.TabIndex = 8;
            this.lblMainMenuSignIn.Tag = "";
            this.lblMainMenuSignIn.Text = "UserName:";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAboutUs,
            this.toolStripBtnHelp,
            this.toolStripBtnSettings,
            this.toolStripBtnExitProgram});
            this.toolStripMain.Location = new System.Drawing.Point(222, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(79, 288);
            this.toolStripMain.TabIndex = 25;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripBtnAboutUs
            // 
            this.toolStripBtnAboutUs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAboutUs.Image")));
            this.toolStripBtnAboutUs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAboutUs.Name = "toolStripBtnAboutUs";
            this.toolStripBtnAboutUs.Size = new System.Drawing.Size(76, 19);
            this.toolStripBtnAboutUs.Text = "About Us";
            // 
            // toolStripBtnHelp
            // 
            this.toolStripBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHelp.Image")));
            this.toolStripBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHelp.Name = "toolStripBtnHelp";
            this.toolStripBtnHelp.Size = new System.Drawing.Size(76, 19);
            this.toolStripBtnHelp.Text = "Help";
            // 
            // toolStripBtnSettings
            // 
            this.toolStripBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSettings.Image")));
            this.toolStripBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSettings.Name = "toolStripBtnSettings";
            this.toolStripBtnSettings.Size = new System.Drawing.Size(76, 19);
            this.toolStripBtnSettings.Text = "Settings";
            // 
            // toolStripBtnExitProgram
            // 
            this.toolStripBtnExitProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnExitProgram.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExitProgram.Image")));
            this.toolStripBtnExitProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExitProgram.Name = "toolStripBtnExitProgram";
            this.toolStripBtnExitProgram.Size = new System.Drawing.Size(76, 19);
            this.toolStripBtnExitProgram.Text = "Exit Program";
            // 
            // lblLoginPage
            // 
            this.lblLoginPage.AutoSize = true;
            this.lblLoginPage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPage.Location = new System.Drawing.Point(12, 9);
            this.lblLoginPage.Name = "lblLoginPage";
            this.lblLoginPage.Size = new System.Drawing.Size(117, 19);
            this.lblLoginPage.TabIndex = 26;
            this.lblLoginPage.Tag = "P1";
            this.lblLoginPage.Text = "LOGIN PAGE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::HughesCampsite.Properties.Resources.Hughes_logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 119);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLoginPage);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.lblMainMenuPassword);
            this.Controls.Add(this.lblMainMenuSignIn);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnMainMenuLogIn);
            this.Controls.Add(this.txtPassWord);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hughes Campsite - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnMainMenuLogIn;
        private System.Windows.Forms.Label lblMainMenuPassword;
        private System.Windows.Forms.Label lblMainMenuSignIn;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripBtnAboutUs;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripBtnSettings;
        private System.Windows.Forms.ToolStripButton toolStripBtnExitProgram;
        private System.Windows.Forms.Label lblLoginPage;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

