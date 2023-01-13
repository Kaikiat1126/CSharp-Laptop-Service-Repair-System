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
    public partial class ReceptionistPage : Form
    {
        public ReceptionistPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void picbProfileC_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile = new Profile(1);
            profile.Show();
        }

        private void btnRegisterNewCus_Click(object sender, EventArgs e)
        {
            this.Close();
            Register register = new Register("cus", 1);
            register.Show();
        }

        private void btnRequestService_Click(object sender, EventArgs e)
        {
            this.Close();
            NewServiceRequestion newservice = new NewServiceRequestion();
            newservice.Show();
        }

        private void btnCustomerPayment_Click(object sender, EventArgs e)
        {
            this.Close();
            PaymentPage payment = new PaymentPage();
            payment.Show();
        }

        private void ReceptionistPage_Load(object sender, EventArgs e)
        {
            lblNameR.Text = Login.instance.userInfo.userUsername;
        }
    }
}
