
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC6Password1UpperCase
{
    class Password
    {
        string PasswordValidator = "^[A-Za-z0-9]{8,}[A-Z]*$";


        public bool Validate(string name)
        {
            return Regex.IsMatch(name, PasswordValidator);
        }


    }
}
