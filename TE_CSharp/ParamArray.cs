using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class ParamArray
    {
        public static void Main()
        {
            table(3, 4);
            Console.WriteLine("-----------------");
            table(5, 6, 7);
        }
        public static void table(params int[] multipliers)
        {
            foreach (int i in multipliers)
            {
                Console.WriteLine("Multiplication table of {0}", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");//Multiplication of 2 elements
                }
            }
            Console.WriteLine();
        }

      
    }
}
