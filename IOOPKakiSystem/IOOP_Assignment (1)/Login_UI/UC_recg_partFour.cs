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
    public partial class UC_recg_partFour : UserControl
    {
        public string thePosition;
        public string position = InfoContainer.Position.ToString();
        public string username = InfoContainer.Username.ToString();
        public string password = InfoContainer.Password.ToString();

        public UC_recg_partFour()
        {
            InitializeComponent();
        }

        private void UC_recg_partFour_Load(object sender, EventArgs e)
        {
            checKPosition();
            lblPosition.Text = thePosition;
            lblUsername.Text = username;
            lblFullName.Text = InfoContainer.Lastname.ToString() + " " + InfoContainer.Firstname.ToString();
            lblPassword.Text = InfoContainer.Password.ToString();
        }

        public bool validInput()
        {
            return true;
        }

        public void Saved()
        {
            // save num to db
            InfoContainer.insertInfo();
            InfoContainer.insertDetails();

            MessageBox.Show("Done!");
        }

        private void checKPosition()
        {
            //string position = InfoContainer.Position.ToString();
            if (position == "1")
            {
                thePosition = "Receptionist";
            } 
            else if (position == "2")
            {
                thePosition = "Technician";
            }
            else if(position == "3")
            {
                thePosition = "Customer";
            }
            else
            {
                thePosition = "Admin";
            }
        }
    }
}
