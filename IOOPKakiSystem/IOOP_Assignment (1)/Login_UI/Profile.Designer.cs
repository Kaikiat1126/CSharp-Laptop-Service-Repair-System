namespace Login_UI
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPsPage = new System.Windows.Forms.Label();
            this.picPasswordPage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEditPage = new System.Windows.Forms.Label();
            this.picEditPage = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panelProfileContainer = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordPage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 601);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblLogout);
            this.panel4.Controls.Add(this.picLogout);
            this.panel4.Location = new System.Drawing.Point(27, 546);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 34);
            this.panel4.TabIndex = 12;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(87, 5);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(68, 24);
            this.lblLogout.TabIndex = 10;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::Login_UI.Properties.Resources.signout;
            this.picLogout.Location = new System.Drawing.Point(1, 1);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(32, 32);
            this.picLogout.TabIndex = 10;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPsPage);
            this.panel3.Controls.Add(this.picPasswordPage);
            this.panel3.Location = new System.Drawing.Point(28, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 34);
            this.panel3.TabIndex = 11;
            // 
            // lblPsPage
            // 
            this.lblPsPage.AutoSize = true;
            this.lblPsPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPsPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsPage.Location = new System.Drawing.Point(39, 5);
            this.lblPsPage.Name = "lblPsPage";
            this.lblPsPage.Size = new System.Drawing.Size(201, 24);
            this.lblPsPage.TabIndex = 10;
            this.lblPsPage.Text = "Password and Security";
            this.lblPsPage.Click += new System.EventHandler(this.lblPsPage_Click);
            // 
            // picPasswordPage
            // 
            this.picPasswordPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPasswordPage.Image = global::Login_UI.Properties.Resources.provide;
            this.picPasswordPage.Location = new System.Drawing.Point(1, 1);
            this.picPasswordPage.Name = "picPasswordPage";
            this.picPasswordPage.Size = new System.Drawing.Size(32, 32);
            this.picPasswordPage.TabIndex = 10;
            this.picPasswordPage.TabStop = false;
            this.picPasswordPage.Click += new System.EventHandler(this.picPasswordPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEditPage);
            this.panel2.Controls.Add(this.picEditPage);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(27, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 34);
            this.panel2.TabIndex = 10;
            // 
            // lblEditPage
            // 
            this.lblEditPage.AutoSize = true;
            this.lblEditPage.BackColor = System.Drawing.Color.Transparent;
            this.lblEditPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPage.ForeColor = System.Drawing.Color.Black;
            this.lblEditPage.Location = new System.Drawing.Point(72, 5);
            this.lblEditPage.Name = "lblEditPage";
            this.lblEditPage.Size = new System.Drawing.Size(99, 24);
            this.lblEditPage.TabIndex = 13;
            this.lblEditPage.Text = "Edit Profile";
            this.lblEditPage.Click += new System.EventHandler(this.lblEditPage_Click);
            // 
            // picEditPage
            // 
            this.picEditPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditPage.Image = global::Login_UI.Properties.Resources.pen;
            this.picEditPage.Location = new System.Drawing.Point(1, 1);
            this.picEditPage.Name = "picEditPage";
            this.picEditPage.Size = new System.Drawing.Size(32, 32);
            this.picEditPage.TabIndex = 10;
            this.picEditPage.TabStop = false;
            this.picEditPage.Click += new System.EventHandler(this.picEditPage_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxLogo.Image = global::Login_UI.Properties.Resources.GreenLogo;
            this.picBoxLogo.Location = new System.Drawing.Point(3, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(285, 94);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.Click += new System.EventHandler(this.picBoxLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.label1.Location = new System.Drawing.Point(337, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "My Profile";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(339, 99);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(143, 29);
            this.title.TabIndex = 9;
            this.title.Text = "Edit Profile";
            // 
            // panelProfileContainer
            // 
            this.panelProfileContainer.Location = new System.Drawing.Point(328, 147);
            this.panelProfileContainer.Name = "panelProfileContainer";
            this.panelProfileContainer.Size = new System.Drawing.Size(515, 375);
            this.panelProfileContainer.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::Login_UI.Properties.Resources.smallSaveBtn;
            this.btnSave.Location = new System.Drawing.Point(755, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUsername.Location = new System.Drawing.Point(533, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(41, 17);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "user";
            // 
            // Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panelProfileContainer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordPage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPsPage;
        private System.Windows.Forms.PictureBox picPasswordPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picEditPage;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.Panel panelProfileContainer;
        private System.Windows.Forms.Label lblEditPage;
        private System.Windows.Forms.Label lblUsername;
    }
}