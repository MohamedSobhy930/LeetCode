public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        
        int[] prefix = new int[n];
        prefix[0] = 1;
        for(int i = 1 ; i < n ; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
        }
        int suffix = 1;
        for(int i = n-1 ; i >= 0 ; i--)
        {
            res[i] = prefix[i] * suffix;
            suffix *= nums[i];
        }
        return res;
    }
}