public class Solution {
    public int MaxSumDivThree(int[] nums) {
        List<int> ones = new List<int>();
        List<int> twos = new List<int>();
        int sum = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            sum += nums[i];
            if(nums[i] % 3 == 1) ones.Add(nums[i]);
            else if(nums[i] % 3 == 2) twos.Add(nums[i]);
        }
        if(sum % 3 == 0)
            return sum; 
        ones.Sort();
        twos.Sort();
        int res = 0 ; 
        if(sum % 3 == 1)
        {
            if(ones.Count >= 1)
                res = Math.Max(res , sum - ones[0]);
            if(twos.Count >= 2)
                res =  Math.Max(res, sum - twos[0] - twos[1]);
        }
        else if(sum % 3 == 2)
        {
            if(twos.Count >= 1)
                res = Math.Max(res , sum - twos[0]);
            if(ones.Count >= 2)
                res = Math.Max(res , sum - ones[0] - ones[1]);
        }
        return res;
    }
}