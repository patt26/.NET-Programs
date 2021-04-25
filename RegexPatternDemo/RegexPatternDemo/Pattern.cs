using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternDemo
{
    class Pattern
    {
        //aaaaaa, sdfg45// pincode -> 6digi , 234 678   345654 [ ]
        //string Regex_Pincode="^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        // string Regex_Pincode = "^[a-z0-9A-Z]+[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}$";
        // string Regex_Pincode = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string Regex_Pincode = "^[1-9][0-9]{5}$";
        string Regex_Pincode1= "^[1-9][0-9]{2}[ ]{0,2}[0-9]{3}$";
        // string Regex_Pincode = "^[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{3}$";
        ///string Regex_Pincode = "^[A-Za-z0-9]+([.][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";

        //string Regex_Pincode = " ^(?!invalid)(.(?!invalid))*$";
        //readonly string Regex_Pincode1 = "^[0-9]{0,}[a-zA-Z]{3,}[a-zA-Z0-9]*$";
        public bool validatePinCode(string input)
        {
            return Regex.IsMatch(input, Regex_Pincode);
        }
        public bool ValidatePinCode1(string Regex_Pincode1) { }
    }

}
