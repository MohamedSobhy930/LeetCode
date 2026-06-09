public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
       int n = nums.Length;
       int index = 0;
       int pivotCount = 0;
       int[] result = new int[n];
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] < pivot) 
                result[index++] = nums[i];
            else if(nums[i] == pivot)
                pivotCount++;
        }
        while(pivotCount > 0)
        {
            result[index++] = pivot;
            pivotCount--;
        }
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] > pivot) 
                result[index++] = nums[i];
        }
        return result;
    }
}