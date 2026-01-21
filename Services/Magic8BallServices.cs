using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace VanhornBMC6.Services
{
    public class Magic8BallServices
    {
        public string Magic8Ball(string responses)
        {

            string[] responses2 ={
        "Probably not, don't ask again",
        "How dare you, thats weird",
        "Um no, you might want to seek therapy",
        "Yes, I always knew you were a nerd",
        "Nah",
        "Yes but also no",
        "System Error, Please try again",
        "You monster, how dare you suggest that",
        "I don't contain the parameters to help you",
        "Ayo, please read the bible bro"
        };

        return $"{responses}";

            bool playAgain = true;


            Random rand = new Random();

            while (playAgain)
            {
                return "Welcome to Magic 8 Ball! Please ask a question:";
                string? question = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(question))
                {
                    return "You need to ask something!";
                    continue;
                }

                if (!question.Trim().EndsWith("?"))
                {
                    return "That doesn't look like a question. Add a ? to your sentence";
                    continue;
                }

                int index = rand.Next(responses.Length);
                return $"Magic 8 Ball says: {responses[index]}";
            }
        }
    }
}