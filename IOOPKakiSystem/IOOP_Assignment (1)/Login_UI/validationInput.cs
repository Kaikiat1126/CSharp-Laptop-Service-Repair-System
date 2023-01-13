using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Login_UI
{
    public class validationInput
    {

        //Check Password Format
        public static bool IsSure(string password, string confirmPassword)
        {

            if (password == confirmPassword && Regex.IsMatch(password, @"^[A-Za-z_@0-9]{8,20}$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Input Password!");
                return false;
            }
        }

        //Check Username Format & Repeat
        public static bool IsName(string username)
        {
            if (Regex.IsMatch(username, @"^[A-Za-z_.@0-9]{5,30}$"))
            {
                string sql = $"SELECT COUNT (*) FROM UserLogin WHERE Username = '{username}'";

                if (Sql.Validation(sql) == false)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Username already exists!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input Username!");
                return false;
            }
        }

        //String to Integer
        public static int GetStringLength(string stringValue)
        {
            return Encoding.Default.GetBytes(stringValue).Length;
        }

        //Check Contact Number Format
        public static bool IsNumber(string ContactNumber)
        {
            int contactLength = GetStringLength(ContactNumber);
            if (contactLength >= 10 && contactLength <= 12 && Regex.IsMatch(ContactNumber, "^[0-9]+$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Input Contact Number!");
                return false;
            }
        }

        //Check Email Format
        public static bool IsEmail(string Email)
        {

            if (Regex.IsMatch(Email, @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Input Email!");
                return false;
            }
        }

        // Check Name Format
        public static bool IsStringName(string firstName, string lastName)
        {
            if (Regex.IsMatch(firstName, @"^[A-Za-z]{2,20}$") && Regex.IsMatch(lastName, @"^[A-Za-z]{2,20}$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Input Name!");
                return false;
            }
        }

        //Check Zipcode Format
        public static bool IsZipcode(string Zipcode)
        {
            int numLength = GetStringLength(Zipcode);
            if (numLength == 5 && Regex.IsMatch(Zipcode, "^[0-9]+$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Input Zipcode!");
                return false;
            }
        }

        //Check Address String Length
        public static bool IsAddress(string addressOne, string addressTwo)
        {
            int addressLength = GetStringLength(addressOne);
            int ADDressLength = GetStringLength(addressTwo);
            if (addressLength > 5 && ADDressLength > 5)
            {
                string lineOne = addressOne.ToLower();
                string lineTwo = addressTwo.ToLower();

                bool row1 = lineOne.Contains("drop table");
                bool row2 = lineOne.Contains("drop database");
                bool row3 = lineTwo.Contains("drop table");
                bool row4 = lineTwo.Contains("drop database");

                if (row1 == true || row2 == true || row3 == true || row4 == true)
                {
                    MessageBox.Show("What are you doing?");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input String Length of AddressLine1 or Line2!");
                return false;
            }
        }

        //Check City & State String Length
        public static bool IsArea(string city, string state)
        {
            int cityLength = GetStringLength(city);
            int stateLength = GetStringLength(state);
            if (cityLength > 3 && stateLength > 3)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Input City or State!");
                return false;
            }
        }
    }
}
