using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter03_Example01.HelperLibrary
{
    public class CodeHelper
    {
        public static string Reverse(string s)
        {
            return new string(s.Reverse().ToArray()); 
        }

        public string Ordered(string s)
        {
            return new string(s.OrderBy(n => n.ToString(), StringComparer.InvariantCultureIgnoreCase).ToArray()); 
        }
    }
}
