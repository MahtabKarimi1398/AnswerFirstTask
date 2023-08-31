using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.Question11
{
   
    //class
    internal class QuestionEleven
    {
        public int age;
        public QuestionEleven( int number) {
             age = number;
                }
        public void Question11() {
            Console.WriteLine("age:"+age);
        }
    }
    //struct
    public struct MyStruct
    {
         public float salary;
        
        public void QuestionStruct() {
            Console.WriteLine(salary+"$");
        }
    }
}
