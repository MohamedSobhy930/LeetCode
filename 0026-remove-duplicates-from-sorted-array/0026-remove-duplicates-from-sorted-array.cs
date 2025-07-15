public class Solution {
    public int RemoveDuplicates(int[] nums)
{
    int k = nums.Length, index = 0, i = 1;
    while(i < nums.Length)
    {
        if(nums[i] == nums[index])
        {
            k--;
        }
        else
        {
            nums[++index] = nums[i];
        }
        i++;
    }
    return k;
}
}