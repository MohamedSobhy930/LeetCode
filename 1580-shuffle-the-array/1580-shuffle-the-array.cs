public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] ans = new int[n * 2];
        int firstHalf = 0; 
        int secondHalf = n;
        for(int i = 0 ; i < n * 2; i++)
        {
            ans[i] = i % 2 == 0 ? nums[firstHalf++] : nums[secondHalf++];
        }
        return ans;
    }
}