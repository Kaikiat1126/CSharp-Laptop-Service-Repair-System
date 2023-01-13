namespace Login_UI
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.lblNameA = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.picbProfileC = new System.Windows.Forms.PictureBox();
            this.picbillustrationC = new System.Windows.Forms.PictureBox();
            this.btnIncomeReport = new System.Windows.Forms.Button();
            this.btnSerRep = new System.Windows.Forms.Button();
            this.btnEmployeeRes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbProfileC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbillustrationC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameA
            // 
            this.lblNameA.AutoSize = true;
            this.lblNameA.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblNameA.Location = new System.Drawing.Point(690, 74);
            this.lblNameA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameA.Name = "lblNameA";
            this.lblNameA.Size = new System.Drawing.Size(68, 27);
            this.lblNameA.TabIndex = 46;
            this.lblNameA.Text = "Name";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblCustomer.Location = new System.Drawing.Point(391, 64);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(114, 39);
            this.lblCustomer.TabIndex = 45;
            this.lblCustomer.Text = "Admin";
            // 
            // picbProfileC
            // 
            this.picbProfileC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbProfileC.Image = global::Login_UI.Properties.Resources.AdminProfilePic;
            this.picbProfileC.Location = new System.Drawing.Point(797, 41);
            this.picbProfileC.Margin = new System.Windows.Forms.Padding(2);
            this.picbProfileC.Name = "picbProfileC";
            this.picbProfileC.Size = new System.Drawing.Size(76, 81);
            this.picbProfileC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbProfileC.TabIndex = 44;
            this.picbProfileC.TabStop = false;
            this.picbProfileC.Click += new System.EventHandler(this.picbProfileC_Click);
            // 
            // picbillustrationC
            // 
            this.picbillustrationC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbillustrationC.Dock = System.Windows.Forms.DockStyle.Left;
            this.picbillustrationC.Image = global::Login_UI.Properties.Resources.AdminIllustration;
            this.picbillustrationC.Location = new System.Drawing.Point(0, 0);
            this.picbillustrationC.Margin = new System.Windows.Forms.Padding(2);
            this.picbillustrationC.Name = "picbillustrationC";
            this.picbillustrationC.Size = new System.Drawing.Size(321, 601);
            this.picbillustrationC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbillustrationC.TabIndex = 43;
            this.picbillustrationC.TabStop = false;
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncomeReport.BackgroundImage")));
            this.btnIncomeReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncomeReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncomeReport.FlatAppearance.BorderSize = 0;
            this.btnIncomeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomeReport.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnIncomeReport.Image = global::Login_UI.Properties.Resources.IncRepIcon;
            this.btnIncomeReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncomeReport.Location = new System.Drawing.Point(397, 452);
            this.btnIncomeReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Padding = new System.Windows.Forms.Padding(45, 0, 77, 0);
            this.btnIncomeReport.Size = new System.Drawing.Size(421, 139);
            this.btnIncomeReport.TabIndex = 49;
            this.btnIncomeReport.Text = "Income Report";
            this.btnIncomeReport.UseVisualStyleBackColor = true;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // btnSerRep
            // 
            this.btnSerRep.BackgroundImage = global::Login_UI.Properties.Resources.orangeBTN;
            this.btnSerRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerRep.FlatAppearance.BorderSize = 0;
            this.btnSerRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerRep.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnSerRep.Image = global::Login_UI.Properties.Resources.SerRepIcon;
            this.btnSerRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerRep.Location = new System.Drawing.Point(397, 298);
            this.btnSerRep.Margin = new System.Windows.Forms.Padding(2);
            this.btnSerRep.Name = "btnSerRep";
            this.btnSerRep.Padding = new System.Windows.Forms.Padding(38, 0, 79, 0);
            this.btnSerRep.Size = new System.Drawing.Size(421, 139);
            this.btnSerRep.TabIndex = 48;
            this.btnSerRep.Text = "Service Report";
            this.btnSerRep.UseVisualStyleBackColor = true;
            this.btnSerRep.Click += new System.EventHandler(this.btnSerRep_Click);
            // 
            // btnEmployeeRes
            // 
            this.btnEmployeeRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeRes.BackgroundImage")));
            this.btnEmployeeRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployeeRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeRes.FlatAppearance.BorderSize = 0;
            this.btnEmployeeRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRes.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnEmployeeRes.Image = global::Login_UI.Properties.Resources.online_registration_1;
            this.btnEmployeeRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeRes.Location = new System.Drawing.Point(397, 155);
            this.btnEmployeeRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeRes.Name = "btnEmployeeRes";
            this.btnEmployeeRes.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.btnEmployeeRes.Size = new System.Drawing.Size(421, 139);
            this.btnEmployeeRes.TabIndex = 47;
            this.btnEmployeeRes.Text = "Employee Registration";
            this.btnEmployeeRes.UseVisualStyleBackColor = true;
            this.btnEmployeeRes.Click += new System.EventHandler(this.btnEmployeeRes_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.btnIncomeReport);
            this.Controls.Add(this.btnSerRep);
            this.Controls.Add(this.btnEmployeeRes);
            this.Controls.Add(this.lblNameA);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.picbProfileC);
            this.Controls.Add(this.picbillustrationC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbProfileC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbillustrationC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameA;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox picbProfileC;
        private System.Windows.Forms.PictureBox picbillustrationC;
        private System.Windows.Forms.Button btnIncomeReport;
        private System.Windows.Forms.Button btnSerRep;
        private System.Windows.Forms.Button btnEmployeeRes;
    }
}