public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] freq = new int[nums.Length-2];
        for (int i = 0; i < nums.Length; i++)
        {
            freq[nums[i]]++;
        }
        int[] result = new int[2];
        int index = 0;
        for(int i = 0 ; i < freq.Length ; i++)
        {
            if(freq[i] > 1)
                result[index++] = i;
        }
        return result;
    } 
}