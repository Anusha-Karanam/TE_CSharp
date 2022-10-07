using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class RegularExpression
    {
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter mobile number");
                string mbl = Console.ReadLine();
                if (MobileValidation(mbl))
                    Console.WriteLine("Entered phone number is Valid");//check valid
                else
                    Console.WriteLine("Entered phone number is Invalid");//check invalid
                Console.WriteLine();
            }
        }
        public static bool MobileValidation(string num)
        {
            return Regex.IsMatch(num, @"^[7-9][0-9]{9}$");
        }
    }
}
