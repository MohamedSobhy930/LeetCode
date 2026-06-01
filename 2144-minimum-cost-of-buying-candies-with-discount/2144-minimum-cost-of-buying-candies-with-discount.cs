public class Solution {
    public int MinimumCost(int[] cost) {
        if(cost.Length <= 2) return cost.Sum();
        int minCost = 0;
        Array.Sort(cost);
        for(int i = cost.Length - 1, j = 0; i >= 0; i-- , j++)
        {
            if(j > 0 && j % 2 == 0)
            {
                j = -1;
                continue;
            }
            minCost += cost[i];
        }   
        return minCost;
    }
}