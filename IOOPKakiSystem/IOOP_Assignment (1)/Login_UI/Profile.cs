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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private int num = 0;

        public Profile(int numInput)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            /*type = typeInput;*/
            num = numInput;
            IniteTitle();
            InitPanel();
            IniteInfo();
        }

        private void IniteTitle()
        {
            if (num == 1)
            {
                title.Text = "Edit Profile";
            }
            else if (num == 2)
            {
                title.Text = "Password and Security";
            }
        }

        private void IniteInfo()
        {
            //lblUsername.Text = Login.instance.userInfo.userName;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelProfileContainer.Controls.Clear();
            panelProfileContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        dynamic currentControl = null;

        private void InitPanel()
        {
            if(num == 1)
            {
                UC_editProfile uC_EditProfile = new UC_editProfile();
                addUserControl(uC_EditProfile);
                currentControl = uC_EditProfile;
            }
            else if(num == 2)
            {
                UC_passwordProfile uC_PasswordProfile = new UC_passwordProfile();
                addUserControl(uC_PasswordProfile);
                currentControl = uC_PasswordProfile;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentControl.Save();
        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            //MessageBox.Show("Back");
            string position = UserPassword.instance.Position;
            if (position == "1")
            {
                ReceptionistPage receptionistPage = new ReceptionistPage();
                receptionistPage.Show();
            }
            else if (position == "2")
            {
                TechnicianPage technicianPage = new TechnicianPage();
                technicianPage.Show();
            }
            else if (position == "3")
            {
                CustomerPage customerPage = new CustomerPage();
                customerPage.Show();
            }
            else if (position == "4")
            {
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
            }
        }

        private void lblEditPage_Click(object sender, EventArgs e)
        {
            changeEditPage();
        }

        private void picEditPage_Click(object sender, EventArgs e)
        {
            changeEditPage();
        }
        private void changeEditPage()
        {
            if (num == 1)
            {
                lblEditPage.Cursor = Cursors.Default;
            }
            else if (num == 2)
            {
                this.Hide();
                Profile profile = new Profile(1);
                profile.Show();
            }
        }

        private void lblPsPage_Click(object sender, EventArgs e)
        {
            changePasswordPage();
        }

        private void picPasswordPage_Click(object sender, EventArgs e)
        {
            changePasswordPage();
        }

        private void changePasswordPage()
        {
            if (num == 1)
            {
                this.Hide();
                Profile profile = new Profile(2);
                profile.Show();
            }
            else if (num == 2)
            {
                lblPsPage.Cursor = Cursors.Default;
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            toLogin();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            toLogin();
        }

        private void toLogin()
        {
            DialogResult logout;
            logout = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (logout == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Login.instance.userInfo.userUsername;
        }
    }
}
