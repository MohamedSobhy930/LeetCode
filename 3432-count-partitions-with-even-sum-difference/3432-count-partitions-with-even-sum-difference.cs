public class Solution {
    public int CountPartitions(int[] nums)
{
    int totalSum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        totalSum += nums[i];
    }
    if(totalSum % 2 != 0)
        return 0;

    return nums.Length -1;
}
}