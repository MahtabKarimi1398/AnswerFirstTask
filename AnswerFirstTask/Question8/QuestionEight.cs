using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.Question8
{
    internal class QuestionEight
    {
        public QuestionEight() { }
        public void Question8(){
            int? number1 = null;
            int number2 = 10;
            int result = number1 ?? number2;

            Console.WriteLine(result);
            Console.WriteLine("------------------------------");

        }
        
    }
}
