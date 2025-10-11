public class Solution {
    public int FindDuplicate(int[] nums) {
        int n = nums.Length;
        int[] unique = new int[n+1];
        for(int i = 0 ; i < n ; i++)
        {
            if(unique[nums[i]] == 0)
                unique[nums[i]] = 1;
            else 
                return nums[i];
        }
        return -1;
    }
}