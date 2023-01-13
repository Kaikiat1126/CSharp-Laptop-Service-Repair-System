namespace Login_UI
{
    partial class TechnicianPage
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
            this.lblNameT = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.picbProfileC = new System.Windows.Forms.PictureBox();
            this.btnUpdCusSerSts = new System.Windows.Forms.Button();
            this.btnServiceRequest = new System.Windows.Forms.Button();
            this.picbillustrationT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbProfileC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbillustrationT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameT
            // 
            this.lblNameT.AutoSize = true;
            this.lblNameT.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblNameT.Location = new System.Drawing.Point(690, 72);
            this.lblNameT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameT.Name = "lblNameT";
            this.lblNameT.Size = new System.Drawing.Size(68, 27);
            this.lblNameT.TabIndex = 46;
            this.lblNameT.Text = "Name";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblCustomer.Location = new System.Drawing.Point(393, 62);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(183, 39);
            this.lblCustomer.TabIndex = 45;
            this.lblCustomer.Text = "Technician";
            // 
            // picbProfileC
            // 
            this.picbProfileC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbProfileC.Image = global::Login_UI.Properties.Resources.profilepic_T_;
            this.picbProfileC.Location = new System.Drawing.Point(797, 39);
            this.picbProfileC.Margin = new System.Windows.Forms.Padding(2);
            this.picbProfileC.Name = "picbProfileC";
            this.picbProfileC.Size = new System.Drawing.Size(76, 81);
            this.picbProfileC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbProfileC.TabIndex = 44;
            this.picbProfileC.TabStop = false;
            this.picbProfileC.Click += new System.EventHandler(this.picbProfileC_Click);
            // 
            // btnUpdCusSerSts
            // 
            this.btnUpdCusSerSts.BackgroundImage = global::Login_UI.Properties.Resources.greenBTN_Big_;
            this.btnUpdCusSerSts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdCusSerSts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdCusSerSts.FlatAppearance.BorderSize = 0;
            this.btnUpdCusSerSts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdCusSerSts.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdCusSerSts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnUpdCusSerSts.Image = global::Login_UI.Properties.Resources.CusSerStsIcon;
            this.btnUpdCusSerSts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdCusSerSts.Location = new System.Drawing.Point(395, 378);
            this.btnUpdCusSerSts.Name = "btnUpdCusSerSts";
            this.btnUpdCusSerSts.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnUpdCusSerSts.Size = new System.Drawing.Size(477, 193);
            this.btnUpdCusSerSts.TabIndex = 49;
            this.btnUpdCusSerSts.Text = "    Update Customer Service Status";
            this.btnUpdCusSerSts.UseVisualStyleBackColor = true;
            this.btnUpdCusSerSts.Click += new System.EventHandler(this.btnUpdCusSerSts_Click);
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.BackgroundImage = global::Login_UI.Properties.Resources.deepgreenBTN_Big_;
            this.btnServiceRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServiceRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceRequest.FlatAppearance.BorderSize = 0;
            this.btnServiceRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequest.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnServiceRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnServiceRequest.Image = global::Login_UI.Properties.Resources.ViewSerReqIcon;
            this.btnServiceRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceRequest.Location = new System.Drawing.Point(395, 168);
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.btnServiceRequest.Size = new System.Drawing.Size(477, 193);
            this.btnServiceRequest.TabIndex = 48;
            this.btnServiceRequest.Text = "View Service Requestion";
            this.btnServiceRequest.UseVisualStyleBackColor = true;
            this.btnServiceRequest.Click += new System.EventHandler(this.btnServiceRequest_Click);
            // 
            // picbillustrationT
            // 
            this.picbillustrationT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbillustrationT.Image = global::Login_UI.Properties.Resources.illustrationT;
            this.picbillustrationT.Location = new System.Drawing.Point(-2, -24);
            this.picbillustrationT.Name = "picbillustrationT";
            this.picbillustrationT.Size = new System.Drawing.Size(355, 706);
            this.picbillustrationT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbillustrationT.TabIndex = 47;
            this.picbillustrationT.TabStop = false;
            // 
            // TechnicianPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.btnUpdCusSerSts);
            this.Controls.Add(this.btnServiceRequest);
            this.Controls.Add(this.picbillustrationT);
            this.Controls.Add(this.lblNameT);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.picbProfileC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TechnicianPage";
            this.Text = "Technician Page";
            this.Load += new System.EventHandler(this.TechnicianPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbProfileC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbillustrationT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameT;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox picbProfileC;
        private System.Windows.Forms.Button btnUpdCusSerSts;
        private System.Windows.Forms.Button btnServiceRequest;
        private System.Windows.Forms.PictureBox picbillustrationT;
    }
}