using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.Question7
{
    internal class QuestionSeven
    {
        public QuestionSeven() { }
        
            public void ChangeValue(int num)
            {
                num += 10;
                int number = 5;
                Console.WriteLine(number);
                
            }
          public  void ChangeValueRef(ref int num)
            {
                num += 10;
                int number = 5;
                ChangeValueRef(ref number);
                Console.WriteLine(number);
            }
            public void ChangeOutput()
            {
                int number1 = 5;
                int number2 = 3;

                int sum;

                CalculateSum(number1, number2, out sum);

                Console.WriteLine("The sum of {0} and {1} is: {2}", number1, number2, sum);
                Console.WriteLine("--------------------------------------");
            }

            static void CalculateSum(int a, int b, out int result)
            {
                result = a + b;
            }
        }


    } 

