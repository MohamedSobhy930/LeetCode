public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] result = new int[nums.Length];
        for(int i = 0 ; i < nums.Length ; i++)
        {
            int smallerNums = 0;
            for(int j = 0 ; j < nums.Length ; j++)
            {
                if(i == j) continue;
                if(nums[j] < nums[i])
                    smallerNums++;
            }
            result[i] = smallerNums;
        }
        return result;
    }
}