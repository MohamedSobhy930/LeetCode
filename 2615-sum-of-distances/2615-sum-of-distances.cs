public class Solution {
    public long[] Distance(int[] nums) {
        int n = nums.Length;
        long[] arr = new long[n];
        var freq = new Dictionary<int,List<int>>();
        for(int i = 0; i < n ; i++)
        {
            if(!freq.ContainsKey(nums[i]))
                freq[nums[i]] = new List<int>();

            freq[nums[i]].Add(i);
        }
        foreach(var indecies in freq.Values)
        {
            if(indecies.Count == 1)
                continue;
            long leftSum = 0;
            long rightSum = 0;
            foreach(var index in indecies)
                rightSum += index;
            for(int i = 0 ; i < indecies.Count ; i++)
            {
                int curIndex = indecies[i];
                long leftCount = i ;
                long rightCount = indecies.Count - i;
                
                long leftDis = (curIndex * leftCount) - leftSum;
                long rightDis = rightSum - (curIndex * rightCount);
                
                arr[curIndex] = leftDis + rightDis;

                leftSum += curIndex;
                rightSum -= curIndex;
            }
        }
        return arr;
    }
}