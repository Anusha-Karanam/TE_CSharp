using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class FileLines
    {
        public static void Main()
        {
            //path of file
            string path = "C:\\Users\\EI13153\\Desktop\\CSharp\\tables.txt";
            string[] content;

            //Read first line
            content = File.ReadAllLines(path);

            Console.WriteLine("First line of the file");
            Console.WriteLine(content[0]);
            Console.WriteLine("-------------------------------");

            //Count number of lines in the file
            int count = File.ReadAllLines(path).Length;
            Console.WriteLine("Total number of lines in the file");
            Console.WriteLine(count);
            Console.WriteLine("-------------------------------");

        }

    }

}
