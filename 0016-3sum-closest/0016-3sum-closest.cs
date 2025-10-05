public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int n = nums.Length;
        if(n == 3) return nums.Sum();
        Array.Sort(nums);
        int closestSum = nums[0]+nums[1]+nums[2];
        if(closestSum == target) return closestSum;
        for(int i = 0 ; i < n - 2 ; i++)
        {
            int left = i+1;
            int right = n-1;
            while(left < right)
            {
                int currentSum = nums[i] + nums[left] + nums[right];
                if(currentSum == target) return currentSum;
                if(Math.Abs(target - currentSum) < Math.Abs(target - closestSum))
                    closestSum = currentSum;
                if(currentSum < target)
                    left++;
                else
                    right--;
            }
        }
        return closestSum;
    }
}