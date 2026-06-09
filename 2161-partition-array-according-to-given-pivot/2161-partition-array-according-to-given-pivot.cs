public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
       int n = nums.Length;
       int index = 0;
       int[] result = new int[n];
       List<int> pivotFreq = new List<int>();
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] < pivot) 
                result[index++] = nums[i];
            else if(nums[i] == pivot)
                pivotFreq.Add(nums[i]);
        }
        foreach(int num in pivotFreq)
        {
            result[index++] = num;
        }
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] > pivot) 
                result[index++] = nums[i];
        }
        return result;
    }
}