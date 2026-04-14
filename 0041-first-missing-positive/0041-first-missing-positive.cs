public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> map = new HashSet<int>();
        long maxNum = int.MinValue;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            map.Add(nums[i]);
            if(nums[i] > maxNum)
                maxNum = nums[i];
        }
        if(maxNum < 1) return 1;
        for(int i = 1 ; i <= maxNum + 1 ; i++)
        {
            if(!map.Contains(i))
                return i;
        }
        return 1;
    }
}