public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int result = nums.Length, index = 0;
        int[] expectedNums = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == val)
            {
                result--;
            }
            else
            {
                expectedNums[index++] = nums[i];
            }
        }
        for(int i = 0 ; i < nums.Length; i++)
        {
            nums[i] = expectedNums[i];
        }
        return result;
    }
}