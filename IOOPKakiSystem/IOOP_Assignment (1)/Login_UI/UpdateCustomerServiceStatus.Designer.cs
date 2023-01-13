namespace Login_UI
{
    partial class UpdateCustomerServiceStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomerServiceStatus));
            this.panelTop = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblServiceOrder = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblCusUsername = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateOfCollection = new System.Windows.Forms.Label();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtCusUsername = new System.Windows.Forms.TextBox();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.txtServiceStatus = new System.Windows.Forms.TextBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.panelTop.Controls.Add(this.picExit);
            this.panelTop.Controls.Add(this.lblServiceOrder);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 75);
            this.panelTop.TabIndex = 0;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(12, 26);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(25, 25);
            this.picExit.TabIndex = 18;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picBack_Click);
            // 
            // lblServiceOrder
            // 
            this.lblServiceOrder.AutoSize = true;
            this.lblServiceOrder.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold);
            this.lblServiceOrder.Location = new System.Drawing.Point(55, 20);
            this.lblServiceOrder.Name = "lblServiceOrder";
            this.lblServiceOrder.Size = new System.Drawing.Size(181, 36);
            this.lblServiceOrder.TabIndex = 0;
            this.lblServiceOrder.Text = "Service Order";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderNo.Location = new System.Drawing.Point(33, 97);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(83, 21);
            this.lblOrderNo.TabIndex = 19;
            this.lblOrderNo.Text = "Order No.";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderDate.Location = new System.Drawing.Point(33, 177);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(91, 21);
            this.lblOrderDate.TabIndex = 20;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblCusUsername
            // 
            this.lblCusUsername.AutoSize = true;
            this.lblCusUsername.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblCusUsername.Location = new System.Drawing.Point(33, 257);
            this.lblCusUsername.Name = "lblCusUsername";
            this.lblCusUsername.Size = new System.Drawing.Size(159, 21);
            this.lblCusUsername.TabIndex = 21;
            this.lblCusUsername.Text = "Customer Username";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblServiceType.Location = new System.Drawing.Point(33, 337);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(104, 21);
            this.lblServiceType.TabIndex = 22;
            this.lblServiceType.Text = "Service Type";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblServiceStatus.Location = new System.Drawing.Point(33, 417);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(112, 21);
            this.lblServiceStatus.TabIndex = 23;
            this.lblServiceStatus.Text = "Service Status";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblCondition.Location = new System.Drawing.Point(33, 497);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(83, 21);
            this.lblCondition.TabIndex = 24;
            this.lblCondition.Text = "Condition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(513, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // lblDateOfCollection
            // 
            this.lblDateOfCollection.AutoSize = true;
            this.lblDateOfCollection.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateOfCollection.Location = new System.Drawing.Point(513, 97);
            this.lblDateOfCollection.Name = "lblDateOfCollection";
            this.lblDateOfCollection.Size = new System.Drawing.Size(142, 21);
            this.lblDateOfCollection.TabIndex = 26;
            this.lblDateOfCollection.Text = "Date of Collection";
            // 
            // cmbOrderNo
            // 
            this.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderNo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbOrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(37, 137);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(300, 29);
            this.cmbOrderNo.TabIndex = 27;
            this.cmbOrderNo.SelectedValueChanged += new System.EventHandler(this.cmbOrderNo_SelectedValueChanged);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtOrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtOrderDate.Location = new System.Drawing.Point(37, 212);
            this.txtOrderDate.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtOrderDate.Multiline = true;
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(300, 25);
            this.txtOrderDate.TabIndex = 28;
            // 
            // txtCusUsername
            // 
            this.txtCusUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCusUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusUsername.Enabled = false;
            this.txtCusUsername.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtCusUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtCusUsername.Location = new System.Drawing.Point(37, 297);
            this.txtCusUsername.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtCusUsername.Multiline = true;
            this.txtCusUsername.Name = "txtCusUsername";
            this.txtCusUsername.ReadOnly = true;
            this.txtCusUsername.Size = new System.Drawing.Size(300, 25);
            this.txtCusUsername.TabIndex = 29;
            // 
            // txtServiceType
            // 
            this.txtServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtServiceType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceType.Enabled = false;
            this.txtServiceType.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtServiceType.Location = new System.Drawing.Point(37, 377);
            this.txtServiceType.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtServiceType.Multiline = true;
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.ReadOnly = true;
            this.txtServiceType.Size = new System.Drawing.Size(300, 25);
            this.txtServiceType.TabIndex = 30;
            // 
            // txtServiceStatus
            // 
            this.txtServiceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceStatus.Enabled = false;
            this.txtServiceStatus.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtServiceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtServiceStatus.Location = new System.Drawing.Point(37, 457);
            this.txtServiceStatus.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtServiceStatus.Multiline = true;
            this.txtServiceStatus.Name = "txtServiceStatus";
            this.txtServiceStatus.ReadOnly = true;
            this.txtServiceStatus.Size = new System.Drawing.Size(300, 25);
            this.txtServiceStatus.TabIndex = 31;
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.Enabled = false;
            this.cmbDay.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(517, 137);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(80, 29);
            this.cmbDay.TabIndex = 33;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Enabled = false;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(617, 137);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(80, 29);
            this.cmbMonth.TabIndex = 34;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Enabled = false;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(717, 137);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(120, 29);
            this.cmbYear.TabIndex = 35;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtDescription.Location = new System.Drawing.Point(517, 257);
            this.txtDescription.MaximumSize = new System.Drawing.Size(330, 220);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(330, 220);
            this.txtDescription.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(697, 537);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCondition
            // 
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.Enabled = false;
            this.cmbCondition.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "N/A",
            "In Progress",
            "Completed",
            "Cancelled"});
            this.cmbCondition.Location = new System.Drawing.Point(37, 542);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(300, 29);
            this.cmbCondition.TabIndex = 39;
            this.cmbCondition.SelectedValueChanged += new System.EventHandler(this.cmbCondition_SelectedValueChanged);
            // 
            // UpdateCustomerServiceStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.txtServiceStatus);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.txtCusUsername);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.cmbOrderNo);
            this.Controls.Add(this.lblDateOfCollection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblServiceStatus);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblCusUsername);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateCustomerServiceStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCustomerServiceStatus";
            this.Load += new System.EventHandler(this.UpdateCustomerServiceStatus_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblServiceOrder;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblCusUsername;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDateOfCollection;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtCusUsername;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.TextBox txtServiceStatus;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCondition;
    }
}