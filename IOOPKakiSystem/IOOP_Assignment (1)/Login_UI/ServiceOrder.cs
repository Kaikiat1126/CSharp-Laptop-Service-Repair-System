using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_UI
{
    class ServiceOrder
    {
        //declare variables
        public string Username, ServiceDate, ServiceType, ServiceStatus, ServiceCondition, CollectionDate, ServiceDesription, PaymentStatus = null;
        public int OrderId;
        public int ServiceFee = 0;

        //constructor for new service
        public ServiceOrder(string username, string serviceType, string serviceStatus, int serviceFee)
        {
            this.Username = username;
            this.ServiceDate = DateTime.Now.ToString("d MMMM yyyy");
            this.ServiceType = serviceType;
            this.ServiceStatus = serviceStatus;
            this.ServiceFee = serviceFee;
            this.ServiceCondition = "N/A";
            this.CollectionDate = "NULL";
            this.ServiceDesription = "N/A";
            this.PaymentStatus = "Unpaid";
        }

        //insert new service order into database
        public void InsertDB()
        {
            Sql.Query($"INSERT INTO CustomerOrder VALUES ('{DateTime.Now.ToString("d MMMM yyyy")}', '{ServiceType}', '{ServiceStatus}', {ServiceFee}, '{ServiceCondition}', '{ServiceDesription}', {CollectionDate}, '{Username}', '{PaymentStatus}');");
        }

        //notify new service order has been inserted successfully
        public void InsertSuccessfull()
        {
            MessageBox.Show($"Order has been placed successfully for {Username}. \n\nService Type: {ServiceType} \nService Status: {ServiceStatus} \nService Fee: RM{ServiceFee}.00");
        }

        //set service fee depends on service type + service status
        public static int ServiceFeeValue(string serviceType, string serviceStatus, int serviceFee)
        {
            if (serviceType == "Remove virus, malware or spyware")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 50;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 80;
                }
            }
            else if (serviceType == "Troubleshot and fix computer running slow")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 60;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 90;
                }
            }
            else if (serviceType == "Laptop screen replacement")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 380;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 430;
                }
            }
            else if (serviceType == "Laptop keyboard replacement")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 160;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 200;
                }
            }
            else if (serviceType == "Laptop battery replacement")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 180;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 210;
                }
            }
            else if (serviceType == "Operating System Format and Installation")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 100;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 150;
                }
            }
            else if (serviceType == "Data backup and recovery")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 80;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 130;
                }
            }
            else if (serviceType == "Internet connectivity issues")
            {
                if (serviceStatus == "Normal")
                {
                    serviceFee = 70;
                }
                else if (serviceStatus == "Urgent")
                {
                    serviceFee = 100;
                }
            }
            return serviceFee;
        }

        //retrieve data from database and insert into list view
        public static void GenerateData(string sqlSelect)
        {
            string sqlNonQuery = sqlSelect;
            SqlConnection conn = new SqlConnection(Sql.connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlNonQuery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int orderId = int.Parse(reader[0].ToString()); //'10'
                string serviceDate = Convert.ToDateTime(reader[1]).ToString("yyy-MM-dd");
                string username = reader[8].ToString();
                string serviceType = reader[2].ToString();
                string serviceStatus = reader[3].ToString();
                int serviceFee = int.Parse(reader[4].ToString());
                string serviceCondition = reader[5].ToString();

                ListViewItem listViewItem = new ListViewItem(Common.GetIDStr(orderId));
                listViewItem.SubItems.Add(serviceDate);
                listViewItem.SubItems.Add(username);
                listViewItem.SubItems.Add(serviceType);
                listViewItem.SubItems.Add(serviceStatus);
                listViewItem.SubItems.Add(serviceFee.ToString());
                listViewItem.SubItems.Add(serviceCondition);
                ViewServiceRequestion.instance.lslvServiceOrder.Items.Add(listViewItem);
            }
            reader.Close();
            conn.Close();
        }

        //constructor for updated service order
        public ServiceOrder(int orderNo, string serviceCondition, string dateOfCollection, string description)
        {
            this.OrderId = orderNo;
            this.ServiceCondition = serviceCondition;
            this.CollectionDate = dateOfCollection;
            this.ServiceDesription = description;
        }

        //update service condition, collection date and description into database
        public void UpdateDB()
        {
            if (this.CollectionDate != null)
            {
                //update into database
                Sql.Query($"UPDATE CustomerOrder SET ServiceCondition = '{this.ServiceCondition}', ServiceDescription = '{this.ServiceDesription}', CollectionDate = '{this.CollectionDate}' WHERE OrderId = {this.OrderId};");

                //notify user
                MessageBox.Show("Updated successfully.");
            }
            else
            {
                //update into database
                Sql.Query($"UPDATE CustomerOrder SET ServiceCondition = '{this.ServiceCondition}', ServiceDescription = '{this.ServiceDesription}', CollectionDate = NULL WHERE OrderId = {this.OrderId};");

                //notify user
                MessageBox.Show("Updated successfully.");
            }
        }

        //constructor for changed service request
        public ServiceOrder(int orderNo, string serviceType, string serviceStatus, int serviceFee)
        {
            this.OrderId = orderNo;
            this.ServiceType = serviceType;
            this.ServiceStatus = serviceStatus;
            this.ServiceFee = serviceFee;
        }

        public void ChangeDB()
        {
            //update into database
            Sql.Query($"UPDATE CustomerOrder SET ServiceType = '{this.ServiceType}', ServiceStatus = '{this.ServiceStatus}', ServiceFee = {this.ServiceFee} WHERE OrderId = {this.OrderId};");
        }

        public void UpdatedSuccessfull()
        {
            MessageBox.Show($"Updated successfully. \n\nCurrent Service Type: {this.ServiceType} \nCurrent Service Status: {this.ServiceStatus} \nCurrent Service Fee: RM{this.ServiceFee}.00");
        }
    }
}
