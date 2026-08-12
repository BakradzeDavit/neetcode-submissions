public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> result = new HashSet<int>();
        int MaximumLength = 0;

        int Length = 0;

        foreach (int num in nums)
        {
            result.Add(num);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            Length = 0;
            int current = nums[i];
            if (!result.Contains(current - 1))
            {
                Length = 1;

                while (result.Contains(current + 1))
                {
                    Length++;
                    current++;
                }

                MaximumLength = Math.Max(MaximumLength, Length);
            }
        }
        return MaximumLength;
    }
}
