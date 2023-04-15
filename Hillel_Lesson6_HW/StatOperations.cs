using System.ComponentModel.Design;

namespace Hillel_Lesson6_HW;

public static class StatOperations
{
    public static void NeverAppeared(List<Number> allNumbers)
    {
        Console.WriteLine("Never Appeared Numbers:");
        Console.WriteLine();

        for (int i = 0; i < allNumbers.Count; i++)
        {
            if (allNumbers[i].Frequency == 0)
            {
                Console.Write("{0} ", allNumbers[i].Index);
            }
        }

    }

    public static void MostAppeared(List<Number> allNumbers, int top)
    {
        Console.WriteLine("Most Appeared Numbers:");
        Console.WriteLine();
        
        Number[] topNumbers = new Number[top];

        topNumbers = allNumbers.OrderByDescending(number => number.Frequency).ToArray();

        for (int i = 0; i < top; i++)
        {
            Console.WriteLine("Index:{0} Frequency:{1}", topNumbers[i].Index, topNumbers[i].Frequency);
        }
    }
}