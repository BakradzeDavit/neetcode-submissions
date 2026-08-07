public class Solution {
    public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    Dictionary<char, int> S = new();
    Dictionary<char, int> T = new();

    for (int i = 0; i < s.Length; i++)
    {
        if (S.ContainsKey(s[i]))
            S[s[i]]++;
        else
            S[s[i]] = 1;

        if (T.ContainsKey(t[i]))
            T[t[i]]++;
        else
            T[t[i]] = 1;
    }

    return S.All(pair => T.ContainsKey(pair.Key) && T[pair.Key] == pair.Value);
}
}
