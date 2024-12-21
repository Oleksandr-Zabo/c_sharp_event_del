namespace CoreLib;

public class NumPositiveClass
{
    public static Func<int[], int> CountPositiveNumbers = delegate (int[] numbers)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                count++;
            }
        }
        return count;
    };
}