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
    public partial class ChangeMyServiceRequest : Form
    {
        public static ChangeMyServiceRequest instance; //current form

        //service order object 
        ServiceOrder changedServiceRequest;

        //username
        string username = Login.instance.userInfo.userUsername;

        //declare variables
        int count = 0; //count the number of msg box pop out
        string[] orderDetails = null;
        int orderNo;
        string serviceType = null;
        string serviceStatus = null;
        int serviceFee = 0;

        public ChangeMyServiceRequest()
        {
            InitializeComponent();
        }

        //return to previous page
        private void picBack_Click(object sender, EventArgs e)
        {
            DialogResult previous;
            previous = MessageBox.Show("Confirm if you want to go back to the previous page.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (previous == DialogResult.Yes)
            {
                this.Close();
                CustomerPage customerPage  = new CustomerPage();
                customerPage.Show();
            }
        }

        private void ChangeMyServiceRequest_Load(object sender, EventArgs e)
        {
            //retrieving order number from database to combo box
            SqlConnection conn = new SqlConnection(Sql.connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT OrderId FROM CustomerOrder WHERE Username = '{username}';", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {
                cmbOrderNo.Items.Add(Common.GetIDStr(int.Parse((reader[0]).ToString())));
            }
            reader.Close();
            conn.Close();
        }


        private void cmbOrderNo_SelectedValueChanged(object sender, EventArgs e)
        {
            //if order no is selected
            if (cmbOrderNo.SelectedItem != null)
            {
                //get order no
                orderNo = Common.GetIDNum(cmbOrderNo.SelectedItem.ToString());
                
                //get order details
                orderDetails = Sql.NonQuery($"SELECT * FROM CustomerOrder WHERE OrderId = {orderNo}");

                //store each detail into variables
                txtOrderDate.Text = orderDetails[1].Split(' ')[0];
                cmbServiceType.Text = orderDetails[2];
                cmbServiceStatus.Text = orderDetails[3];
                txtServiceFee.Text = "RM" + orderDetails[4] + ".00";
                txtCondition.Text = orderDetails[5];

                //change txtbox condition's color depends on service status
                switch (txtCondition.Text)
                {
                    case "N/A":
                        txtCondition.BackColor = Color.FromArgb(92, 89, 89);
                        break;

                    case "In Progress":
                        txtCondition.BackColor = Color.FromArgb(230, 57, 70);
                        break;

                    case "Completed":
                        txtCondition.BackColor = Color.FromArgb(128, 237, 153);
                        break;

                    case "Cancelled":
                        txtCondition.BackColor = Color.FromArgb(125, 133, 151);
                        break;

                    default:
                        txtCondition.BackColor = Color.FromArgb(92, 89, 89);
                        break;
                }

                //enable/ disable changes on service request
                switch (txtCondition.Text)
                {
                    case "N/A":
                        cmbServiceType.Enabled = true;
                        cmbServiceStatus.Enabled = true;
                        txtServiceFee.BackColor = Color.White;
                        break;
                    case "In Progress":
                    case "Completed":
                    case "Cancelled":
                        cmbServiceType.Enabled = false;
                        cmbServiceStatus.Enabled = false;
                        txtServiceFee.BackColor = Color.FromArgb(196, 196, 196);
                        break;
                    default:
                        cmbServiceType.Enabled = false;
                        cmbServiceStatus.Enabled = false;
                        txtServiceFee.BackColor = Color.FromArgb(196, 196, 196);
                        break;
                }
            }
            else
            {
                //set all to default
                txtOrderDate.Clear();
                cmbServiceType.SelectedItem = null;
                cmbServiceStatus.SelectedItem = null;
                txtServiceFee.Clear();
                txtCondition.Text = "N/A";
                txtCondition.BackColor = Color.FromArgb(92, 89, 89);
            }
        }

        private void cmbServiceType_SelectedValueChanged(object sender, EventArgs e)
        {
            //if order no is selected
            if (cmbOrderNo.SelectedItem != null)
            {
                //get service type
                serviceType = cmbServiceType.SelectedItem.ToString();
                
                //get service status
                serviceStatus = cmbServiceStatus.Text.ToString();
                
                //get service fee
                serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);

                //display service fee
                txtServiceFee.Text = "RM" + serviceFee.ToString() + ".00";
            }
        }

        private void cmbServiceStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            //if order no is selected
            if (cmbOrderNo.SelectedItem != null)
            {
                //get service status
                serviceStatus = cmbServiceStatus.SelectedItem.ToString();
                
                //get service fee
                serviceFee = ServiceOrder.ServiceFeeValue(serviceType, serviceStatus, serviceFee);

                //display service fee
                txtServiceFee.Text = "RM" + serviceFee.ToString() + ".00";
            }
        }

        //change service request
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validating if order no exists
            if (cmbOrderNo.SelectedItem == null)
            {
                MessageBox.Show("Please select an order number.");
                count += 1;
            }
            else
            {
                //get order no
                orderNo = Common.GetIDNum(cmbOrderNo.SelectedItem.ToString());
                
                //validating service status
                if (txtCondition.Text != "N/A")
                {
                    MessageBox.Show($"Service condition is '{txtCondition.Text}'. No changes are allowed.");
                    count += 1;
                }
                //validating changes on service request
                else if (serviceType == orderDetails[2] && serviceStatus == orderDetails[3])
                {
                    MessageBox.Show("Please select a different service type or service status.");
                    count += 1;
                }
                //validating service fee
                else if (serviceFee == 0)
                {
                    MessageBox.Show("Changes failed. Please try again.");
                    count += 1;
                }
            }

            //if no msg box pop out
            if (count == 0)
            {
                //create an object
                changedServiceRequest = new ServiceOrder(orderNo, serviceType, serviceStatus, serviceFee);

                //update object into database
                changedServiceRequest.ChangeDB();

                //notify user
                changedServiceRequest.UpdatedSuccessfull();

                //clear selected order no
                cmbOrderNo.SelectedItem = null;
            }
            count = 0; //clear errors
        }
    }
}
