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
    public partial class UC_editProfile : UserControl
    {
        public UC_editProfile()
        {
            InitializeComponent();
        }

        string username = Login.instance.userInfo.userUsername;

        private void UC_editProfile_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = Login.instance.userInfo.userFirstName;
            txtLastName.Text = Login.instance.userInfo.userLastName;
            txtAddressLineOne.Text = Login.instance.userInfo.userAddressLineOne;
            txtAddressLineTwo.Text = Login.instance.userInfo.userAddressLineTwo;
            txtCity.Text = Login.instance.userInfo.userCity;
            txtZipcode.Text = Login.instance.userInfo.userZipCode;
            txtState.Text = Login.instance.userInfo.userStateAdd;        
        }

        private bool validInput()
        {
            // get four values
            string ProFirstName = txtFirstName.Text;
            string ProLastName = txtLastName.Text;
            string ProAddressOne = txtAddressLineOne.Text;
            string ProAddressTwo = txtAddressLineTwo.Text;
            string ProCity = txtCity.Text;
            string ProZipcode = txtZipcode.Text;
            string ProState = txtState.Text;

            if (ProFirstName != "" && ProLastName != "" && ProAddressOne != "" && ProAddressTwo != "" && ProCity != "" && ProZipcode != "" && ProState != "")
            {
                bool res1 = validationInput.IsZipcode(ProZipcode);
                bool res2 = validationInput.IsStringName(ProFirstName, ProLastName);
                bool res3 = validationInput.IsAddress(ProAddressOne, ProAddressTwo);
                bool res4 = validationInput.IsArea(ProCity, ProState);
                if (res1 == true && res2 == true && res3 == true && res4 == true)
                {
                    UserInfo.instance.changeProfile(ProFirstName, ProLastName, ProAddressOne, ProAddressTwo, ProCity, ProZipcode, ProState);
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


        public void Save()
        {
            bool res = validInput();
            if (res == true)
            {

                //set query
                string queryD = ($"UPDATE Details SET FirstName = '{txtFirstName.Text}', " +
                    $"LastName = '{txtLastName.Text}', AddressLineOne = '{txtAddressLineOne.Text}', " +
                    $"AddressLineTwo = '{txtAddressLineTwo.Text}', City = '{txtCity.Text}', ZipCode = '{txtZipcode.Text}', " +
                    $"StateAdd = '{txtState.Text}' WHERE Username = '{username}'");


                // save num to db
                Sql.Query(queryD);

                MessageBox.Show("Successful!");
            }
            else
            {
                //MessageBox.Show("Invalid value");
            }

        }

    }
}
