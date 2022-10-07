using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class FileOperation
    {
        public static void Main()
        {
            //file path
            string path = "\\tables.txt";
            string movepath = "C:\\Users\\EI13153\\Desktop\\CSharp\\tables.txt";
           // string copypath = "C:\\Users\\EI13153\\Desktop\\CSharp\\tables-copy.txt";

            //check whether the file exists
            if (File.Exists(path))
            {
                //Copy file
              //File.Copy(path, copypath);

                //Move the file
                //File.Move(copypath, movepath);

                //Delete file
                File.Delete(movepath);
            }
            else
            {
                Console.WriteLine("File does not Exist");//file does not exist
            }
        }
    }
}
