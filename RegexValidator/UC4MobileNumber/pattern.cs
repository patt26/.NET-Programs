using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC4MobileNumber
{
    class PhoneNum
    {
        string PhoneValidator = "^[91]{2}[ ]*[0-9]{10}$";


        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, PhoneValidator);
        }


    }
}
