using System;
using System.Threading.Tasks;
namespace JesseGameBuild
{   
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\tCoin Toss!");


            Console.WriteLine("Please type in your name\n");
            string name = Console.ReadLine().ToUpper();

            Console.WriteLine("Got it!");

            Console.WriteLine("Please type in your guess(H for Heads or T for tails)");
            string guess = Console.ReadLine().ToUpper();


            if ((guess == "H") || (guess == "T"))
            {
                Console.WriteLine("You guessed\t" + guess);
                Console.WriteLine("The Coin is in the air!\n");
            }
            else
            {
                Console.WriteLine("I'm sorry could you repeat that\n");
                guess = Console.ReadLine().ToUpper();
                Console.WriteLine("You guessed...." + guess);
				Console.WriteLine("The Coin is in the air!");

			}

            System.Threading.Thread.Sleep(3000);
           
            var random = new Random();
            var flip = random.Next(0, 10);

            // H is 0 - 4 and T is 5 - 9.

            if (flip <= 4 && guess == "H")
            {
                Console.WriteLine("HEADS! " + name + " WINS!");
                Console.ReadKey();
            }
            else if (flip <= 4 && guess == "T")
            {
                Console.WriteLine("HEADS! Better Luck Next Time, " + name);
                Console.ReadKey();
            }

            else if (flip > 4 && guess == "H")
            {
                Console.WriteLine("TAILS! Better Luck Next Time, " + name);
                Console.ReadKey();

            }
            else if (flip > 4 && guess == "T")
            {
                Console.WriteLine("TAILS! " + name + " Wins!");
                Console.ReadKey();
            }
        }
    }
}
