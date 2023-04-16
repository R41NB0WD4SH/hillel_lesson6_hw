using System;
using System.Collections;
using System.Collections.Generic;

namespace Hillel_Lesson6_HW
{
    class Programm
    {
        static void Main(string[] args)
        {

            const int numbersCount = 37;
            
            const int tenGamesCheck = 9;
            const int fiftyGamesCheck = 49;
            const int oneHundredGamesCheck = 99;

            const int gamesCount = 100;



            Dictionary<int, int> allNumbers = new Dictionary<int, int>(36);


            for (int i = 1; i < numbersCount; i++)
            {
                allNumbers.Add(i, 0);
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FIRST PLAYDAY");
            Console.WriteLine();
            Console.WriteLine();
            
            
            for (int i = 0; i < gamesCount; i++)
            {
                int[] winNumbers;

                winNumbers = Lottery.Emit(8, 37, allNumbers).ToArray();

                Console.Write("{0} Win Numbers: ", i + 1);

                for (int j = 0; j < winNumbers.Length; j++)
                {
                    Console.Write("{0} ", winNumbers[j]);
                }

                if (i == tenGamesCheck)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} GAMES STAT", tenGamesCheck + 1);
                    StatOperations.NeverAppeared(allNumbers);
                    Console.WriteLine();
                    Console.WriteLine();
                    StatOperations.MostAppeared(allNumbers);
                    Console.WriteLine();
                }
                
                if (i == fiftyGamesCheck)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} GAMES STAT", fiftyGamesCheck + 1);
                    StatOperations.NeverAppeared(allNumbers);
                    Console.WriteLine();
                    Console.WriteLine();
                    StatOperations.MostAppeared(allNumbers);
                    Console.WriteLine();
                }
                
                if (i == oneHundredGamesCheck)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} GAMES STAT", oneHundredGamesCheck + 1);
                    StatOperations.NeverAppeared(allNumbers);
                    Console.WriteLine();
                    Console.WriteLine();
                    StatOperations.MostAppeared(allNumbers);
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
            
            




            Console.ReadKey();


 

        }
    }
}