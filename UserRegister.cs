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
        public string regex_FirstName = "^[A-Z][a-z]{2,}$";
        public string regex_LastName = "^[A-Z][a-z]{2,}$";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, regex_FirstName);
        }
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, regex_LastName);
        }
    }
}
