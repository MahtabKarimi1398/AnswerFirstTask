using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.QuestionNo
{
    internal class QuestionNo
    {
        public QuestionNo() { }
        public void Question9() {
            // Multidimensional:
            int[,] multidimensionalArray = new int[3, 2];
            multidimensionalArray[0, 0] = 1;
            multidimensionalArray[0, 1] = 2;
            multidimensionalArray[1, 0] = 3;
            multidimensionalArray[1, 1] = 4;
            multidimensionalArray[2, 0] = 5;
            multidimensionalArray[2, 1] = 6;
            for(int i = 0; i <3; i++)
            {
                for(int j = 0; j <2; j++)
                {
                    Console.Write(multidimensionalArray[i, j] +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Jagged:
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            for (int x = 0; x < jaggedArray.Length; x++)
            {
                for (int y = 0; y < jaggedArray[x].Length;y++)
                {
                    Console.Write(jaggedArray[x][y]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
        }
    }
}
