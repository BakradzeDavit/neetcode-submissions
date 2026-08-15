public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();

                int result = 0;

                if (token == "*")
                {
                    result = num2 * num1;
                }
                else if (token == "/")
                {
                    result = num2 / num1;
                }
                else if (token == "+")
                {
                    result = num2 + num1;
                }
                else
                {
                    result = num2 - num1;
                }

                stack.Push(result);
            }
        }

        return stack.Peek();
    }
}