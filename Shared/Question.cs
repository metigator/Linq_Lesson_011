using System.Collections.Generic;
namespace Shared
{
    public class Question
    {
      

        public string Title { get; set; }
        public List<Choice> Choices { get; set; } = new();

        public int CorrectAnswer { get; set; }



        public readonly static Question Default = new Question
        {
            Title = "<<<<< QUESTION TITLE GOES HERE >>>>>",
            Choices = new List<Choice>
            {
                new Choice { Order = 1, Description = "<<<<< CHOICE #1 GOES HERE >>>>>" },
                new Choice { Order = 2, Description = "<<<<< CHOICE #2 GOES HERE >>>>>" },
                new Choice { Order = 3, Description = "<<<<< CHOICE #3 GOES HERE >>>>>" },
                new Choice { Order = 4, Description = "<<<<< CHOICE #4 GOES HERE >>>>>" }
            },
            CorrectAnswer = 0
        };


        public override string ToString()
        {
            var choices = "";

            foreach (var item in Choices)
            {
                choices += $"\n\t{item.Order}) {item.Description}";
            }

            return $"{Title}" +
                   $"{choices}";


        }
    }
}
