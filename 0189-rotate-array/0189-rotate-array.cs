public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;
        Reverse(nums, n-k , n-1);
        Reverse(nums,0 , n - k-1);
        Reverse(nums, 0 , n -1);
    }
    public void Reverse(int[] arr ,int start ,int end)
    {
        while(start < end)
        {
        int temp = arr[start];
        arr[start++] = arr[end];
        arr[end--] = temp;
        }
    }
}