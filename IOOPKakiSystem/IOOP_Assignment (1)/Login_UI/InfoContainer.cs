using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_UI
{
    public class InfoContainer
    {
        public static string Username = "";
        public static string Password = "";
        public static string Position = "";
        public static string Firstname = "";
        public static string Lastname = "";
        public static string Gender = "";
        public static string ContactNumber = "";
        public static string Email = "";
        public static string AddressOne = "";
        public static string AddressTwo = "";
        public static string City = "";
        public static string Zipcode = "";
        public static string State = "";


        //control cahce
        public static dynamic uc_recg_partOne = null;
        public static UC_recg_partTwo uc_recg_partTwo = null;
        public static UC_recg_partThree uc_recg_partThree = null;

        public static void RecgDetails(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public static void VerifyPosition(string position)
        {
            if (position == "Receptionist")
            {
                Position = "1";
            }
            else if (position == "Technician")
            {
                Position = "2";
            }
            else if (position == "Customer")
            {
                Position = "3";
            }
        }

        public static void RecgInfo(string firstname, string lastname, string gender, string contactnum, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Gender = gender;
            ContactNumber = contactnum;
            Email = email;
        }

        public static void RecgAddress(string addressOne, string addressTwo, string city, string zipcode, string state)
        {
            AddressOne = addressOne;
            AddressTwo = addressTwo;
            City = city;
            Zipcode = zipcode;
            State = state;
        }

        public static void insertInfo()
        {
            string sqlLogin = $"INSERT INTO UserLogin VALUES ('{Username}','{Password}',{Position});";

            Sql.Query(sqlLogin);
        }

        public static void insertDetails()
        {
            string sqlDetails = $"INSERT INTO Details VALUES ('{Firstname}', '{Lastname}', '{ContactNumber}', '{Gender}'," +
            $"'{Email}', '{AddressOne}', '{AddressTwo}', '{City}', '{Zipcode}', '{State}', '{Username}');";

            Sql.Query(sqlDetails);
        }
    }
}
