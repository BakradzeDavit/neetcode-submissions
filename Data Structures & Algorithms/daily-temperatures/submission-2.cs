public class Solution
{

    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> stack = new Stack<int>(); // 30
        int[] result = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {

            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                result[stack.Peek()] = i - stack.Pop();

            }

            stack.Push(i);
           
        }
        return result;
    }
} // Input: temperatures = [30,38,30,36,35,40,28]
