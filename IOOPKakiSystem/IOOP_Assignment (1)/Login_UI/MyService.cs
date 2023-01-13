using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Login_UI
{
    public partial class MyService : Form
    {
        public MyService()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        int orderNo;
        string[] orderDetails = null;
        string username = Login.instance.userInfo.userUsername;


        private void MyService_Load(object sender, EventArgs e)
        {
            //lblAmountPaid.Text = Login.instance.userInfo.userUsername;
            lblAmountPaid.Text = string.Empty;
            lblCollectionDate.Text = string.Empty;
            lblDescription.Text = string.Empty;
            lblServiceType.Text = string.Empty;
            lblStatus.Text = string.Empty;

            string connStr = ConfigurationManager.ConnectionStrings["ioopkakiDBCS"].ToString();
            SqlConnection conn = new SqlConnection(Sql.connStr);
            conn.Open();

            string sql = $"SELECT OrderID FROM CustomerOrder WHERE Username = '{username}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboMyOrder.Items.Add(Common.GetIDStr(int.Parse((dr[0]).ToString())));
            }
            dr.Close();
            conn.Close();
        }

        private void comboMyOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboMyOrder.SelectedItem != null)
            {
                orderNo = Common.GetIDNum(comboMyOrder.SelectedItem.ToString());
                orderDetails = Sql.NonQuery($"SELECT * FROM CustomerOrder WHERE OrderId = {orderNo}");
                lblServiceType.Text = orderDetails[2];
                lblAmountPaid.Text = "RM" + orderDetails[4] + ".00";
                lblStatus.Text = orderDetails[5];
                lblDescription.Text = orderDetails[6];
                lblCollectionDate.Text = orderDetails[7];

                switch (lblStatus.Text)
                {
                    case "N/A":
                        lblStatus.BackColor = Color.FromArgb(92,89,89);
                        break;

                    case "In Progress":
                        lblStatus.BackColor = Color.FromArgb(230, 57, 70);
                        break;

                    case "Completed":
                        lblStatus.BackColor = Color.FromArgb(128, 237, 153);
                        break;

                    case "Cancelled":
                        lblStatus.BackColor = Color.FromArgb(125, 133, 151);
                        break;

                }
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerPage customerPage = new CustomerPage();
            customerPage.Show();
        }

    }
}
