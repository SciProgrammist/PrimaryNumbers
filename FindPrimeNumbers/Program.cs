using System;

namespace FindPrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Ahead = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tGive me a number between 2 and sqrt(n), I will refer to it as n.");
                Console.Write("\n\t What is your n? ");
                int n = int.Parse(Console.ReadLine());
                int test = 2;
                int factors = 0;
                while (test * test <= n)
                {
                    
                    if (n%test == 0)
                    {
                        factors++;
                        
                        Console.WriteLine("\n\tIt isn't a primary number");

                    }
                    test++;
                }
                if (factors > 0) ;
                else Console.WriteLine("It is a primary number!");
                Console.ReadKey();
                Console.Write("Would you like to try again? [y/n] ");
                string xyz = Console.ReadLine().ToLower();
                Ahead = xyz == "y" ? true : false;
            } while (Ahead == true);

        }
    }
}
