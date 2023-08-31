using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.Question6
{
    internal class QuestionSix
    {
        public QuestionSix() { }
        public void Question6() {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                    Console.Write(i);
            }
            Console.WriteLine();
            int j = 0;
            while (j < 10)
            {
                if (j == 5)
                {
                    break;
                }
                Console.Write(j);
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");

        }
    }
}
