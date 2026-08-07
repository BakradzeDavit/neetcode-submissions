
public class Solution
{

    public string Encode(IList<string> strs)
    {
        string encodedString = "";
        foreach (string str in strs)
        {
            encodedString += str.Length + "#" + str;
        }
        return encodedString;
    }

    public List<string> Decode(string s)
    {
        List<string> decodedStrings = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int length = 0;
            StringBuilder decodedString = new StringBuilder();
            bool isLength = true;
            while (isLength)
            {
                if (s[i] == '#')
                {
                    isLength = false;
                }
                else
                {
                    length = length * 10 + (s[i] - '0');
                }
                i++;
            }
            while (length > 0 && i < s.Length && !isLength)
            {
                decodedString.Append(s[i]);
                length--;
                i++;
            }
            decodedStrings.Add(decodedString.ToString());
        }
        return decodedStrings;
    }
}
