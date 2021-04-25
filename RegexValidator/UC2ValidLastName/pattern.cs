using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC2ValidLastName
{
    class LastName
    {
        string LastName_Validator = "^[A-Z]{1}[a-z]{3,}$";


        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, LastName_Validator);
        }
    }
}
