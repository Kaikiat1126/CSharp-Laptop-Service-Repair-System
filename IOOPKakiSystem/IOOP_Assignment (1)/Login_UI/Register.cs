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
    public partial class Register : Form
    {

        public static Register instance;
        
        public Register()
        {
            InitializeComponent();
            instance = this;
        }

        private string type = "";
        private int num = 0;

        dynamic currentControl = null;

        public Register(string typeInput,int numInput)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            instance = this;
            type = typeInput;
            num = numInput;
            IniteTitle();
            InitLeftBar();
            InitBottom();
            InitPanel();
        }


        private void IniteTitle()
        {
            uC_Process1.Init(type, num);
            if (type == "cus")
            {
                title.Text = "New Customer Registration";
                pictureBox3.Image = Properties.Resources.Avatar1;
            }
            else if (type == "emp")
            {
                title.Text = "New Employee Registration";
                pictureBox3.Image = Properties.Resources.Avatar2;
            }
        }

        private void InitLeftBar()
        {
            if (type == "cus")
            {
                picBoxLogo.Image = Properties.Resources.GreenLogo;
                panel1.BackColor = Color.FromArgb(255, 191, 105);  
            }
            else if (type == "emp")
            {
                picBoxLogo.Image = Properties.Resources.OrangeLogo;
                panel1.BackColor = Color.FromArgb(203, 243, 240);
            }
            uC_recg_icon1.Init(type, 1);
            uC_recg_icon2.Init(type, 2);
            uC_recg_icon3.Init(type, 3);
        }

        private void InitBottom()
        {
            if (type == "cus" && num<4)
            {
                save.Image = Properties.Resources.BlueSave;
            }
            else if (type == "cus" && num == 4 )
            {
                save.Image = Properties.Resources.BlueDone;
                next.Hide();
            }
            else if (type == "emp" && num < 4)
            {
                save.Image = Properties.Resources.OrangeSave;
            }
            else if (type == "emp" && num == 4)
            {
                save.Image = Properties.Resources.OrangeDone;
                next.Hide();
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void InitPanel()
        {
            if (num ==1 && type=="cus")
            {
                UC_recg_cus uC_Recg_Cus = new UC_recg_cus();
                addUserControl(uC_Recg_Cus);
                currentControl = uC_Recg_Cus;
                InfoContainer.uc_recg_partOne = currentControl;
            }
            else if (num == 1 && type == "emp")
            {
                UC_recg_emp uC_Recg_Emp = new UC_recg_emp();
                addUserControl(uC_Recg_Emp);
                currentControl = uC_Recg_Emp;
                InfoContainer.uc_recg_partOne = currentControl;
            }
            else if (num == 2)
            {
                UC_recg_partTwo uC_Recg_PartTwo = new UC_recg_partTwo();
                uC_Recg_PartTwo.Init(type);
                addUserControl(uC_Recg_PartTwo);
                currentControl = uC_Recg_PartTwo;
                InfoContainer.uc_recg_partTwo = currentControl;
            }
            else if (num == 3)
            {
                UC_recg_partThree uC_Recg_PartThree = new UC_recg_partThree();
                uC_Recg_PartThree.Init(type);
                addUserControl(uC_Recg_PartThree);
                currentControl = uC_Recg_PartThree;
                InfoContainer.uc_recg_partThree = currentControl;
            }
            else if (num == 4)
            {
                UC_recg_partFour uC_Recg_PartFour = new UC_recg_partFour();
                addUserControl(uC_Recg_PartFour);
                this.uC_Process1.Unload();
                currentControl = uC_Recg_PartFour;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            if (currentControl.validInput())
            {
                currentControl.Saved();
                if (num < 4)
                {
                    this.Hide();
                    Register register = new Register(type, num + 1);
                    register.Show();
                }
                else if (num == 4)
                {
                    this.Close();
                    if (type == "cus")
                    {
                        ReceptionistPage receptionistPage = new ReceptionistPage();
                        receptionistPage.Show();
                    }
                    else
                    {
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            
        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {
            DialogResult previous;
            previous = MessageBox.Show("Back to previous page?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (previous == DialogResult.Yes)
            {
                this.Close();
                if (type == "cus")
                {
                    ReceptionistPage receptionistPage = new ReceptionistPage();
                    receptionistPage.Show();
                }
                else
                {
                    AdminPage adminPage = new AdminPage();
                    adminPage.Show();
                }
            }
        }
    }
}
