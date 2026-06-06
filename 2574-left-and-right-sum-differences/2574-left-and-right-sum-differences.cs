public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int leftSum = 0;
        int rightSum = 0;
        int n = nums.Length;
        for(int i = 0; i < n ; i++)
        {
            rightSum += nums[i];
        }
        int[] result = new int[n];
        for(int i = 0 ; i < n ; i++)
        {
            result[i] = Math.Abs(leftSum - ( rightSum - nums[i]));
            rightSum -= nums[i];
            leftSum += nums[i];
        }
        return result;
    }
}