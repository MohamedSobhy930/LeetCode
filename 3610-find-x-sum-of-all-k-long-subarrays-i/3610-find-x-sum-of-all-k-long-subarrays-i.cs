public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        int[] result = new int[nums.Length - k + 1];
        int n = nums.Length;
        for(int i = 0 ; i < n - k + 1 ; i++)
        {
            var freq = new Dictionary<int,int>();
            int j = i ; 
            while(j < k + i)
            {
                if(!freq.ContainsKey(nums[j]))
                    freq[nums[j]] = 0;
                freq[nums[j]]++;
                j++;
            }
            int xSum = 0;
            var topX = freq.OrderByDescending(pair => pair.Value)
                        .ThenByDescending(pair => pair.Key)
                        .Take(x)
                        .ToList();
            foreach(var item in topX)
            {
                xSum += item.Key * item.Value;
            }
            result[i] = xSum;
        }
        return result;
    }
}