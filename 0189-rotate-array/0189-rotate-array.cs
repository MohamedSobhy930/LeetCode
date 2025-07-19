public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int index = 0 ;
        k %= n;
        int[] arr = new int[nums.Length];
        for(int i = n -k ; i < 2* n - k ; i++ )
        {
            arr[index++] = nums[i % n];
        }
        Array.Copy(arr,nums,n);
    }
}