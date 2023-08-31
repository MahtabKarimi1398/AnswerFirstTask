using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.QuestionTwo
{
    internal class QuestionTwo
    {
       public QuestionTwo() { }
        public void Question2() {
            // Implicit 
            int num1 = 10;
            double num2 = num1; 
            Console.WriteLine(num2);
            // Explicit 
            string str = "10";
            int num3 = Convert.ToInt32(str); 
            Console.WriteLine(num3);
            // Boxing 
            int num4 = 20;
            object obj = num4;
            // Unboxing
            int num5 = (int)obj;  
            Console.WriteLine(num5);
            Console.WriteLine("------------------------------");
        }
    }
}
