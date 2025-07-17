public class Solution {
    public int MajorityElement(int[] nums) {
        if(nums.Length <= 2) return nums[0];
       Dictionary<int,int> freq = new Dictionary<int,int>();
       for(int i = 0 ; i < nums.Length ;i++)
       {
        if(!freq.ContainsKey(nums[i]))
            freq[nums[i]] = 0;
        freq[nums[i]]++;
       } 
       int k = nums.Length / 2;
       foreach(var pair in freq)
       {
        if(pair.Value > k)
            return pair.Key;
       }
       return -1;
    }
}