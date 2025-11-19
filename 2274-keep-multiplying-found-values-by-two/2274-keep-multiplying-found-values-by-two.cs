public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length ; i++)
        {
            if(nums[i] == original)
                original *= 2;
        }
        return original;
    }
}