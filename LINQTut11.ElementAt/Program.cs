using Shared;
using System;
using System.Linq;

namespace LINQTut11.ElementAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
             
            var questionAt10 = questions.ElementAt(10);

            // var questionAt300 = questions.ElementAt(300); ArugumentOutOfRangeException
            var questionAt300 = questions.ElementAtOrDefault(300);
            
            if(questionAt300 is null)
            {

            }


            Console.WriteLine(questionAt300);
            Console.ReadKey();
        }
    }
}
