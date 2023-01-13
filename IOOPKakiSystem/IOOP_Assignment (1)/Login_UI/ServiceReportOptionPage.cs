using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class ServiceReportOptionPage : Form
    {
        public ServiceReportOptionPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
         
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboSerType.Text == "" || comboMonth.Text =="" || comboYear.Text == "")
            {
                MessageBox.Show("Please Select all the Option!");
            }
            else
            {
                ServiceReport newSerRep = new ServiceReport(comboSerType.Text, comboMonth.Text, comboYear.Text);
                newSerRep.ShowDialog();
            }
        }

        private void ServiceReportOptionPage_Load(object sender, EventArgs e)
        {
            comboMonth.SelectedIndex = 0;
            comboSerType.SelectedIndex = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage admin = new AdminPage();
            admin.ShowDialog();
        }
    }
}
