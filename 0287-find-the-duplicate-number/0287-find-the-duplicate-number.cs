public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int,int> unique = new Dictionary<int,int>();
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(!unique.ContainsKey(nums[i]))
            {
                unique[nums[i]] = 1;
            }
            else 
            {
                return nums[i];
            }
        }
        return -1;
    }
}