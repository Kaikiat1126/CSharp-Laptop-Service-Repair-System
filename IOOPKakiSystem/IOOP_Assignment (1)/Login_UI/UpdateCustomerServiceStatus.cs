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
    public partial class UpdateCustomerServiceStatus : Form
    {
        public static UpdateCustomerServiceStatus instance; //declare current form
        int count = 0; //to count the number of message box pop out

        //service order object 
        ServiceOrder updatedServiceOrder;

        //declare variables
        int orderNo;
        string serviceCondition = null;
        string dateOfCollection = null;
        string description = null;
        string[] orderDetails = null;

        public UpdateCustomerServiceStatus()
        {
            InitializeComponent();
        }

        //disable combobox date of collection
        private void DisableCmbDateOfCollection()
        {
            cmbDay.Enabled = false;
            cmbMonth.Enabled = false;
            cmbYear.Enabled = false;
        }

        //enable combobox date of collection
        private void EnableCmbDateOfCollection()
        {
            cmbDay.Enabled = true;
            cmbMonth.Enabled = true;
            cmbYear.Enabled = true;
        }

        //set date of collection to 1/1/2022
        private void DefaultCmbDateOfCollection()
        {
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }

        //return to previous page
        private void picBack_Click(object sender, EventArgs e)
        {
            DialogResult previous;
            previous = MessageBox.Show("Confirm if you want to go back to the previous page.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (previous == DialogResult.Yes)
            {
                this.Hide();
                TechnicianPage technicianPage = new TechnicianPage();
                technicianPage.Show();
            }
        }

        private void UpdateCustomerServiceStatus_Load(object sender, EventArgs e)
        {
            //add year items to combobox (2022-2100)
            for (int i = 2020; i <= 2100; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }

            //add month items to combobox (1-12)
            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i.ToString());
            }

            //add day items to combobox (1-31)
            for (int i = 1; i <= 31; i++)
            {
                cmbDay.Items.Add(i.ToString());
            }

            DefaultCmbDateOfCollection();

            //retrieving order number from database to combo box
            SqlConnection conn = new SqlConnection(Sql.connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT OrderId FROM CustomerOrder", conn);
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
            //set collection date as default
            DefaultCmbDateOfCollection();
            //if order no is selected
            if (cmbOrderNo.SelectedItem != null)
            {
                //get order no
                orderNo = Common.GetIDNum(cmbOrderNo.SelectedItem.ToString());
                
                //get order detatils list
                orderDetails = Sql.NonQuery($"SELECT * FROM CustomerOrder WHERE OrderId = {orderNo}");

                //store each detail into variables
                txtOrderDate.Text = orderDetails[1].Split(' ')[0];
                txtCusUsername.Text = orderDetails[8];
                txtServiceType.Text = orderDetails[2];
                txtServiceStatus.Text = orderDetails[3];
                cmbCondition.Text = orderDetails[5];
                txtDescription.Text = orderDetails[6];
                dateOfCollection = orderDetails[7];
                
                //split date of collection
                string[] fullDate = dateOfCollection.Split('/');
                if (dateOfCollection != "")
                {
                    cmbDay.Text = fullDate[0];
                    cmbMonth.Text = fullDate[1];
                    cmbYear.Text = fullDate[2].Substring(0, 4);
                }

                //enable/ disable combobox date of collection depends on the service status
                switch (cmbCondition.Text)
                {
                    case "N/A":
                    case "In Progress":
                        cmbCondition.Enabled = true;
                        DisableCmbDateOfCollection();
                        dateOfCollection = null;
                        break;
                    case "Completed":
                        cmbCondition.Enabled = false;
                        EnableCmbDateOfCollection();
                        break;

                    case "Cancelled":
                        cmbCondition.Enabled = false;
                        dateOfCollection = null;
                        break;
                }

                //allow changes on txtbox description
                txtDescription.Enabled = true;
                txtDescription.ReadOnly = false;
            }
            else
            {
                //set all to default
                txtOrderDate.Clear();
                txtCusUsername.Clear();
                txtServiceType.Clear();
                txtServiceStatus.Clear();
                cmbCondition.SelectedItem = null;
                DisableCmbDateOfCollection();
                txtDescription.Clear();  
            }
        }

        //enable/ disable combobox condition depends on condition
        private void cmbCondition_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCondition.Text == "Completed")
            {
                EnableCmbDateOfCollection();
                if (cmbDay.Text != "" && cmbMonth.Text != "" && cmbYear.Text != "")
                {
                    dateOfCollection = $"{cmbYear.Text}/{cmbMonth.Text}/{cmbDay.Text}";
                }
                else
                {
                    MessageBox.Show("Please select a date of collection.");
                    count += 1;
                }
            }
            else
            {
                DisableCmbDateOfCollection();
                dateOfCollection = null;
            }
        }

        //update service details
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
                //display order details
                orderNo = Common.GetIDNum(cmbOrderNo.SelectedItem.ToString());
                serviceCondition = cmbCondition.Text;
                description = txtDescription.Text;

                //validating updated details
                switch (serviceCondition)
                {
                    case "N/A":
                    case "In Progress":
                    case "Cancelled":

                        //set as no date of collection
                        dateOfCollection = null;

                        //validating changes on service condition and description
                        if (serviceCondition == orderDetails[5] && description == orderDetails[6])
                        {
                            MessageBox.Show("No changes detected. Please try again.");
                            count += 1;
                        }
                        //validating changes on in progress to n/a
                        else if (orderDetails[5] == "In Progress" && (serviceCondition == "N/A" || serviceCondition == "Cancelled"))
                        {
                            MessageBox.Show($"Cannot change the status 'In Progress' to '{serviceCondition}'.");
                            count += 1;
                        }
                        break;

                    case "Completed":
                        //validating input of date of collection
                        if (dateOfCollection != "" && dateOfCollection != null)
                        {
                            //display date of collection in the format of yyyyMMdd
                            dateOfCollection = $"{cmbYear.Text}/{cmbMonth.Text}/{cmbDay.Text}";
                            //validating the format of date
                            DateTime dateValue;
                            if (!DateTime.TryParse(dateOfCollection, out dateValue))
                            {
                                MessageBox.Show("Invalid date of collection.");
                                count += 1;
                            }
                            //validating changes on date of collection and description
                            else if (orderDetails[5] == "Completed" && Convert.ToDateTime(dateOfCollection) == Convert.ToDateTime(orderDetails[7].Split(' ')[0]) && description == orderDetails[6])
                            {
                                MessageBox.Show("Same record detected. Please change the date of colection or the desctiption.");
                                count += 1;
                            }
                            else
                            {
                                //validating if date of collection after order date
                                if (Convert.ToDateTime(dateOfCollection) < Convert.ToDateTime(orderDetails[1].Split(' ')[0]))
                                {
                                    MessageBox.Show("Please select the correct collection date. (on/ after order date)");
                                    count += 1;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a date of collection.");
                            count += 1;
                        }
                        break;
                }

                //validating if values exist in description
                if (description == "")
                {
                    MessageBox.Show("Please enter a description.");
                    count += 1;
                }
                //validating the length of description (1-255)
                else if (description.Length > 255)
                {
                    MessageBox.Show("Description exceeded 255 characters.");
                    count += 1;
                }
            }

            //if no msg box pop out
            if (count == 0)
            {
                //create an object
                updatedServiceOrder = new ServiceOrder(orderNo, serviceCondition, dateOfCollection, description);

                //update object into database
                updatedServiceOrder.UpdateDB();
            
                //clear selected order no
                cmbOrderNo.SelectedItem = null;
            }
            count = 0; //clear errors
        }
    }
}
