public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        long minNum = int.MaxValue;
        long maxNum = int.MinValue;
        int n = nums.Length;
        for(int i = 0 ; i < n ; i++)
        {
            minNum = Math.Min(minNum , nums[i]);
            maxNum = Math.Max(maxNum , nums[i]);
        }

        return (maxNum - minNum) * k;
    }
}