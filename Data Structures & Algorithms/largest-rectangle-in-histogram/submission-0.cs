
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int[] left = new int[heights.Length];
        int[] right = new int[heights.Length];
        int maxArea = 0;
        Stack<int> stack = new Stack<int>();
        for (int i = heights.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }
            if (stack.Count > 0)
            {
                right[i] = stack.Peek();
            }
            else
            {
                right[i] = heights.Length;
            }
            stack.Push(i);
        }
        Stack<int> stack1 = new Stack<int>();

        for (int i = 0; i < heights.Length; i++)
        {
            while (stack1.Count > 0 && heights[stack1.Peek()] >= heights[i])
            {
                stack1.Pop();
            }

            if (stack1.Count > 0)
            {
                left[i] = stack1.Peek();
            }
            else
            {
                left[i] = -1;
            }

            stack1.Push(i);
        }

        for (int i = 0; i < heights.Length; i++)
        {
            int width = right[i] - left[i] - 1;
            int area = heights[i] * width;

            if (area > maxArea)
            {
                maxArea = area;
            }
        }
        return maxArea;

    }
}
