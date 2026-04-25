public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        int i = 0;
        while(k > 0 && i < nums.Length)
        {
            if(nums[i] < 0)
            {
                nums[i] *= -1;
                k--;
            }
            i++;
        }
        if(k == 0 || (k % 2 == 0))
        {
            return SumArr(ref nums);
        }
        Array.Sort(nums);
        nums[0] *= -1;
        return SumArr(ref nums);
    }
    private int SumArr(ref int[] nums)
    {
        int sum = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            sum += nums[i];
        }
        return sum;
    }
}