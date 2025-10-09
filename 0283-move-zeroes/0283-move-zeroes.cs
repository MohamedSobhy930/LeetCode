public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length == 1) return;
        int left = 0 ; 
        int right = 0 ;
        while(right < nums.Length)
        {
            if(nums[right] != 0)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
            }
            right++;
        }
    }
}