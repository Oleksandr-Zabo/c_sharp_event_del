namespace CoreLib;

public class UnicNegatClass
{
    public static Func<int[], int> UnicNegative = nums => {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                bool ToAddCount = true;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i != j)
                    {
                        ToAddCount = false;
                        break;
                    }
                }

                if (ToAddCount)
                {
                    count++;
                }
            }
        }
        return count;
    };  
}