using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.Question4
{
    internal class QuestionFour
    {
        public int x;
        public string day;
        public int y;
        public QuestionFour( int x1,string d,int y1 ) {
            int x = x1;
            string day = d;
            int y = y1;
        }

        public void Question4()
        {
            //if else statement 
            if (x > 0)
            {
                Console.WriteLine("x is positive");
            }
            else
            {
                Console.WriteLine("x is not positive");
            }
            //switch
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Today is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;
                default:
                    Console.WriteLine("Today is not Monday or Tuesday");
                    break;
            }
            //conditional operator (? )
            string result = (y > 0) ? "y is positive" : "y is not positive";
            Console.WriteLine(result);
            Console.WriteLine("------------------------------");


        }
    }
}
