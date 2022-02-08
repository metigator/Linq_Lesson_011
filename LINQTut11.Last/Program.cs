using Shared;
using System;
using System.Linq;

namespace LINQTut11.Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var lastQuestion = questions.Last();
            Console.WriteLine(lastQuestion);

            //var someQuestion = questions.Last(x => x.Title.Length == 0); //InvalidOperationException

            var someOtherQuestion = questions.LastOrDefault(x => x.Title.Length == 0); //null

            if (someOtherQuestion is null)
            {
                Console.WriteLine("Question is null");
            }
            Console.ReadKey();
        }
    }
}
