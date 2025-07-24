public class Solution {
    public int Jump(int[] nums) {
        if(nums.Length == 1) return 0;
        int farthest = 0, steps = 0, end = 0;
        for(int i = 0; i < nums.Length-1 ; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);

            if(i == end)
            {
                end = farthest;
                steps++;
            }
        }
        return steps;
    }
}