
namespace Login_UI
{
    partial class ServiceReport
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
            this.lblServiceRepTitle = new System.Windows.Forms.Label();
            this.dgvServiceReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicbBack1 = new System.Windows.Forms.Button();
            this.PicbLogo = new System.Windows.Forms.PictureBox();
            this.lblNoDataAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceRepTitle
            // 
            this.lblServiceRepTitle.AutoSize = true;
            this.lblServiceRepTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F, System.Drawing.FontStyle.Bold);
            this.lblServiceRepTitle.Location = new System.Drawing.Point(429, 90);
            this.lblServiceRepTitle.Name = "lblServiceRepTitle";
            this.lblServiceRepTitle.Size = new System.Drawing.Size(113, 15);
            this.lblServiceRepTitle.TabIndex = 2;
            this.lblServiceRepTitle.Text = "XXXX Service Report";
            // 
            // dgvServiceReport
            // 
            this.dgvServiceReport.AllowUserToAddRows = false;
            this.dgvServiceReport.AllowUserToDeleteRows = false;
            this.dgvServiceReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvServiceReport.Location = new System.Drawing.Point(75, 137);
            this.dgvServiceReport.Name = "dgvServiceReport";
            this.dgvServiceReport.ReadOnly = true;
            this.dgvServiceReport.RowHeadersWidth = 51;
            this.dgvServiceReport.RowTemplate.Height = 24;
            this.dgvServiceReport.Size = new System.Drawing.Size(801, 355);
            this.dgvServiceReport.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Service Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount (RM)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_UI.Properties.Resources.SerRepContainer;
            this.pictureBox1.Location = new System.Drawing.Point(22, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // PicbBack1
            // 
            this.PicbBack1.FlatAppearance.BorderSize = 0;
            this.PicbBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PicbBack1.Image = global::Login_UI.Properties.Resources.back_3;
            this.PicbBack1.Location = new System.Drawing.Point(12, 12);
            this.PicbBack1.Name = "PicbBack1";
            this.PicbBack1.Size = new System.Drawing.Size(46, 41);
            this.PicbBack1.TabIndex = 23;
            this.PicbBack1.UseVisualStyleBackColor = true;
            this.PicbBack1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PicbLogo
            // 
            this.PicbLogo.Image = global::Login_UI.Properties.Resources.IOOPKakiLOGO;
            this.PicbLogo.Location = new System.Drawing.Point(370, 2);
            this.PicbLogo.Name = "PicbLogo";
            this.PicbLogo.Size = new System.Drawing.Size(219, 76);
            this.PicbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicbLogo.TabIndex = 0;
            this.PicbLogo.TabStop = false;
            // 
            // lblNoDataAlert
            // 
            this.lblNoDataAlert.AutoSize = true;
            this.lblNoDataAlert.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.lblNoDataAlert.Location = new System.Drawing.Point(351, 310);
            this.lblNoDataAlert.Name = "lblNoDataAlert";
            this.lblNoDataAlert.Size = new System.Drawing.Size(254, 19);
            this.lblNoDataAlert.TabIndex = 25;
            this.lblNoDataAlert.Text = "No relative information in this selection";
            this.lblNoDataAlert.Visible = false;
            // 
            // ServiceReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 532);
            this.Controls.Add(this.lblNoDataAlert);
            this.Controls.Add(this.PicbBack1);
            this.Controls.Add(this.dgvServiceReport);
            this.Controls.Add(this.lblServiceRepTitle);
            this.Controls.Add(this.PicbLogo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceReport";
            this.Load += new System.EventHandler(this.ServiceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicbLogo;
        private System.Windows.Forms.Label lblServiceRepTitle;
        private System.Windows.Forms.DataGridView dgvServiceReport;
        private System.Windows.Forms.Button PicbBack1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNoDataAlert;
    }
}