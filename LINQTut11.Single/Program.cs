using Shared;
using System;
using System.Linq;

namespace LINQTut11.Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            //var question = questions.Single(x => x.Title.Contains("#245"));
            //var question2 = questions.SingleOrDefault(x => x.Title.Contains("#245"));
            //var question3 = questions.Single(x => x.Title.Length == 0);

            QuestionBank.All.ToQuiz();

            Console.ReadKey();
        }
    }
}
