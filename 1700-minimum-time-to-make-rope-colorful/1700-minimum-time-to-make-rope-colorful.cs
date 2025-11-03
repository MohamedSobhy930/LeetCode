public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int totalTime = 0; 
        int i = 0;
        int n = colors.Length;
        while(i < n)
        {
            int j = i+1;
            int totalCost = neededTime[i];
            int maxCost = neededTime[i];
            while(j < n && colors[i] == colors[j])
            {
                totalCost += neededTime[j];
                maxCost = Math.Max(maxCost , neededTime[j]);
                j++;
            }
            if(j > i + 1 )
                totalTime += (totalCost - maxCost);
            i = j;
        }
        return totalTime;
    }
}