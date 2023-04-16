using System.ComponentModel.Design;

namespace Hillel_Lesson6_HW;

public static class StatOperations
{
    public static void NeverAppeared(Dictionary<int, int> allNumbers)
    {
        Console.WriteLine("Never Appeared Numbers:");
        Console.WriteLine();

        HashSet<int> neverAppeared = new HashSet<int>();

        foreach (KeyValuePair<int, int> number in allNumbers)
        {
            if (number.Value == 0)
            {
                neverAppeared.Add(number.Key);
                Console.Write("{0} ", number.Key);
            }
        }

    }

    public static void MostAppeared(Dictionary<int, int> allNumbers)
    {
        Console.WriteLine("Most Appeared Numbers:");
        Console.WriteLine();

        var sortedAllNumbers = allNumbers.OrderByDescending(number => number.Value);
        

        foreach (KeyValuePair<int, int> number in sortedAllNumbers)
        {
            if (number.Value != 0)
            {
                Console.Write("{0} - {1} times, ", number.Key, number.Value);
            }
            
        }
    }
}