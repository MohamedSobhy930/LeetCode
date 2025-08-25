public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
       var distance = new Dictionary<int,int>();
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(distance.ContainsKey(nums[i]))
            {
                if(i - distance[nums[i]] <= k)
                    return true;
            }
            distance[nums[i]] = i;
        }
        return false;
    }
}