namespace CoreLib;

public class FindNegateArrClass
{
    public static Func<int[], int[]> FindNegate = arr =>
    {
        int lengthNeg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                lengthNeg++;
            }
        }
        
        int[] negArr = new int[lengthNeg];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                negArr[index] = arr[i];
                index++;
            }
        }
        return negArr;
    };
}