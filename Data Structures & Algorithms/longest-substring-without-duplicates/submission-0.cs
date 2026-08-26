public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> list = new HashSet<char>();
        int left = 0; // Input: s = "zxyzwyz"
        int right = 0;
        int maxcount = 0;
        for (; right < s.Length; right++)
        {
            char c = s[right];
            while (list.Contains(c))
            {

                list.Remove(s[left]);
                left++;
            }
            list.Add(c);
            maxcount = Math.Max(maxcount, list.Count);
        }
        return maxcount;
    }
}
