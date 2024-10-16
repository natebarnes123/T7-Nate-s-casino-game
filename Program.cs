using System.Xml;

namespace T7_Nate_s_casino_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice, playAgain;
            int points = 3;
            bool done = false;
            Random generator = new Random();
            int headOrTail;

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
                }
                else
                {
                    Console.WriteLine("The computer flipped a tails");
                }
               

                Console.WriteLine("Do you want to play again?");

                playAgain = Console.ReadLine().ToLower();
                if (playAgain == "n" || playAgain == "no") 
                    done = true;
            }










        }
    }
}
