namespace Hillel_Lesson6_HW;

public static class Lottery
{
    public static int[] Emit(List<Number> allNumbers, int quantitiyOfWinNumbers)
    {

        int[] winNumbers = new int[0];
        
        Random rnd = new Random();

        for (int i = 0; i < quantitiyOfWinNumbers; i++)
        {
            int winNumber = rnd.Next(1, 101);
            
            Array.Resize(ref winNumbers, winNumbers.Length + 1);
            winNumbers[winNumbers.Length - 1] = winNumber;

            for (int j = 0; j < allNumbers.Count; j++)
            {
                if (allNumbers[j].Index == winNumber)
                {
                    allNumbers[j].Frequency++;
                }
            }
        }


        return winNumbers;
    }


    public static void GenerateDayResults(int[][] dayResults, int quantityOfWinNumbers, List<Number> allNumbers)
    {
        for (int i = 0; i < dayResults.GetLength(0); i++)
        {
            dayResults[i] = Lottery.Emit(allNumbers, quantityOfWinNumbers);
        }
    }

    public static void ShowDayResults(int[][] dayResults)
    {
        for (int i = 0; i < dayResults.GetLength(0); i++)
        {
            for (int j = 0; j < dayResults[i].Length; j++)
            {
                Console.Write("{0} ", dayResults[i][j]);
            }
            Console.WriteLine();
        }        
    }
}