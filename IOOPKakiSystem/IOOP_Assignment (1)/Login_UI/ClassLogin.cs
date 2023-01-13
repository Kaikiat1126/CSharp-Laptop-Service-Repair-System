using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_UI
{
    public class UserInfo
    {
        public static UserInfo instance;

        public string userFirstName = "";
        public string userLastName = "";
        public string userContactNumber = "";
        public string userGender = "";
        public string userEmailAddress = "";
        public string userAddressLineOne = "";
        public string userAddressLineTwo = "";
        public string userCity = "";
        public string userZipCode = "";
        public string userStateAdd = "";
        public string userUsername = "";
        public string userPosition = "";

        public UserInfo(string firstName, string lastName, string phoneNum, string gender
            , string email, string address1, string address2, string city, string zipCode,
            string state, string userName, string position)
        {
            userFirstName = firstName;
            userLastName = lastName;
            userContactNumber = phoneNum;
            userGender = gender;
            userEmailAddress = email;
            userAddressLineOne = address1;
            userAddressLineTwo = address2;
            userCity = city;
            userZipCode = zipCode;
            userStateAdd = state;
            userUsername = userName;
            userPosition = position;

            instance = this;
        }

        public void changeProfile(string pFirstname, string pLastname, string pAddressOne, 
            string pAddressTwo, string pCity, string pZipcode, string pState)
        {
            userFirstName = pFirstname;
            userLastName = pLastname;
            userAddressLineOne= pAddressOne;
            userAddressLineTwo = pAddressTwo;
            userCity = pCity;
            userZipCode = pZipcode;
            userStateAdd = pState;
        }

        public void changeSecurity(string pContact, string pEmail)
        {
            userContactNumber = pContact;
            userEmailAddress = pEmail;
        }
    }

    public class UserPassword
    {
        public static UserPassword instance;

        public string Password = "";
        public string Position = "";

        public UserPassword(string password, string position)
        {
            Password = password;
            Position = position;

            instance = this;
        }

        public void changePassword(string pPassword)
        {
            Password = pPassword;
        }
    }
}
