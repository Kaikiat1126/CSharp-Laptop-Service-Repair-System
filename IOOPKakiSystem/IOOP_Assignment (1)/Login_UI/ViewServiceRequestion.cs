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
    public partial class ViewServiceRequestion : Form
    {
        public static ViewServiceRequestion instance; //current form
        public TechnicianPage form2; //previous form

        //select all from customer order
        string slctAll = "SELECT * FROM CustomerOrder;";

        //disable changes on listview
        private void lslvServiceOrder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
                e.Item.Focused = false;
            }
        }

        //disable changes on listview width
        private void lslvServiceOrder_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lslvServiceOrder.Columns[e.ColumnIndex].Width;
        }

        public ViewServiceRequestion()
        {
            InitializeComponent();
            form2 = new TechnicianPage(); //previous form
            instance = this; //current form
        }

        //return to previous form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult previous;
            previous = MessageBox.Show("Confirm if you want to go back to the previous page.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (previous == DialogResult.Yes)
            {
                this.Hide();
                form2.Show();
            }
        }

        //clear the search txtbox
        private void txtSearch_Click(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void ViewServiceRequestion_Load(object sender, EventArgs e)
        {
            //count and display total order on lblServiceOrder
            string totalOrder = Sql.NonQuery1("SELECT COUNT(*) FROM CustomerOrder;");
            lblServiceOrder.Text = totalOrder + " Service Orders";

            //count and display total pending order on lblServiceInProgress
            string totalPendingOrder = Sql.NonQuery1("SELECT COUNT(*) FROM CustomerOrder WHERE ServiceCondition <> 'Completed' AND ServiceCondition <> 'Cancelled';");
            lblServiceInProgress.Text = totalPendingOrder + " Pending Orders";

            //count and display total customer on lblTotalCustomer
            string totalCustomer = Sql.NonQuery1("SELECT COUNT(DISTINCT Username) FROM CustomerOrder;");
            lblTotalCustomer.Text = totalCustomer + " Customers";

            ServiceOrder.GenerateData(slctAll);
        }

        //search from service order when enter key is down
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //clear list view
                lslvServiceOrder.Items.Clear();

                //notify user not to include 'OR0000' when searching for an order number

                string[] normal = {"nor", "norm", "norma", "normal"};
                string[] format = { "for", "form", "forma", "format" };
                if (txtSearch.Text.ToLower().Contains("or") && txtSearch.Text.ToLower() != "or" && !normal.Contains(txtSearch.Text.ToLower()) && !format.Contains(txtSearch.Text.ToLower()))
                {
                    MessageBox.Show("Please type number only for searching an order number.");
                }
                else
                {
                    //if not searching for 'OR0000'
                    ServiceOrder.GenerateData($"select * from CustomerOrder WHERE OrderID LIKE '%{txtSearch.Text}%' OR OrderDate LIKE '%{txtSearch.Text}%' OR ServiceType LIKE '%{txtSearch.Text}%' OR ServiceStatus LIKE '%{txtSearch.Text}%' OR ServiceFee LIKE '%{txtSearch.Text}%' OR ServiceCondition LIKE '%{txtSearch.Text}%' OR Username LIKE '%{txtSearch.Text}%';");
                }

                //if no item found
                if (lslvServiceOrder.Items.Count == 0)
                {
                    MessageBox.Show($"{txtSearch.Text} is not found.");
                    ServiceOrder.GenerateData(slctAll);
                }
                txtSearch.Clear();
            }
        }
    }
}

