
namespace Login_UI
{
    partial class PaymentPage
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
            this.pnlheader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblChoosePM = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtCusname = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblDService = new System.Windows.Forms.Label();
            this.lblDAmount = new System.Windows.Forms.Label();
            this.lblDStatus = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOnlineB = new System.Windows.Forms.Button();
            this.btnCBCard = new System.Windows.Forms.Button();
            this.btnEwallet = new System.Windows.Forms.Button();
            this.picbInputPanel = new System.Windows.Forms.PictureBox();
            this.pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbInputPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.pnlheader.Controls.Add(this.panel1);
            this.pnlheader.Controls.Add(this.lblPayment);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(882, 75);
            this.pnlheader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login_UI.Properties.Resources.back_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 44);
            this.panel1.TabIndex = 21;
            this.panel1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F);
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblPayment.Location = new System.Drawing.Point(71, 12);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(121, 36);
            this.lblPayment.TabIndex = 2;
            this.lblPayment.Text = "Payment";
            // 
            // lblChoosePM
            // 
            this.lblChoosePM.AutoSize = true;
            this.lblChoosePM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblChoosePM.Location = new System.Drawing.Point(138, 123);
            this.lblChoosePM.Name = "lblChoosePM";
            this.lblChoosePM.Size = new System.Drawing.Size(177, 19);
            this.lblChoosePM.TabIndex = 2;
            this.lblChoosePM.Text = "Choose a payment method:";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.lblCusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblCusName.Location = new System.Drawing.Point(141, 285);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(90, 15);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Customer Name";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblService.Location = new System.Drawing.Point(141, 352);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(44, 15);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Service";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblStatus.Location = new System.Drawing.Point(494, 352);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblAmount.Location = new System.Drawing.Point(141, 414);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(47, 15);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.lblReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblReference.Location = new System.Drawing.Point(141, 480);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(58, 15);
            this.lblReference.TabIndex = 9;
            this.lblReference.Text = "Reference";
            // 
            // txtCusname
            // 
            this.txtCusname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCusname.Location = new System.Drawing.Point(145, 317);
            this.txtCusname.Name = "txtCusname";
            this.txtCusname.Size = new System.Drawing.Size(446, 18);
            this.txtCusname.TabIndex = 10;
            // 
            // txtReference
            // 
            this.txtReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReference.Location = new System.Drawing.Point(145, 511);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(442, 18);
            this.txtReference.TabIndex = 11;
            // 
            // lblDService
            // 
            this.lblDService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblDService.Location = new System.Drawing.Point(146, 380);
            this.lblDService.Name = "lblDService";
            this.lblDService.Size = new System.Drawing.Size(326, 23);
            this.lblDService.TabIndex = 13;
            // 
            // lblDAmount
            // 
            this.lblDAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblDAmount.Location = new System.Drawing.Point(146, 445);
            this.lblDAmount.Name = "lblDAmount";
            this.lblDAmount.Size = new System.Drawing.Size(441, 23);
            this.lblDAmount.TabIndex = 14;
            // 
            // lblDStatus
            // 
            this.lblDStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblDStatus.Location = new System.Drawing.Point(496, 380);
            this.lblDStatus.Name = "lblDStatus";
            this.lblDStatus.Size = new System.Drawing.Size(95, 23);
            this.lblDStatus.TabIndex = 15;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackgroundImage = global::Login_UI.Properties.Resources.deepgreenBTN_mid_;
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnCheckout.Location = new System.Drawing.Point(637, 499);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(133, 47);
            this.btnCheckout.TabIndex = 20;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::Login_UI.Properties.Resources.deepgreenBTN_mid_;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnOK.Location = new System.Drawing.Point(637, 499);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 47);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOnlineB
            // 
            this.btnOnlineB.BackgroundImage = global::Login_UI.Properties.Resources.PaymentBTN;
            this.btnOnlineB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOnlineB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnlineB.FlatAppearance.BorderSize = 0;
            this.btnOnlineB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlineB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.btnOnlineB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnOnlineB.Image = global::Login_UI.Properties.Resources.onlinebIcon;
            this.btnOnlineB.Location = new System.Drawing.Point(576, 155);
            this.btnOnlineB.Name = "btnOnlineB";
            this.btnOnlineB.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnOnlineB.Size = new System.Drawing.Size(143, 95);
            this.btnOnlineB.TabIndex = 18;
            this.btnOnlineB.Text = "Credit/Debit Card";
            this.btnOnlineB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOnlineB.UseVisualStyleBackColor = true;
            this.btnOnlineB.Click += new System.EventHandler(this.btnOnlineB_Click);
            // 
            // btnCBCard
            // 
            this.btnCBCard.BackgroundImage = global::Login_UI.Properties.Resources.PaymentBTN;
            this.btnCBCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCBCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCBCard.FlatAppearance.BorderSize = 0;
            this.btnCBCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCBCard.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.btnCBCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnCBCard.Image = global::Login_UI.Properties.Resources.cardIcon;
            this.btnCBCard.Location = new System.Drawing.Point(377, 155);
            this.btnCBCard.Name = "btnCBCard";
            this.btnCBCard.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCBCard.Size = new System.Drawing.Size(143, 95);
            this.btnCBCard.TabIndex = 17;
            this.btnCBCard.Text = "Credit/Debit Card";
            this.btnCBCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCBCard.UseVisualStyleBackColor = true;
            this.btnCBCard.Click += new System.EventHandler(this.btnCBCard_Click);
            // 
            // btnEwallet
            // 
            this.btnEwallet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEwallet.BackgroundImage = global::Login_UI.Properties.Resources.PaymentBTN;
            this.btnEwallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEwallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEwallet.FlatAppearance.BorderSize = 0;
            this.btnEwallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEwallet.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F);
            this.btnEwallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnEwallet.Image = global::Login_UI.Properties.Resources.ewalletIcon;
            this.btnEwallet.Location = new System.Drawing.Point(178, 155);
            this.btnEwallet.Name = "btnEwallet";
            this.btnEwallet.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnEwallet.Size = new System.Drawing.Size(143, 95);
            this.btnEwallet.TabIndex = 16;
            this.btnEwallet.Text = "E-Wallet";
            this.btnEwallet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEwallet.UseVisualStyleBackColor = false;
            this.btnEwallet.Click += new System.EventHandler(this.btnEwallet_Click);
            // 
            // picbInputPanel
            // 
            this.picbInputPanel.Image = global::Login_UI.Properties.Resources.Paymentinputpanel1;
            this.picbInputPanel.Location = new System.Drawing.Point(88, 82);
            this.picbInputPanel.Name = "picbInputPanel";
            this.picbInputPanel.Size = new System.Drawing.Size(716, 493);
            this.picbInputPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbInputPanel.TabIndex = 1;
            this.picbInputPanel.TabStop = false;
            // 
            // PaymentPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnOnlineB);
            this.Controls.Add(this.btnCBCard);
            this.Controls.Add(this.btnEwallet);
            this.Controls.Add(this.lblDStatus);
            this.Controls.Add(this.lblDAmount);
            this.Controls.Add(this.lblDService);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtCusname);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.lblChoosePM);
            this.Controls.Add(this.picbInputPanel);
            this.Controls.Add(this.pnlheader);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PaymentPage";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbInputPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.PictureBox picbInputPanel;
        private System.Windows.Forms.Label lblChoosePM;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.TextBox txtCusname;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblDService;
        private System.Windows.Forms.Label lblDAmount;
        private System.Windows.Forms.Label lblDStatus;
        private System.Windows.Forms.Button btnEwallet;
        private System.Windows.Forms.Button btnCBCard;
        private System.Windows.Forms.Button btnOnlineB;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel panel1;
    }
}