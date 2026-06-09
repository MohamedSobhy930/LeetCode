public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
       LinkedList<int> leftPivot = new LinkedList<int>();
       LinkedList<int> rightPivot = new LinkedList<int>(); 
       int n = nums.Length;
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] < pivot) 
                leftPivot.AddLast(nums[i]);
            else if(nums[i] > pivot)
                rightPivot.AddLast(nums[i]);
            else 
                rightPivot.AddFirst(nums[i]);
        }
        foreach(int num in rightPivot)
        {
            leftPivot.AddLast(num);
        }
        int[] result = new int[n];
        leftPivot.CopyTo(result,0);
        return result;
    }
}