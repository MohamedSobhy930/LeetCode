public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
       List<int> leftPivot = new List<int>();
       List<int> rightPivot = new List<int>(); 
       int n = nums.Length;
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] < pivot) 
                leftPivot.Add(nums[i]);
        }
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] > pivot) 
                rightPivot.Add(nums[i]);
            else if(nums[i] == pivot)
                rightPivot.Insert(0, nums[i]);
        }
        leftPivot.AddRange(rightPivot);
        return leftPivot.ToArray();
    }
}