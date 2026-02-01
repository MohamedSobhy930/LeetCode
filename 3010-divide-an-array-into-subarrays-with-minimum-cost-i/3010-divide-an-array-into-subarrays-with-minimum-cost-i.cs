public class Solution {
    public int MinimumCost(int[] nums) {
        int n = nums.Length ;
        if(n == 3) return nums.Sum();
        int result = nums[0] ;
        int smallest1 = int.MaxValue; 
        int smallest2 = int.MaxValue;
        for(int i = 1 ; i < n ; i++)
        {
            if(nums[i] < smallest1 )
            {
                smallest2 = smallest1;
                smallest1 = nums[i];
            }
            else if(nums[i] < smallest2)
            {
                smallest2 = nums[i];
            }
        }
        result += smallest1 + smallest2;
        return result;
    }
}