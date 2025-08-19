public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if ((i != j) && (nums[i] + nums[j] == target))
            {
                return new int[] { i , j};
            }
        }
    }
    return nums;
    }
}