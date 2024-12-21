namespace CoreLib;

public class MultipleOfSevenClass
{
    public static Func<int[], int> CountMultiplesOfSeven = delegate (int[] numbers)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number % 7 == 0)
            {
                count++;
            }
        }
        return count;
    };
}