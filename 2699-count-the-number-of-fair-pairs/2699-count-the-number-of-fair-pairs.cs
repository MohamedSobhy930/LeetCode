public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);
        
        return Helper(nums , upper) - Helper(nums , lower -1);
    }
    public long Helper(int[] arr ,int upper )
    {
        long result = 0;
        int left = 0 ; 
        int right = arr.Length -1;
        while(left < right)
        {
            if(arr[left] + arr[right] > upper)
                right--;
            else
            {
                result += right - left ;
                left++;
            }
        }
        return result;
    }
}