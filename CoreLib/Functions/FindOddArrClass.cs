namespace CoreLib;

public class FindOddArrClass
{
    public static Func<int[], int[]> findOddNumbers = nums =>
    {
        var result = new int[nums.Length];
        int index = 0;

        foreach (var num in nums)
        {
            if (num % 2 != 0)
            {
                result[index++] = num;
            }
        }

        Array.Resize(ref result, index); // Resize the array to remove the empty elements
        return result;
    };

}