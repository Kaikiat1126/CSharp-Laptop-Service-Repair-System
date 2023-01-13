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
    public partial class ServiceReport : Form
    {
        public string ServiceType;
        public string Month;
        public string Year;
        SerRepGenerator generator;
        public ServiceReport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public ServiceReport(string Sertype, string month, string year)
        {
            InitializeComponent();
            ServiceType = Sertype;
            Month = month;
            Year = year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void ServiceReport_Load(object sender, EventArgs e)
        {
            lblServiceRepTitle.Text = Year +" " + Month + " Service Report";
            generator = new SerRepGenerator(Month, ServiceType, Year);
            GetData();
            if (dgvServiceReport.Rows.Count == 0)
            {
                lblServiceRepTitle.Visible = false;
                dgvServiceReport.Visible = false;
                lblNoDataAlert.Visible = true;
            }
        }

        private void GetData()
        {
            int numericMonth = generator.MonthDigitaliser(); 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ioopkakiDBCS"].ToString());
            con.Open();
            string sql;
            if (ServiceType == "-ALL-")
            {
                sql = generator.query(numericMonth, Convert.ToInt32(Year));
            }
            else
            {
                sql = generator.query(numericMonth, ServiceType, Convert.ToInt32(Year));
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvServiceReport.Rows.Add(GetIDStr(dr.GetInt32(0)), dr.GetString(1), dr.GetString(2), dr.GetDateTime(3).ToString("d"), dr.GetString(4), dr.GetInt32(5));
            }
            con.Close();
        }

        private string GetIDStr(int numID)
        {
            return "IN" + numID.ToString().PadLeft(5, '0');
        }
    }
}