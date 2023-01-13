
namespace Login_UI
{
    partial class Income_Report
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
            this.lblRepTitle = new System.Windows.Forms.Label();
            this.dgvIncomeReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblYear = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.lblNoDataAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRepTitle
            // 
            this.lblRepTitle.AutoSize = true;
            this.lblRepTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F, System.Drawing.FontStyle.Bold);
            this.lblRepTitle.Location = new System.Drawing.Point(404, 118);
            this.lblRepTitle.Name = "lblRepTitle";
            this.lblRepTitle.Size = new System.Drawing.Size(112, 15);
            this.lblRepTitle.TabIndex = 3;
            this.lblRepTitle.Text = "20XX Income Report";
            // 
            // dgvIncomeReport
            // 
            this.dgvIncomeReport.AllowUserToAddRows = false;
            this.dgvIncomeReport.AllowUserToDeleteRows = false;
            this.dgvIncomeReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncomeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomeReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvIncomeReport.Location = new System.Drawing.Point(93, 165);
            this.dgvIncomeReport.Name = "dgvIncomeReport";
            this.dgvIncomeReport.ReadOnly = true;
            this.dgvIncomeReport.RowHeadersWidth = 51;
            this.dgvIncomeReport.RowTemplate.Height = 24;
            this.dgvIncomeReport.Size = new System.Drawing.Size(723, 343);
            this.dgvIncomeReport.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Months";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 450;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total Order";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RM";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.lblYear.Location = new System.Drawing.Point(682, 14);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 15);
            this.lblYear.TabIndex = 25;
            this.lblYear.Text = "Year";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Login_UI.Properties.Resources.YearCombo;
            this.pictureBox3.Location = new System.Drawing.Point(675, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Login_UI.Properties.Resources.back_3;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 39);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login_UI.Properties.Resources.IncomeRepFrame;
            this.pictureBox2.Location = new System.Drawing.Point(46, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(824, 469);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_UI.Properties.Resources.IOOPKakiLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(367, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboYear
            // 
            this.comboYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.comboYear.Location = new System.Drawing.Point(695, 41);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(85, 21);
            this.comboYear.TabIndex = 27;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            // 
            // lblNoDataAlert
            // 
            this.lblNoDataAlert.AutoSize = true;
            this.lblNoDataAlert.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.lblNoDataAlert.Location = new System.Drawing.Point(330, 317);
            this.lblNoDataAlert.Name = "lblNoDataAlert";
            this.lblNoDataAlert.Size = new System.Drawing.Size(205, 19);
            this.lblNoDataAlert.TabIndex = 28;
            this.lblNoDataAlert.Text = "No Relative Information Existed";
            this.lblNoDataAlert.Visible = false;
            // 
            // Income_Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.lblNoDataAlert);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvIncomeReport);
            this.Controls.Add(this.lblRepTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Income_Report";
            this.Text = "Income_Report";
            this.Load += new System.EventHandler(this.Income_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRepTitle;
        private System.Windows.Forms.DataGridView dgvIncomeReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label lblNoDataAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}