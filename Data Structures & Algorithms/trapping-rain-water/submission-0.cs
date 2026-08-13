public class Solution
{
    public int Trap(int[] height)
    {
        int result = 0;
        int[] leftMax = new int[height.Length];
        int[] rightMax = new int[height.Length];
        for (int i = 0; i < height.Length; i++)
        {
            leftMax[i] = Math.Max(i > 0 ? leftMax[i - 1] : 0, height[i]);
        }

        for(int i = height.Length - 1; i >= 0; i--)
        {
            rightMax[i] = Math.Max(i == height.Length - 1 ? 0 : rightMax[i + 1], height[i]);
        }
        for (int i = 0; i < height.Length   ; i++)
        {
            result += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }

        return result;
    }
}
