﻿namespace Scada.Comm.Shell.Forms
{
    partial class FrmDeviceCommand
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlCmdData = new System.Windows.Forms.Panel();
            this.txtCmdData = new System.Windows.Forms.TextBox();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbString = new System.Windows.Forms.RadioButton();
            this.pnlCmdVal = new System.Windows.Forms.Panel();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.txtCmdVal = new System.Windows.Forms.TextBox();
            this.lblCmdVal = new System.Windows.Forms.Label();
            this.rbRequest = new System.Windows.Forms.RadioButton();
            this.rbBinary = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.numCmdNum = new System.Windows.Forms.NumericUpDown();
            this.lblCmdNum = new System.Windows.Forms.Label();
            this.pnlCmdData.SuspendLayout();
            this.pnlCmdVal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmdNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(216, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(297, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlCmdData
            // 
            this.pnlCmdData.Controls.Add(this.txtCmdData);
            this.pnlCmdData.Controls.Add(this.rbHex);
            this.pnlCmdData.Controls.Add(this.rbString);
            this.pnlCmdData.Location = new System.Drawing.Point(12, 51);
            this.pnlCmdData.Name = "pnlCmdData";
            this.pnlCmdData.Size = new System.Drawing.Size(360, 159);
            this.pnlCmdData.TabIndex = 6;
            // 
            // txtCmdData
            // 
            this.txtCmdData.AcceptsReturn = true;
            this.txtCmdData.Location = new System.Drawing.Point(0, 23);
            this.txtCmdData.Multiline = true;
            this.txtCmdData.Name = "txtCmdData";
            this.txtCmdData.Size = new System.Drawing.Size(360, 136);
            this.txtCmdData.TabIndex = 2;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(67, 0);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(86, 17);
            this.rbHex.TabIndex = 1;
            this.rbHex.Text = "Hexadecimal";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // rbString
            // 
            this.rbString.AutoSize = true;
            this.rbString.Checked = true;
            this.rbString.Location = new System.Drawing.Point(0, 0);
            this.rbString.Name = "rbString";
            this.rbString.Size = new System.Drawing.Size(52, 17);
            this.rbString.TabIndex = 0;
            this.rbString.TabStop = true;
            this.rbString.Text = "String";
            this.rbString.UseVisualStyleBackColor = true;
            // 
            // pnlCmdVal
            // 
            this.pnlCmdVal.Controls.Add(this.btnOn);
            this.pnlCmdVal.Controls.Add(this.btnOff);
            this.pnlCmdVal.Controls.Add(this.txtCmdVal);
            this.pnlCmdVal.Controls.Add(this.lblCmdVal);
            this.pnlCmdVal.Location = new System.Drawing.Point(12, 51);
            this.pnlCmdVal.Name = "pnlCmdVal";
            this.pnlCmdVal.Size = new System.Drawing.Size(360, 36);
            this.pnlCmdVal.TabIndex = 5;
            // 
            // btnOn
            // 
            this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOn.Location = new System.Drawing.Point(207, 16);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(45, 20);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnCmdVal_Click);
            // 
            // btnOff
            // 
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOff.Location = new System.Drawing.Point(156, 16);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(45, 20);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnCmdVal_Click);
            // 
            // txtCmdVal
            // 
            this.txtCmdVal.Location = new System.Drawing.Point(0, 16);
            this.txtCmdVal.Name = "txtCmdVal";
            this.txtCmdVal.Size = new System.Drawing.Size(150, 20);
            this.txtCmdVal.TabIndex = 1;
            this.txtCmdVal.Text = "0";
            // 
            // lblCmdVal
            // 
            this.lblCmdVal.AutoSize = true;
            this.lblCmdVal.Location = new System.Drawing.Point(-3, 0);
            this.lblCmdVal.Name = "lblCmdVal";
            this.lblCmdVal.Size = new System.Drawing.Size(34, 13);
            this.lblCmdVal.TabIndex = 0;
            this.lblCmdVal.Text = "Value";
            // 
            // rbRequest
            // 
            this.rbRequest.AutoSize = true;
            this.rbRequest.Location = new System.Drawing.Point(298, 27);
            this.rbRequest.Name = "rbRequest";
            this.rbRequest.Size = new System.Drawing.Size(65, 17);
            this.rbRequest.TabIndex = 4;
            this.rbRequest.Text = "Request";
            this.rbRequest.UseVisualStyleBackColor = true;
            this.rbRequest.CheckedChanged += new System.EventHandler(this.rbCmdType_CheckedChanged);
            // 
            // rbBinary
            // 
            this.rbBinary.AutoSize = true;
            this.rbBinary.Location = new System.Drawing.Point(203, 27);
            this.rbBinary.Name = "rbBinary";
            this.rbBinary.Size = new System.Drawing.Size(54, 17);
            this.rbBinary.TabIndex = 3;
            this.rbBinary.Text = "Binary";
            this.rbBinary.UseVisualStyleBackColor = true;
            this.rbBinary.CheckedChanged += new System.EventHandler(this.rbCmdType_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(108, 27);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 2;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbCmdType_CheckedChanged);
            // 
            // numCmdNum
            // 
            this.numCmdNum.Location = new System.Drawing.Point(12, 25);
            this.numCmdNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numCmdNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCmdNum.Name = "numCmdNum";
            this.numCmdNum.Size = new System.Drawing.Size(90, 20);
            this.numCmdNum.TabIndex = 1;
            this.numCmdNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCmdNum
            // 
            this.lblCmdNum.AutoSize = true;
            this.lblCmdNum.Location = new System.Drawing.Point(9, 9);
            this.lblCmdNum.Name = "lblCmdNum";
            this.lblCmdNum.Size = new System.Drawing.Size(92, 13);
            this.lblCmdNum.TabIndex = 0;
            this.lblCmdNum.Text = "Command number";
            // 
            // FrmDeviceCommand
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.pnlCmdVal);
            this.Controls.Add(this.pnlCmdData);
            this.Controls.Add(this.rbRequest);
            this.Controls.Add(this.rbBinary);
            this.Controls.Add(this.rbStandard);
            this.Controls.Add(this.numCmdNum);
            this.Controls.Add(this.lblCmdNum);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeviceCommand";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Command to {0}";
            this.Load += new System.EventHandler(this.FrmDeviceCommand_Load);
            this.pnlCmdData.ResumeLayout(false);
            this.pnlCmdData.PerformLayout();
            this.pnlCmdVal.ResumeLayout(false);
            this.pnlCmdVal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmdNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlCmdData;
        private System.Windows.Forms.TextBox txtCmdData;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RadioButton rbString;
        private System.Windows.Forms.Panel pnlCmdVal;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.TextBox txtCmdVal;
        private System.Windows.Forms.Label lblCmdVal;
        private System.Windows.Forms.RadioButton rbRequest;
        private System.Windows.Forms.RadioButton rbBinary;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.NumericUpDown numCmdNum;
        private System.Windows.Forms.Label lblCmdNum;
    }
}