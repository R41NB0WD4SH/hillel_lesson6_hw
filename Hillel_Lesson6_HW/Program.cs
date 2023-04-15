using System;
using System.Collections;
using System.Collections.Generic;

namespace Hillel_Lesson6_HW
{
    class Programm
    {
        static void Main(string[] args)
        {

            const int numbersCount = 101;


            List<Number> allNumbers = new List<Number>();

            for (int i = 0; i < numbersCount; i++)
            {
                allNumbers.Add(new Number(i));
            }


            const int firstPlayday = 10;
            const int secondPlayday = 50;
            const int thirdPlayday = 100;

            const int quantityOfWinNumbers = 10;

            int[][] firstPlaydayResutls = new int[firstPlayday][];
            int[][] secondPlaydayResutls = new int[secondPlayday][];
            int[][] thirdPlaydayResutls = new int[thirdPlayday][];


            #region -=- FIRST_DAY_RESULTS -=-=

            Console.WriteLine("FIRST DAY");
            
            Lottery.GenerateDayResults(firstPlaydayResutls, quantityOfWinNumbers, allNumbers);
            
            Lottery.ShowDayResults(firstPlaydayResutls);
            
            
            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            StatOperations.NeverAppeared(allNumbers);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            StatOperations.MostAppeared(allNumbers, 10);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            #region -=- SECOND_DAY_RESULTS -=-

            Console.WriteLine("SECOND DAY");
            
            Lottery.GenerateDayResults(secondPlaydayResutls, quantityOfWinNumbers, allNumbers);
            
            Lottery.ShowDayResults(secondPlaydayResutls);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            StatOperations.NeverAppeared(allNumbers);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            StatOperations.MostAppeared(allNumbers, 10);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            #endregion

            
            #region -=- THIRD_DAY_RESULTS -=-

            Console.WriteLine("THIRD DAY");
            
            Lottery.GenerateDayResults(thirdPlaydayResutls, quantityOfWinNumbers, allNumbers);
            
            Lottery.ShowDayResults(thirdPlaydayResutls);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            #endregion
            
            StatOperations.NeverAppeared(allNumbers);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
            
            StatOperations.MostAppeared(allNumbers, 10);

            Console.ReadKey();
        }
    }
}