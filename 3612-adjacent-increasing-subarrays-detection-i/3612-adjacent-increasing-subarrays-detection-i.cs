public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        int n = nums.Count ;
        bool isIncreasing(int start)
        {
            for(int j = start+1 ; j < k + start ; j++)
            {
                if(nums[j] <= nums[j-1])
                    return false;
            }
            return true;
        }
        for(int i = 0 ; i <= n - 2*k ; i++)
        {
           if(isIncreasing(i) && isIncreasing(i+k))
                return true;
        }
        return false;
    }
}