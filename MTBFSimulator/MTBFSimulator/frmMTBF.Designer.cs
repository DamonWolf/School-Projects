namespace MTBFSimulator
{
    partial class frmMTBF
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
            this.chkClosePress = new System.Windows.Forms.CheckBox();
            this.chkResumeProd = new System.Windows.Forms.CheckBox();
            this.chkPrevMaintenance = new System.Windows.Forms.CheckBox();
            this.chkPredictiveMaintSet = new System.Windows.Forms.CheckBox();
            this.cboMTBF = new System.Windows.Forms.ComboBox();
            this.lblProdResumed = new System.Windows.Forms.Label();
            this.lblPredictiveMaintCount = new System.Windows.Forms.Label();
            this.lblClosedNumber = new System.Windows.Forms.Label();
            this.lblNumberClosed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.txtPressOpen = new System.Windows.Forms.TextBox();
            this.txtPressClosed = new System.Windows.Forms.TextBox();
            this.txtPressBottom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkClosePress
            // 
            this.chkClosePress.AutoSize = true;
            this.chkClosePress.Location = new System.Drawing.Point(25, 143);
            this.chkClosePress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkClosePress.Name = "chkClosePress";
            this.chkClosePress.Size = new System.Drawing.Size(105, 21);
            this.chkClosePress.TabIndex = 0;
            this.chkClosePress.Text = "Close Press";
            this.chkClosePress.UseVisualStyleBackColor = true;
            this.chkClosePress.CheckedChanged += new System.EventHandler(this.chkClosePress_CheckedChanged);
            // 
            // chkResumeProd
            // 
            this.chkResumeProd.AutoSize = true;
            this.chkResumeProd.Location = new System.Drawing.Point(257, 199);
            this.chkResumeProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkResumeProd.Name = "chkResumeProd";
            this.chkResumeProd.Size = new System.Drawing.Size(154, 21);
            this.chkResumeProd.TabIndex = 1;
            this.chkResumeProd.Text = "Resume Production";
            this.chkResumeProd.UseVisualStyleBackColor = true;
            this.chkResumeProd.CheckedChanged += new System.EventHandler(this.chkResumeProd_CheckedChanged);
            // 
            // chkPrevMaintenance
            // 
            this.chkPrevMaintenance.AutoSize = true;
            this.chkPrevMaintenance.Location = new System.Drawing.Point(25, 199);
            this.chkPrevMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPrevMaintenance.Name = "chkPrevMaintenance";
            this.chkPrevMaintenance.Size = new System.Drawing.Size(217, 21);
            this.chkPrevMaintenance.TabIndex = 2;
            this.chkPrevMaintenance.Text = "On Preventative Maintenance";
            this.chkPrevMaintenance.UseVisualStyleBackColor = true;
            // 
            // chkPredictiveMaintSet
            // 
            this.chkPredictiveMaintSet.AutoSize = true;
            this.chkPredictiveMaintSet.Location = new System.Drawing.Point(25, 270);
            this.chkPredictiveMaintSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPredictiveMaintSet.Name = "chkPredictiveMaintSet";
            this.chkPredictiveMaintSet.Size = new System.Drawing.Size(196, 21);
            this.chkPredictiveMaintSet.TabIndex = 3;
            this.chkPredictiveMaintSet.Text = "Set Predictive Maint Count";
            this.chkPredictiveMaintSet.UseVisualStyleBackColor = true;
            this.chkPredictiveMaintSet.CheckedChanged += new System.EventHandler(this.chkPredictiveMaintSet_CheckedChanged);
            // 
            // cboMTBF
            // 
            this.cboMTBF.FormattingEnabled = true;
            this.cboMTBF.Items.AddRange(new object[] {
            5,
            10,
            15});
            this.cboMTBF.Location = new System.Drawing.Point(157, 18);
            this.cboMTBF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMTBF.Name = "cboMTBF";
            this.cboMTBF.Size = new System.Drawing.Size(100, 24);
            this.cboMTBF.TabIndex = 4;
            this.cboMTBF.SelectedIndexChanged += new System.EventHandler(this.cboMTBF_SelectedIndexChanged);
            // 
            // lblProdResumed
            // 
            this.lblProdResumed.AutoSize = true;
            this.lblProdResumed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdResumed.Location = new System.Drawing.Point(276, 242);
            this.lblProdResumed.Name = "lblProdResumed";
            this.lblProdResumed.Size = new System.Drawing.Size(135, 17);
            this.lblProdResumed.TabIndex = 5;
            this.lblProdResumed.Text = "Production resumed";
            this.lblProdResumed.Visible = false;
            // 
            // lblPredictiveMaintCount
            // 
            this.lblPredictiveMaintCount.AutoSize = true;
            this.lblPredictiveMaintCount.Location = new System.Drawing.Point(251, 270);
            this.lblPredictiveMaintCount.Name = "lblPredictiveMaintCount";
            this.lblPredictiveMaintCount.Size = new System.Drawing.Size(0, 17);
            this.lblPredictiveMaintCount.TabIndex = 6;
            // 
            // lblClosedNumber
            // 
            this.lblClosedNumber.AutoSize = true;
            this.lblClosedNumber.Location = new System.Drawing.Point(21, 167);
            this.lblClosedNumber.Name = "lblClosedNumber";
            this.lblClosedNumber.Size = new System.Drawing.Size(171, 17);
            this.lblClosedNumber.TabIndex = 7;
            this.lblClosedNumber.Text = "Number of Press Closings";
            // 
            // lblNumberClosed
            // 
            this.lblNumberClosed.AutoSize = true;
            this.lblNumberClosed.Location = new System.Drawing.Point(251, 158);
            this.lblNumberClosed.Name = "lblNumberClosed";
            this.lblNumberClosed.Size = new System.Drawing.Size(0, 17);
            this.lblNumberClosed.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "MTBF";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(21, 121);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(78, 20);
            this.lblWarning.TabIndex = 10;
            this.lblWarning.Text = "Warning";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(105, 103);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 20);
            this.Message.TabIndex = 11;
            // 
            // txtPressOpen
            // 
            this.txtPressOpen.Location = new System.Drawing.Point(157, 50);
            this.txtPressOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPressOpen.Name = "txtPressOpen";
            this.txtPressOpen.Size = new System.Drawing.Size(100, 22);
            this.txtPressOpen.TabIndex = 15;
            this.txtPressOpen.Text = "PressOpen";
            // 
            // txtPressClosed
            // 
            this.txtPressClosed.Location = new System.Drawing.Point(157, 70);
            this.txtPressClosed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPressClosed.Name = "txtPressClosed";
            this.txtPressClosed.Size = new System.Drawing.Size(100, 22);
            this.txtPressClosed.TabIndex = 16;
            this.txtPressClosed.Text = "PressClosed";
            // 
            // txtPressBottom
            // 
            this.txtPressBottom.Location = new System.Drawing.Point(157, 89);
            this.txtPressBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPressBottom.Name = "txtPressBottom";
            this.txtPressBottom.Size = new System.Drawing.Size(100, 22);
            this.txtPressBottom.TabIndex = 17;
            this.txtPressBottom.Text = "PressBottom";
            // 
            // frmMTBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 327);
            this.Controls.Add(this.txtPressBottom);
            this.Controls.Add(this.txtPressClosed);
            this.Controls.Add(this.txtPressOpen);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumberClosed);
            this.Controls.Add(this.lblClosedNumber);
            this.Controls.Add(this.lblPredictiveMaintCount);
            this.Controls.Add(this.lblProdResumed);
            this.Controls.Add(this.cboMTBF);
            this.Controls.Add(this.chkPredictiveMaintSet);
            this.Controls.Add(this.chkPrevMaintenance);
            this.Controls.Add(this.chkResumeProd);
            this.Controls.Add(this.chkClosePress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMTBF";
            this.Text = "MTBF Simulator";
            this.Load += new System.EventHandler(this.frmMTBF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkClosePress;
        private System.Windows.Forms.CheckBox chkResumeProd;
        private System.Windows.Forms.CheckBox chkPrevMaintenance;
        private System.Windows.Forms.CheckBox chkPredictiveMaintSet;
        private System.Windows.Forms.ComboBox cboMTBF;
        private System.Windows.Forms.Label lblProdResumed;
        private System.Windows.Forms.Label lblPredictiveMaintCount;
        private System.Windows.Forms.Label lblClosedNumber;
        private System.Windows.Forms.Label lblNumberClosed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox txtPressOpen;
        private System.Windows.Forms.TextBox txtPressClosed;
        private System.Windows.Forms.TextBox txtPressBottom;
    }
}

