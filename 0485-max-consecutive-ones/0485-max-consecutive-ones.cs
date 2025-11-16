public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxOnes = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(nums[i] == 0) continue;
            int count = 0 ; 
            int j = i ; 
            while(j < nums.Length && nums[j] == 1) 
            {
                count++;
                j++;
            }
            maxOnes = Math.Max(count , maxOnes);
            i = j;
        }
        return maxOnes;
    }
}