using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace T7_Nate_s_casino_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            int points = 3;
            bool done = false;
            Random generator = new Random();
            int headOrTail;
            string playAgain;
            // 0 - Heads
            // 1 - Tails

            string heads, tails;

            Console.WriteLine("Hello user, welcome to nates casino toin coss.");
            while (!done)
            {
                

                Console.Write("Would you like to pick heads or tails: ");
                userChoice = Console.ReadLine().ToLower();
                
                headOrTail = generator.Next(2);


                if (headOrTail == 0)
                {
                    Console.WriteLine("The computer flipped a heads");
                    if (userChoice == "heads" || userChoice == "h")
                    {
                        Console.WriteLine("Good guess, you get one point");
                        points += 1;
                    }
                    else
                    {
                        Console.WriteLine("You did not pick heads, one point will be taken away");
                        points -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("The computer flipped a tails");
                    if (userChoice == "tails" || userChoice == "t")
                    {
                        Console.WriteLine("Good guess, you get one point");
                        points += 1;
                    }
                    else
                    {
                        Console.WriteLine("You did not guess tails, one point will be taken away");
                        points -= 1;
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Do you want to play again? You currently have " + points + " points");
               
                   
                if (points == 0)
                {
                    Console.WriteLine("You have 0 points left, you lose. Come back later");
                    done = true;
                }
                else
                {
                    Console.WriteLine("would you like to play again");
                    if (playAgain == "no" || playAgain == "n")
                    {
                        done = true;
                    }
                }
                
              
                    
            }










        }
    }
}
