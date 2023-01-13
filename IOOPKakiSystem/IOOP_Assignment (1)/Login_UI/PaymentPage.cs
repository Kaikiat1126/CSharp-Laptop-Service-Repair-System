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
    public partial class PaymentPage : Form
    {

        string paymthd = "";
        Payment newPayment;
        public static PaymentPage instance;
        public ReceptionistPage receptionistPage;
        public ReceiptInfo receiptInfo;
        public PaymentPage()
        {
            InitializeComponent();
            instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCusname.Text == "")
            {
                MessageBox.Show("please enter The Customer name!");
            }
            else if (txtReference.Text == "")
            {
                MessageBox.Show("please enter the Reference!");
            }
            else if (paymthd == "")
            {
                MessageBox.Show("please choose a Payment Method before check out!");
            }
            else if (btnOK.Text == "Done")
            {
                this.Close();
                receptionistPage = new ReceptionistPage();
                receptionistPage.Show();
            }
            else
            {
                newPayment = new Payment(txtCusname.Text, txtReference.Text, paymthd);
                newPayment.GetOrderDetail();
                displayOrderDetails();
            }
        }
        private void displayOrderDetails()
        {
            if (newPayment.name == txtCusname.Text && newPayment.PaymentStatus == "Unpaid" && newPayment.ServiceCondition == "Completed")
            {
                lblDService.Text = newPayment.ServiceType;
                lblDStatus.Text = newPayment.ServiceStatus;
                lblDAmount.Text = "RM " + newPayment.amount.ToString() + ".00";
                btnOK.Visible = false;
                btnCheckout.Visible = true;
            }
            else if (newPayment.name == txtCusname.Text && newPayment.PaymentStatus == "Unpaid" && newPayment.ServiceCondition == "In Progress")
            {
                MessageBox.Show("The Service is in Progress");
            }
            else if (newPayment.name == txtCusname.Text && newPayment.PaymentStatus == "Unpaid" && newPayment.ServiceCondition == "N/A")
            {
                MessageBox.Show("The Service is still in queue");
            }
            else if (newPayment.name == txtCusname.Text && newPayment.PaymentStatus == "Paid" && newPayment.ServiceCondition == "Completed")
            {
                MessageBox.Show("This Customer dont have any outstanding payment");
            }
            else if (newPayment.name == txtCusname.Text && newPayment.PaymentStatus == "Unpaid" && newPayment.ServiceCondition == "Cancelled")
            {
                MessageBox.Show("This order has been cancelled");
            }
            else
            {
                MessageBox.Show("This customer didn't make any order or havent Register into the system");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            bool CheckoutPayment = newPayment.CheckOutPayment();
            if (CheckoutPayment == true && btnCheckout.Text == "Check Out")
            {
                MessageBox.Show("Payment Success!");
                Receipt newReceipt = new Receipt();
                receiptInfo = new ReceiptInfo(newPayment.FirstName, newPayment.LastName, newPayment.InvoiceNumber, newPayment.Date, newPayment.paymthd, newPayment.Orderid, 
                    newPayment.ServiceType, newPayment.ServiceStatus, newPayment.amount);
                newReceipt.ShowDialog();
                btnCheckout.Visible = false;
                btnOK.Visible = true;
                btnOK.Text = "Done";
            }
            else
            {
                MessageBox.Show("Payment Unsuccess!");
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            btnCheckout.Visible = false;
        }

        private void btnEwallet_Click(object sender, EventArgs e)
        {
            paymthd = "E-Wallet";
            Console.WriteLine(paymthd);
            btnEwallet.FlatStyle = FlatStyle.Standard;
            btnCBCard.FlatStyle = FlatStyle.Flat;
            btnOnlineB.FlatStyle = FlatStyle.Flat;
        }

        private void btnCBCard_Click(object sender, EventArgs e)
        {
            paymthd = "Credit Debit Card";
            Console.WriteLine(paymthd);
            btnCBCard.FlatStyle = FlatStyle.Standard;
            btnEwallet.FlatStyle = FlatStyle.Flat;
            btnOnlineB.FlatStyle = FlatStyle.Flat;
        }

        private void btnOnlineB_Click(object sender, EventArgs e)
        {
            paymthd = "Online Banking";
            Console.WriteLine(paymthd);
            btnOnlineB.FlatStyle = FlatStyle.Standard;
            btnEwallet.FlatStyle = FlatStyle.Flat;
            btnCBCard.FlatStyle = FlatStyle.Flat;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            receptionistPage = new ReceptionistPage();
            receptionistPage.Show();
        }
    }
}
