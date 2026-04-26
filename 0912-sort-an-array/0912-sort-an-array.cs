public class Solution {
    public int[] SortArray(int[] nums) {
        int maxNum = nums[0];
        int minNum = nums[0];
        int n = nums.Length;
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] > maxNum)
                maxNum = nums[i];
            else if(nums[i] < minNum)
                minNum = nums[i];
        }
        int[] arr = new int[maxNum - minNum + 1];
        for(int i = 0 ; i < n; i++)
        {
            arr[nums[i] - minNum]++;
            
        }
        int index = 0;
        int[] result = new int[n];
        for(int i = 0 ; i < arr.Length ; i++)
        {
            for(int j = 0 ; j < arr[i] ; j++ , index++)
            {
                result[index] = i + minNum;
            }
        }
        return result ;
    }
}