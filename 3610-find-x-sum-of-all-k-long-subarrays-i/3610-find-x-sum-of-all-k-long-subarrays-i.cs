public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        int[] result = new int[nums.Length - k + 1];
        int n = nums.Length;
        var freq = new Dictionary<int,int>();
        for(int i = 0 ; i < k ; i++)
        {
            if(!freq.ContainsKey(nums[i]))
                    freq[nums[i]] = 0;
                freq[nums[i]]++;
        }
        result[0] = CalculateXsum(freq , x);
        for(int i = 1 ; i < n - k + 1 ; i++)
        {
            freq[nums[i-1]]--;
            if(freq[nums[i-1]] == 0)
                freq.Remove(nums[i-1]);

            if(!freq.ContainsKey(nums[i + k-1]))
                freq[nums[i + k-1]] = 0;
            freq[nums[i + k-1]]++;

            result[i] = CalculateXsum(freq , x);
        }
        return result;
    }
    public int CalculateXsum(Dictionary<int,int> currFreq , int x)
    {
        int xSum = 0;
        var topX = currFreq.OrderByDescending(pair => pair.Value)
                    .ThenByDescending(pair => pair.Key)
                    .Take(x)
                    .ToList();
        foreach(var item in topX)
        {
            xSum += item.Key * item.Value;
        }
        return xSum;
    }
}