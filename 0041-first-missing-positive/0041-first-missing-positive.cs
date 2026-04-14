public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> map = new HashSet<int>();
        int maxNum = int.MinValue;
        int n = nums.Length;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(nums[i] > 0 && nums[i] <= n)
            {
                map.Add(nums[i]);
                if(nums[i] > maxNum)
                    maxNum = nums[i];
            }
        }
        if(maxNum < 1) return 1;
        for(int i = 1 ; i <= n ; i++)
        {
            if(!map.Contains(i))
                return i;
        }
        return n+1;
    }
}