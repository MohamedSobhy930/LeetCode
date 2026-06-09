public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        Array.Sort(nums);
        long result = nums[nums.Length - 1] - nums[0];
        return result * k;
    }
}