using System;

namespace AdviseNumber
{
    public static class Advise
    {
        public static void ShowTitle()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t Advise a number");
            Console.WriteLine();
        }
        public static void AdviseRandomNumber()
        {
            bool ok = false;
            int i = 0;
            int guess;
            int random;
            Random number = new Random();
            random = number.Next(0, 100) + 1;

            do
            {
                i++;
                
                Console.Write($"{i}. try: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == random)
                {
                    ok = true;
                }
                else if (guess < random)
                {
                    Console.WriteLine($"\t\tThe number is X > {guess}");
                }
                else if(guess > random)
                {
                    Console.WriteLine($"\t\tThe number is X < {guess}");
                }

            } while (ok == false);

            ShowTrys(i);
        }

        private static void ShowTrys(int attempt)
        {
            if(attempt > 0 && attempt <= 5)
            {
                Console.WriteLine($"\nGood job! You need {attempt} trys.");
            }
            else if(attempt > 5 && attempt <= 10)
            {
                Console.WriteLine($"\nAlready quite good! You need {attempt} trys.");
            }
            else if (attempt > 10)
            {
                Console.WriteLine($"\nFinally done! You need {attempt} trys.");
            }
        }
    }
}
