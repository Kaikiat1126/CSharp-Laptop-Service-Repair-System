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
    public partial class TechnicianPage : Form
    {
        public TechnicianPage()
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

        private void TechnicianPage_Load(object sender, EventArgs e)
        {
            lblNameT.Text = Login.instance.userInfo.userUsername;
        }

        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewServiceRequestion viewsvrq = new ViewServiceRequestion();
            viewsvrq.Show();
        }

        private void btnUpdCusSerSts_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateCustomerServiceStatus update = new UpdateCustomerServiceStatus();
            update.Show();
        }
    }
}
