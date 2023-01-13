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
    public partial class UC_recg_partThree : UserControl
    {

        public UC_recg_partThree()
        {
            InitializeComponent();
        }

        public void Init(string type)
        {
            PictureBox[] longBox = { pictureBox1, pictureBox2 };
            PictureBox[] shortBox = { pictureBox3, pictureBox4, pictureBox5 };

            if(type == "cus")
            {
                foreach (PictureBox longBoxContainer in longBox)
                {
                    longBoxContainer.Image = Properties.Resources.longBlueContainer;
                }

                foreach (PictureBox shortBoxContainer in shortBox)
                {
                    shortBoxContainer.Image = Properties.Resources.smallBlueContainer;
                }
            }
            else if (type == "emp")
            {
                foreach (PictureBox longBoxContainer in longBox)
                {
                    longBoxContainer.Image = Properties.Resources.longOrangeContainer;
                }

                foreach (PictureBox shortBoxContainer in shortBox)
                {
                    shortBoxContainer.Image = Properties.Resources.smallOrangeContainer;
                }
            }
        }

        private void UC_recg_partThree_Load(object sender, EventArgs e)
        {
            txtAddressLineOne.Text = string.Empty;
            txtAddressLineTwo.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZipcode.Text = string.Empty;
        }

        public bool validInput()
        {
            // get values
            string AddressOne = txtAddressLineOne.Text;
            string AddressTwo = txtAddressLineTwo.Text;
            string City = txtCity.Text;
            string Zipcode = txtZipcode.Text;
            string State = txtState.Text;

            if (AddressOne != "" && AddressTwo != "" && City != "" && Zipcode != "" && State != "")
            {
                bool res1 = validationInput.IsZipcode(Zipcode);
                bool res2 = validationInput.IsAddress(AddressOne, AddressTwo);
                bool res3 = validationInput.IsArea(City, State);
                if (res1 == true && res2 == true && res3 == true)
                {
                    InfoContainer.RecgAddress(AddressOne, AddressTwo, City, Zipcode, State);
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
