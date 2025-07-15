public class Solution {
    public int RemoveDuplicates(int[] nums)
{
    int k = nums.Length, index = 0;
    int[] expectedNums = new int[nums.Length];
    expectedNums[0] = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        if (expectedNums[index] == nums[i])
        {
            k--;
        }
        else
        {
            expectedNums[++index] = nums[i];
        }
    }
    for(int i = 0; i < nums.Length; i++)
    {
        nums[i] = expectedNums[i];
    }
    return k;
}
}