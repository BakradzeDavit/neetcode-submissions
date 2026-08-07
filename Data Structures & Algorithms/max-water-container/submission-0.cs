public class Solution
{
    public int MaxArea(int[] heights)
    {

        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        // (right - left) × min(height[left], height[right])
        while (left < right)
        {
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);
            int currentArea = width * height;
            if (currentArea > maxArea) {
                maxArea = currentArea;
            }
            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
// Height: [1,8,6,2,5]