public class Solution {
    public int MajorityElement(int[] nums) {
       Array.Sort(nums);
       int n = nums.Length;
    if(nums[0] == nums[n/2])
        return nums[0];
    else 
        return nums[n/2];
    }
}