using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC5Password
{
    class Password
    {
        string PasswordValidator = "^([A-Za-z0-9][A-Z]*[0-9]{1}[@!#$%^&*]{1}){8,}$"; //incomplete
        

        public bool Validate(string name)
        {
            return Regex.IsMatch(name, PasswordValidator);
        }


    }
}
