namespace HughesCampsite
{
    partial class ErrorCodes
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
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.txtErrorCode = new System.Windows.Forms.TextBox();
            this.listErrorCodes = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.Location = new System.Drawing.Point(125, 9);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(63, 13);
            this.lblEnterCode.TabIndex = 0;
            this.lblEnterCode.Text = "Enter Code:";
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.Location = new System.Drawing.Point(194, 6);
            this.txtErrorCode.MaxLength = 5;
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.Size = new System.Drawing.Size(78, 20);
            this.txtErrorCode.TabIndex = 0;
            this.txtErrorCode.TextChanged += new System.EventHandler(this.txtErrorCode_TextChanged);
            // 
            // listErrorCodes
            // 
            this.listErrorCodes.FormattingEnabled = true;
            this.listErrorCodes.Location = new System.Drawing.Point(12, 42);
            this.listErrorCodes.Name = "listErrorCodes";
            this.listErrorCodes.Size = new System.Drawing.Size(260, 186);
            this.listErrorCodes.TabIndex = 3;
            this.listErrorCodes.SelectedIndexChanged += new System.EventHandler(this.listErrorCodes_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ErrorCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listErrorCodes);
            this.Controls.Add(this.txtErrorCode);
            this.Controls.Add(this.lblEnterCode);
            this.Name = "ErrorCodes";
            this.Text = "Error Code Search";
            this.Load += new System.EventHandler(this.ErrorCodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.TextBox txtErrorCode;
        private System.Windows.Forms.ListBox listErrorCodes;
        private System.Windows.Forms.Button btnClose;
    }
}