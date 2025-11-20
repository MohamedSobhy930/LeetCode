public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int n = nums.Length;
        var numsCopy = (int[])nums.Clone();
        Array.Sort(numsCopy);
        var map = new Dictionary<int,int>();
        for(int i = 0 ; i < n ; i++)
        {
            if(!map.ContainsKey(numsCopy[i]))
                map[numsCopy[i]] = i;
        }
        int[] result = new int[n];
        for(int i = 0 ; i < n ; i++)
        {
            if(map.ContainsKey(nums[i]))
                result[i] = map[nums[i]];
        }
        return result;
    }
}