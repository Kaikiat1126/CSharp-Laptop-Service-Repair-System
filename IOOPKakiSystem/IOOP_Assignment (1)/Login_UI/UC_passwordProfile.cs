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
    public partial class UC_passwordProfile : UserControl
    {
        string username = Login.instance.userInfo.userUsername;

        public UC_passwordProfile()
        {
            InitializeComponent();
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = show.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = show.Checked ? '\0' : '*';
        }

        private bool validInput()
        {
            // get four values
            string ProContactNumber = txtContactNumber.Text;
            string ProEmail = txtEmail.Text;
            string ProPassword = txtPassword.Text;
            string ProConfirmPassword = txtConfirmPassword.Text;

            //if(1 != "" && 2 != " &&3 4 ){do somehting}
            if (ProContactNumber != "" && ProEmail != "" && ProPassword != "" && ProConfirmPassword != "")
            {
                bool res1 = validationInput.IsNumber(ProContactNumber);
                bool res2 = validationInput.IsEmail(ProEmail);
                bool res3 = validationInput.IsSure(ProPassword, ProConfirmPassword);
                if (res1 == true && res2 == true && res3 == true)
                {
                    UserInfo.instance.changeSecurity(ProContactNumber, ProEmail);
                    UserPassword.instance.changePassword(ProPassword);
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
                string queryD = ($"UPDATE Details SET ContactNumber = '{txtContactNumber.Text}', " +
                    $"EmailAddress = '{txtEmail.Text}' WHERE Username = '{username}'");

                string queryP = ($"UPDATE UserLogin SET AccPassword = '{txtPassword.Text}' WHERE Username = '{username}'");

                // save num to db
                Sql.Query(queryD);
                Sql.Query(queryP);


                MessageBox.Show("Successful!");
            }
            else
            {
                //MessageBox.Show("Invalid Value");
            }
            
        }

        private void UC_passwordProfile_Load(object sender, EventArgs e)
        {
            //show info, instance
            txtContactNumber.Text = Login.instance.userInfo.userContactNumber;
            txtEmail.Text = Login.instance.userInfo.userEmailAddress;
            txtPassword.Text = Login.instance.userPassword.Password;
            txtConfirmPassword.Text = Login.instance.userPassword.Password;
        }
    }
}
