namespace Login_UI
{
    partial class MyService
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
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblCollectionDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.comboMyOrder = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceType
            // 
            this.lblServiceType.BackColor = System.Drawing.SystemColors.Window;
            this.lblServiceType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(56, 270);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblServiceType.Size = new System.Drawing.Size(316, 31);
            this.lblServiceType.TabIndex = 2;
            this.lblServiceType.Text = "test";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.BackColor = System.Drawing.SystemColors.Window;
            this.lblAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(56, 372);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblAmountPaid.Size = new System.Drawing.Size(316, 31);
            this.lblAmountPaid.TabIndex = 3;
            this.lblAmountPaid.Text = "test";
            // 
            // lblCollectionDate
            // 
            this.lblCollectionDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCollectionDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCollectionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionDate.Location = new System.Drawing.Point(495, 169);
            this.lblCollectionDate.Name = "lblCollectionDate";
            this.lblCollectionDate.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblCollectionDate.Size = new System.Drawing.Size(316, 31);
            this.lblCollectionDate.TabIndex = 4;
            this.lblCollectionDate.Text = "test";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(495, 270);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblDescription.Size = new System.Drawing.Size(316, 248);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "test";
            // 
            // comboMyOrder
            // 
            this.comboMyOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMyOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMyOrder.FormattingEnabled = true;
            this.comboMyOrder.Location = new System.Drawing.Point(56, 169);
            this.comboMyOrder.Name = "comboMyOrder";
            this.comboMyOrder.Size = new System.Drawing.Size(316, 26);
            this.comboMyOrder.TabIndex = 8;
            this.comboMyOrder.SelectedValueChanged += new System.EventHandler(this.comboMyOrder_SelectedValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(56, 487);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(316, 31);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "test";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = global::Login_UI.Properties.Resources.back_icon;
            this.picBack.Location = new System.Drawing.Point(22, 29);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(32, 32);
            this.picBack.TabIndex = 1;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Login_UI.Properties.Resources.MyService;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 601);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MyService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.comboMyOrder);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCollectionDate);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyService";
            this.Text = "My Service";
            this.Load += new System.EventHandler(this.MyService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblCollectionDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox comboMyOrder;
        private System.Windows.Forms.Label lblStatus;
    }
}