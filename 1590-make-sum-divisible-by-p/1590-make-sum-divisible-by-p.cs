public class Solution {
    public int MinSubarray(int[] nums, int p) {
        int n = nums.Length;
        long sum = 0;
        for(int i = 0 ; i < n; i++)
        {
            sum += nums[i];
        }
        int targetRemainder =(int)(sum % p);
        if(targetRemainder == 0) return 0;

        var remainderMap = new Dictionary<int, int>();
        remainderMap[0] = -1 ;
        
        int curSumRemainder = 0 ; 
        int minLength = n;
        for(int i = 0 ; i < n ; i++)
        {
            curSumRemainder = (curSumRemainder + nums[i]) % p;
            int neededRemainder = (curSumRemainder - targetRemainder + p) % p;

            if(remainderMap.ContainsKey(neededRemainder))
            {
                minLength = Math.Min(minLength , i - remainderMap[neededRemainder]);
            }
            remainderMap[curSumRemainder] = i;
        }
    return minLength == n ? -1 : minLength;
    }
}