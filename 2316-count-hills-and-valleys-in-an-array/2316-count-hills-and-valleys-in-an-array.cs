public class Solution {
    public int CountHillValley(int[] nums) {
      int hillsAndValleys = 0;
      int i = 1;
        while(i < nums.Length - 1)
        {
             int left = i - 1;
            while (left >= 0 && nums[left] == nums[i]) {
                left--;
            }
            int right = i + 1;
            while (right < nums.Length && nums[right] == nums[i]) {
                right++;
            }
            if(left >= 0 && right < nums.Length)
            { 
            if(nums[left] < nums[i] && nums[i] > nums[right])
                hillsAndValleys++;
            else if(nums[left] > nums[i] && nums[i] < nums[right])
                hillsAndValleys++;
            }
            i = right;
        }
        return hillsAndValleys;
    }
}