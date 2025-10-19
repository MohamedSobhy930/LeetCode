public class Solution {
    public int FindPairs(int[] nums, int k) {
        Array.Sort(nums);
        int result = 0; 
        int left = 0; 
        int right = 1;
        while(left < nums.Length && right < nums.Length)
        {
            if(left == right) 
            {
                right++;
                continue;
            }
            int num =nums[right] - nums[left];
            if(num > k)
                left++;
            else if(num < k)
                right++;
            else
            {
                result++;
                while(left +1 < nums.Length && nums[left] == nums[left+1]) 
                {
                    left++;
                }
            left++;
            }
        }
        return result;
    }
}