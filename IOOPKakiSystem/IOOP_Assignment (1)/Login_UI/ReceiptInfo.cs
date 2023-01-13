using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_UI
{
    public class ReceiptInfo
    {
        public string Fname;
        public string Lname;
        public int InvoiceNum;
        public string Date;
        public string Paymthd;
        public int OrderID;
        public string Service;
        public string Status;
        public int Amount;

        public ReceiptInfo(string firstName, string lastName, int invoiceNum, string date,
            string paymethod, int orderID, string service, string status, int amount)
        {
            Fname = firstName;
            Lname = lastName;
            InvoiceNum = invoiceNum;
            Date = date;
            Paymthd = paymethod;
            OrderID = orderID;
            Service = service;
            Status = status;
            Amount = amount;
        }
    }
}
