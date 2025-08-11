public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int sum = 0 , minLength = int.MaxValue; 
        int left = 0 , right = 0;
        while(right < nums.Length)
        {
            sum += nums[right];
            while(sum >= target)
            {
                minLength = Math.Min(minLength , right - left + 1);
                sum -= nums[left++];
            }
            right++;
        }
        return minLength == int.MaxValue ? 0 : minLength;
    }
}