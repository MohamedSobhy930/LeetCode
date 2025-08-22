public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length <= 1) return nums.Length;
        Array.Sort(nums);
        int longestSequence = 1;
        int sequence = 1;
        for(int i = 0; i < nums.Length - 1 ; i++)
        {
            if(nums[i] == nums[i+1]) continue;
            else if(nums[i] + 1== nums[i+1] )
                sequence++;
            else 
            {
                longestSequence = Math.Max(longestSequence , sequence);
                sequence = 1;
            }
        }
        return Math.Max(longestSequence , sequence);
    }
}