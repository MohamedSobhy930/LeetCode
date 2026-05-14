public class Solution {
    public bool IsGood(int[] nums) {
        int n = nums.Length ;
        int maxNum = n - 1;
        int[] freq = new int[maxNum + 1];
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] > maxNum) return false;
            freq[nums[i]]++;
        }
        for(int i = 1 ; i < maxNum ;i++)
        {
            if(freq[i] != 1) return false;
        }
        if(freq[maxNum] != 2) return false;
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