using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_RegexPIN_Validation
{
    //ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

    //If the function is passed a valid PIN string, return true, else return false.
    class Program
    {
        static void Main(string[] args)
        {
            Kata.RegexMatch(123);
        }
    }
}
