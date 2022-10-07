using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    //Collections
    internal class collections
    {
        public static void Dictionary_Demo()
        {
            Dictionary<int, string> vs = new Dictionary<int, string>();
            Console.WriteLine("DICTIONARY");
            Console.WriteLine("Enter dictionary items");
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Enter dictionary value for key {i}: ");
                vs[i] = i.ToString(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Dictionary items are: ");
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var key = new List<int>(vs.Keys);
            Console.WriteLine("Dictionary keys are: ");
            foreach (var obj in key)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var values = new List<string>(vs.Values);
            Console.WriteLine("Dictionary values are: ");
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            while (true)
            {
                Console.Write("Enter the key to get the value or else enter to zero to stop: ");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt < 6 && opt > 0)
                {
                    Console.WriteLine($"Value: {vs[opt]}");
                }
                else
                {
                    Console.WriteLine("Invalid key");
                }
                if (opt == 0)
                {
                    break;
                }
            }
            Console.WriteLine("-----------------------------------------");
        }
        //Hashtable
        public static void Hashtable_Demo()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("HASH TABLE");
            Console.WriteLine("Enter 5 hash table items");
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Enter hast table value for key {i}: ");
                ht[i] = i.ToString(Console.ReadLine());
            }
            Console.WriteLine("HASHTABLE");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Fetching 10 hash table items are: ");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Key{i}: {ht[i]}");
            }
        }
        public static void Main()
        {
            Console.WriteLine("-----------------------------------------");
            Dictionary_Demo();
            Console.WriteLine("-----------------------------------------");
            Hashtable_Demo();
        }
    }
}
