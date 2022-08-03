using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Program
{
    public class UserRegister
    {
        //Regex Patterns 
        public string regex_FirstName = "^[A-Z][a-z]{2,}$";
        public string regex_LastName = "^[A-Z][a-z]{2,}$";
        public string regex_Email = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,})?$";
        public string regex_PhoneNumber = "^[+]?[9][1][' ']?[0-9]{10}$";
        public string regex_Password = "^[A-Z][a-z]{7,}$";
        //Method to check the First Name
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, regex_FirstName);
        }
        //Method to check the Last Name
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, regex_LastName);
        }
        //Method to check the Email ID
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, regex_Email);
        }
        //Method to check the PhoneNumber
        public bool validatePhoneNum(string phonenum)
        {
            return Regex.IsMatch(phonenum, regex_PhoneNumber);
        }
        //Method to check the Password
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, regex_Password);
        }
    }
}

