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
    public partial class Income_Report : Form
    {
        public Income_Report()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Year = comboYear.Text;
            switch (Year)
            {
                case "2020":
                    ClearData();
                    GetMonthlyIncome(Year);
                    break;
                case "2021":
                    ClearData();
                    GetMonthlyIncome(Year);
                    break;
                case "2022":
                    ClearData();
                    GetMonthlyIncome(Year);
                    break;
                case "2023":
                    ClearData();
                    GetMonthlyIncome(Year);
                    break;
            }
        }

        private void GetMonthlyIncome(string year)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ioopkakiDBCS"].ToString());
            con.Open();
            string query = $"SELECT MONTH(Orderdate), COUNT(OrderID), SUM(ServiceFee) FROM CustomerOrder WHERE YEAR(OrderDate) = {year} AND Payment_Status = 'Paid' GROUP BY MONTH(Orderdate)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvIncomeReport.Rows.Add(alphaMonth(dr.GetInt32(0).ToString()), dr.GetInt32(1), dr.GetInt32(2)+ ".00");
            }
            con.Close();
            lblRepTitle.Text = year + " Income Report";
            if (dgvIncomeReport.Rows.Count == 0)
            {
                lblRepTitle.Visible = false;
                dgvIncomeReport.Visible = false;
                lblNoDataAlert.Visible = true;
            }
        }

        string alphaMonth(string month)
        {
            string[] MonthRepo = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Disember" };
            int count = 1;
            foreach (string m in MonthRepo)
            {
                if (month == Array.IndexOf(MonthRepo, MonthRepo[count]).ToString())
                {
                    month = MonthRepo[count];
                    break;
                }
                count++;
            }
            return month;
        }

        private void ClearData()
        {
            int count;
            for (count = 1; count < dgvIncomeReport.Rows.Count; count++)
            {
                dgvIncomeReport.Rows.Clear();
            }
        }

        private void Income_Report_Load(object sender, EventArgs e)
        {
            lblRepTitle.Text = "Income Report";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage admin = new AdminPage();
            admin.Show();
        }
    }
}
