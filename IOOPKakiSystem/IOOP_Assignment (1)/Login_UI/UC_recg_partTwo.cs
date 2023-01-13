using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Login_UI
{
    public partial class UC_recg_partTwo : UserControl
    {

        public UC_recg_partTwo()
        {
            InitializeComponent();
        }

        public void Init(string type)
        {
            PictureBox[] smallPics = { pictureBox1, pictureBox2, pictureBox3 };

            if(type == "cus")
            {
                pictureBox4.Image = Properties.Resources.smallBlueContainer;
                pictureBox5.Image = Properties.Resources.longBlueContainer;

                foreach  (PictureBox p in smallPics)
                {
                    p.Image = Properties.Resources.midBlueContainer;
                }
            }
            else if(type == "emp")
            {
                pictureBox4.Image = Properties.Resources.smallOrangeContainer;
                pictureBox5.Image = Properties.Resources.longOrangeContainer;

                foreach (PictureBox p in smallPics)
                {
                    p.Image = Properties.Resources.midOrangeContainer;
                }
            }
        }

        private void UC_recg_partTwo_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtEmail.Text = string.Empty;  
        }

        public bool validInput()
        {
            // get values
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            string gender = "";

            if (comboGender.SelectedIndex != -1)
            {
                gender = comboGender.SelectedItem.ToString();
            }

            if (firstname != "" && lastname != "" && contact != "" && email != "" && gender != "")
            {
                bool res1 = validationInput.IsStringName(firstname, lastname);
                bool res2 = validationInput.IsNumber(contact);
                bool res3 = validationInput.IsEmail(email);
                if (res1 == true && res2 == true && res3 == true)
                {
                    InfoContainer.RecgInfo(firstname, lastname, gender, contact, email);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Empty Value!");
                return false;
            }
        }

        public void Saved()
        {
            // save num to db
        }

    }
}
