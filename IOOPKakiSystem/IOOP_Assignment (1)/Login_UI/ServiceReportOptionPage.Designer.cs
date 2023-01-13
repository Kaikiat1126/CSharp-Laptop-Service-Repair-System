
namespace Login_UI
{
    partial class ServiceReportOptionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceReportOptionPage));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblServiceR = new System.Windows.Forms.Label();
            this.comboSerType = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(355, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 470);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblServiceR
            // 
            this.lblServiceR.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F);
            this.lblServiceR.Location = new System.Drawing.Point(347, 18);
            this.lblServiceR.Name = "lblServiceR";
            this.lblServiceR.Size = new System.Drawing.Size(249, 51);
            this.lblServiceR.TabIndex = 2;
            this.lblServiceR.Text = "Service Report";
            // 
            // comboSerType
            // 
            this.comboSerType.BackColor = System.Drawing.Color.White;
            this.comboSerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSerType.FormattingEnabled = true;
            this.comboSerType.Items.AddRange(new object[] {
            "-ALL-",
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement ",
            "Operating System Format and Installation",
            "Data Backup and recovery ",
            "Internet connectivity issues"});
            this.comboSerType.Location = new System.Drawing.Point(415, 261);
            this.comboSerType.Name = "comboSerType";
            this.comboSerType.Size = new System.Drawing.Size(316, 28);
            this.comboSerType.TabIndex = 10;
            // 
            // comboMonth
            // 
            this.comboMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "Disember"});
            this.comboMonth.Location = new System.Drawing.Point(415, 349);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(316, 28);
            this.comboMonth.TabIndex = 11;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F);
            this.lblServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblServiceType.Location = new System.Drawing.Point(411, 232);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(106, 22);
            this.lblServiceType.TabIndex = 5;
            this.lblServiceType.Text = "Service type";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblMonth.Location = new System.Drawing.Point(411, 320);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(62, 22);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_UI.Properties.Resources.SerRepOptSideImg;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::Login_UI.Properties.Resources.deepgreenBTN_mid_;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F);
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(695, 486);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 47);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Login_UI.Properties.Resources.OrangeLogo;
            this.pictureBox3.Location = new System.Drawing.Point(383, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(406, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // comboYear
            // 
            this.comboYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.comboYear.Location = new System.Drawing.Point(416, 435);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(316, 28);
            this.comboYear.TabIndex = 23;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblYear.Location = new System.Drawing.Point(412, 406);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 22);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "Year";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Login_UI.Properties.Resources.back_icon;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ServiceReportOptionPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboSerType);
            this.Controls.Add(this.lblServiceR);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceReportOptionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceReportOptionPage";
            this.Load += new System.EventHandler(this.ServiceReportOptionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblServiceR;
        private System.Windows.Forms.ComboBox comboSerType;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}