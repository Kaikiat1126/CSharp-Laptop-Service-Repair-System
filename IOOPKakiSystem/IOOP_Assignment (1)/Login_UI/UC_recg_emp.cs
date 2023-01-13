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
    public partial class UC_recg_emp : UserControl
    {

        public UC_recg_emp()
        {
            InitializeComponent();
        }

        private void UC_recg_emp_Load(object sender, EventArgs e)
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtConfirmPassword.Text = String.Empty;
        }

        public bool validInput()
        {
            // get values
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string employeePosition = "";

            if(comboPosition.SelectedIndex != -1)
            {
                employeePosition = comboPosition.SelectedItem.ToString();
            }

            if (username != "" && password != "" && confirmPassword != "" && employeePosition != "")
            {
                bool res1 = validationInput.IsName(username);
                bool res2 = validationInput.IsSure(password, confirmPassword);
                if (res1 == true && res2 == true)
                {
                    InfoContainer.RecgDetails(username, password);
                    InfoContainer.VerifyPosition(employeePosition);
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
