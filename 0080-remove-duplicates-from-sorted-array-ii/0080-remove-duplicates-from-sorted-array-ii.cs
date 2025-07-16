public class Solution {
    public int RemoveDuplicates(int[] nums) {
    int k = 0;
    for(int i = 0; i < nums.Length ; i++)
    {
        if(k < 2 || nums[k-2] != nums[i])
        {
            nums[k] = nums[i];
            k++;
        }
    }
    return k;
}
}