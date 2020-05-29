using System;

namespace Quadax_program
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "";
            string guess = "";
            string answer = "";
            int turns = 1;
            bool win = false;


            //create an answer
            answer = Answer.CreateAnswer();

            Console.WriteLine("Guess a four digit number to win. Each digit 0-6 and you have 10 turns");

            guess = Console.ReadLine();


            while (turns <10)
            {

                if (guess == answer)
                {
                    win = true;
                    break;
                }

                Validation validation = new Validation();
                string message = validation.ValidateGuess(guess);

                if (!string.IsNullOrWhiteSpace(message))
                {
                    Console.WriteLine("Error: " + message);
                }
                else
                {
                    CompareGuessToAnswer compareGuessToAnswer = new CompareGuessToAnswer();
                    key = compareGuessToAnswer.Compare(guess,answer);
                    turns += 1;
                    Console.WriteLine("Try again, turn - " + turns);
                    Console.WriteLine("Your guess is - " + guess);
                    Console.WriteLine("Keys: " + key);
                 
                }

                guess = Console.ReadLine();
            }

            if(win == false)
            {
                Console.WriteLine("Out of turns");
                Console.WriteLine("Answer is " + answer);

            }
            else
            {
                Console.WriteLine("You Win! Your guess " + guess + " matches number " + answer);
            }
            
            Console.ReadKey();

        }
    }
}
