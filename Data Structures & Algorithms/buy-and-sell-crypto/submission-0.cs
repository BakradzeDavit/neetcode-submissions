public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int buy = 0; // 1
        
        int maxprofit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
           
            if (prices[i] <= prices[buy])
            {
                buy = i;
            }
            else if (maxprofit < prices[i] - prices[buy])
            {
                maxprofit = prices[i] - prices[buy];
            }
            
           
        }

        return maxprofit;
    } // Input: prices = [10,1,5,6,7,1]
}
