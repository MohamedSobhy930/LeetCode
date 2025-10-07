public class Solution {
    public void NextPermutation(int[] nums) {
        int p = -1;
        for(int i = nums.Length-2 ; i >= 0 ; i--)
        {
            if(nums[i] < nums[i+1])
            {
                p = i;
                break;
            }
        }
        if(p == -1)
        {
            Array.Reverse(nums);
            return;
        } 
        int j = nums.Length -1;
        while(true)
        {
            if(nums[p] < nums[j])
            {
                int temp = nums[p];
                nums[p] = nums[j];
                nums[j] = temp;
                break;
            }
            j--;
        }
        Array.Reverse(nums,p+1,nums.Length - (p+1));
    }
}