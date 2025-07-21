public class Solution {
    public int MaxProfit(int[] prices)
{
    
    int maxprofit=0;
    int buy = prices[0];
    
    for (int i = 1; i < prices.Length; i++)
    {
        int sell = prices[i];
        if (buy < sell)
        {
            if (maxprofit < sell - buy)
                maxprofit = sell - buy;
        }
        else if (buy > sell)
        {
            buy = sell;    
        }
    }
    return maxprofit;
}
}
