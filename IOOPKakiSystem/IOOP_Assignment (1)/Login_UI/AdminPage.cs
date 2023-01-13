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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            lblNameA.Text = Login.instance.userInfo.userUsername;
        }

        private void picbProfileC_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile = new Profile(1);
            profile.Show();
        }


        //Function Buttom
        private void btnEmployeeRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register("emp", 1);
            register.Show();
        }

        private void btnSerRep_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceReportOptionPage svreportop = new ServiceReportOptionPage();
            svreportop.Show();
        }

        private void btnIncomeReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Income_Report income = new Income_Report();
            income.Show();
        }
    }
}
