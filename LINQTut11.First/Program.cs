using Shared;
using System;
using System.Linq;

namespace LINQTut11.First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var firstQuestion = questions.First();
            Console.WriteLine(firstQuestion);

            //var someQuestion = questions.First(x => x.Title.Length == 0); //InvalidOperationException
            var someOtherQuestion = questions.FirstOrDefault(x => x.Title.Length == 0); //null

            if(someOtherQuestion is null)
            {
                Console.WriteLine("Question is null");
            }

            Console.ReadKey();
        }
    }
}
