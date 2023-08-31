using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.QuestionOne
{
    internal class QuestionOne
    {
        
        public QuestionOne() { }
        public void Question1()
        { 
            // Types Value
            int a = 5;
            int b = a;
            b = 10;
            Console.WriteLine(a); 

            // Types Reference
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 0;
            Console.WriteLine(arr1[0]);

            // Types Pointer
            unsafe { int c = 5;
            int* ptr = &c;
            *ptr = 10;
            Console.WriteLine(c); }
            Console.WriteLine("------------------------------");
        }
    }
}
