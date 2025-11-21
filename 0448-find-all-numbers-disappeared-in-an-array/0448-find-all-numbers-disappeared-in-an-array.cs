public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> result = new List<int>();
        var map = new HashSet<int>();
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(!map.Contains(nums[i]))
                map.Add(nums[i]);
        }
        for(int i = 1 ; i <= nums.Length ; i++)
        {
            if(!map.Contains(i))
                result.Add(i);
        }
        return result;
    }
}