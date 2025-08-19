public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long res = 0 ; 
        long zeroCount = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(nums[i] == 0)
            {
                zeroCount++;
                res += zeroCount;
            }
            else
                zeroCount = 0;
        }
        return res;
    }
}