using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.Question5
{
    internal class QuestionFive
    {
        public QuestionFive() { }
        public void Question5() {
            //while
            int x = 0;
            while (x < 5)
            {
                Console.Write(x);
                x++;
            }
            Console.WriteLine();
            //do … while 
            int y = 8;
            do
            {
                Console.Write(y);
                y++;
            } while (y < 5);
            //for
            int z=0;
            Console.WriteLine();
            for ( z = 0; z < 5; z++)
            {
                Console.Write(z);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");

        }
    }
}
