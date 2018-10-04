using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FSDConsoleApplication
{
    public class StringExtension
    {
        public const string c_EmailExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public void CheckEmail()
        {
            Console.Write("\n\nRead a input string and verify it's valid format.\n");
            string sInputString = Convert.ToString(Console.ReadLine());
            bool value = IsValidEmail(sInputString);
            Console.WriteLine(value);
        }


        private bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, c_EmailExpression);
        }
    }

    
}
