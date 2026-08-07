public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }
        int[] result = new int[k];
        var sorted = frequencyMap.OrderByDescending(pair => pair.Value);

        int index = 0;

        foreach (var pair in sorted)
        {
            if (index == k)
                break;

            result[index] = pair.Key;
            index++;
        }
        return result;
    }
}
