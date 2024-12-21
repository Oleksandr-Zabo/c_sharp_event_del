namespace CoreLib;

public class FindMaxArrClass
{
    public static Func<int[], int> FindMax = arr =>
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    };
}