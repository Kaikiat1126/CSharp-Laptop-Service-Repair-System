using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            lblFname.Text = PaymentPage.instance.receiptInfo.Fname;
            lblLname.Text = PaymentPage.instance.receiptInfo.Lname;
            string numTitle = "IN";
            lblDInvoiceNo.Text = GetIDStr(PaymentPage.instance.receiptInfo.InvoiceNum, numTitle);
            lblDDate.Text = PaymentPage.instance.receiptInfo.Date;
            lblDPaymentM.Text = PaymentPage.instance.receiptInfo.Paymthd;
            numTitle = "OR";
            lblDOrderNum.Text = GetIDStr(PaymentPage.instance.receiptInfo.OrderID, numTitle);
            lblDServiceType.Text = PaymentPage.instance.receiptInfo.Service;
            lblDStatus.Text = PaymentPage.instance.receiptInfo.Status;
            lblDAmount.Text = PaymentPage.instance.receiptInfo.Amount.ToString();
        }

        private string GetIDStr(int numID, string title)
        {
            return title + numID.ToString().PadLeft(5, '0');
        }

        //change OR00010 to 10
        private int GetIDNum(string strID)
        {
            return int.Parse(strID.Substring(2, 5));
        }

        private Point mPoint;
        private void drag_down(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void drag_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        public static void PrintControl(string docName, string printerName, Panel ucToPrint, bool isPrintView)
        {
            using (var printDoc = new PrintDocument())
            {
                if (!string.IsNullOrEmpty(printerName))
                {
                    printDoc.DefaultPageSettings.PrinterSettings.PrinterName = printerName;
                    printDoc.DefaultPageSettings.Landscape = true;
                }
                printDoc.DocumentName = docName;
                printDoc.PrintPage += (sender, e) =>
                {
                    ucToPrint.Show();
                    var bitMap = new Bitmap(ucToPrint.Width, ucToPrint.Height);
                    ucToPrint.DrawToBitmap(bitMap, new Rectangle(0, 0, ucToPrint.Width, ucToPrint.Height));
                    //e.Graphics.DrawImageUnscaled(bitMap, Point.Empty);
                    e.Graphics.DrawImage(bitMap, Point.Empty);
                };
                if (isPrintView)
                {
                    using (var printViewDlg = new PrintPreviewDialog())
                    {
                        printViewDlg.Document = printDoc;
                        (printViewDlg as Form).WindowState = FormWindowState.Maximized;
                        printViewDlg.ShowDialog();
                    }
                }
                else
                {
                    printDoc.Print();
                }
            }

        }
        private void btnGenPDF_Click(object sender, EventArgs e)
        {
            PrintControl("Receipt", "Microsoft Print to PDF",this.pnlContainer, true);
        }

    }
}
