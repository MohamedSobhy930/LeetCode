public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        List<bool> result = new List<bool>();
        int remainder = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            remainder = (remainder * 2 + nums[i]) % 5;
            if(remainder % 5 == 0 )
                result.Add(true);
            else
                result.Add(false);
        }
        return result;
    }
}