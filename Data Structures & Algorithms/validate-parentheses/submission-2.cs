public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        
        foreach (char s2 in s)
        {
            if (s2 == '[' ||  s2 == '{' ||  s2 == '(')
            {
                stack.Push(s2);
            } else if (s2 == ']'){
                if (stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                    continue;
                }
                return false;
            }
            else if (s2 == '}')
            {
                if (stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                    continue;
                }
                return false;
            }
            else if (s2 == ')')
            {
                if (stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                    continue;
                }
                return false;
            }

        }
        return stack.Count == 0;
    }
}
