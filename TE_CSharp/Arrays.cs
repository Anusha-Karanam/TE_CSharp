using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Arrays
    {
        public static void Main()
        {

            Array_2D();
            Console.WriteLine("------------------------------------------");
            
        }
        public static void Array_2D()
        {
            //int[rows,columns]
            int[,] matrix1 = new int[2,2]
            {
              //matrix1 
                {1,2}, //array[1,2]
                {3,4} //array[3,4]
            };
            //int[row,colums]
            int[,] matrix2 = new int[2,2]
            {
                //matrix2
                {2,4},//array[2,4]
                {6,8}//array[6,8]
            };
            //matrix 3
            int[,] matrix3 = new int[2,2];//array[2,2]
            //rows
            for (int row = 0; row < matrix3.GetLength(0); row++) 
            {
                //columns
                for (int col = 0; col < matrix3.GetLength(1); col++) 
                {
                    matrix3[row, col] = matrix1[row, col] + matrix2[row, col];//Addition of 2 matrices
                    Console.Write(matrix3[row,col]+"\n");
                }
               
            }

        }
    }
}
