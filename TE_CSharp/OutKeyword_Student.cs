using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class OutKeyword_Student
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdep;

            Console.WriteLine("Displaying student details using OUT keyword");
            student(out sid, out sname, out sdep);

            Console.WriteLine($"Student id:{sid}");
            Console.WriteLine($"Student name:{sname}");
            Console.WriteLine($"Student Department:{sdep}");
        }
        //display student input details
        public static void student(out int sid, out string sname, out string sdep)
        {
            sid = 54;
            sname = "Anusha";
            sdep = "ECE";
        }
    }
}
