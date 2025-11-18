public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int n = nums.Length ;
        int[] seen = new int[n];
        for(int i = 0 ; i < n ; i++)
        {
            if(seen[nums[i]-1] == 0)
                seen[nums[i] - 1] = 0;
            seen[nums[i] - 1]++;
        }
        int[] result = new int[2];
        for(int i = 0 ; i < n ; i++)
        {
            if(seen[i] == 2)
                result[0] = i+1;
            if(seen[i] == 0)
                result[1] = i+1;
        }
        return result;
    }
}