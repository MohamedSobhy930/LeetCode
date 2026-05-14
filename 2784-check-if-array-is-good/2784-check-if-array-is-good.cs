public class Solution {
    public bool IsGood(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length ;
        if(nums[n - 1] + 1 != n) return false;
        for(int i = 0 ; i < n ;i++)
        {
            if(nums[i] != i + 1 && i != n - 1) return false;
            else if(i == n - 1 && nums[i] == i) return true;
        }
        return true;
    }
}
// int[] freq = new int[nums.Length+1];
        // for(int i = 0 ; i < nums.Length ; i++)
        // {
        //     freq[nums[i]] += 1;
        // }
        // for(int i = 1 ; i < freq.Length ; i++)
        // {
        //     if(freq[i] > 1 && i != freq.Length - 1) return false;
        // }
        // if(freq[freq.Length-1] != 2) return false;
        // return true;