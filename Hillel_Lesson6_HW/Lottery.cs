using System.Runtime.InteropServices;

namespace Hillel_Lesson6_HW;

public static class Lottery
{
    public static IEnumerable<int> Emit(int count, int max, Dictionary<int, int> allNumbers)
    {
        Random rnd = new Random();

        int[] winNumbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            int winNumber = rnd.Next(1, max);

            if (!winNumbers.Contains(winNumber))
            {
                winNumbers[i] = winNumber;
                allNumbers[winNumber]++;
            }
            else
            {
                i--;
            }
        }

        return winNumbers;
    }


}