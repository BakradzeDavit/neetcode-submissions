public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] strChars = str.ToCharArray();
            Array.Sort(strChars);
            string sortedStr = new string(strChars);
            if (anagramGroups.ContainsKey(sortedStr))
            {
                anagramGroups[sortedStr].Add(str);
            }
            else
            {
                anagramGroups[sortedStr] = new List<string> { str };
            }
        }

        return new List<List<string>>(anagramGroups.Values);
    }
}
