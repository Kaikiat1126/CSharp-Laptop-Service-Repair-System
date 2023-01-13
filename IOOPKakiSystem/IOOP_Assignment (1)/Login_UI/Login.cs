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
    public partial class Login : Form
    {
        public static Login instance;

        public UserInfo userInfo;

        public UserPassword userPassword;

        private string position = null;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            picError.Hide();
            instance = this;
            InitEvent();
        }

        private void InitEvent()
        {
            txtUsername.Enter += new EventHandler(name_Enter);
            txtUsername.Leave += new EventHandler(name_Leave);

            txtPassword.Enter += new EventHandler(pass_Enter);
            txtPassword.Leave += new EventHandler(pass_Leave);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your Username")
            {
                txtUsername.Text = "";
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Enter your Username";
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Enter your Password";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Valid the current txtPassword value
            if (chkShowPassword.Checked == false && txtPassword.Text != "Enter your Password")
            {
                //txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
                txtPassword.PasswordChar = '*';
            }
            else if (chkShowPassword.Checked == true || txtPassword.Text == "Enter your Password")
            {
                txtPassword.PasswordChar = '\0';
            }        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Connect to Database
            string connStr = ConfigurationManager.ConnectionStrings["ioopkakiDBCS"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT * FROM UserLogin WHERE Username='{txtUsername.Text}'" + $" AND AccPassword='{txtPassword.Text}'";


            Console.WriteLine(sql);
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //get password
                string password = dr[1].ToString();
                string position = dr[2].ToString();
                userPassword = new UserPassword(password, position);

                //get User Info
                SqlConnection conn1 = new SqlConnection(connStr);
                conn1.Open();

                string sqlInfo = $"SELECT * FROM Details WHERE Username='{txtUsername.Text}'";

                Console.WriteLine(sqlInfo);
                SqlCommand sqlInfoCommand = new SqlCommand(sqlInfo, conn1);

                SqlDataReader drInfo = sqlInfoCommand.ExecuteReader();

                while (drInfo.Read())
                {
                    string FirstName = drInfo[0].ToString();
                    string LastName = drInfo[1].ToString();
                    string contactnumber = drInfo[2].ToString();
                    string Gender = drInfo[3].ToString();
                    string email = drInfo[4].ToString();
                    string addressOne = drInfo[5].ToString();
                    string addressTwo = drInfo[6].ToString();
                    string city = drInfo[7].ToString();
                    string zipcode = drInfo[8].ToString();
                    string state = drInfo[9].ToString();
                    string username = drInfo[10].ToString();

                    userInfo = new UserInfo(FirstName, LastName, contactnumber, Gender, email,
                                                addressOne, addressTwo, city, zipcode, state, username, position);
                }

              
                MessageBox.Show("Login sucess, Welcome");

                if(dr[2].ToString() == "3")
                {
                    position = "3";
                    this.Hide();

                    CustomerPage customer = new CustomerPage();
                    customer.Show();

                }
                else if(dr[2].ToString() == "1")
                {
                    position = "1";
                    this.Hide();

                    ReceptionistPage receptionist = new ReceptionistPage();
                    receptionist.Show();
                }
                else if (dr[2].ToString() == "2")
                {
                    position = "2";
                    this.Hide();

                    TechnicianPage tech = new TechnicianPage();
                    tech.Show();

                }
                else if (dr[2].ToString() == "4")
                {
                    position = "3";
                    this.Hide();

                    AdminPage admin = new AdminPage();
                    admin.Show();
                }

                drInfo.Close();
                conn1.Close();
            }
            else
            {
                //MessageBox.Show("Invalid Login please check username and password");
                picError.Show();
            }
            dr.Close();
            conn.Close();

        }

    }
}