using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Login_UI
{
    class Payment
    {
        public string UserInputcusname;
        public string UserInputreference;
        public string paymthd;
        public string name;
        public string ServiceType;
        public string ServiceStatus;
        public int amount;
        public string ServiceCondition;
        public string PaymentStatus;
        public int Orderid;
        public string FirstName;
        public string LastName;
        public int InvoiceNumber;
        public string Date;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ioopkakiDBCS"].ToString());
        public Payment(string inputCusname, string Reference, string paymentMethod)
        {
            UserInputcusname = inputCusname;
            UserInputreference = Reference;
            paymthd = paymentMethod;
        }

        public void GetOrderDetail()
        {
            con.Open();
            string sql = "SELECT Username, ServiceType, ServiceStatus, ServiceFee, ServiceCondition, Payment_Status, OrderID FROM CustomerOrder WHERE Username = '" + UserInputcusname + "' and OrderID = (Select max(OrderID) from CustomerOrder where Username = '" + UserInputcusname + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                name = dr.GetString(0);
                ServiceType = dr.GetString(1);
                ServiceStatus = dr.GetString(2);
                amount = dr.GetInt32(3);
                ServiceCondition = dr.GetString(4);
                PaymentStatus = dr.GetString(5);
                Orderid = dr.GetInt32(6);
            }
            con.Close();

            con.Open();
            string FLname = $"SELECT FirstName, LastName FROM Details WHERE Username = '{UserInputcusname}'";
            SqlCommand GetFLname = new SqlCommand(FLname, con);
            SqlDataReader dr2 = GetFLname.ExecuteReader();

            while (dr2.Read())
            {
                FirstName = dr2.GetString(0);
                LastName = dr2.GetString(1);
            }
            con.Close();
        }

        public bool CheckOutPayment()
        {
            con.Open();
            DateTime currentDate = DateTime.Today;
            Date = currentDate.ToString("d MMMM yyyy");
            string addPayment = "INSERT INTO Payment VALUES( '" + Date + "', '" + paymthd + "', '" + amount + "', '" + UserInputreference + "', '" + name + "', '" + Orderid + "')";
            Console.WriteLine(addPayment);
            SqlCommand CMDaddPayment = new SqlCommand(addPayment, con);
            int add = CMDaddPayment.ExecuteNonQuery();

            string updatePaySts = $"UPDATE CustomerOrder SET Payment_Status = 'Paid' where OrderID = {Orderid}";
            Sql.Query(updatePaySts);

            //SqlCommand CMDUpdatePaySts = new SqlCommand(updatePaySts, con);
            //CMDUpdatePaySts.ExecuteNonQuery();

            if (add != 0)
            {
                con.Close();

                con.Open();
                string Invoicenum = $"SELECT InvoiceNumber FROM Payment WHERE OrderID= '{Orderid}'";
                SqlCommand GetInvoicenum = new SqlCommand(Invoicenum, con);
                SqlDataReader dr = GetInvoicenum.ExecuteReader();

                while (dr.Read())
                {
                    InvoiceNumber = dr.GetInt32(0);
                }
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
