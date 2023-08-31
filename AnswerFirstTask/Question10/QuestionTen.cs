using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerFirstTask.Question10
{
    internal class QuestionTen
    {
        public QuestionTen() { }
        public void Question10() {

            Color selectedColor = Color.Red;

            switch (selectedColor)
            {
                case Color.Red:
                    Console.WriteLine("Selected color is Red.");
                    break;
                case Color.Green:
                    Console.WriteLine("Selected color is Green.");
                    break;
                case Color.Blue:
                    Console.WriteLine("Selected color is Blue.");
                    break;
            }
            Console.WriteLine("------------------------------");

        }
        public enum Color
        {
            Red,
            Green,
            Blue
        }

    }
}
