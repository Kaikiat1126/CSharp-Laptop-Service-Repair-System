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
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnChangeMySer_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeMyServiceRequest request = new ChangeMyServiceRequest();
            request.Show();
        }

        private void btnViewMySer_Click(object sender, EventArgs e)
        {
            this.Close();
            MyService myService = new MyService();
            myService.Show();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            lblNameC.Text = Login.instance.userInfo.userUsername;
        }

        private void picbProfileC_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile = new Profile(1);
            profile.Show();
        }
    }
}
