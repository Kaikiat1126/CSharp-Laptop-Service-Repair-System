using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class NewServiceRequestion : Form
    {
        public static NewServiceRequestion instance; //declare current form

        //service order object 
        ServiceOrder newServiceOrder;

        //declare variables
        string customerId, serviceType, serviceStatus;
        int serviceFee, count; //count: to count the number of msg box pop out

        //set other variables to default
        public void Restart()
        {
            count = 0;
            txtCustomerName.Clear();
            customerId = null;
            serviceType = null;
            serviceStatus = null;
            serviceFee = 0;
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        public NewServiceRequestion()
        {
            InitializeComponent();
            instance = this; //current form
            Restart();
        }

        //return to previous form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult previous;
            previous = MessageBox.Show("Confirm if you want to go back to the previous page.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (previous == DialogResult.Yes)
            {
                this.Close();
                ReceptionistPage receptionistPage = new ReceptionistPage();
                receptionistPage.Show();
            }
        }

        //set service type depends on btn clicked
        private void btnVirus_Click(object sender, EventArgs e)
        {
            serviceType = "Remove virus, malware or spyware";

            //enable clicking effect
            btnVirus.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89); 
            btnVirus.FlatAppearance.BorderSize = 1;

            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        private void btnTroubleshot_Click(object sender, EventArgs e)
        {
            serviceType = "Troubleshot and fix computer running slow";
            btnTroubleshot.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnTroubleshot.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            serviceType = "Laptop screen replacement";
            btnScreen.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnScreen.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            serviceType = "Laptop keyboard replacement";
            btnKeyboard.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnKeyboard.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            serviceType = "Laptop battery replacement";
            btnBattery.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnBattery.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        private void btnInstallation_Click(object sender, EventArgs e)
        {
            serviceType = "Operating System Format and Installation";
            btnInstallation.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnInstallation.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            serviceType = "Data backup and recovery";
            btnBackup.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnBackup.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            serviceType = "Internet connectivity issues";
            btnInternet.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnInternet.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee + ".00";
        }

        //set service status depends on btn clicked
        private void btnNormal_Click(object sender, EventArgs e)
        {
            serviceStatus = "Normal";
            btnNormal.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnNormal.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee.ToString() + ".00";
        }

        private void btnUrgent_Click(object sender, EventArgs e)
        {
            serviceStatus = "Urgent";
            btnUrgent.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnUrgent.FlatAppearance.BorderSize = 1;
            serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);
            lblTotalPrice.Text = "RM" + serviceFee.ToString() + ".00";
        }

        //disable clicking effect
        private void btnVirus_Leave(object sender, EventArgs e)
        {
            btnVirus.FlatAppearance.BorderSize = 0;
        }

        private void btnTroubleshot_Leave(object sender, EventArgs e)
        {
            btnTroubleshot.FlatAppearance.BorderSize = 0;
        }

        private void btnScreen_Leave(object sender, EventArgs e)
        {
            btnScreen.FlatAppearance.BorderSize = 0;
        }

        private void btnKeyboard_Leave(object sender, EventArgs e)
        {
            btnKeyboard.FlatAppearance.BorderSize = 0;
        }

        private void btnBattery_Leave(object sender, EventArgs e)
        {
            btnBattery.FlatAppearance.BorderSize = 0;
        }

        private void btnInstallation_Leave(object sender, EventArgs e)
        {
            btnInstallation.FlatAppearance.BorderSize = 0;
        }

        private void btnBackup_Leave(object sender, EventArgs e)
        {
            btnBackup.FlatAppearance.BorderSize = 0;
        }

        private void btnInternet_Leave(object sender, EventArgs e)
        {
            btnInternet.FlatAppearance.BorderSize = 0;
        }

        private void btnPlaceOrder_Leave(object sender, EventArgs e)
        {
            btnPlaceOrder.FlatAppearance.BorderSize = 0;
        }

        private void btnNormal_Leave(object sender, EventArgs e)
        {
            btnNormal.FlatAppearance.BorderSize = 0;
        }

        private void btnUrgent_Leave(object sender, EventArgs e)
        {
            btnUrgent.FlatAppearance.BorderSize = 0;
        }

        //place order
        private void button1_Click(object sender, EventArgs e)
        {
            btnPlaceOrder.FlatAppearance.BorderColor = Color.FromArgb(92, 89, 89);
            btnPlaceOrder.FlatAppearance.BorderSize = 1;

            //validating the input of customer username
            if (Sql.Validation($"SELECT COUNT (*) FROM UserLogin WHERE Username = '{txtCustomerName.Text}' AND PositionID = 3"))
            {
                customerId = txtCustomerName.Text.ToLower();

                //retrieve customer's latest order
                if (Sql.Validation($"SELECT COUNT (*) FROM CustomerOrder WHERE Username = '{customerId}'"))
                {
                    string[] latestOrder = Sql.NonQuery($"SELECT TOP 1 * FROM CustomerOrder WHERE Username = '{customerId}' ORDER BY OrderId DESC;");
                    if (latestOrder[5] != "Completed" || latestOrder[9].ToLower() != "paid")
                    {
                        MessageBox.Show($"Order failed: {customerId}'s current order has not completed or has not been paid.");
                        count += 1;
                    }//validating the input of service type
                    else if (serviceType == null)
                    {
                        MessageBox.Show("Please select a service type.");
                        count += 1;
                    }
                    //validating the input of service status
                    else if (serviceStatus == null)
                    {
                        MessageBox.Show("Please select a service status.");
                        count += 1;
                    }
                    //validating the value of service fee
                    else if (serviceFee == 0)
                    {
                        MessageBox.Show("Order failed. Please try again.");
                        count += 1;
                    }
                }
            }
            else
            {
                //alert username not found
                MessageBox.Show("Customer username not found. Please try again.");
                count += 1;
            }

            //no msg box pop out
            if (count == 0) 
            {
                //create an object 
                newServiceOrder = new ServiceOrder(customerId, serviceType, serviceStatus, serviceFee);

                //insert object into database
                newServiceOrder.InsertDB();
                
                //notify receptionist 
                newServiceOrder.InsertSuccessfull();
            }
            Restart();
        }
    }
}
