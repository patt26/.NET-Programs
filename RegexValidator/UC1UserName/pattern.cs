using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC1UserName
{
    class Pattern
    {
        string Name_Validator = "^[A-Z]{1}[a-z]{3,}$";


        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, Name_Validator);
        }


    }
}
    







   

