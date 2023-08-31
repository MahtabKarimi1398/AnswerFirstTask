using AnswerFirstTask.Question10;
using AnswerFirstTask.Question11;
using AnswerFirstTask.Question3;
using AnswerFirstTask.Question4;
using AnswerFirstTask.Question5;
using AnswerFirstTask.Question6;
using AnswerFirstTask.Question7;
using AnswerFirstTask.Question8;
using AnswerFirstTask.QuestionNo;
using AnswerFirstTask.QuestionOne;
using AnswerFirstTask.QuestionTwo;

internal class Program
{
    private static void Main(string[] args)
    {
        QuestionOne questionOne = new QuestionOne();
        questionOne.Question1();

        QuestionTwo questionTwo = new QuestionTwo();
        questionTwo.Question2();

        QuestionThree questionThree = new QuestionThree(4.2);
        questionThree.Question3();

        QuestionFour questionFour = new QuestionFour(-4,"My",-2);
        questionFour.Question4();

        QuestionFive questionFive = new QuestionFive();
        questionFive.Question5();


        QuestionSix questionSix = new QuestionSix();
        questionSix.Question6();

        QuestionSeven questionSeven = new QuestionSeven();
        questionSeven.ChangeValue(10);
        questionSeven.ChangeOutput();

        QuestionEight questionEight = new QuestionEight();
        questionEight.Question8();

        QuestionNo questionNo = new QuestionNo();
        questionNo.Question9();

        QuestionTen questionTen = new QuestionTen();
        questionTen.Question10();

        QuestionEleven questionEleven = new QuestionEleven(32);
        questionEleven.Question11();
        MyStruct myStruct;
        myStruct.salary = 1895;
        myStruct.QuestionStruct();
        

        
    }
}