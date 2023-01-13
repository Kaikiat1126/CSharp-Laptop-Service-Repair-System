namespace Login_UI
{
    partial class CustomerPage
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
            this.btnChangeMySer = new System.Windows.Forms.Button();
            this.btnViewMySer = new System.Windows.Forms.Button();
            this.lblNameC = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.picbProfileC = new System.Windows.Forms.PictureBox();
            this.picbillustrationC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbProfileC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbillustrationC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeMySer
            // 
            this.btnChangeMySer.BackgroundImage = global::Login_UI.Properties.Resources.deeporangeBTN_Big_;
            this.btnChangeMySer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeMySer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeMySer.FlatAppearance.BorderSize = 0;
            this.btnChangeMySer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMySer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeMySer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnChangeMySer.Image = global::Login_UI.Properties.Resources.ChaMySerReqIcon;
            this.btnChangeMySer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeMySer.Location = new System.Drawing.Point(430, 159);
            this.btnChangeMySer.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeMySer.Name = "btnChangeMySer";
            this.btnChangeMySer.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnChangeMySer.Size = new System.Drawing.Size(392, 157);
            this.btnChangeMySer.TabIndex = 42;
            this.btnChangeMySer.Text = "Change My Service Request";
            this.btnChangeMySer.UseVisualStyleBackColor = true;
            this.btnChangeMySer.Click += new System.EventHandler(this.btnChangeMySer_Click);
            // 
            // btnViewMySer
            // 
            this.btnViewMySer.BackgroundImage = global::Login_UI.Properties.Resources.orangeBTN_Big_;
            this.btnViewMySer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewMySer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMySer.FlatAppearance.BorderSize = 0;
            this.btnViewMySer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMySer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewMySer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnViewMySer.Image = global::Login_UI.Properties.Resources.ViewMySerIcon;
            this.btnViewMySer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewMySer.Location = new System.Drawing.Point(430, 374);
            this.btnViewMySer.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMySer.Name = "btnViewMySer";
            this.btnViewMySer.Padding = new System.Windows.Forms.Padding(38, 0, 60, 0);
            this.btnViewMySer.Size = new System.Drawing.Size(392, 157);
            this.btnViewMySer.TabIndex = 41;
            this.btnViewMySer.Text = "View My Service";
            this.btnViewMySer.UseVisualStyleBackColor = true;
            this.btnViewMySer.Click += new System.EventHandler(this.btnViewMySer_Click);
            // 
            // lblNameC
            // 
            this.lblNameC.AutoSize = true;
            this.lblNameC.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblNameC.Location = new System.Drawing.Point(684, 72);
            this.lblNameC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameC.Name = "lblNameC";
            this.lblNameC.Size = new System.Drawing.Size(68, 27);
            this.lblNameC.TabIndex = 40;
            this.lblNameC.Text = "Name";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblCustomer.Location = new System.Drawing.Point(384, 62);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(164, 39);
            this.lblCustomer.TabIndex = 39;
            this.lblCustomer.Text = "Customer";
            // 
            // picbProfileC
            // 
            this.picbProfileC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbProfileC.Image = global::Login_UI.Properties.Resources.profilepic_C_;
            this.picbProfileC.Location = new System.Drawing.Point(790, 39);
            this.picbProfileC.Margin = new System.Windows.Forms.Padding(2);
            this.picbProfileC.Name = "picbProfileC";
            this.picbProfileC.Size = new System.Drawing.Size(76, 81);
            this.picbProfileC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbProfileC.TabIndex = 38;
            this.picbProfileC.TabStop = false;
            this.picbProfileC.Click += new System.EventHandler(this.picbProfileC_Click);
            // 
            // picbillustrationC
            // 
            this.picbillustrationC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbillustrationC.Dock = System.Windows.Forms.DockStyle.Left;
            this.picbillustrationC.Image = global::Login_UI.Properties.Resources.CustomerIllustration;
            this.picbillustrationC.Location = new System.Drawing.Point(0, 0);
            this.picbillustrationC.Margin = new System.Windows.Forms.Padding(2);
            this.picbillustrationC.Name = "picbillustrationC";
            this.picbillustrationC.Size = new System.Drawing.Size(321, 601);
            this.picbillustrationC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbillustrationC.TabIndex = 37;
            this.picbillustrationC.TabStop = false;
            // 
            // CustomerPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.btnChangeMySer);
            this.Controls.Add(this.btnViewMySer);
            this.Controls.Add(this.lblNameC);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.picbProfileC);
            this.Controls.Add(this.picbillustrationC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerPage";
            this.Text = "Customer Page";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbProfileC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbillustrationC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeMySer;
        private System.Windows.Forms.Button btnViewMySer;
        private System.Windows.Forms.Label lblNameC;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox picbProfileC;
        private System.Windows.Forms.PictureBox picbillustrationC;
    }
}