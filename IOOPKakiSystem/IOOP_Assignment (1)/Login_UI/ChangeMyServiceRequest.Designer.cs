namespace Login_UI
{
    partial class ChangeMyServiceRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMyServiceRequest));
            this.panelTop = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.lblChangeServiceOrder = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServiceFee = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.cmbServiceStatus = new System.Windows.Forms.ComboBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.panelTop.Controls.Add(this.picBack);
            this.panelTop.Controls.Add(this.lblChangeServiceOrder);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 75);
            this.panelTop.TabIndex = 1;
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(12, 26);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(25, 25);
            this.picBack.TabIndex = 18;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // lblChangeServiceOrder
            // 
            this.lblChangeServiceOrder.AutoSize = true;
            this.lblChangeServiceOrder.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold);
            this.lblChangeServiceOrder.Location = new System.Drawing.Point(55, 20);
            this.lblChangeServiceOrder.Name = "lblChangeServiceOrder";
            this.lblChangeServiceOrder.Size = new System.Drawing.Size(280, 36);
            this.lblChangeServiceOrder.TabIndex = 0;
            this.lblChangeServiceOrder.Text = "Change Service Order";
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
            this.btnSave.Location = new System.Drawing.Point(691, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.BackColor = System.Drawing.Color.White;
            this.txtServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceFee.Enabled = false;
            this.txtServiceFee.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtServiceFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtServiceFee.Location = new System.Drawing.Point(295, 453);
            this.txtServiceFee.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtServiceFee.Multiline = true;
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.ReadOnly = true;
            this.txtServiceFee.Size = new System.Drawing.Size(300, 25);
            this.txtServiceFee.TabIndex = 49;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtOrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtOrderDate.Location = new System.Drawing.Point(295, 213);
            this.txtOrderDate.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtOrderDate.Multiline = true;
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(300, 25);
            this.txtOrderDate.TabIndex = 46;
            // 
            // cmbOrderNo
            // 
            this.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderNo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbOrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(295, 133);
            this.cmbOrderNo.MinimumSize = new System.Drawing.Size(250, 0);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(300, 29);
            this.cmbOrderNo.TabIndex = 45;
            this.cmbOrderNo.SelectedValueChanged += new System.EventHandler(this.cmbOrderNo_SelectedValueChanged);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblCondition.Location = new System.Drawing.Point(291, 493);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(83, 21);
            this.lblCondition.TabIndex = 44;
            this.lblCondition.Text = "Condition";
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblServiceFee.Location = new System.Drawing.Point(291, 413);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(94, 21);
            this.lblServiceFee.TabIndex = 43;
            this.lblServiceFee.Text = "Service Fee";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblServiceStatus.Location = new System.Drawing.Point(291, 333);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(119, 21);
            this.lblServiceStatus.TabIndex = 42;
            this.lblServiceStatus.Text = "Service Status*";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblServiceType.Location = new System.Drawing.Point(291, 253);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(111, 21);
            this.lblServiceType.TabIndex = 41;
            this.lblServiceType.Text = "Service Type*";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderDate.Location = new System.Drawing.Point(291, 173);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(91, 21);
            this.lblOrderDate.TabIndex = 40;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderNo.Location = new System.Drawing.Point(291, 93);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(83, 21);
            this.lblOrderNo.TabIndex = 39;
            this.lblOrderNo.Text = "Order No.";
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.Enabled = false;
            this.cmbServiceType.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.cmbServiceType.Location = new System.Drawing.Point(295, 293);
            this.cmbServiceType.MinimumSize = new System.Drawing.Size(250, 0);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(300, 29);
            this.cmbServiceType.TabIndex = 51;
            this.cmbServiceType.SelectedValueChanged += new System.EventHandler(this.cmbServiceType_SelectedValueChanged);
            // 
            // cmbServiceStatus
            // 
            this.cmbServiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceStatus.Enabled = false;
            this.cmbServiceStatus.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.cmbServiceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cmbServiceStatus.FormattingEnabled = true;
            this.cmbServiceStatus.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.cmbServiceStatus.Location = new System.Drawing.Point(293, 373);
            this.cmbServiceStatus.MinimumSize = new System.Drawing.Size(250, 0);
            this.cmbServiceStatus.Name = "cmbServiceStatus";
            this.cmbServiceStatus.Size = new System.Drawing.Size(300, 29);
            this.cmbServiceStatus.TabIndex = 52;
            this.cmbServiceStatus.SelectedValueChanged += new System.EventHandler(this.cmbServiceStatus_SelectedValueChanged);
            // 
            // txtCondition
            // 
            this.txtCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCondition.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.txtCondition.ForeColor = System.Drawing.Color.White;
            this.txtCondition.Location = new System.Drawing.Point(295, 538);
            this.txtCondition.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(300, 25);
            this.txtCondition.TabIndex = 53;
            this.txtCondition.Text = "N/A";
            this.txtCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeMyServiceRequest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.cmbServiceStatus);
            this.Controls.Add(this.cmbServiceType);
            this.Controls.Add(this.txtServiceFee);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.cmbOrderNo);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblServiceFee);
            this.Controls.Add(this.lblServiceStatus);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangeMyServiceRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeMyServiceRequest";
            this.Load += new System.EventHandler(this.ChangeMyServiceRequest_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Label lblChangeServiceOrder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtServiceFee;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.ComboBox cmbServiceStatus;
        private System.Windows.Forms.TextBox txtCondition;
    }
}