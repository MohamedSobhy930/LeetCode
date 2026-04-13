public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        if(nums[start] == target) return 0;
        int res = int.MaxValue ;
        for(int i = start ; i < nums.Length ; i++)
        {
            if(nums[i] == target)
            {
                res = i - start;
                break;
            }
        }
        for(int i = start ; i >= 0 ; i--)
        {
            if(nums[i] == target)
            {
                res = Math.Min(res , start - i);
                break;
            }
        }
        return res;
    }
}