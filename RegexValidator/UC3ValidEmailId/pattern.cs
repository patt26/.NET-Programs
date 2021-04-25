using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC3ValidEmailId
{
    
    
        class EmailId
        {
            string EmailIdValidator = "^[a-zA-Z0-9]+([.]{1}[a-zA-Z0-9]+)?[@]{1}[a-zA-Z]+[.][A-Za-z]{3}$";


            public bool ValidateName(string name)
            {
                return Regex.IsMatch(name, EmailIdValidator);
            }


        }
    
}
