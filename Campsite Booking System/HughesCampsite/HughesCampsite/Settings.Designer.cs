namespace HughesCampsite
{
    partial class Settings
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
            this.lblInactivebtnColour = new System.Windows.Forms.Label();
            this.comboBtnColourIsntOver = new System.Windows.Forms.ComboBox();
            this.comboBtnIsOverIt = new System.Windows.Forms.ComboBox();
            this.lblActiveBtnColour = new System.Windows.Forms.Label();
            this.comboFormColour = new System.Windows.Forms.ComboBox();
            this.lblFormColour = new System.Windows.Forms.Label();
            this.comboFontType = new System.Windows.Forms.ComboBox();
            this.comboFontSize = new System.Windows.Forms.ComboBox();
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFontType = new System.Windows.Forms.Label();
            this.checkBoxColourBlind = new System.Windows.Forms.CheckBox();
            this.lblFontColour = new System.Windows.Forms.Label();
            this.comboFontColour = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInactivebtnColour
            // 
            this.lblInactivebtnColour.AutoSize = true;
            this.lblInactivebtnColour.Location = new System.Drawing.Point(99, 42);
            this.lblInactivebtnColour.Name = "lblInactivebtnColour";
            this.lblInactivebtnColour.Size = new System.Drawing.Size(114, 13);
            this.lblInactivebtnColour.TabIndex = 0;
            this.lblInactivebtnColour.Text = "Inactive button Colour:";
            // 
            // comboBtnColourIsntOver
            // 
            this.comboBtnColourIsntOver.FormattingEnabled = true;
            this.comboBtnColourIsntOver.Location = new System.Drawing.Point(219, 42);
            this.comboBtnColourIsntOver.Name = "comboBtnColourIsntOver";
            this.comboBtnColourIsntOver.Size = new System.Drawing.Size(179, 21);
            this.comboBtnColourIsntOver.TabIndex = 1;
            this.comboBtnColourIsntOver.SelectedIndexChanged += new System.EventHandler(this.comboBtnColourChange);
            // 
            // comboBtnIsOverIt
            // 
            this.comboBtnIsOverIt.FormattingEnabled = true;
            this.comboBtnIsOverIt.Location = new System.Drawing.Point(219, 69);
            this.comboBtnIsOverIt.Name = "comboBtnIsOverIt";
            this.comboBtnIsOverIt.Size = new System.Drawing.Size(179, 21);
            this.comboBtnIsOverIt.TabIndex = 2;
            this.comboBtnIsOverIt.SelectedIndexChanged += new System.EventHandler(this.comboBtnColourChange);
            // 
            // lblActiveBtnColour
            // 
            this.lblActiveBtnColour.AutoSize = true;
            this.lblActiveBtnColour.Location = new System.Drawing.Point(99, 69);
            this.lblActiveBtnColour.Name = "lblActiveBtnColour";
            this.lblActiveBtnColour.Size = new System.Drawing.Size(106, 13);
            this.lblActiveBtnColour.TabIndex = 3;
            this.lblActiveBtnColour.Text = "Active button Colour:";
            // 
            // comboFormColour
            // 
            this.comboFormColour.FormattingEnabled = true;
            this.comboFormColour.Location = new System.Drawing.Point(219, 96);
            this.comboFormColour.Name = "comboFormColour";
            this.comboFormColour.Size = new System.Drawing.Size(179, 21);
            this.comboFormColour.TabIndex = 3;
            this.comboFormColour.SelectedIndexChanged += new System.EventHandler(this.comboBtnColourChange);
            // 
            // lblFormColour
            // 
            this.lblFormColour.AutoSize = true;
            this.lblFormColour.Location = new System.Drawing.Point(99, 96);
            this.lblFormColour.Name = "lblFormColour";
            this.lblFormColour.Size = new System.Drawing.Size(66, 13);
            this.lblFormColour.TabIndex = 5;
            this.lblFormColour.Text = "Form Colour:";
            // 
            // comboFontType
            // 
            this.comboFontType.FormattingEnabled = true;
            this.comboFontType.Location = new System.Drawing.Point(219, 177);
            this.comboFontType.Name = "comboFontType";
            this.comboFontType.Size = new System.Drawing.Size(179, 21);
            this.comboFontType.TabIndex = 6;
            this.comboFontType.SelectedIndexChanged += new System.EventHandler(this.comboBtnColourChange);
            // 
            // comboFontSize
            // 
            this.comboFontSize.FormattingEnabled = true;
            this.comboFontSize.Location = new System.Drawing.Point(219, 150);
            this.comboFontSize.Name = "comboFontSize";
            this.comboFontSize.Size = new System.Drawing.Size(179, 21);
            this.comboFontSize.TabIndex = 5;
            this.comboFontSize.SelectedIndexChanged += new System.EventHandler(this.comboBtnColourChange);
            // 
            // comboFont
            // 
            this.comboFont.FormattingEnabled = true;
            this.comboFont.Location = new System.Drawing.Point(219, 123);
            this.comboFont.Name = "comboFont";
            this.comboFont.Size = new System.Drawing.Size(179, 21);
            this.comboFont.TabIndex = 4;
            this.comboFont.SelectedIndexChanged += new System.EventHandler(this.comboBtnColourChange);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(99, 123);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(31, 13);
            this.lblFont.TabIndex = 9;
            this.lblFont.Text = "Font:";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(99, 150);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(54, 13);
            this.lblFontSize.TabIndex = 10;
            this.lblFontSize.Text = "Font Size:";
            // 
            // lblFontType
            // 
            this.lblFontType.AutoSize = true;
            this.lblFontType.Location = new System.Drawing.Point(99, 177);
            this.lblFontType.Name = "lblFontType";
            this.lblFontType.Size = new System.Drawing.Size(58, 13);
            this.lblFontType.TabIndex = 11;
            this.lblFontType.Text = "Font Type:";
            // 
            // checkBoxColourBlind
            // 
            this.checkBoxColourBlind.AutoSize = true;
            this.checkBoxColourBlind.Location = new System.Drawing.Point(286, 232);
            this.checkBoxColourBlind.Name = "checkBoxColourBlind";
            this.checkBoxColourBlind.Size = new System.Drawing.Size(112, 17);
            this.checkBoxColourBlind.TabIndex = 8;
            this.checkBoxColourBlind.Text = "Colour Blind Mode";
            this.checkBoxColourBlind.UseVisualStyleBackColor = true;
            this.checkBoxColourBlind.CheckStateChanged += new System.EventHandler(this.checkColourBlind);
            // 
            // lblFontColour
            // 
            this.lblFontColour.AutoSize = true;
            this.lblFontColour.Location = new System.Drawing.Point(99, 204);
            this.lblFontColour.Name = "lblFontColour";
            this.lblFontColour.Size = new System.Drawing.Size(64, 13);
            this.lblFontColour.TabIndex = 13;
            this.lblFontColour.Text = "Font Colour:";
            // 
            // comboFontColour
            // 
            this.comboFontColour.FormattingEnabled = true;
            this.comboFontColour.Location = new System.Drawing.Point(219, 204);
            this.comboFontColour.Name = "comboFontColour";
            this.comboFontColour.Size = new System.Drawing.Size(179, 21);
            this.comboFontColour.TabIndex = 7;
            this.comboFontColour.SelectedIndexChanged += new System.EventHandler(this.comboBtnColourChange);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboFontColour);
            this.Controls.Add(this.lblFontColour);
            this.Controls.Add(this.checkBoxColourBlind);
            this.Controls.Add(this.lblFontType);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.comboFont);
            this.Controls.Add(this.comboFontSize);
            this.Controls.Add(this.comboFontType);
            this.Controls.Add(this.lblFormColour);
            this.Controls.Add(this.comboFormColour);
            this.Controls.Add(this.lblActiveBtnColour);
            this.Controls.Add(this.comboBtnIsOverIt);
            this.Controls.Add(this.comboBtnColourIsntOver);
            this.Controls.Add(this.lblInactivebtnColour);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInactivebtnColour;
        private System.Windows.Forms.ComboBox comboBtnColourIsntOver;
        private System.Windows.Forms.ComboBox comboBtnIsOverIt;
        private System.Windows.Forms.Label lblActiveBtnColour;
        private System.Windows.Forms.ComboBox comboFormColour;
        private System.Windows.Forms.Label lblFormColour;
        private System.Windows.Forms.ComboBox comboFontType;
        private System.Windows.Forms.ComboBox comboFontSize;
        private System.Windows.Forms.ComboBox comboFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblFontType;
        private System.Windows.Forms.CheckBox checkBoxColourBlind;
        private System.Windows.Forms.Label lblFontColour;
        private System.Windows.Forms.ComboBox comboFontColour;
        private System.Windows.Forms.Button btnReset;
    }
}