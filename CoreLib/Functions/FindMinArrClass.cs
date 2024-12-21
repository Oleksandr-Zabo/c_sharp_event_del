namespace CoreLib;

public class FindMinArrClass
{
    public static Func<int[], int> FindMin = arr =>
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    };
}